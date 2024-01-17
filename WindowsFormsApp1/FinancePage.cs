using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FinancePage : Form
    {
        FunctionService function = new FunctionService();
        int financeType = 0; // 1 = Receipts // 2 = Invoices // 3 = Checks
        public FinancePage()
        {
            InitializeComponent();
            
        }
        public FinancePage(int whatType)
        {
            InitializeComponent();
            financeType = whatType;
            Populate();
        }
        private void Populate()
        {
            if(financeType == 1)
            {
                FinanceGrid.AutoGenerateColumns = false;
                FinanceGrid.DataSource = function.GetAllReceiptsByUserId(Choose.id);
                FinanceGrid.DataMember = "Receipts";
            }
            if(financeType == 2)
            {
                FinanceGrid.AutoGenerateColumns = false;
                FinanceGrid.DataSource = function.GetAllInvoicesByUserId(Choose.id);
                FinanceGrid.DataMember = "Invoices";
            }
            if(financeType == 3)
            {
                FinanceGrid.AutoGenerateColumns = false;
                FinanceGrid.DataSource = function.GetAllChecksByUserId(Choose.id);
                FinanceGrid.DataMember = "Checks";
            }
            
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(FinanceGrid, 0, 1);
            if(ids.Count == 0)
            {
                MessageBox.Show("בחר מסמך");
            }
            else if(financeType == 1)
            {
                Choose.ReceiptsToPrint.AddRange(ids);
                Program.play.printReceipt();
            }
            else if(financeType == 2)
            {
                Choose.InvoicesToPrint.AddRange(ids);
                Program.play.printInvoice();
            }
            else if(financeType == 3)
            {
                Choose.ChecksToPrint.AddRange(ids);
                Program.play.printCheck();
            }
        }
        private List<int> IdSelected(DataGridView table, int index, int idIndex)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.Cells[index].Value != null && Convert.ToBoolean(row.Cells[index].Value) == true)
                {
                    ids.Add(int.Parse(row.Cells[idIndex].Value.ToString()));
                }
            }
            return ids;
        }
        private void SelectAllOrder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in FinanceGrid.Rows)
            {
                if (row.Cells[0].Value == null && Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[0].Value = true;
                }
                else if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[0].Value = false;
                }
                else
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == false)
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            if(financeType == 1)
            {
                InputForm input = new InputForm("מספר קבלה:", true);
                if (input.ShowDialog() == DialogResult.OK)
                {
                    id = input.userInputInt;
                }
                DataSet data = function.GetReceiptByIdTable(id);
                if (data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("לא נמצאה קבלה");
                }
                else
                {
                    FinanceGrid.AutoGenerateColumns = false;
                    FinanceGrid.DataSource = data;
                    FinanceGrid.DataMember = "Receipts";
                }
            }
            else if(financeType == 2)
            {
                InputForm input = new InputForm("מספר חשבונית מס:", true);
                if (input.ShowDialog() == DialogResult.OK)
                {
                    id = input.userInputInt;
                }
                DataSet data = function.GetInvoicesByIdTable(id);
                if (data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("לא נמצאה חשבונית מס");
                }
                else
                {
                    FinanceGrid.AutoGenerateColumns = false;
                    FinanceGrid.DataSource = data;
                    FinanceGrid.DataMember = "Invoices";
                }
            }
            else if(financeType == 3)
            {

            }
        }
        private void CancelOrder_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(FinanceGrid, 0, 1);
            if(ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט");
            }
            else
            {
                if (financeType == 1)
                {
                    List<int> CanceledReceipts = function.CanceledReceipts(ids);
                    if (CanceledReceipts.Count > 0)
                    {
                        MessageBox.Show("קבלות " + String.Join(",", CanceledReceipts) + " כבר זוכו");
                    }
                    else
                    {
                        DataSet data = function.ReceiptRefund(Choose.id);
                        if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
                        {
                            int totalRefund = 0;
                            List<Receipt> receipts = new List<Receipt>();
                            int highestReReceipt = function.HighestReReceipt();

                            foreach (int orderId in ids)
                            {
                                Receipt old = function.GetReceiptCopyById(orderId);
                                highestReReceipt++;
                                string name = function.FullNameById(old.User);
                                Receipt receipt = new Receipt(old.User, "זיכוי קבלה מספר " + highestReReceipt + " עבור " + name, old.Price, old.Type);
                                totalRefund += old.Price;
                                receipts.Add(receipt);
                                function.SetReceiptCanceled(orderId);
                                function.AddMoney(-old.Price, function.GetTypeString(old.Type - 1));
                                Choose.ReceiptsToPrint.Add(highestReReceipt);
                            }
                            int newDebt = Choose.u.Debt + totalRefund;
                            function.NewReReceipt(receipts);
                            int current = 0;
                            int id = 0;
                            List<int[]> listId = new List<int[]>();
                            foreach (DataRow row in data.Tables[0].Rows)
                            {
                                if (totalRefund > 0)
                                {
                                    current = row.Field<int>("OrderPaid");
                                    id = row.Field<int>("OrderId");
                                    if (totalRefund >= current)
                                    {
                                        listId.Add(new int[] { id, 0 });
                                        totalRefund = totalRefund - current;
                                    }
                                    else if (totalRefund < current)
                                    {
                                        current = current - totalRefund;
                                        listId.Add(new int[] { id, current });
                                        totalRefund = 0;
                                    }
                                }
                                else continue;
                            }
                            function.Refund(listId);
                            function.SetDebt(Choose.id, newDebt);
                            
                            Program.play.printReReceipt(true);
                        }
                        else
                        {
                            MessageBox.Show("אין קבלות לזכות");
                        }
                    }
                    
                }
                else if(financeType == 2)
                {
                    List<int> checking = function.canceledInvoices(ids); // checking if there is canceled invoices in the users selection
                    if(checking.Count > 0)
                    {
                        MessageBox.Show("חשבוניות מס מספר " + String.Join(",", checking) + " כבר זוכו");
                    }
                    else
                    {
                        checking.Clear();
                        checking = function.OrdersPaidByInvoice(ids);
                        if(checking.Count > 0)
                        {
                            MessageBox.Show("חשבוניות מס מספר " + String.Join(",", checking) + " כבר שולמו בחלקן או במלואן");
                        }
                        else
                        {
                            List<Invoice> invoices = new List<Invoice>();
                            int highestReInvoice = function.HighestReInvoice();
                            int totalRefund = 0; // Because Im canceling Orders I need to delete his debt !!!
                            List<int[]> toSet = new List<int[]>(); // To set the orders ReInvoice
                            foreach (int id in ids)
                            {
                                highestReInvoice++;
                                Invoice old = function.GetInvoiceCopyById(id);
                                string name = function.FullNameById(old.User);
                                Invoice invoice = new Invoice(old.User, "חשבונית זיכוי מספר " + highestReInvoice + " עבור " + name, old.Price);
                                invoices.Add(invoice);
                                toSet.Add(new int[] { old.Id, highestReInvoice });
                                Choose.InvoicesToPrint.Add(highestReInvoice);
                                function.SetInvoiceCanceled(old.Id);
                                totalRefund += old.Price;
                            }
                            function.NewReInvoice(invoices);
                            foreach(int[] i in toSet)
                            {
                                function.SetOrdersReInvoiceByInvoice(i[0], i[1]);
                            }
                            int newDebt = Choose.u.Debt - totalRefund;
                            function.SetDebt(Choose.id, newDebt);
                            Program.play.printReInvoice(true);
                            
                        }
                    }
                }
                else if(financeType == 3)
                {
                    List<int> checking = function.canceledChecks(ids); // checking if there is canceled invoices in the users selection
                    if(checking.Count > 0)
                    {
                        MessageBox.Show("חשבוניות מס/קבלה מספר " + String.Join(",", checking) + " כבר זוכו");
                    }
                    else
                    {
                        int highestReInvoice = function.HighestReInvoice();
                        int highestReReceipt = function.HighestReReceipt();
                        int totalRefund = 0; // Because Im canceling Orders I need to delete his debt !!!
                        List<Receipt> receipts = new List<Receipt>();
                        List<Invoice> invoices = new List<Invoice>();
                        List<int[]> toSet = new List<int[]>(); // To set the orders ReInvoice
                        foreach (int id in ids)
                        {
                            highestReInvoice++;
                            highestReReceipt++;
                            Check old = function.GetCheckCopyById(id);
                            string name = function.FullNameById(old.User);
                            totalRefund += old.Price;
                            Invoice invoice = new Invoice(old.User, "חשבונית זיכוי מספר " + highestReInvoice + " עבור " + name, old.Price);
                            Receipt receipt = new Receipt(old.User, "זיכוי קבלה מספר " + highestReReceipt + " עבור " + name, old.Price, old.Type);
                            toSet.Add(new int[] { old.Id, highestReInvoice });
                            function.AddMoney(-old.Price, function.GetTypeString(old.Type - 1));
                            invoices.Add(invoice);
                            receipts.Add(receipt);
                            function.SetCheckCanceled(id);
                            Choose.ReceiptsToPrint.Add(highestReReceipt);
                            Choose.InvoicesToPrint.Add(highestReInvoice);
                        }
                        function.NewReInvoice(invoices);
                        function.NewReReceipt(receipts);
                        foreach (int[] i in toSet)
                        {
                            function.SetOrdersReInvoiceByCheck(i[0], i[1]);
                        }
                        //int newDebt = Choose.u.Debt - totalRefund;
                        //function.SetDebt(Choose.id, newDebt); I DONT NEED TO UPDATE DEBT BECAUSE I DELETED THE ITEMS AND ALSO THE PAYMENT SO IT CANCELS OUT!!!!
                        Program.play.printReInvoice(true);
                        Program.play.printReReceipt(true);
                    }
                }
                    
            }
        }
    }
}

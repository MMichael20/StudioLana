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
        int financeType = 0;
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
    }
}

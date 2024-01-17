using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PayDebt : Form
    {
        FunctionService function = new FunctionService();
        private void PayDebt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitAll();
                e.Handled = true;
            }
        }
       
        public PayDebt()
        {
            InitializeComponent();
        }
        // Control ActiveControl;

        private void PayDebt_Load(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            this.ActiveControl = AmountBox;
            AmountText.Text = String.Format("₪{0}.00", Choose.u.Debt.ToString());
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }
        private void AmountBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }
        //private void Pay(int amount)
        //{
        //    int index = Listbox.SelectedIndex;
        //    Check c = new Check("תשלום עבור הזמנות", Choose.id, amount , index + 1);
        //    int current = 0;
        //    int goal = 0;
        //    int diff = 0;
        //    int orderId = 0;
        //    List<int> listId = new List<int>();
        //    DataSet data = GetAllUnpaidOrdersById(Choose.id);
        //    if(data.Tables[0].Rows.Count == 0)
        //    {
        //        MessageBox.Show("הלקוח שילם הכל אחשלי!");
        //    }
        //    else
        //    {
        //        foreach (DataRow row in data.Tables[0].Rows)
        //        {
        //            if (amount > 0)
        //            {
        //                current = row.Field<int>("OrderPaid");
        //                goal = row.Field<int>("OrderPrice");
        //                orderId = row.Field<int>("OrderId");
        //                if (current < goal)
        //                {
        //                    diff = goal - current;
        //                    if (amount >= diff)
        //                    {
        //                        CloseDebt(orderId, current + diff);
        //                        amount = amount - diff;
        //                        listId.Add(orderId);
        //                    }
        //                    else if (amount < diff)
        //                    {
        //                        PayForOrders(orderId, amount + current);
        //                        amount = 0;
        //                        listId.Add(orderId);
        //                    }
        //                }
        //                else if (current == goal)
        //                {
        //                    UpdateFull(orderId);

        //                }
        //            }
        //        }
        //        if(amount > 0)
        //        {
        //            MessageBox.Show("נשאר עודף: " + amount.ToString());
        //        }

        //        MessageBox.Show("שולם על הזמנות: " +string.Join(", ", listId));
        //        NewCheck(c);
        //    }
        //}
        void AddTextToTextBox(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Assuming textBox1 is the TextBox control
                AmountBox.Text += button.Text;
                this.ActiveControl = null;
            }
        }
        private void UpdateOrders(int amount)
        {
            int userDebt = Choose.u.Debt;
            int current = 0;
            int goal = 0;
            int diff = 0;
            int id = 0;
            int totalReceipt = 0;
            int index = TypeBox.SelectedIndex;
            List<int[]> listId = new List<int[]>();
            List<int[]> Checks = new List<int[]>();
            List<int> listIds = new List<int>();
            List<int[]> invoiceIds = new List<int[]>();
            DataSet data = function.NeedsReceipt(Choose.id);
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow row in data.Tables[0].Rows)
                {
                    if (amount > 0)
                    {
                        current = row.Field<int>("OrderPaid");
                        goal = row.Field<int>("OrderPrice");
                        id = row.Field<int>("OrderId");
                        if (current < goal)
                        {
                            diff = goal - current;
                            if (amount >= diff)
                            {
                                listId.Add(new int[] { id, goal, 1 });
                                amount = amount - diff;
                                totalReceipt += diff;
                                userDebt = userDebt - diff;
                            }
                            else if (amount < diff)
                            {
                                listId.Add(new int[] { id, amount + current, 0 });
                                userDebt = userDebt - amount;
                                totalReceipt += amount;
                                amount = 0;
                            }
                        }
                    }
                    else continue;
                }
                //PRINT AND ADD RECEIEPTS, ALSO NEED TO UPDATE THE ORDERS TO PAID AND FULL
                function.Pay(listId);
            }
            if (amount == 0)
            {
                
            }
            else
            {
                listId.Clear();
                data = function.GetAllInvoicelessOrdersById(Choose.id);
                if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        if (amount > 0)
                        {
                            current = row.Field<int>("OrderPaid");
                            goal = row.Field<int>("OrderPrice");
                            id = row.Field<int>("OrderId");
                            if (current < goal)
                            {
                                diff = goal - current;
                                if (amount >= diff)
                                {
                                    invoiceIds.Add(new int[] { id, goal });
                                    listId.Add(new int[] { id, goal, 1 });
                                    totalReceipt += diff;
                                    amount = amount - diff;
                                    userDebt = userDebt - diff;
                                }
                                else if (amount < diff)
                                {
                                    userDebt = userDebt - amount;
                                    totalReceipt += amount;
                                    listId.Add(new int[] { id, amount + current, 0 }); // NOT A GOOD LINE!!!! BECAUSE IT WILL ADD TO THE INVOICE...IT NEEDS TO GO TO THE RECEIPT INSTEAD
                                    amount = 0;
                                }
                            }
                        }
                        else continue;
                    }
                    function.Pay(listId);
                    if (invoiceIds.Count > 0)
                    {
                        int highestInvoice = function.HighestInvoice() + 1;
                        Invoice invoice = new Invoice(Choose.id, "חשבונית מס מספר " + highestInvoice + " עבור " + Choose.u.Fname + " " + Choose.u.LName, invoiceIds.Sum(arr => arr[1]));
                        function.NewInvoice(invoice);
                        function.UpdateOrdersInvoice(invoiceIds.Select(arr => arr[0]).ToList(), highestInvoice);
                        Choose.InvoicesToPrint.Add(highestInvoice);
                        //MessageBox.Show("Invoice: " + invoice.ToString());
                        // CREATE AND PRINT INVOICES AND RECEIPTS!!!
                    }
                }
            }
            if(amount == 0)
            {
               
            }
            else
            {
                data = function.GetAllUnpaidOrdersById(Choose.id);
                if (amount >= userDebt)
                {
                    if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Tables[0].Rows)
                        {
                            listIds.Add(row.Field<int>("OrderId"));
                        }
                        int highestCheck = function.HighestCheck() + 1;
                        Check newCheck = new Check(Choose.id, @"חשבונית מס\קבלה מספר " + highestCheck + " עבור " + Choose.u.Fname + " " + Choose.u.LName, userDebt, index + 1);
                        function.NewCheck(newCheck);
                        function.SetOrdersCheck(listIds, highestCheck);
                        Choose.ChecksToPrint.Add(highestCheck);
                        AddMoney(userDebt);
                        amount = amount - userDebt;
                        userDebt = 0;
                    }
                }
                else if(amount < userDebt)
                {
                    listId.Clear();
                    if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0) 
                    {
                        foreach (DataRow row in data.Tables[0].Rows)
                        {
                            if (amount > 0)
                            {
                                current = row.Field<int>("OrderPaid");
                                goal = row.Field<int>("OrderPrice");
                                id = row.Field<int>("OrderId");
                                if (current < goal)
                                {
                                    diff = goal - current;
                                    if (amount >= diff)
                                    {
                                        listId.Add(new int[] { id, goal, 1 });
                                        Checks.Add(new int[] { id, goal });
                                        userDebt = userDebt - diff;
                                        amount = amount - diff;
                                    }
                                    else if (amount < diff)
                                    {
                                        listId.Add(new int[] { id, amount + current, 0 });
                                        userDebt = userDebt - amount;
                                        totalReceipt += amount;
                                        amount = 0;
                                    }
                                }
                            }
                            else continue;
                        }
                    }
                    function.Pay(listId);
                    if(Checks.Count > 0)
                    {
                        int highestCheck = function.HighestCheck() + 1;
                        Check check = new Check(Choose.id, @"חשבונית מס\קבלה מספר " + highestCheck + " עבור " + Choose.u.Fname + " " + Choose.u.LName, Checks.Sum(arr => arr[1]), index +1);
                        function.NewCheck(check);
                        function.SetOrdersCheck(Checks.Select(arr => arr[0]).ToList(), highestCheck);
                        Choose.ChecksToPrint.Add(highestCheck);
                        AddMoney(Checks.Sum(arr => arr[1]));
                    }
                    //CREATE CHECK FOR THE ORDERS THAT ARE FULLY PAID..AND A RECEIPT FOR THE ORDER THATS LEFT...!!!!!!
                }
            }
            if (amount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("נשאר עודף: " + amount.ToString() + " האם להשאיר בקופה", "עודף", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    totalReceipt += amount;
                    userDebt = userDebt - amount;
                    AddMoney(amount);
                    amount = 0;
                }
            }
            if (totalReceipt > 0)
            {
                int highestReceipt = function.HighestReceipt() + 1;
                Receipt receipt = new Receipt(Choose.id, "קבלה מספר " + highestReceipt + " עבור " + Choose.u.Fname + " " + Choose.u.LName, totalReceipt, index + 1);
                function.NewReceipt(receipt);
                Choose.ReceiptsToPrint.Add(highestReceipt);
                AddMoney(totalReceipt);
                //MessageBox.Show(" Receipt:" + receipt.ToString());
            }
            Choose.u.Debt = userDebt;
            function.SetDebt(Choose.id, userDebt);
            MessageBox.Show("תודה על התשלום");
           
        }
        private void AddMoney(int amount)
        {
            function.AddMoney(amount, function.GetTypeString(TypeBox.SelectedIndex));
        }
        
        private void Submit_Click(object sender, EventArgs e)
        {
            SubmitAll();
        }
        private void SubmitAll()
        {
            if (!Validation.Digits(AmountBox.Text))
            {
                MessageBox.Show("רשום רק מספרים!");
            }
            else if (TypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("אנא בחר סוג תשלום!");
            }
            else
            {
                int amount = int.Parse(AmountBox.Text);
                if (amount > 0)
                {
                    UpdateOrders(amount);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void myButton11_Click(object sender, EventArgs e)
        {
            AmountBox.Text = "";
        }
        private void Listbox_Click(object sender, EventArgs e)
        {
            //function.UpIndex(Listbox);
            TypeBox.DroppedDown = true;
        }

        private static decimal CalculateTotal(DataSet dataSet)
        {
            decimal total = 0;
            decimal paid = 0;
            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Assuming OrderPrice column contains decimal values
                    if (decimal.TryParse(row["OrderPrice"].ToString(), out decimal orderPrice))
                    {
                        total += orderPrice;
                    }
                    if (decimal.TryParse(row["OrderPaid"].ToString(), out decimal orderPaid))
                    {
                        paid += orderPaid;
                    }
                }
            }
            return total - paid;
        }
    }
}

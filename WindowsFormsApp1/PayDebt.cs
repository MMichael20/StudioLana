using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PayDebt : Form
    {

        private DataSet GetAllUnpaidOrdersById(int id)
        {
            OrderService os = new OrderService();
            return os.GetAllUnpaidOrdersById(id);
        }
        private void CloseDebt(int id, int amount)
        {
            OrderService os = new OrderService();
            os.CloseDebt(id, amount);
        }
        private void UpdateFull(int id)
        {
            OrderService os = new OrderService();
            os.UpdateFull(id);
        }
        private void PayForOrders(int id, int amount)
        {
            OrderService os = new OrderService();
            os.PayForOrders(id, amount);
        }
        private void NewCheck(Check p)
        {
            CheckService cs = new CheckService();
            cs.NewCheck(p);
        }
        private void SetDebt(int id, int debt)
        {
            UserService us = new UserService();
            us.SetDebt(id, debt);
        }

        public PayDebt()
        {
            InitializeComponent();
        }
        // Control ActiveControl;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(button.Text);
        }
        private void PayDebt_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AmountBox;
        }

        private void AmountBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }
        private void Pay(int amount)
        {
            int index = Listbox.SelectedIndex;
            Check c = new Check("תשלום עבור הזמנות", Choose.id, amount , index + 1);
            int current = 0;
            int goal = 0;
            int diff = 0;
            int orderId = 0;
            List<int> listId = new List<int>();
            DataSet data = GetAllUnpaidOrdersById(Choose.id);
            if(data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("הלקוח שילם הכל אחשלי!");
            }
            else
            {
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    if (amount > 0)
                    {
                        current = row.Field<int>("OrderPaid");
                        goal = row.Field<int>("OrderPrice");
                        orderId = row.Field<int>("OrderId");
                        if (current < goal)
                        {
                            diff = goal - current;
                            if (amount >= diff)
                            {
                                CloseDebt(orderId, current + diff);
                                amount = amount - diff;
                                listId.Add(orderId);
                            }
                            else if (amount < diff)
                            {
                                PayForOrders(orderId, amount + current);
                                amount = 0;
                                listId.Add(orderId);
                            }
                        }
                        else if (current == goal)
                        {
                            UpdateFull(orderId);

                        }
                    }
                }
                if(amount > 0)
                {
                    MessageBox.Show("נשאר עודף: " + amount.ToString());
                }
                
                MessageBox.Show("שולם על הזמנות: " +string.Join(", ", listId));
                NewCheck(c);
            }
            

        }
        //private void UpdateOrders(int amount)
        //{
        //    DataSet data = GetAllUnpaidOrdersById(Choose.id);
        //    int current = 0;
        //    int goal = 0;
        //    int diff = 0;
        //    //int rowCount = -1;
        //    bool full = false;
        //    List<int[]> listId = new List<int[]>();
            
        //    foreach (DataRow row in data.Tables[0].Rows)
        //    {
        //        //rowCount++;
        //        if (amount > 0)
        //        {
        //            current = row.Field<int>("OrderPaid");
        //            goal = row.Field<int>("OrderPrice");
        //            if (current < goal)
        //            {
        //                diff = goal - current;
        //                if (amount >= diff)
        //                {
        //                    row["OrderPaid"] = current + diff;
        //                    row["OrderFull"] = true;
        //                    //listId.Add(new int[] { rowCount, diff, 1 });
        //                    amount = amount - diff;
        //                }
        //                else if (amount < diff)
        //                {
        //                    row["OrderFull"] = amount + current;
        //                    //listId.Add(new int[] {rowCount, amount, 0 });
        //                    amount = 0;
        //                }
        //            }
        //        }
        //        else return;
                
        //    }
        //    //for (int i = 0; i < listId.Count; i++)
        //    //{
        //    //    foreach(int[] item in listId)
        //    //    {
        //    //        rowCount = item[0];
        //    //        int paid = item[1];
        //    //        if (item[2] == 1)
        //    //        {
        //    //            full = true;
        //    //        }
        //    //        else
        //    //        {
        //    //            full = false;
        //    //        }
        //    //        DataRow row = data.Tables[0].Rows[rowCount];
        //    //        row["OrderPaid"] = paid;
        //    //        row["OrderFull"] = full;
        //    //    }
        //    //}
        //}
        private void Submit_Click(object sender, EventArgs e)
        {
            if (!Validation.Digits(AmountBox.Text))
            {
                MessageBox.Show("רשום רק מספרים!");
            }
            else if (Listbox.SelectedIndex == -1)
            {
                MessageBox.Show("אנא בחר סוג תשלום!");
            }
            else
            {
                int amount = int.Parse(AmountBox.Text);
                if (amount > 0)
                {
                    Pay(amount);
                    SetDebt(Choose.id, Choose.u.Debt - amount);
                    Choose.u.Debt = Choose.u.Debt - amount;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
               
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AmountBox.Text = "";
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        private void PayService(List<int[]> listId)
        {
            OrderService os = new OrderService();
            os.Pay(listId);
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
            DataSet data = GetAllUnpaidOrdersById(Choose.id);
            int current = 0;
            int goal = 0;
            int diff = 0;
            int id = 0;
            int totalPaid = 0;
            List<int[]> listId = new List<int[]>();

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
                            listId.Add(new int[] { id, diff, 1 });
                            totalPaid += diff;
                            amount = amount - diff;
                        }
                        else if (amount < diff)
                        {
                            listId.Add(new int[] { id, amount, 0 });
                            totalPaid += amount;
                            amount = 0;
                        }
                    }
                }
                else continue;
            }
            if (amount > 0)
            {
                MessageBox.Show("נשאר עודף: " + amount.ToString());
            }
            PayService(listId);
            int index = Listbox.SelectedIndex;
            Check c = new Check("תשלום עבור הזמנות", Choose.id, totalPaid, index + 1);
            NewCheck(c);
            MessageBox.Show("שולם על הזמנות: " + string.Join(",", listId.Select(arr => arr[0]))); 
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
            else if (Listbox.SelectedIndex == -1)
            {
                MessageBox.Show("אנא בחר סוג תשלום!");
            }
            else
            {
                int amount = int.Parse(AmountBox.Text);
                if (amount > 0)
                {
                    int newDebt = Choose.u.Debt - amount;
                    UpdateOrders(amount);
                    SetDebt(Choose.id, newDebt);
                    Choose.u.Debt = newDebt;
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
            Listbox.DroppedDown = true;
        }
    }
}

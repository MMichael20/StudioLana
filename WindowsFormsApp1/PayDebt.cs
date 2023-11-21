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
    public partial class PayDebt : Form
    {
        int id;
        private void NewCheck(Check p)
        {
            CheckService cs = new CheckService();
            cs.NewCheck(p);
        }
        private void SetDebt(int id, double debt)
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

        public void LoadAmount(int x, int a)
        {
            AmountText.Text = String.Format("₪ {0:n}", x);
            id = a;
        }

        private void PayDebt_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AmountBox;
        }

        private void AmountBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

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
                int index = Listbox.SelectedIndex;
                SetDebt(id, -int.Parse(AmountBox.Text));
                Choose.u.Debt = Choose.u.Debt - int.Parse(AmountBox.Text);
                Check c = new Check("תשלום עבור הזמנות", id, int.Parse(AmountBox.Text), index + 1);
                NewCheck(c);
                MessageBox.Show("התשלום התקבל בהצלחה!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
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

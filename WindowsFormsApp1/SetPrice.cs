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
    public partial class SetPrice : Form
    {
        public SetPrice()
        {
            InitializeComponent();
        }

        private void SumbitB_Click(object sender, EventArgs e)
        {
            if (!Validation.Digits(AmountBox.Text))
            {
                Msg.Text = "הכנס מספרים בלבד!";
            }
            if (AmountBox.Text != "")
            {
                Choose.price = int.Parse(AmountBox.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                Msg.Text = "הכנס מספר ";
            }
        }

        private void SetPrice_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AmountBox;
        }
        public void l(int x)
        {
            Price.Text = "המחיר המקורי הוא: " + String.Format("₪ {0:n}", x);       
        }

        private void AmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

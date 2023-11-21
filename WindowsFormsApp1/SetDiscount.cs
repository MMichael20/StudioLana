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
    public partial class SetDiscount : Form
    {
        public SetDiscount()
        {
            InitializeComponent();
        }

        private void SumbitB_Click(object sender, EventArgs e)
        {
            if (AmountBox.Text == "")
            {
                Msg.Text = "הכנס מספר ";
            }
            else if (!Validation.Digits(AmountBox.Text))
            {
                Msg.Text = "הכנס מספרים בלבד!";
            }
            else if(int.Parse(AmountBox.Text) < 0 & int.Parse(AmountBox.Text) > 100)
            {
                Msg.Text = "הכנס מספר בין אפס למאה!";
            }
            else
            {
                Choose.discount = int.Parse(AmountBox.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void SetDiscount_Load(object sender, EventArgs e)
        {

        }
    }
}

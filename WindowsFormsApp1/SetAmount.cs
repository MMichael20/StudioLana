using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetAmount : Form
    {
        public SetAmount()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

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
            
            else
            {
                Choose.amount = int.Parse(AmountBox.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void SetAmount_Load(object sender, EventArgs e)
        {

        }
    }
}

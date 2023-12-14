using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {
            Idm.Text = "";
            Passm.Text = "";
            if(Id.Text != "admin")
            {
                Idm.Text = "לא קיים!";
            }
            else if(Pass.Text != "1234")
            {
                Passm.Text = "לא קיים!";
            }
            else
            {
                
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

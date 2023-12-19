using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        private void CenterAll()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            ChangeLabel.Location = new Point((this.Width - ChangeLabel.Size.Width) / 2, (ChangeLabel.Location.Y));
        }

        public InputForm(string label)
        {
            this.KeyPreview = true; 
            InitializeComponent();
            ChangeLabel.Text = label;
            CenterAll();

        }
        public string userInput
        {
            get { return UserInput.Texts;}
        }
        private void YesIcon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Your code to handle the "Enter" key press
                // For example, perform an action or call a method
                YesIcon_Click(sender, e);
            }
        }


    }
}

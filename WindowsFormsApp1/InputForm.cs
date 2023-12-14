using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        private void CenterFormOnScreen()
        {
            // Get the screen's working area
            System.Drawing.Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;

            // Calculate the center of the screen
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            // Set the form's location to the calculated center
            this.Location = new System.Drawing.Point(x, y);
        }
        public InputForm(string label)
        {
            CenterFormOnScreen();
            InitializeComponent();
            ChangeLabel.Text = label;
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
    }
}

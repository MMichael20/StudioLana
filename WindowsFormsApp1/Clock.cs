using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clock : Form
    {

        FunctionService function = new FunctionService();
        public Clock()
        {
            InitializeComponent();
        }
        private void SetStartWork(string name)
        {
            ClockService cs = new ClockService();
            cs.SetStartWork(name);
        }
        private void SetEndWork(string name)
        {
            ClockService cs = new ClockService();
            cs.SetEndWork(name);
        }
        private int IsThereEntry(string name)
        {
            ClockService cs = new ClockService();
            return cs.IsThereEntry(name);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if(WorkersList.SelectedItem == null)
            {
                MessageBox.Show("בחר עובד מן הרשימה!");
            }
            else if (IsThereEntry(WorkersList.SelectedItem.ToString()) > 0)
            {
                DialogResult result = MessageBox.Show("סומנה כניסה ללא יציאה, האם רוצה לעדכן יציאה?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    
                }
            }
            else
            {
                Choose.worker = WorkersList.SelectedItem.ToString();
                SetStartWork(WorkersList.Text);
                //MessageBox.Show("נרשמה כניסה לעובד - " + WorkersList.SelectedItem.ToString());
                Program.play.SetText();
                this.Close();

            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            if (WorkersList.SelectedItem == null)
            {
                MessageBox.Show("בחר עובד מן הרשימה!");
            }
            else if(IsThereEntry(WorkersList.SelectedItem.ToString()) == 0)
            {
                MessageBox.Show("אין סימון כניסה להיום");
            }
            else
            {
                Choose.worker = "אורח";
                SetEndWork(WorkersList.Text);
                //MessageBox.Show("נרשמה יציאה לעובד - " + WorkersList.SelectedItem.ToString());
                Program.play.SetText();
                this.Close();
            }
        }

        private void WorkersList_Click(object sender, EventArgs e)
        {
            WorkersList.DroppedDown = true;
        }
    }
}

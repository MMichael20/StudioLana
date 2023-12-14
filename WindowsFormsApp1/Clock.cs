using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }
        private void SetStartWork(string name)
        {
            ClockService cs = new ClockService();
            cs.SetStartWork(name, DateTime.Now);
        }
        private void SetEndWork(string name)
        {
            ClockService cs = new ClockService();
            cs.SetEndWork(name, DateTime.Now);
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
    }
}

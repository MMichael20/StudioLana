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
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }
        private void SetWork(string name, int type)
        {
            ClockService cs = new ClockService();
            cs.SetWork(name, DateTime.Now, type);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if(WorkersList.SelectedItem == null)
            {
                MessageBox.Show("בחר עובד מן הרשימה!");
            }
            else
            {
                SetWork(WorkersList.Text, 1);

            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            if (WorkersList.SelectedItem == null)
            {
                MessageBox.Show("בחר עובד מן הרשימה!");
            }
            else
            {
                SetWork(WorkersList.Text, 0);

            }
        }
    }
}

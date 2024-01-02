using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoadingScreen : Form
    {
        private Timer timer;
        private int dotCount = 1;
       
        public LoadingScreen()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        public LoadingScreen(int time)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = time;
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateText();
            dotCount = (dotCount % 4) + 1;
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
        public void UpdateText()
        {
            Loading.Text = "טוען." + new string('.', dotCount);
        }
    }
}

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
    public partial class PaymentStats : Form
    {
        
        public PaymentStats()
        {
            InitializeComponent();
            
            
           
        }
        public DataSet GetAllChecksByType(int t)
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecksByType(t);
        }
        public DataSet GetAllChecksByTypeAndDate(int t, DateTime date)
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecksByTypeAndDate(t, date);
        }
        public DataSet GetAllChecksByDate(DateTime date)
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecksByDate(date);
        }
        public DataSet GetAllChecks()
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecks();
        }
        public void Populate()
        {

            int bit = 0;
            int credit = 0;
            int cash = 0;
            CheckTable.AutoGenerateColumns = false;
            CheckTable.DataSource = GetAllChecks();
            CheckTable.DataMember = "Checks";

            bit += int.Parse(GetAllChecksByType(1).Tables[0].Rows.Count.ToString());
            credit += int.Parse(GetAllChecksByType(2).Tables[0].Rows.Count.ToString());
            cash += int.Parse(GetAllChecksByType(3).Tables[0].Rows.Count.ToString());

            int total = bit + credit + cash;
            Total.Text = "מספר כל התשלומים: " + total;
            BitLabel.Text = "מספר התשלומים בביט: " + bit;

            CreditLabel.Text = "מספר התשלומים באשראי: " + credit;
            CashLabel.Text = "מספר התשלומים במזומן: " + cash;


            Chart1.Series["s1"].Points.Add(bit);
            Chart1.Series["s1"].Points[0].Color = System.Drawing.Color.CadetBlue;
            Chart1.Series["s1"].Points[0].AxisLabel = "ביט";

            Chart1.Series["s1"].Points.Add(credit);
            Chart1.Series["s1"].Points[1].Color = System.Drawing.Color.IndianRed;
            Chart1.Series["s1"].Points[1].AxisLabel = "אשראי";

            Chart1.Series["s1"].Points.Add(cash);
            Chart1.Series["s1"].Points[2].Color = System.Drawing.Color.GreenYellow;
            Chart1.Series["s1"].Points[2].AxisLabel = "מזומן";
        }
        private void PaymentStats_Load(object sender, EventArgs e)
        {
            Populate();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int bit = 0;
            int credit = 0;
            int cash = 0;
            int total = bit + credit + cash;
            Total.Text = "מספר כל התשלומים: " + total;
            BitLabel.Text = "מספר התשלומים בביט: " + bit;

            CreditLabel.Text = "מספר התשלומים באשראי: " + credit;
            CashLabel.Text = "מספר התשלומים במזומן: " + cash;
            CheckTable.AutoGenerateColumns = false;
            CheckTable.DataSource = GetAllChecksByDate(FromDate.Value);
            CheckTable.DataMember = "Checks";

            bit += int.Parse(GetAllChecksByTypeAndDate(1, FromDate.Value).Tables[0].Rows.Count.ToString());
            credit += int.Parse(GetAllChecksByTypeAndDate(2, FromDate.Value).Tables[0].Rows.Count.ToString());
            cash += int.Parse(GetAllChecksByTypeAndDate(3, FromDate.Value).Tables[0].Rows.Count.ToString());
            total = bit + credit + cash;
            
            Total.Text = "מספר כל התשלומים: " + total;
            BitLabel.Text = "מספר התשלומים בביט: " + bit;

            CreditLabel.Text = "מספר התשלומים באשראי: " + credit;
            CashLabel.Text = "מספר התשלומים במזומן: " + cash;
            
            
            Chart1.Series["s1"].Points.Clear();
            Chart1.Series["s1"].Points.Add(bit);
            Chart1.Series["s1"].Points[0].Color = System.Drawing.Color.CadetBlue;
            Chart1.Series["s1"].Points[0].AxisLabel = "ביט";

            Chart1.Series["s1"].Points.Add(credit);
            Chart1.Series["s1"].Points[1].Color = System.Drawing.Color.IndianRed;
            Chart1.Series["s1"].Points[1].AxisLabel = "אשראי";

            Chart1.Series["s1"].Points.Add(cash);
            Chart1.Series["s1"].Points[2].Color = System.Drawing.Color.GreenYellow;
            Chart1.Series["s1"].Points[2].AxisLabel = "מזומן";
        }
    }
}

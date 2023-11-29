using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

        private DataSet GetUserById(int x)
        {
            UserService us = new UserService();
            return us.GetUserById(x);
        }
        private DataSet GetCity(int x)
        {
            CityService cs = new CityService();
            return cs.GetCity(x);
        }
        private DataSet GetId(string x)
        {
            CityService cs = new CityService();
            return cs.GetId(x);
        }
        private DataSet HighestUser()
        {
            UserService us = new UserService();
            return us.HighestUser();
        }
        private DataSet GetOrdersById(int x)
        {
            OrderService os = new OrderService();
            return os.GetOrdersById(x);
        }
        private DataSet GetOrders(int x)
        {
            OrderService os = new OrderService();
            return os.GetOrdersById(x);
        }
        private DataSet GetReadyOrders(int x)
        {
            OrderService os = new OrderService();
            return os.GetFinishById(x) ;
        }
        private DataSet GetDebt(int x)
        {
            UserService us = new UserService();
            return us.GetDebt(x);
        }
        private void SetDebt(int id, double debt)
        {
            UserService us = new UserService();
            us.SetDebt(id, debt);
        }
        private DataSet GetUsers()
        {
            UserService us = new UserService();
            return us.GetUsers();
        }
        public Main()
        {
            InitializeComponent();            
        }
        public void SetText()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Extract the hour from the current time
            int currentHour = currentTime.Hour;

            // Check the time of the day and print the corresponding greeting
            if (currentHour >= 5 && currentHour < 12)
            {
                
                GreetText.Text = "בוקר טוב, " + Choose.worker + "!";
            }
            else if (currentHour >= 12 && currentHour < 18)
            {
                GreetText.Text = "צהריים טובים, " + Choose.worker + "!";
            }
            else
            {
                GreetText.Text = "ערב טוב, " + Choose.worker + "!";
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SetText();
            UserGrid.AutoGenerateColumns = false;
            UserGrid.DataSource = GetUsers();
            UserGrid.DataMember = "Users";
        }
        private void UserS_Click(object sender, EventArgs e)
        {
            SaveB.Enabled = false;
            UserSearch userS = new UserSearch();
            if(userS.ShowDialog() == DialogResult.OK)
            {
                Populate(Choose.u);
                Block();
            }
        }
        public void Populate(User u)
        {
            Mname.Text = u.Fname + " " + u.LName;
            Debt.Text = String.Format("₪ {0:n}", u.Debt.ToString());
            Id.Text = u.Id.ToString();
            Fname.Text = u.Fname;
            Lname.Text = u.LName;
            Street.Text = u.Street;
            City.Text = (GetCity(u.City).Tables[0].Rows[0][0].ToString());
            Phone.Text = u.Phone;
            Note.Text = u.Note;
            Discount.Text = u.Discount.ToString();
            Sub.Text = u.Sub;
            IdBox.Text = u.Id.ToString();
            FnameBox.Text = u.Fname;
            LnameBox.Text = u.LName;
            CityBox1.Text = (GetCity(u.City).Tables[0].Rows[0][0].ToString());
            StreetBox.Text = u.Street;
            PhoneBox.Text = u.Phone;
            NoteBox.Text = u.Note;
            DisBox.Text = u.Discount.ToString();
            SubBox.Text = u.Sub;
            EmailBox.Text = u.Email;
            DebtBox.Text = String.Format("₪ {0:n}", u.Debt.ToString());
            OrderGrid.AutoGenerateColumns = false;
            OrderGrid.DataSource = GetOrders(u.Id);
            OrderGrid.DataMember = "Orders";
            ReadyGrid.AutoGenerateColumns = false;
            ReadyGrid.DataSource = GetReadyOrders(u.Id);
            ReadyGrid.DataMember = "Orders";
            Calculate();
        }
        private void Block()
        {
            FnameBox.ReadOnly = true;
            LnameBox.ReadOnly = true;
            // CityBox.ReadOnly = true;
            StreetBox.ReadOnly = true;
            PhoneBox.ReadOnly = true;
            NoteBox.ReadOnly = true;
            DisBox.ReadOnly = true;
            SubBox.ReadOnly = true;
            EmailBox.ReadOnly = true;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            IdBox.Text = (int.Parse(HighestUser().Tables[0].Rows[0][0].ToString())+ 1).ToString();
            Unblock();
            FnameBox.Text = "";
            LnameBox.Text = "";
            CityBox1.Text = "";
            StreetBox.Text = "";
            PhoneBox.Text = "";
            NoteBox.Text = "";
            DisBox.Text = "";
            SubBox.Text = "";
            EmailBox.Text = "";
            DebtBox.Text = "";
        }
        public void Unblock()
        {
            
            FnameBox.ReadOnly = false;
            LnameBox.ReadOnly = false;
            // CityBox.ReadOnly = false;
            StreetBox.ReadOnly = false;
            PhoneBox.ReadOnly = false;
            NoteBox.ReadOnly = false;
            DisBox.ReadOnly = false;
            SubBox.ReadOnly = false;
            EmailBox.ReadOnly = false;
            DebtBox.ReadOnly = false;
            SaveB.Enabled = true;
        }

        private void CityBox_DoubleClick(object sender, EventArgs e)
        {
            if(CityBox1.ReadOnly == false)
            {
                CityForm cf = new CityForm();
                cf.Show();
            }

            
        }
        public void UpdateCity(int x)
        {
            CityBox1.Text = (GetCity(x).Tables[0].Rows[0][0].ToString());
        }
        private bool Check()
        {
            if (!Validation.Digits(DisBox.Text))
            {
                MessageBox.Show("הקש מספר בתיבת ההנחה!");
                return false;
            }
            if (!Validation.Digits(DebtBox.Text))
            {
                MessageBox.Show("הקש מספר בתיבת היתרה!!");
                return false;
            }
            // Validation v = new Validation();
            // return !string.IsNullOrWhiteSpace(str); v.Check(FnameBox.Text, LnameBox.Text, StreetBox.Text, CityBox.Text, PhoneBox.Text, NoteBox.Text, DisBox.Text, SubBox.Text, EmailBox.Text);
            if (string.IsNullOrWhiteSpace(FnameBox.Text))
            {
                MessageBox.Show("שם פרטי ריק!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(LnameBox.Text))
            {
                MessageBox.Show("שם משפחה ריק!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(PhoneBox.Text))
            {
                MessageBox.Show("המספר טלפון ריק!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(CityBox1.Text))
            {
                MessageBox.Show("העיר ריק!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SaveB_Click(object sender, EventArgs e)
        {

          
            if (int.Parse(IdBox.Text) == int.Parse(HighestUser().Tables[0].Rows[0][0].ToString()) + 1)
            {
                
                if (DisBox.Text == "")
                {
                    DisBox.Text = "0";
                }
                if (SubBox.Text == "")
                {
                    SubBox.Text = "אין";
                }
                if (NoteBox.Text == "")
                {
                    NoteBox.Text = "אין";
                }
                if (EmailBox.Text == "")
                {
                    EmailBox.Text = "אין";
                }
                if (StreetBox.Text == "")
                {
                    StreetBox.Text = "אין";
                }
                if(CityBox1.Text == "")
                {
                    CityBox1.Text = "לא צויין";
                }
                if(DebtBox.Text == "")
                {
                    DebtBox.Text = "0";
                }
                else if(Check())
                {
                    User u = new User(FnameBox.Text, LnameBox.Text, StreetBox.Text, int.Parse(GetId(CityBox1.Text).Tables[0].Rows[0][0].ToString()), PhoneBox.Text, NoteBox.Text, int.Parse(DisBox.Text), SubBox.Text, EmailBox.Text, double.Parse(DebtBox.Text));
                    
                    UserService us = new UserService();
                    us.InsertUser(u);
                    Block();
                    SaveB.Enabled = false;
                    this.timer1.Start();
                    Bar.Visible = true;
                    System.Threading.Thread.Sleep(3000);
                    DataSet ds = GetUserById(int.Parse(IdBox.Text));
                    User n = new User(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(),
                    int.Parse(ds.Tables[0].Rows[0][4].ToString()), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), int.Parse(ds.Tables[0].Rows[0][7].ToString()), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), double.Parse(ds.Tables[0].Rows[0][10].ToString()));
                    Populate(n);
                    MessageBox.Show("הלקוח נרשם בהצלחה!");
                    Bar.Visible = false;
                    Bar.Value = 0;
                    Choose.u = n;
                }
            }

            else if(Check())
            { 
                User u = new User(int.Parse(IdBox.Text), FnameBox.Text, LnameBox.Text, StreetBox.Text, int.Parse(GetId(CityBox1.Text).Tables[0].Rows[0][0].ToString()), PhoneBox.Text, NoteBox.Text, int.Parse(DisBox.Text), SubBox.Text, EmailBox.Text, int.Parse(DebtBox.Text.Replace("₪", "")));
                UserService us = new UserService();
                us.UpdatetUser(u);
                Block();
                SaveB.Enabled = false;
                this.timer1.Start();
                Bar.Visible = true;
                System.Threading.Thread.Sleep(3000);
                Populate(u);
                MessageBox.Show("הלקוח התעדכן בהצלחה! ");
                Bar.Visible = false;
                Bar.Value = 0;
                Choose.u = u;
            }
        }
        //private void Format()
        //{
        //    for(int i = 0; i < OrderGrid.Rows.Count; i++)
        //    {
        //        OrderGrid.Rows[i].Cells[6].ValueType = typeof(string);
        //        int x = int.Parse(OrderGrid.Rows[i].Cells[6].Value.ToString());
        //        //MessageBox.Show(x.ToString());
        //        OrderGrid.Rows[i].Cells[6].Value = String.Format("₪ {0:n}", x);
        //        //OrderGrid.Rows[i].Cells[6].Value = "hi";
        //    }
        //    for (int i = 0; i < ReadyGrid.Rows.Count; i++)
        //    {
        //        int x = int.Parse(ReadyGrid.Rows[i].Cells[6].Value.ToString());
        //        //MessageBox.Show(x.ToString());
        //        //OrderGrid.Rows[i].Cells[6].Value = String.Format("₪ {0:n}", x);
        //        //ReadyGrid.Rows[i].Cells[6].Value = "hi";
        //    }
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Bar.Increment(85);
        }

        private void NewItemB_Click(object sender, EventArgs e)
        {
            if(Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                NewItems ni = new NewItems();
                ni.getId(int.Parse(Id.Text));
                ni.getDis(int.Parse(Discount.Text));
                if (ni.ShowDialog() == DialogResult.OK)
                {
                    System.Threading.Thread.Sleep(500);
                    OrderGrid.AutoGenerateColumns = false;
                    OrderGrid.DataSource = GetOrders(int.Parse(Id.Text));
                    OrderGrid.DataMember = "Orders";
                    Calculate();
                }
            }

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void Calculate()
        {
            int total = 0;
            int amount = 0;
            int total2 = 0;
            int amount2 = 0;
            for (int i = 0; i < OrderGrid.Rows.Count; i++)
            {
                total += int.Parse(OrderGrid.Rows[i].Cells[6].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                amount += int.Parse(OrderGrid.Rows[i].Cells[5].Value.ToString());
            }
            for(int i =0; i< ReadyGrid.Rows.Count; i++)
            {
                total2 += int.Parse(ReadyGrid.Rows[i].Cells[6].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                amount2 += int.Parse(ReadyGrid.Rows[i].Cells[5].Value.ToString());
            }
            TotalM.Text = String.Format("₪ {0:n}", total);
            TotalA.Text = amount.ToString();
            TotalM2.Text = String.Format("₪ {0:n}", total2);
            TotalA2.Text = amount2.ToString();
            Debt.Text = String.Format("₪ {0:n}" , GetDebt(int.Parse(Id.Text)).Tables[0].Rows[0][0].ToString());
        }
        private void EditB_Click(object sender, EventArgs e)
        {
            if(CityBox1.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                Unblock();
            }
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (OrderGrid.Rows.Count > 0)
            {
                OrderService os = new OrderService();
                os.UpdateStatus(int.Parse(OrderGrid.CurrentRow.Cells[0].Value.ToString()), "בוטל");
                SetDebt(int.Parse(Id.Text), -int.Parse(OrderGrid.CurrentRow.Cells[6].Value.ToString()));
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("הפריט הוסר בהצלחה");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetOrders(int.Parse(Id.Text));
                OrderGrid.DataMember = "Orders";
                Calculate();
                Populate(Choose.u);
            }
            else
            {
                MessageBox.Show("לא נבחרו הזמנות");
            }
        }
        private void ReadyB_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (OrderGrid.Rows.Count > 0)
            {
                OrderService os = new OrderService();
                os.UpdateStatus(int.Parse(OrderGrid.CurrentRow.Cells[0].Value.ToString()), "מוכן");
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("הפריט הועבר בהצלחה");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetOrders(int.Parse(Id.Text));
                OrderGrid.DataMember = "Orders";
                ReadyGrid.AutoGenerateColumns = false;
                ReadyGrid.DataSource = GetReadyOrders(int.Parse(Id.Text));
                ReadyGrid.DataMember = "Orders";
                Calculate();
            }
            else
            {
                MessageBox.Show("לא נבחרו הזמנות");
            }

        }
        
        private void PayDebt_Click(object sender, EventArgs e)
        {
            
            if(Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                if (Choose.u.Debt <= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("ללקוח לא קיים חוב האם רוצה להמשיך?", "אין חוב", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PayDebt pd = new PayDebt();
                        pd.LoadAmount(int.Parse(Debt.Text.Replace("₪", "")), int.Parse(Id.Text));
                        if (pd.ShowDialog() == DialogResult.OK)
                        {
                            Calculate();
                        }
                    }
                    
                }
                else
                {
                    PayDebt pd = new PayDebt();
                    pd.LoadAmount(int.Parse(Debt.Text.Replace("₪", "")), int.Parse(Id.Text));
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        Calculate();
                    }
                }
            }
         }

        private void ReadyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (OrderGrid.Rows.Count > 0)
            {
                OrderService os = new OrderService();
                os.UpdateStatus(int.Parse(OrderGrid.CurrentRow.Cells[0].Value.ToString()), "הוחזר");
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("הפריט הועבר בהצלחה");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetOrders(int.Parse(Id.Text));
                OrderGrid.DataMember = "Orders";
                ReadyGrid.AutoGenerateColumns = false;
                ReadyGrid.DataSource = GetReadyOrders(int.Parse(Id.Text));
                ReadyGrid.DataMember = "Orders";
                Calculate();
            }
            else
            {
                MessageBox.Show("לא נבחרו הזמנות");
            }
        }

        public static void CheckMaker()
        {
            try
            {
                TextWriter tw = new StreamWriter("C:/Users/Michael/Desktop/Checks/Check.txt", true);
                tw.WriteLine("Very interesting something");
                tw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Worked!");

        }

        private void CityBox_Click(object sender, EventArgs e)
        {
            if (FnameBox.ReadOnly == false)
            {
                CityForm cf = new CityForm();
                cf.Show();
            }
            else
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!!");
            }
        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            CheckMaker();
        }

        private void TestBox_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }
           
        private static decimal CalculateTotal(DataSet dataSet)
        {
            decimal total = 0;
            if(dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Assuming OrderPrice column contains decimal values
                    if (decimal.TryParse(row["OrderPrice"].ToString(), out decimal orderPrice))
                    {
                        total += orderPrice;
                    }
                }
            }
            

            return total;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataSet dataSet = GetOrdersById(Choose.id);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס' הזמנה" },
                    { "UserName", "שם" },
                    { "ItemName", "תיאור" },
                    { "ColorName", "צבע" },
                    { "OrderAmount", "כמות" },
                    { "OrderPrice", "מחיר" }
                    // Add more mappings as needed
                };

            Graphics graphics = e.Graphics;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;

            int leftMargin = 20;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("MM / dd / yyyy HH: mm");
            string receiptNo = "Receipt #: 001";
            string thankYou = "!תודה רבה על ההזמנה";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF receiptNoSize = measureString(receiptNo, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + receiptNoSize.Height + 40 + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;
            //20 + // Space between table and total
            //40 + // Height of the total section
            //thankYouSize.Height; // Height of the thank you section

            // Reset top margin to align at the top of the page
            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            graphics.DrawString(receiptNo, normalFont, brush, centerX - receiptNoSize.Width / 2, topMargin);
            topMargin += (int)receiptNoSize.Height;


            // Define the text for the three lines
            string line1 = "לכ': " + dataSet.Tables[0].Rows[0][11].ToString() + " " + dataSet.Tables[0].Rows[0][12].ToString();
            string line2 = "תאריך הזמנה: " + dataSet.Tables[0].Rows[0][4].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);

            // Draw the lines in the desired styles before the table section
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines

            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10 ;


            Font tableFont = new Font("Arial", 10);
            Font HeaderTableFont = new Font("Arial", 10, FontStyle.Bold);

            int columnWidth = 50; // Increased column width
            int columnSpacing = 30; // Increased column spacing

            for (int i = 0; i < selectedColumns.Length; i++)
            {
                string columnName = selectedColumns[i];
                string columnTitle = columnTitleMap.ContainsKey(columnName) ? columnTitleMap[columnName] : columnName;
                SizeF columnTitleSize = graphics.MeasureString(columnTitle, HeaderTableFont);

                // Calculate the center for each column
                int xPosition = (int)(((totalWidth - (selectedColumns.Length * columnWidth) - (selectedColumns.Length - 1) * columnSpacing)) / 2) + i * (columnWidth + columnSpacing);
                int textOffset = (int)((columnWidth - columnTitleSize.Width) / 2); // Adjust for text alignment

                graphics.DrawString(columnTitle, HeaderTableFont, Brushes.Black, xPosition + textOffset, topMargin);
            }

            topMargin += 30; // Increased space between table header and data

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                for (int i = 0; i < selectedColumns.Length; i++)
                {
                    int columnIndex = dataSet.Tables[0].Columns.IndexOf(selectedColumns[i]);
                    if (columnIndex >= 0)
                    {
                        string columnValue = row[columnIndex].ToString();
                        SizeF columnValueSize = graphics.MeasureString(columnValue, tableFont);

                        // Calculate the center for each column and adjust for text alignment
                        int xPosition = (int)(((totalWidth - (selectedColumns.Length * columnWidth) - (selectedColumns.Length - 1) * columnSpacing)) / 2) + i * (columnWidth + columnSpacing);
                        int textOffset = (int)((columnWidth - columnValueSize.Width) / 2); // Adjust for text alignment

                        graphics.DrawString(columnValue, tableFont, Brushes.Black, xPosition + textOffset, topMargin);
                    }
                }
                topMargin += 25; // Increased row height
            }

            topMargin += 0; // Increased space between table and total
            decimal totalAmount = CalculateTotal(dataSet);
            decimal tax = totalAmount * 0.17m;
            decimal beforeTax = totalAmount - tax;
            string line1BeforeTotal = "לפני מע'מ: " + beforeTax.ToString("C");
            string line2BeforeTotal = "סה'כ מע'מ: " + tax.ToString("C");

            line1Size = measureString(line1BeforeTotal, normalFont);
            line2Size = measureString(line2BeforeTotal, normalFont);

            topMargin += 10; // Increase space between previous content and additional lines

            graphics.DrawString(line1BeforeTotal, normalFont, brush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height;

            graphics.DrawString(line2BeforeTotal, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height;

            string totalText = "סך הכל לתשלום בש'ח: " + totalAmount.ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            string additionalMessage1 = "סימון ומידה באחריות הלקוח בלבד";
            string additionalMessage2 = "קבלת בגד עם שובר הזמנה בלבד";
            string additionalMessage3 = "אין החזר כספי על תיקון שבוצע";
            string additionalMessage4 = "שמירת פריט עד 30 יום";
            string additionalMessage5 = "אין אחריות על גניבה או כל נזק אחר";
            string additionalMessage6 = "לתשומת לבכם - המתפרה סגורה ביום שלישי";

            SizeF additionalMessageSize1 = measureString(additionalMessage1, normalFont);
            SizeF additionalMessageSize2 = measureString(additionalMessage2, normalFont);
            SizeF additionalMessageSize3 = measureString(additionalMessage3, normalFont);
            SizeF additionalMessageSize4 = measureString(additionalMessage4, normalFont);
            SizeF additionalMessageSize5 = measureString(additionalMessage5, normalFont);
            SizeF additionalMessageSize6 = measureString(additionalMessage6, normalFont);

            topMargin += 0; // Increase space between total and additional messages

            graphics.DrawString(additionalMessage1, normalFont, brush, centerX - additionalMessageSize1.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize1.Height;

            graphics.DrawString(additionalMessage2, normalFont, brush, centerX - additionalMessageSize2.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize2.Height;

            graphics.DrawString(additionalMessage3, normalFont, brush, centerX - additionalMessageSize3.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize3.Height;

            graphics.DrawString(additionalMessage4, normalFont, brush, centerX - additionalMessageSize4.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize4.Height;

            graphics.DrawString(additionalMessage5, normalFont, brush, centerX - additionalMessageSize5.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize5.Height;

            graphics.DrawString(additionalMessage6, normalFont, brush, centerX - additionalMessageSize6.Width / 2, topMargin);
            topMargin += (int)additionalMessageSize6.Height;

            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);


        }

        private void History_Click(object sender, EventArgs e)
        {
            if(Choose.u == null)
            {
                AllOrders All = new AllOrders();
                All.Show();
            }
            else
            {
                AllOrders All = new AllOrders();
                All.Show();
            }
            
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(Choose.location);
            PaymentStats ps = new PaymentStats();
            ps.Show();
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            Clock w = new Clock();
            w.Show();
        }

        private void XIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

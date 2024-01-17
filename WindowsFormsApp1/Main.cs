using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Text;
using SelectPdf;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        bool isBlocked = true;
        private Point mouseLocation;
        FunctionService function = new FunctionService();
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
        public void SignOut()
        {
            Choose.u = null;
            Choose.id = 0;
            ResetAllBoxes();
            Unpopulate();
            SaveB.Enabled = false;
        }
        public void SignIn(int id)
        {
            DataSet ds = function.GetUserById(id);
            User u = new User(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(),
              int.Parse(ds.Tables[0].Rows[0][4].ToString()), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), int.Parse(ds.Tables[0].Rows[0][7].ToString()), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), int.Parse(ds.Tables[0].Rows[0][10].ToString()));
            Choose.u = u;
            Choose.id = id;
            Populate(Choose.u);
            Block();
            tabControl1.SelectedIndex = 2;
            PopulateFinance();
        }
        private List<int> IdSelected(DataGridView table, int index, int idIndex)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.Cells[index].Value != null && Convert.ToBoolean(row.Cells[index].Value) == true)
                {
                    ids.Add(int.Parse(row.Cells[idIndex].Value.ToString()));
                }
            }
            return ids;
        }
        public double CalculateWork(DataSet dataSet)
        {
            double minutes = 0;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                minutes += double.Parse(row[4].ToString());
            }
            minutes = minutes / 60;
            return minutes;

        }
        private async Task Animate(int goal, Label label)
        {
            const int animationSpeed = 1; // Adjust animation speed (lower values make it faster)
            int step = goal / 20; // Adjust steps for a smooth animation
            for (int i = 0; i <= goal; i += step)
            {
                label.Text = i.ToString();
                await Task.Delay(animationSpeed); // Adjust the delay time for speed
            }
            label.Text = goal.ToString();
        }
        private void CalculateProfit()
        {

            DateTime today = DateTime.Today;
            DayOfWeek currentDay = today.DayOfWeek;
            DateTime startOfWeek = today.AddDays(-(int)currentDay);
            int price = 0;
            int year = 0;
            int month = 0;
            int day = 0;
            DataTable data = function.GetAllPrices().Tables[0];
            foreach (DataRow row in data.Rows)
            {
                price = int.Parse(row["CheckPrice"].ToString());
                DateTime date = row.Field<DateTime>("CheckDate");
                if (date.Year == today.Year && date.Month == today.Month && date.Day == today.Day)
                {
                    day += price;
                }
                if (date.Year == today.Year && date.Month == today.Month)
                {
                    month += price;
                }
                year += price;
            }
            ThisYearText.Text = year.ToString();
            ThisMonthText.Text = month.ToString();
            ThisDayText.Text = day.ToString();
            // NEEDS AN OPTIMIZATION!!
        }
        public void populateGraff()
        {
            Chart newChart = CheckService.GenerateChart(); // Assuming GenerateChart returns a new Chart
            MonthGraff.Series.Clear();
            MonthGraff.Legends.Clear();

            // Copy properties from newChart to chart2
            MonthGraff.ChartAreas.Clear();
            foreach (ChartArea area in newChart.ChartAreas)
            {
                MonthGraff.ChartAreas.Add(area);
            }

            // Copy series from newChart to chart2
            foreach (Series series in newChart.Series)
            {
                MonthGraff.Series.Add(series);
            }
        }
        public void PopulateShop()
        {
            ShopGrid.AutoGenerateColumns = false;
            ShopGrid.DataSource = function.ShopList();
            ShopGrid.DataMember = "Shop";
        }
        public void PopulateGrids()
        {
            UserGrid.AutoGenerateColumns = false;
            UserGrid.DataSource = function.GetUsers();
            UserGrid.DataMember = "Users";
            UnfinishedItems.AutoGenerateColumns = false;
            UnfinishedItems.DataSource = function.GetUnfinished();
            UnfinishedItems.DataMember = "Orders";
            UserOwe.AutoGenerateColumns = false;
            UserOwe.DataSource = function.GetUserDebts();
            UserOwe.DataMember = "Users";
            PopulateShop();
            CalculateProfit();
            populateGraff();
            PopulateFinance();

        }
        private void PopulateFinance()
        {
            FinanceGrid.AutoGenerateColumns = false;
            FinanceGrid.DataSource = function.GetAllFinanceById(Choose.id);

        }
        private void Main_Load(object sender, EventArgs e)
        {
            SetText();
            PopulateGrids();
            //Clock w = new Clock();
            //w.Show();
            //function.SortChecks();
        }
        private void UserS_Click(object sender, EventArgs e)
        {
            SaveB.Enabled = false;
            UserSearch userS = new UserSearch();
            if (userS.ShowDialog() == DialogResult.OK)
            {
                Populate(Choose.u);
                Block();
            }
        }
        public void PopulateDebt()
        {
            int debt = function.GetDebt(Choose.id);
            Debt.Text = String.Format("₪ {0:n}", debt.ToString());
            DebtBox.Text = String.Format("₪ {0:n}", debt.ToString());
        }
        private void Populate(User u)
        {
            Mname.Text = u.Fname + " " + u.LName;
            Debt.Text = String.Format("₪ {0:n}", u.Debt.ToString());
            DebtBox.Text = u.Debt.ToString();
            Id.Text = u.Id.ToString();
            Fname.Text = u.Fname;
            Lname.Text = u.LName;
            Street.Text = u.Street;
            City.Text = (function.GetCity(u.City).Tables[0].Rows[0][0].ToString());
            Phone.Text = u.Phone;
            Note.Text = u.Note;
            Discount.Text = u.Discount.ToString();
            Sub.Text = u.Sub;
            IdBox.Text = u.Id.ToString();
            FnameBox.Text = u.Fname;
            LnameBox.Text = u.LName;
            CityBox1.Text = (function.GetCity(u.City).Tables[0].Rows[0][0].ToString());
            StreetBox.Text = u.Street;
            PhoneBox.Text = u.Phone;
            NoteBox.Text = u.Note;
            DisBox.Text = u.Discount.ToString();
            SubBox.Text = u.Sub;
            EmailBox.Text = u.Email;
            DebtBox.Text = String.Format("₪ {0:n}", u.Debt.ToString());
            OrderGrid.AutoGenerateColumns = false;
            OrderGrid.DataSource = function.GetOrders(u.Id);
            OrderGrid.DataMember = "Orders";
            ReadyGrid.AutoGenerateColumns = false;
            ReadyGrid.DataSource = function.GetReadyOrders(u.Id);
            ReadyGrid.DataMember = "Orders";
            Calculate();
            int labelCenterX = 125;
            Label[] labels = { Id, Fname, Lname, Street, City, Phone, Note, Discount, Sub };
            foreach (Label label in labels)
            {
                int labelWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;
                label.Location = new Point(labelCenterX - labelWidth, label.Location.Y);
            }
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
            DebtBox.ReadOnly = true;
            isBlocked = true;
        }
        private void ResetAllBoxes()
        {
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
        private void Unpopulate()
        {
            Mname.Text = "";
            Debt.Text = "";
            Id.Text = "";
            Fname.Text = "";
            Lname.Text = "";
            Street.Text = "";
            City.Text = "";
            Phone.Text = "";
            Note.Text = "";
            Discount.Text = "";
            Sub.Text = "";
            IdBox.Text = "";
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
            TotalM.Text = "";
            TotalA.Text = "";
            TotalM2.Text = "";
            TotalA2.Text = "";
            Debt.Text = "";
            OrderGrid.DataSource = null;
            ReadyGrid.DataSource = null;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            IdBox.Text = (function.HighestUser() + 1).ToString();
            Unblock();
            ResetAllBoxes();
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
            isBlocked = false;
        }
        private void CityBox_DoubleClick(object sender, EventArgs e)
        {
            if (CityBox1.ReadOnly == false)
            {
                CityForm cf = new CityForm();
                cf.Show();
            }
        }
        public void UpdateCity(int x)
        {
            CityBox1.Text = (function.GetCity(x).Tables[0].Rows[0][0].ToString());
        }
        private bool Check()
        {
            string debt = DebtBox.Text.ToString();
            if (!Validation.Digits(DisBox.Text))
            {
                MessageBox.Show("הקש מספר בתיבת ההנחה!");
                return false;
            }
            if (!int.TryParse(debt.Replace(",", "").Replace("₪", "").Replace(".00", ""), out int newDebt))
            {
                MessageBox.Show("הקש מספר בתיבת היתרה!!");
                return false;
            }
            else
            {
                DebtBox.Text = newDebt.ToString();
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
            if (int.Parse(IdBox.Text) == (function.HighestUser() + 1))
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
                if (CityBox1.Text == "")
                {
                    CityBox1.Text = "לא צויין";
                }
                if (DebtBox.Text == "")
                {
                    DebtBox.Text = "0";
                }
                if (Check())
                {
                    User u = new User(FnameBox.Text, LnameBox.Text, StreetBox.Text, int.Parse(function.GetId(CityBox1.Text).Tables[0].Rows[0][0].ToString()), PhoneBox.Text, NoteBox.Text, int.Parse(DisBox.Text), SubBox.Text, EmailBox.Text, int.Parse(DebtBox.Text));
                    function.InsertUser(u);
                    Block();
                    SaveB.Enabled = false;
                    this.timer1.Start();
                    Bar.Visible = true;
                    System.Threading.Thread.Sleep(3000);
                    DataSet ds = function.GetUserById(int.Parse(IdBox.Text));
                    User newUser = new User(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(),
                    int.Parse(ds.Tables[0].Rows[0][4].ToString()), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), int.Parse(ds.Tables[0].Rows[0][7].ToString()), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), int.Parse(ds.Tables[0].Rows[0][10].ToString()));
                    SignIn(newUser.Id);
                    MessageBox.Show("הלקוח נרשם בהצלחה!");
                    Bar.Visible = false;
                    Bar.Value = 0;
                }
            }
            else if (Check())
            {
                User u = new User(int.Parse(IdBox.Text), FnameBox.Text, LnameBox.Text, StreetBox.Text, int.Parse(function.GetId(CityBox1.Text).Tables[0].Rows[0][0].ToString()), PhoneBox.Text, NoteBox.Text, int.Parse(DisBox.Text), SubBox.Text, EmailBox.Text, int.Parse(DebtBox.Text.Replace("₪", "")));
                function.UpdateUser(u);
                Block();
                SaveB.Enabled = false;
                this.timer1.Start();
                Bar.Visible = true;
                System.Threading.Thread.Sleep(1000);
                Choose.u = u;
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
            if (Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                NewItems ni = new NewItems();
                if (ni.ShowDialog() == DialogResult.OK)
                {
                    OrderGrid.AutoGenerateColumns = false;
                    OrderGrid.DataSource = function.GetOrders(Choose.id);
                    OrderGrid.DataMember = "Orders";
                    DebtBox.Text = Choose.u.Debt.ToString("C");
                    Calculate();
                    System.Threading.Thread.Sleep(100);
                    PrintPreview.Document = printDocument1;
                    PrintPreview.ShowDialog();
                    printInvoice();
                    //for(int i = 0)
                    //printDocument1.Print();
                }
            }
        }
        public void Calculate()
        {
            int total = 0;
            int amount = 0;
            int total2 = 0;
            int amount2 = 0;
            for (int i = 0; i < OrderGrid.Rows.Count; i++)
            {
                total += int.Parse(OrderGrid.Rows[i].Cells["OrderPrice"].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                amount += int.Parse(OrderGrid.Rows[i].Cells["OrderAmount"].Value.ToString());
            }
            for (int i = 0; i < ReadyGrid.Rows.Count; i++)
            {
                total2 += int.Parse(ReadyGrid.Rows[i].Cells["OrderPrice2"].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                amount2 += int.Parse(ReadyGrid.Rows[i].Cells["OrderAmount2"].Value.ToString());
            }
            TotalM.Text = String.Format("₪ {0:n}", total);
            TotalA.Text = amount.ToString();
            TotalM2.Text = String.Format("₪ {0:n}", total2);
            TotalA2.Text = amount2.ToString();
            try
            {
                Debt.Text = String.Format("₪ {0:n}", Choose.u.Debt);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        private void EditB_Click(object sender, EventArgs e)
        {
            if (CityBox1.Text == "")
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

            List<int> ids = IdSelected(OrderGrid, 0, 1);
            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט!");
            }
            else
            {
                DialogResult result = MessageBox.Show("רציני את רוצה לבטל", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    List<int> ordersPaid = function.OrdersPaid(ids);
                    List<int> listOfInvoices = function.ListOfInvoices(ids);
                    if(ordersPaid.Count > 0)
                    {
                        MessageBox.Show("הזמנות " + String.Join(", ", ordersPaid) + " כבר שולמו");
                    }
                    else if (listOfInvoices.Count > 0)
                    {
                        MessageBox.Show("להזמנות " + String.Join(", ", listOfInvoices) + " קיימות חשבונית מס");
                    }
                    else
                    {
                        int total = 0;
                        foreach (DataGridViewRow row in OrderGrid.Rows)
                        {
                            if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value) == true)
                            {
                                total += int.Parse(row.Cells["OrderPrice"].Value.ToString());
                            }
                        }
                        function.UpdateStatus(IdSelected(OrderGrid, 0, 1), "בוטל");
                        int newDebt = Choose.u.Debt - total;
                        Choose.u.Debt = newDebt;
                        function.SetDebt(Choose.id, newDebt);
                        MessageBox.Show("הפריט הוסר בהצלחה");
                        OrderGrid.AutoGenerateColumns = false;
                        OrderGrid.DataSource = function.GetOrders(Choose.id);
                        OrderGrid.DataMember = "Orders";
                        Calculate();
                        Populate(Choose.u);
                    }
                }
            }
        }
        private void ReadyB_Click(object sender, EventArgs e)
        {


            List<int> ids = IdSelected(OrderGrid, 0, 1);
            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט!");
            }
            else
            {
                string cabin = "ללא";
                InputForm input = new InputForm("בחר תא:", false);
                if (input.ShowDialog() == DialogResult.OK)
                {
                    cabin = input.userInput;
                }
                function.SetCabin(ids, cabin);
                function.UpdateStatus(ids, "מוכן");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = function.GetOrders(Choose.id);
                OrderGrid.DataMember = "Orders";
                ReadyGrid.AutoGenerateColumns = false;
                ReadyGrid.DataSource = function.GetReadyOrders(Choose.id);
                ReadyGrid.DataMember = "Orders";
                Calculate();
            }
        }
        private void SendMessage(string message)
        {
            string number = "{+}972" + Choose.u.Phone.Substring(1);
            //string programPath = @"G:\_PROJECT_\Extra\main.exe"; // Replace this with the path to your program
            string programPath = @"Extra\main.exe"; // Replace this with the path to your program
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = programPath,
                UseShellExecute = true // Set to true if you want to use the shell
            };

            Process process = new Process
            {
                StartInfo = startInfo
            };

            try
            {
                process.Start();

                // Delay for a moment to ensure the application has started
                System.Threading.Thread.Sleep(5000); // Adjust this delay as needed
                SendKeys.SendWait(number); // Replace this with the keys you want to send
                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait(message); 
                SendKeys.SendWait("{ENTER}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PayDebt_Click(object sender, EventArgs e)
        {
            if (!function.isRegisterOpen())
            {
                MessageBox.Show("קופה לא נפתחה");
            }
            else if (Id.Text == "")
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                if (Choose.u.Debt <= 0)
                {
                    MessageBox.Show("ללקוח לא קיים חוב");
                }
                else
                {
                    PayDebt pd = new PayDebt();
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        Calculate();
                        printCheck();
                        printReceipt();
                        printInvoice();
                    }
                }
            }
        }
        public void printCheck()
        {
            int count = Choose.ChecksToPrint.Count;
            for (int i = 0; i < count; i++)
            {
                PrintPreview.Document = PrintCheck;
                PrintPreview.ShowDialog();
                //PrintCheck.Print();
                Choose.ChecksToPrint.RemoveAt(0);
            }
        }
        public void printReceipt()
        {
            int count = Choose.ReceiptsToPrint.Count;
            for (int i = 0; i < count; i++)
            {
                PrintPreview.Document = PrintReceipt;
                PrintPreview.ShowDialog();
                //PrintReceipt.Print();
                Choose.ReceiptsToPrint.RemoveAt(0);
            }
        }
        public void printReReceipt(bool changeDebt)
        {
            int count = Choose.ReceiptsToPrint.Count;
            for (int i = 0; i < count; i++)
            {
                PrintPreview.Document = PrintReReceipt;
                PrintPreview.ShowDialog();
                //PrintReReceipt.Print();
                Choose.ReceiptsToPrint.RemoveAt(0);
            }
            if (changeDebt)
            {
                PopulateDebt();
            }
        }
        public void printReInvoice(bool changeDebt)
        {
            int count = Choose.InvoicesToPrint.Count;
            for (int i = 0; i < count; i++)
            {
                PrintPreview.Document = ReInvoicePrint;
                PrintPreview.ShowDialog();
                //ReInvoicePrint.Print();
                Choose.InvoicesToPrint.RemoveAt(0);
            }
            if (changeDebt)
            {
                SignIn(Choose.id);
            }
        }
        public static void CheckMaker()
        {
            try
            {
                TextWriter tw = new StreamWriter("C:/Users/Michael/Desktop/Checks/Check.txt", true);
                tw.WriteLine("The date today is:" + DateTime.Now.ToString());
                tw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
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
            List<int> ids = IdSelected(ReadyGrid, 0, 1);
            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט!");
            }
            else
            {
                function.UpdateStatus(ids, "בטיפול");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = function.GetOrders(Choose.id);
                OrderGrid.DataMember = "Orders";
                ReadyGrid.AutoGenerateColumns = false;
                ReadyGrid.DataSource = function.GetReadyOrders(Choose.id);
                ReadyGrid.DataMember = "Orders";
                Calculate();
            }
        }
        private void AddCust_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            IdBox.Text = (function.HighestUser() + 1).ToString();
            Unblock();
            ResetAllBoxes();
        }
        private void TestBox_Click(object sender, EventArgs e)
        {
            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                PrintPreview.Document = printDocument1;
                PrintPreview.ShowDialog();

            }
        }
        private static decimal CalculateTotal(DataSet dataSet)
        {
            decimal total = 0;
            decimal paid = 0;
            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Assuming OrderPrice column contains decimal values
                    if (decimal.TryParse(row["OrderPrice"].ToString(), out decimal orderPrice))
                    {
                        total += orderPrice;
                    }
                    if (decimal.TryParse(row["OrderPaid"].ToString(), out decimal orderPaid))
                    {
                        paid += orderPaid;
                    }
                }
            }
            return total - paid;
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataSet dataSet = function.GetOrderPrint(Choose.id);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס'" },
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

            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
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
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;

            // Define the text for the three lines
            string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string line2 = "תאריך הזמנה: " + dataSet.Tables[0].Rows[0]["OrderDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines

            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
        }
        private void History_Click(object sender, EventArgs e)
        {
            if (Choose.u == null)
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
        private void XIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            
        }
    
        private void UserGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int x = int.Parse(this.UserGrid.CurrentRow.Cells[0].Value.ToString());
                DataSet ds = function.GetUserById(x);
                User u = new User(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(),
                  int.Parse(ds.Tables[0].Rows[0][4].ToString()), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), int.Parse(ds.Tables[0].Rows[0][7].ToString()), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), int.Parse(ds.Tables[0].Rows[0][10].ToString()));
                SignIn(u.Id);
                tabControl1.SelectedIndex = 2;
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Clock w = new Clock();
            w.Show();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = function.GetUsers().Tables[0];
            DataView dv = dt.DefaultView;

            // dv.RowFilter = string.Format("username LIKE '%{0}%' OR userphone LIKE '%{0}%' OR (username + ' ' + fname) LIKE '%{0}%'", SearchText.Text);
            dv.RowFilter = string.Format("userphone LIKE '%{0}%' OR (username + ' ' + userlname) LIKE '%{0}%'", SearchText.Text);
            UserGrid.DataSource = dv.ToTable();
        }
        private void Disselect_Click(object sender, EventArgs e)
        {
            SignOut();
        }
        private void CheckListButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            tabControl2.SelectedIndex = 3;
        }
        private void OweButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            tabControl2.SelectedIndex = 0;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
        private void ToItemsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void MovingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void MovingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }
        private void PrintWorkButton_Click(object sender, EventArgs e)
        {
            if (WorkersList.SelectedItem == null)
            {
                MessageBox.Show("נא לבחור עובד!");
            }
            else if (YearSelect.SelectedItem == null)
            {
                MessageBox.Show("נא לבחור שנה");
            }
            else if (MonthSelect.SelectedItem == null)
            {
                MonthSelect.SelectedIndex = 12;
            }
            else
            {
                //PrintPreview.Document = PrintWork;
                //PrintPreview.ShowDialog();
                PrintWork.Print();
            }
        }
        private void PrintWork_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataSet dataSet = new DataSet();
            if (MonthSelect.SelectedIndex == 12)
            {
                dataSet = function.GetClocksByYear(int.Parse(YearSelect.SelectedItem.ToString()), WorkersList.SelectedItem.ToString());
            }
            else
            {
                dataSet = function.GetClocksByMonth(int.Parse(YearSelect.SelectedItem.ToString()), int.Parse(MonthSelect.SelectedItem.ToString()), WorkersList.SelectedItem.ToString());
            }
            string[] selectedColumns = { "ClockDiff", "ClockExit", "ClockEntry", "ClockId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "ClockId", "מס'" },
                    { "ClockName", "שם" },
                    { "ClockEntry", "כניסה" },
                    { "ClockExit", "יציאה" },
                    { "ClockDiff", "דקות" }
                };

            Graphics graphics = e.Graphics;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;

            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה על ההזמנה";
            float totalWidth = graphics.VisibleClipBounds.Width;
            int centerX = (int)(totalWidth / 2);
            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);
            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;
            topMargin = 20;
            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            string line1 = "שם העובד: " + WorkersList.Text;
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);

            topMargin += 10; // Add space before the table segment
            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            Font tableFont = new Font("Arial", 10);
            Font HeaderTableFont = new Font("Arial", 10, FontStyle.Bold);

            int columnWidth = 120; // Increased column width
            int columnSpacing = 30; // Increased column spacing

            for (int i = 0; i < selectedColumns.Length; i++)
            {
                string columnName = selectedColumns[i];
                string columnTitle = columnTitleMap.ContainsKey(columnName) ? columnTitleMap[columnName] : columnName;
                SizeF columnTitleSize = graphics.MeasureString(columnTitle, HeaderTableFont);
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
            decimal totalAmount = 0;
            decimal tax = totalAmount * 0.17m;
            decimal beforeTax = totalAmount - tax;
            topMargin += (int)line1Size.Height;
            string totalText = "סך הכל שעות עבודה: ";
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            topMargin += 0; // Increase space between total and additional messages
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
        }
        private void YesIcon_Click(object sender, EventArgs e)
        {
            if (WorkersList.SelectedItem == null)
            {
                MessageBox.Show("נא לבחור עובד!");
            }
            else if (YearSelect.SelectedItem == null)
            {
                MessageBox.Show("נא לבחור שנה");
            }
            else if (MonthSelect.SelectedItem == null)
            {
                MonthSelect.SelectedIndex = 12;
            }
            else
            {
                DataSet dataSet = new DataSet();
                if (MonthSelect.SelectedIndex == 12)
                {
                    dataSet = function.GetClocksByYear(int.Parse(YearSelect.SelectedItem.ToString()), WorkersList.SelectedItem.ToString());
                }
                else
                {
                    dataSet = function.GetClocksByMonth(int.Parse(YearSelect.SelectedItem.ToString()), int.Parse(MonthSelect.SelectedItem.ToString()), WorkersList.SelectedItem.ToString());
                }
                WorkersGrid.AutoGenerateColumns = false;
                WorkersGrid.DataSource = dataSet;
                WorkersGrid.DataMember = "Clock";
                WorkText.Text = "כמות שעות: " + CalculateWork(dataSet).ToString("0.00");
            }
        }
        private void UserGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.UserGrid.CurrentRow.Cells[0].Value.ToString());
            SignIn(id);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                SignOut();
            }
            if (tabControl1.SelectedIndex != 1)
            {
                if (!isBlocked)
                {
                    Block();
                }
            }
        }
        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(ReadyGrid, 0, 1);
            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else if (ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט!");
            }
            else
            {
                function.Deliver(ids);
                System.Threading.Thread.Sleep(100);
                MessageBox.Show("הפריט נמסר בהצלחה");
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = function.GetOrders(Choose.id);
                OrderGrid.DataMember = "Orders";
                ReadyGrid.AutoGenerateColumns = false;
                ReadyGrid.DataSource = function.GetReadyOrders(Choose.id);
                ReadyGrid.DataMember = "Orders";
                Calculate();
            }
        }
        private void RefreshBox_Click(object sender, EventArgs e)
        {
            if (Choose.id != 0)
            {
                Populate(Choose.u);
            }
            PopulateGrids();
            CalculateProfit();
        }
        private void UserOwe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.UserOwe.CurrentRow.Cells[0].Value.ToString());
            SignIn(id);
        }
        private void UnfinishedItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (this.UnfinishedItems.CurrentRow.Cells[1].Value.ToString());

            int start = name.IndexOf('(') + 1;
            int end = name.IndexOf(')') - start;
            int id = int.Parse(name.Substring(start, end));
            SignIn(id);
        }
        private void OrderGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                OrderGrid.ClearSelection();
            }
        }
        private void SelectAllOrder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrderGrid.Rows)
            {
                if (row.Cells[0].Value == null && Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[0].Value = true;
                }
                else if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[0].Value = false;
                }
                else
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == false)
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        private void SelectAllReady_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ReadyGrid.Rows)
            {
                if (row.Cells[0].Value == null && Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    row.Cells[0].Value = true;
                }
                else if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[0].Value = false;
                }
                else
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == false)
                    {
                        row.Cells[0].Value = true;
                    }
                }

            }
        }

        private void ReadyGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                ReadyGrid.ClearSelection();
            }
        }

        private void PrintChecks_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(OrderGrid, 0, 1);
            ids.AddRange(IdSelected(ReadyGrid, 0, 1));
            if (ids.Count == 0)
            {
                MessageBox.Show("בחר הזמנות");
            }
            else
            {
                PrintPreview.Document = PrintSelected;
                PrintPreview.ShowDialog();
                //PrintSelected.Print();
            }

        }

        private void PrintSelected_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<int> ids = IdSelected(OrderGrid, 0, 1);
            ids.AddRange(IdSelected(ReadyGrid, 0, 1));
            DataSet dataSet = function.GetOrderPrintByIds(ids);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס'" },
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

            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
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
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string line2 = "תאריך הזמנה: " + dataSet.Tables[0].Rows[0][4].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines

            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
        }

        private void SubmitShop_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(ShopGrid, 4, 0);
            if (ids.Count == 0)
            {
                int amount = 0;
                if (!int.TryParse(ShopAmountBox.Texts.ToString(), out amount))
                {
                    MessageBox.Show("אנא רשום מספרים בכמות");
                }
                else if (ShopNameBox.Texts.ToString() == "")
                {
                    MessageBox.Show("שם הפריט ריק");
                }
                else
                {
                    Shop l = new Shop(ShopNameBox.Texts.ToString(), ShopNoteBox.Texts.ToString(), amount, DateTime.Now, false);
                    function.NewShop(l);
                    MessageBox.Show("נוסף פריט");
                    PopulateShop();
                }
            }
            else
            {
                function.isBought(ids);
                MessageBox.Show("הרשימה התעדכנה");
                PopulateShop();
            }

        }

        private void PrintShop_Click(object sender, EventArgs e)
        {
            //PrintPreview.Document = PrintShopList;
            //PrintPreview.ShowDialog();
            PrintShopList.Print();
        }

        private void PrintShopList_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataSet dataSet = function.ShopList();
            string[] selectedColumns = { "ShopDate", "ShopAmount", "ShopNote", "ShopName" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "ShopId", "מס'" },
                    { "ShopName", "שם" },
                    { "ShopNote", "הערה" },
                    { "ShopAmount", "כמות" },
                    { "ShopDate", "תאריך" },
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;

            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!סופר אמא";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);

            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;

            // Define the text for the three lines
            string line1 = "רשימת קניות";
            string line2 = "תאריך: " + DateTime.Today.ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines

            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            topMargin += 40;
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
        }
        private void DrawAdditionalMessages(Graphics graphics, Font normalFont, int centerX, ref int topMargin)
        {
            string[] additionalMessages = new string[]
                {
                    "סימון ומידה באחריות הלקוח בלבד",
                    "קבלת בגד עם שובר הזמנה בלבד",
                    "אין החזר כספי על תיקון שבוצע",
                    "שמירת פריט עד 30 יום",
                    "אין אחריות על גניבה או כל נזק אחר",
                    "לתשומת לבכם - המתפרה סגורה ביום שלישי"
                };
            foreach (string message in additionalMessages)
            {
                SizeF messageSize = graphics.MeasureString(message, normalFont);

                graphics.DrawString(message, normalFont, Brushes.Black, centerX - messageSize.Width / 2, topMargin);
                topMargin += (int)messageSize.Height;
            }
        }
        private void GoEdit_Click(object sender, EventArgs e)
        {

            if (Choose.id == 0)
            {
                MessageBox.Show("עלייך לשלוף תיק לקוח!");
            }
            else
            {
                Unblock();
                tabControl1.SelectedIndex = 1;
            }
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1 && tabControl1.SelectedIndex == 3)
            {
                Animate(int.Parse(ThisYearText.Text), ThisYearText);
                Animate(int.Parse(ThisMonthText.Text), ThisMonthText);
                Animate(int.Parse(ThisDayText.Text), ThisDayText);
            }
        }
        private void SelectShop_Click(object sender, EventArgs e)
        {
            int index = 4;
            foreach (DataGridViewRow row in ShopGrid.Rows)
            {
                if (row.Cells[index].Value == null && Convert.ToBoolean(row.Cells[index].Value) == false)
                {
                    row.Cells[index].Value = true;
                }
                else if (row.Cells[index].Value != null && Convert.ToBoolean(row.Cells[index].Value) == true)
                {
                    row.Cells[index].Value = false;
                }
                else
                {
                    if (Convert.ToBoolean(row.Cells[index].Value) == false)
                    {
                        row.Cells[index].Value = true;
                    }
                }

            }
        }
        private void WorkersList_Click(object sender, EventArgs e)
        {
            WorkersList.DroppedDown = true;
        }
        private void MonthSelect_Click(object sender, EventArgs e)
        {
            MonthSelect.DroppedDown = true;
        }
        private void YearSelect_Click(object sender, EventArgs e)
        {
            YearSelect.DroppedDown = true;
        }
        public void printInvoice()
        {
            int count = Choose.InvoicesToPrint.Count;
            for (int i = 0; i < count; i++)
            {
                PrintPreview.Document = PrintInvoice;
                PrintPreview.ShowDialog();
                //PrintCheck.Print();
                Choose.InvoicesToPrint.RemoveAt(0);
            }
        }
        private void monthIncome_Click(object sender, EventArgs e)
        {
            AllOrders ao = new AllOrders(Choose.id);
            if(ao.ShowDialog() == DialogResult.OK)
            {
                printInvoice();
            }
        }
        private void CreateReport()
        {
            LoadingScreen loading = new LoadingScreen();
            loading.Show();
            OleDbDataReader reader = function.GetAllUsersPhones();
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument pdf = converter.ConvertHtmlString(AddHtml(reader));

            // Save PDF to a file
            string pdfFilePath = "Reports/report.pdf";
            pdf.Save(pdfFilePath);
            pdf.Close();

            loading.Close();
            MessageBox.Show("Operation completed!");

            MessageBox.Show($"PDF created successfully. Path: {Path.GetFullPath(pdfFilePath)}");
        }
        public string AddHtml(OleDbDataReader reader)
        {
            StringBuilder htmlContent = new StringBuilder();
            htmlContent.Append($@"
           <!DOCTYPE html>
            <html lang='he'>
            <head>
                <meta charset='UTF-8'>
                <style>
                    body {{
                        font-family: 'Arial Hebrew', Arial, sans-serif; /* Use your preferred Hebrew-supported font */
                        text-align: center;
                        margin: 40px;
                        direction: rtl;
                    }}
                    h1 {{
                        font-size: 24px;
                        margin-bottom: 10px;
                    }}
                    h2 {{
                        font-size: 18px;
                        margin-top: 30px;
                        margin-bottom: 5px;
                    }}
                    .container {{
                        width: 70%;
                        margin: 0 auto; /* Center the container */
                        text-align: right; /* Align text to the right */
                    }}
                    .row {{
                        display: flex;
                        justify-content: space-between;
                        border-bottom: 1px solid #ccc;
                        padding: 5px 0;
                    }}
                    .cell {{
                        width: 30%;
                        direction: ; /* Set text direction to right-to-left */
                    }}
                    .cell2{{
                        width: 30%;
                        direction: ltr; /* Set text direction to right-to-left */
                    }}
                    .h11{{
                        font-size: 32px;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <center><h1 class='h11'>Studio Lana</h1></center>
                    <h2>רשימת משתמשים</h2> ");
            if(reader != null)
            {
                while (reader.Read())
                {
                    string name = reader["FullName"].ToString();
                    string phone = reader["UserPhone"].ToString();
                    string debt = reader["UserDebt"].ToString();
                    htmlContent.Append($@"<div class='row'>
                        <div class='cell'>{name}</div>
                        <div class='cell2'>{phone}</div>
                        <div class='cell2'>{debt}</div>
                    </div> ");
                }
            }
            htmlContent.Append($@" 
                </div>
            </body>
            </html>
        ");
            return htmlContent.ToString();
        }
        public string AddHtmlReport()
        {
            StringBuilder htmlContent = new StringBuilder();
            htmlContent.Append(@"<!DOCTYPE html>
            <html lang='he'>
            <head>
                <meta charset='UTF-8'>
                <title>Financial Report</title>
                <style>
                    body {
                        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                        direction: rtl;
                        text-align: center;
                        color: #333;
                    }
                    .container {
                        max-width: 800px;
                        margin: 0 auto;
                        padding: 20px;
                        text-align: right;
                    }
                    .title {
                        font-size: 36px;
                        margin-bottom: 20px;
                        color: #333;
                        text-align: center;
                    }
                    .right-side {
                        display: inline-block;
                        width: 40%;
                        vertical-align: top;
                    }
                    .line {
                        margin-bottom: 5px;
                        color: #888;
                        font-size: 12px;
                    }
                    .sentences {
                        margin-top: 10px;
                        font-size: 14px;
                    }
                    /* Decoration for the row */
                    .row {
                        display: flex;
                        justify-content: space-between;
                        margin-bottom: 20px;
                    }
                    .column {
                        flex: 1;
                        padding: 10px;
                        background-color: #f2f2f2;
                        border-radius: 20px;
                        font-size: 14px;
                    }
                    .divider {
                        border-bottom: 1px solid #ccc;
                        margin-bottom: 20px;
                    }
                    /* Headers for sentence sections */
                    h2 {
                        margin-bottom: 5px;
                        font-size: 16px;
                    }
                </style>
            </head>
            <body>
            <div class='container'>
                <div class='title'>
                    STUDIO LANA
                </div>");

            // Continue appending the rest of the HTML content here...
            decimal amountSum = 0;
            decimal paidSum = 0;
            decimal priceSum = 0;
            Dictionary<string, decimal> results = function.OrderMonthReport(DateTime.Now.Month, DateTime.Now.Year);
            if (results != null)
            {
                amountSum = results["AmountSum"];
                 paidSum = results["PaidSum"];
                priceSum = results["PriceSum"];
            }
            htmlContent.Append($@"
                        <div class='right-side'>
                          <div class='line'>עין חנוך 15 דירה 26 קרית אונו</div>
                          <div class='line'>054-5606832</div>
                          <div class='line'>מספר ע.מ \ ח.פ 323608935</div>
                          <div class='line'>דוח סוף חודש לתאריך - {DateTime.Now.Month}\{DateTime.Now.Year}</div>
	                      <div class='line'>תאריך הפקה - {DateTime.Now}</div>
                        </div>
                        <div class='divider'></div>
                        <div class='row'>
                          <div class='column'><center>סה'כ פריטים: {amountSum} </center></div>
                          <div class='column'><center>סה'כ הכנסות: {priceSum}</center></div>
                          <div class='column'><center>נפרע: {paidSum}</center></div>
                        </div>

                        <div class='sentences'>
                          <h2>סה'כ סכום הזמנות חודשי: {priceSum}</h2>
	                      <h2>סה'כ סכום הזמנות ביטול\זיכוי מחדש: 0</h2>
                          <p>סה'כ הזמנות: {amountSum}</p>
                          <p>סכום הזמנות שטרם שולמו: {priceSum - paidSum}</p>
                          <p>סכום הזמנות ששולמו: {paidSum}</p>
                          <h2>פירוט לצרכי מס:</h2>
	                      <div class='divider'></div>
                          <p>סכום חשבוניות מס: 1500, כמות: 0</p>
                          <p>סכום חשבוניות מס\קבלה: 1000, כמות: 0</p>
                          <p>סכום קבלות: 1000</p>
                          <p>סכום זיכויים במס - החזר כסף: 1500, כמות: 0</p>
                          <p>סכום זיכויים במס - קיזוז חשבוניות: 0 , כמות: 0</p>
                          <p>סה'כ חיוב במס: 15000</p>
                          <p>סה'כ זיכוי במס: 0</p>
                          <p>סה'כ מס לדיווח: 15000</p>
                          <div class='divider'></div>
                          <center><h2>תכולת קופה:</h2></center>
	                      <div class='row'>
                          <div class='column'><center>מזומן: 15000</center></div>
                          <div class='column'><center>אשראי: 0</center></div>
                          <div class='column'><center>אחר: 24550</center></div>
                        </div>
                        </div>
                      </div>
                    </body>
                    </html>");
            return htmlContent.ToString();
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(ReadyGrid, 0, 1);
            if(ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט");
            }
            else if(ids.Count == 1)
            {
                string message = "היי " + Choose.u.Fname + " " +Choose.u.LName + ", פריט מספר: "+ string.Join(", ", ids) + " מוכן, מוזמנים להגיע לאסוף בשעות הפעילות, תודה!";
                SendMessage(message);
            }
            else
            {
                string message = "היי " + Choose.u.Fname + " " + Choose.u.LName + ", פריטים מספר: " + string.Join(", ", ids) + " מוכנים, מוזמנים להגיע לאסוף בשעות הפעילות, תודה!";
                SendMessage(message);
            }
        }

        private void ReportMonth_Click(object sender, EventArgs e)
        {
            LoadingScreen loading = new LoadingScreen();
            loading.Show();
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument pdf = converter.ConvertHtmlString(AddHtmlReport());
            // Save PDF to a file
            string pdfFilePath = "Reports/report.pdf";
            pdf.Save(pdfFilePath);
            pdf.Close();
            loading.Close();
            MessageBox.Show($"PDF created successfully. Path: {Path.GetFullPath(pdfFilePath)}");
            Process.Start(Path.GetFullPath(pdfFilePath));
        }

        private void PrintCheck_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet checkData = function.GetCheckById(Choose.ChecksToPrint[0]);
            DataSet dataSet = function.GetCheckPrint(Choose.ChecksToPrint[0]);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס'" },
                    { "UserName", "שם" },
                    { "ItemName", "תיאור" },
                    { "ColorName", "צבע" },
                    { "OrderAmount", "כמות" },
                    { "OrderPrice", "מחיר" },
                    { "OrderDate" , "ת. הזמנה" }
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה ולהתראות";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;
            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            //string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string name = checkData.Tables[0].Rows[0]["CheckName"].ToString();
            int index = name.IndexOf('ע');
            string line1 = name.Substring(0, index);
            string nameLine = name.Substring(index);
            string line2 = "תאריך הפקה: " + checkData.Tables[0].Rows[0]["CheckDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);
            string extraLine;
            if (Boolean.Parse(checkData.Tables[0].Rows[0]["CheckPrinted"].ToString()))
            {
                extraLine = "העתק";
            }
            else
            {
                extraLine = "מקור";
            }
            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF nameLineSize = measureString(nameLine, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            SizeF extraLineSize = measureString(extraLine, normalFont);
            topMargin += 10; // Add space before the table segment

            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(nameLine, headlineFont, headingBrush, centerX - nameLineSize.Width / 2, topMargin);
            topMargin += (int)nameLineSize.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(extraLine, normalFont, brush, centerX - extraLineSize.Width / 2, topMargin);
            topMargin += (int)extraLineSize.Height + 5;
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            decimal totalAmount = int.Parse(checkData.Tables[0].Rows[0]["CheckPrice"].ToString());
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

            string totalText = "סך הכל שולם ב" + checkData.Tables[0].Rows[0]["TypeName"].ToString() + ": " + totalAmount.ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
            function.SetCheckPrinted(Choose.ChecksToPrint[0]);
        }

        private void PrintReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet dataSet = function.GetReceiptById(Choose.ReceiptsToPrint[0]);
            string[] selectedColumns = { "Price" , "TypeName" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "TypeName", "אופן תשלום" },
                    { "Price", "סכום" },
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה ולהתראות";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            //string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string extraLine;
            if (Boolean.Parse(dataSet.Tables[0].Rows[0]["Printed"].ToString()))
            {
                extraLine = "העתק";
            }
            else
            {
                extraLine = "מקור";
            }
            string name = dataSet.Tables[0].Rows[0]["Name"].ToString();
            int index = name.IndexOf('ע');
            string line1 = name.Substring(0, index);
            string nameLine = name.Substring(index);
            string line2 = "תאריך הפקה: " + dataSet.Tables[0].Rows[0]["ReceiptDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF nameLineSize = measureString(nameLine, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            SizeF extraLineSize = measureString(extraLine, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(nameLine, headlineFont, headingBrush, centerX - nameLineSize.Width / 2, topMargin);
            topMargin += (int)nameLineSize.Height + 5; // Add some space between headline and normal text lines

            graphics.DrawString(extraLine, normalFont, brush, centerX - extraLineSize.Width / 2, topMargin);
            topMargin += (int)extraLineSize.Height + 5;
            
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            string totalText = "סך הכל שולם ב" + dataSet.Tables[0].Rows[0]["TypeName"].ToString() + ": " + int.Parse(dataSet.Tables[0].Rows[0]["Price"].ToString()).ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
            function.SetReceiptPrinted(Choose.ReceiptsToPrint[0]);
        }
        private void PrintInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet invoiceData = function.GetInvoiceById(Choose.InvoicesToPrint[0]);
            DataSet dataSet = function.GetInvoicePrint(Choose.InvoicesToPrint[0]);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס'" },
                    { "UserName", "שם" },
                    { "ItemName", "תיאור" },
                    { "ColorName", "צבע" },
                    { "OrderAmount", "כמות" },
                    { "OrderPrice", "מחיר" },
                    { "OrderDate" , "ת. הזמנה" }
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה ולהתראות";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            //string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string extraLine;
            if (Boolean.Parse(invoiceData.Tables[0].Rows[0]["InvoicePrinted"].ToString()))
            {
                extraLine = "העתק";
            }
            else
            {
                extraLine = "מקור";
            }
            string name = invoiceData.Tables[0].Rows[0]["InvoiceName"].ToString();
            int index = name.IndexOf('ע');
            string line1 = name.Substring(0, index);
            string nameLine = name.Substring(index);
            string line2 = "תאריך הפקה: " + invoiceData.Tables[0].Rows[0]["InvoiceDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF nameLineSize = measureString(nameLine, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            SizeF extraLineSize = measureString(extraLine, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(nameLine, headlineFont, headingBrush, centerX - nameLineSize.Width / 2, topMargin);
            topMargin += (int)nameLineSize.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(extraLine, normalFont, brush, centerX - extraLineSize.Width / 2, topMargin);
            topMargin += (int)extraLineSize.Height + 5;
            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            decimal totalAmount = int.Parse(invoiceData.Tables[0].Rows[0]["InvoicePrice"].ToString());
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

            string totalText = "סך הכל לתשלום: " + totalAmount.ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
            function.SetInvoicePrinted(Choose.InvoicesToPrint[0]);
        }
        private void urgent_Click(object sender, EventArgs e)
        {

        }
        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            FinancePage f = new FinancePage(1);
            if(f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ChecksButton_Click(object sender, EventArgs e)
        {
            FinancePage f = new FinancePage(3);
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            FinancePage f = new FinancePage(2);
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OpenRegister_Click(object sender, EventArgs e)
        {
            if (function.isRegisterOpen())
            {
                MessageBox.Show("קופה נפתחה היום");
                Register register = function.GetTodayRegister();
                if(register == null)
                {
                    MessageBox.Show("בעיה");
                }
                else
                {
                    MessageBox.Show("פתיחה: " + register.Start + "\n" + "מזומן: " + register.Cash + "\n" + "ביט: " +
                    register.Bit + "\n" + "פייבוקס: " + register.Paybox + "\n" + "צ'קים: " + register.Checks + "\n" +
                    "כרטיס אשראי: " + register.Credit + "\n" + "אחר: " + register.Other + "\n" + "------------------- \n סך הכל: " + register.Sum()
                    , "תכולת קופה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                InputForm i = new InputForm("פתח קופה:", true);
                i.SetInputText(function.SuggestOpen().ToString());
                if(i.ShowDialog() == DialogResult.OK)
                {
                    function.OpenRegister(i.userInputInt);
                }
                else
                {
                    MessageBox.Show("פעולה נכשלה");
                }
            }
        }

        private void PrintReReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet dataSet = function.GetReReceiptById(Choose.ReceiptsToPrint[0]);
            string[] selectedColumns = { "Price", "TypeName" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "TypeName", "אופן הפקדה" },
                    { "Price", "סכום" },
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה ולהתראות";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            //string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string extraLine;
            if (Boolean.Parse(dataSet.Tables[0].Rows[0]["Printed"].ToString()))
            {
                extraLine = "העתק";
            }
            else
            {
                extraLine = "מקור";
            }
            string name = dataSet.Tables[0].Rows[0]["FullName"].ToString();
            int index = name.IndexOf('ע');
            string line1 = name.Substring(0, index);
            string nameLine = name.Substring(index);
            string line2 = "תאריך הפקה: " + dataSet.Tables[0].Rows[0]["FullDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF nameLineSize = measureString(nameLine, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            SizeF extraLineSize = measureString(extraLine, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(nameLine, headlineFont, headingBrush, centerX - nameLineSize.Width / 2, topMargin);
            topMargin += (int)nameLineSize.Height + 5; // Add some space between headline and normal text lines

            graphics.DrawString(extraLine, normalFont, brush, centerX - extraLineSize.Width / 2, topMargin);
            topMargin += (int)extraLineSize.Height + 5;

            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            string totalText = "סך הכל הוחזר ב" + dataSet.Tables[0].Rows[0]["TypeName"].ToString() + ": " + int.Parse(dataSet.Tables[0].Rows[0]["Price"].ToString()).ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
            function.SetReReceiptPrinted(Choose.ReceiptsToPrint[0]);
        }

        private void ReInvoicePrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataSet invoiceData = function.GetReInvoiceById(Choose.InvoicesToPrint[0]);
            DataSet dataSet = function.GetReInvoicePrint(Choose.InvoicesToPrint[0]);
            string[] selectedColumns = { "OrderPrice", "OrderAmount", "ItemName", "OrderId" };
            Dictionary<string, string> columnTitleMap = new Dictionary<string, string>
                {
                    { "OrderId", "מס'" },
                    { "UserName", "שם" },
                    { "ItemName", "תיאור" },
                    { "ColorName", "צבע" },
                    { "OrderAmount", "כמות" },
                    { "OrderPrice", "מחיר" },
                    { "OrderDate" , "ת. הזמנה" }
                    // Add more mappings as needed
                };
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Brush headingBrush = Brushes.DarkBlue;
            int topMargin = 20; // Set top margin to position at the top of the page

            string storeName = "Studio Lana";
            string address = "עין חנוך 15, גני תקווה";
            string phone = "טלפון: " + "054-5606832";
            string date = DateTime.Now.ToString("dd / MM / yyyy HH: mm");
            string thankYou = "!תודה רבה ולהתראות";

            // Calculate the width of the receipt content
            float totalWidth = graphics.VisibleClipBounds.Width;

            // Calculate the center of the drawing area
            int centerX = (int)(totalWidth / 2);

            SizeF measureString(string text, Font font) => graphics.MeasureString(text, font);

            SizeF storeNameSize = measureString(storeName, titleFont);
            SizeF addressSize = measureString(address, normalFont);
            SizeF phoneSize = measureString(phone, normalFont);
            SizeF dateSize = measureString(date, normalFont);
            SizeF thankYouSize = measureString(thankYou, normalFont);

            // Calculate the total height of the receipt content
            float totalHeight = storeNameSize.Height + addressSize.Height + phoneSize.Height +
                                dateSize.Height + // Space between sections
                                40 + // Increased space between store information and table headers
                                selectedColumns.Length * 30 + // Height of table headers
                                dataSet.Tables[0].Rows.Count * 25;

            topMargin = 20;

            graphics.DrawString(storeName, titleFont, headingBrush, centerX - storeNameSize.Width / 2, topMargin);
            topMargin += (int)storeNameSize.Height;
            graphics.DrawString(address, normalFont, brush, centerX - addressSize.Width / 2, topMargin);
            topMargin += (int)addressSize.Height;
            graphics.DrawString(phone, normalFont, brush, centerX - phoneSize.Width / 2, topMargin);
            topMargin += (int)phoneSize.Height;
            graphics.DrawString(date, normalFont, brush, centerX - dateSize.Width / 2, topMargin);
            topMargin += (int)dateSize.Height;
            // Define the text for the three lines
            //string line1 = "לכ': " + Choose.u.Fname + " " + Choose.u.LName;
            string extraLine;
            if (Boolean.Parse(invoiceData.Tables[0].Rows[0]["Printed"].ToString()))
            {
                extraLine = "העתק";
            }
            else
            {
                extraLine = "מקור";
            }
            string name = invoiceData.Tables[0].Rows[0]["FullName"].ToString();
            int index = name.IndexOf('ע');
            string line1 = name.Substring(0, index);
            string nameLine = name.Substring(index);
            string line2 = "תאריך הפקה: " + invoiceData.Tables[0].Rows[0]["FullDate"].ToString();
            Font headlineFont = new Font("Arial", 12, FontStyle.Bold);

            // Measure the sizes of these lines
            SizeF line1Size = measureString(line1, headlineFont);
            SizeF nameLineSize = measureString(nameLine, headlineFont);
            SizeF line2Size = measureString(line2, normalFont);
            SizeF extraLineSize = measureString(extraLine, normalFont);
            topMargin += 10; // Add space before the table segment

            // Draw headline style line
            graphics.DrawString(line1, headlineFont, headingBrush, centerX - line1Size.Width / 2, topMargin);
            topMargin += (int)line1Size.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(nameLine, headlineFont, headingBrush, centerX - nameLineSize.Width / 2, topMargin);
            topMargin += (int)nameLineSize.Height + 5; // Add some space between headline and normal text lines
            graphics.DrawString(extraLine, normalFont, brush, centerX - extraLineSize.Width / 2, topMargin);
            topMargin += (int)extraLineSize.Height + 5;
            // Draw normal style lines
            graphics.DrawString(line2, normalFont, brush, centerX - line2Size.Width / 2, topMargin);
            topMargin += (int)line2Size.Height + 10;

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
            decimal totalAmount = int.Parse(invoiceData.Tables[0].Rows[0]["Price"].ToString());
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

            string totalText = "סך הכל לתשלום: " + totalAmount.ToString("C");
            SizeF totalSize = graphics.MeasureString(totalText, tableFont);
            graphics.DrawString(totalText, tableFont, Brushes.Black, centerX - totalSize.Width / 2, topMargin);
            topMargin += 40;
            DrawAdditionalMessages(graphics, normalFont, centerX, ref topMargin);
            // The existing thank you message
            graphics.DrawString(thankYou, normalFont, brush, centerX - thankYouSize.Width / 2, topMargin);
            function.SetReInvoicePrinted(Choose.InvoicesToPrint[0]);
        }
    }   
}
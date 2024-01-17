using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class NewItems : Form
    {
        FunctionService function = new FunctionService();
        private object previousValue;
        public DataTable table = new DataTable();
        public NewItems()
        {
            InitializeComponent();
        }
        private void NewC_Click(object sender, EventArgs e)
        {
            ItemsList il = new ItemsList();
            table.Rows.Add();
            NewItemGrid.DataSource = table;
            if(NewItemGrid.Rows.Count != 0)
            {
                NewItemGrid.CurrentCell = NewItemGrid.Rows[NewItemGrid.Rows.Count - 1].Cells[0]; 
            } 
            
            NewItemGrid.CurrentRow.Cells[0].Value = NewItemGrid.Rows.Count;
            NewItemGrid.DataSource = table;
            int nRowIndex = NewItemGrid.Rows.Count - 1;
            NewItemGrid.CurrentCell = NewItemGrid.Rows[nRowIndex].Cells[0];
            if(il.ShowDialog() == DialogResult.OK)
            {
                InsertItem(Choose.item);
            }
            else
            {
                NewItemGrid.Rows.RemoveAt(NewItemGrid.Rows.Count - 1);
            }
        }
        private void NewItems_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            CenterAll();
            UpdateTotal();
            if(Choose.u.Discount > 0 & Choose.u.Discount <= 100)
            {
                DiscountTextBox.Texts = Choose.u.Discount.ToString();
            }
        }
        private void CenterAll()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            
        }
        private void NewItemGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 & e.RowIndex >= 0)
            {
                ItemsList il = new ItemsList();
                if (il.ShowDialog() == DialogResult.OK)
                {
                    InsertItem(Choose.item);
                }
            }
            if (e.ColumnIndex == 3  & e.RowIndex >= 0)
            {
                ColorList cl = new ColorList();
                if(cl.ShowDialog() == DialogResult.OK)
                {
                    DataSet ds = function.GetColorById(Choose.color);
                    ColorType c = new ColorType(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString());
                    NewItemGrid.CurrentRow.Cells[3].Value = c.Cname.ToString();
                }
            }
            if (e.ColumnIndex == 2 & e.RowIndex >= 0)
            {
                
                NewItemGrid.CurrentCell = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                NewItemGrid.BeginEdit(true);
                //SetAmount sa = new SetAmount();
                //if (sa.ShowDialog() == DialogResult.OK)
                //{
                //    NewItemGrid.CurrentRow.Cells[2].Value = Choose.amount;
                //    if (NewItemGrid.CurrentRow.Cells[5].Value != null)
                //    {
                        
                //        if (NewItemGrid.CurrentRow.Cells[5].Value.ToString().Contains("("))
                //        {
                //            if (DisBox.Text != "0 %")
                //            {
                //                // int price = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                //                int id = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                //                DataSet ds = GetItemById(id);
                //                Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
                //                double discount = Convert.ToDouble(Choose.discount);
                //                discount = discount / 100;
                //                int price = i.Price;
                //                double sale = price * discount;
                //                double newprice = price - sale;
                //                NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", Math.Ceiling(newprice) * Choose.amount) + " (" + price * Choose.amount + ")";
                //                UpdateTotal();
                //            }
                //        }
                //        else
                //        {
                //            // double x = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                //            int id = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                //            DataSet ds = GetItemById(id);
                //            Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
                //            NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", i.Price * Choose.amount);
                //            UpdateTotal();
                //        }
                //    }
                //}
            }
            if (e.ColumnIndex == 4 & e.RowIndex >= 0)
            {
                NewItemGrid.CurrentCell = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                NewItemGrid.BeginEdit(true);
            }
            if (e.ColumnIndex == 5 & e.RowIndex >= 0)
            {
                //SetPrice sp = new SetPrice();

                //if (NewItemGrid.CurrentRow.Cells["Price"].Value != null)
                //{
                //    if (NewItemGrid.CurrentRow.Cells["Price"].Value.ToString().Contains("("))
                //    {
                //        sp.newPrice(int.Parse(NewItemGrid.CurrentRow.Cells["Price"].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", "")));
                //    }
                //    else
                //    {
                //        sp.newPrice(int.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", "")));
                //    }
                //}
                //if (sp.ShowDialog() == DialogResult.OK)
                //{
                //    NewItemGrid.CurrentRow.Cells["Price"].Value = String.Format("₪ {0:n}", Choose.price);
                //    UpdateTotal();
                //}
                NewItemGrid.CurrentCell = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                NewItemGrid.BeginEdit(true);
            }
            if (e.ColumnIndex == 6 & e.RowIndex >= 0)
            {
                NewItemGrid.CurrentCell = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                NewItemGrid.BeginEdit(true);
            }
            if (e.ColumnIndex == 7 & e.RowIndex >= 0)
            {
                NewItemGrid.Rows.RemoveAt(e.RowIndex);
                updateN();
                UpdateTotal();
            }
        }
        private void CalculatePrice()
        {

            if (NewItemGrid.CurrentRow.Cells["Price"].Value != null)
            {
                if (NewItemGrid.CurrentRow.Cells["Price"].Value.ToString().Contains("("))
                {
                    if (DisBox.Text != "")
                    {
                        // int price = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                        int itemId = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                        DataSet ds = function.GetItemPriceById(itemId);
                        double discount = Convert.ToDouble(Choose.discount);
                        discount = discount / 100;
                        int price = int.Parse(ds.Tables["Items"].Rows[0]["ItemPrice"].ToString());
                        double sale = price * discount;
                        double newprice = price - sale;
                        NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", Math.Ceiling(newprice) * Choose.amount) + " (" + price * Choose.amount + ")";
                        UpdateTotal();
                    }
                }
                else
                {
                    // double x = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                    int itemId = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                    DataSet ds = function.GetItemPriceById(itemId);
                    NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", int.Parse(ds.Tables["Items"].Rows[0]["ItemPrice"].ToString()) * Choose.amount);
                    UpdateTotal();
                }
            }
        }
        private void InsertItem(int item)
        {
            DataSet ds = function.GetItemById(item);
            Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
            NewItemGrid.CurrentRow.Cells[1].Value = i.Name + " [" + i.Id.ToString() + "]";
            NewItemGrid.CurrentRow.Cells[6].Value = i.Length.ToString() + FindDay(i.Length);
            NewItemGrid.CurrentRow.Cells[2].Value = "1";
            
            if(DisBox.Text == "")
            {
                NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", i.Price);
            }
            else
            {   
                NewItemGrid.CurrentRow.Cells[5].Value = DiscountOne(int.Parse(DisBox.Text.Replace("% ", "")), i.Price);
            }
            UpdateTotal();
        }
        private void updateN()
        {
            for(int i = 0; i < NewItemGrid.Rows.Count; i++)
            {
                NewItemGrid.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void DeleteC_Click(object sender, EventArgs e)
        {
            if(NewItemGrid.Rows.Count > 0)
            {
                NewItemGrid.Rows.RemoveAt(NewItemGrid.CurrentCell.RowIndex);
                updateN();
                UpdateTotal();
            }
        }
        public string FindDay(int x) // x is how many days it takes for the work
        {
            DateTime today = DateTime.Today;
            int day = (int)today.DayOfWeek;
            int f = day + x; // f is the day the work supposed to be finished (without saturday)
            if (f > 6)
            {
                f = f - 6;
            }
            if (f == 6)
            {
                return " - יום ראשון";
            }
            else
            {
                
                if(f == 0)
                {
                    return " - יום ראשון";
                }
                if (f == 1)
                {
                    return " - יום שני";
                }
                if (f == 2)
                {
                    return " - יום שלישי";
                }
                if (f == 3)
                {
                    return " - יום רביעי";
                }
                if (f == 4)
                {
                    return " - יום חמישי";
                }
                if (f == 5)
                {
                    return " - יום שישי";
                }
                return "";
            }
        }
        public void UpdateTotal()
        {
            int total = 0;
            if (NewItemGrid.Rows.Count != 0)
            {
                for(int i = 0; i < NewItemGrid.Rows.Count; i++)
                {
                    if (NewItemGrid.Rows[i].Cells["Price"].Value != null)
                    {
                        int check = NewItemGrid.Rows[i].Cells["Price"].Value.ToString().IndexOf(" (");
                        if(check < 0 )
                        {
                            total += int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                        }
                        else
                        {
                            total += int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Remove(check).Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                        }
                    }  
                }
                Total.Text = String.Format("₪ {0:n}", total);
            }
            else if (NewItemGrid.Rows.Count == 0)
            {
                Total.Text = String.Format("₪ {0:n}", 0);
            }
        }
        private void Color1_Click(object sender, EventArgs e)
        {
            if (NewItemGrid.Rows.Count > 0)
            {
                Ncolor(20);
            }
        }
        private void Color2_Click(object sender, EventArgs e)
        {
            Ncolor(15);
        }
        private void Color3_Click(object sender, EventArgs e)
        {
            Ncolor(13);
        }
        private void Color4_Click(object sender, EventArgs e)
        {
            Ncolor(4);
        }
        private void Color5_Click(object sender, EventArgs e)
        {
            Ncolor(6);
        }
        private void Color6_Click(object sender, EventArgs e)
        {
            Ncolor(9);
        }
        private void Color7_Click(object sender, EventArgs e)
        {
            Ncolor(10);
        }
        private void Color8_Click(object sender, EventArgs e)
        {
            Ncolor(18);
        }
        private void Color9_Click(object sender, EventArgs e)
        {
            Ncolor(7);
        }
        private void Color10_Click(object sender, EventArgs e)
        {
            if(NewItemGrid.Rows.Count > 0)
            {
                ColorList cl = new ColorList();
                if (cl.ShowDialog() == DialogResult.OK)
                {
                    DataSet ds = function.GetColorById(Choose.color);
                    ColorType c = new ColorType(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString());
                    NewItemGrid.CurrentRow.Cells[3].Value = c.Cname.ToString();
                }
            }
        }
        public void Ncolor(int id)
        {
            if(NewItemGrid.Rows.Count > 0)
            {
                DataSet ds = function.GetColorById(id);
                ColorType c = new ColorType(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString());
                NewItemGrid.CurrentRow.Cells[3].Value = c.Cname.ToString();
               
            }
            this.ActiveControl = null;
        }
        public void Nitem(int x)// New item from the buttons
        {
            table.Rows.Add();
            NewItemGrid.DataSource = table;
            if (NewItemGrid.Rows.Count != 0)
            {
                NewItemGrid.CurrentCell = NewItemGrid.Rows[NewItemGrid.Rows.Count - 1].Cells[0];
            }
            NewItemGrid.CurrentRow.Cells[0].Value = NewItemGrid.Rows.Count;
            NewItemGrid.DataSource = table;
            int nRowIndex = NewItemGrid.Rows.Count - 1;
            NewItemGrid.CurrentCell = NewItemGrid.Rows[nRowIndex].Cells[0];
            InsertItem(x);
            UpdateTotal();
            this.ActiveControl = null;
        }
        private void Item1_Click(object sender, EventArgs e)
        {
           
            Nitem(4);
        }
        private void Item2_Click(object sender, EventArgs e)
        {
            Nitem(5);

        }
        private void Item3_Click(object sender, EventArgs e)
        {
            Nitem(6);
        }
        private void Item4_Click(object sender, EventArgs e)
        {
            Nitem(7);
        }
        private void Item5_Click(object sender, EventArgs e)
        {
            Nitem(8);
        }
        private void Item6_Click(object sender, EventArgs e)
        {
            Nitem(9);
        }
        private void Item7_Click(object sender, EventArgs e)
        {
            Nitem(10);
        }
        private void Item8_Click(object sender, EventArgs e)
        {
            Nitem(11);
        }
        private void Item9_Click(object sender, EventArgs e)
        {
            Nitem(12);
        }
        private void Item10_Click(object sender, EventArgs e)
        {
            Nitem(13);
        }
        public bool Check()
        {
            for (int i = 0; i < NewItemGrid.Rows.Count; i++)
            {
                // if (string.IsNullOrWhiteSpace(NewItemGrid.Rows[i].Cells[1].Value.ToString()))
                if(NewItemGrid.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("שורה מספר " + (i+1) + " ריקה!");
                    return false;
                }
            }
            return true;
        }
        public void Discount(int x)
        {
            if(NewItemGrid.Rows.Count != 0)
            {
                double discount = Convert.ToDouble(x);
                discount = discount / 100;
                for (int i = 0; i < NewItemGrid.Rows.Count; i++)
                {
                     if (NewItemGrid.Rows[i].Cells[5].Value != null)
                     {
                        if (NewItemGrid.Rows[i].Cells[5].Value.ToString().Contains("("))
                        {
                            double price = Double.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Substring(NewItemGrid.Rows[i].Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                            double sale = price * discount;
                            double newprice = price - sale;
                            NewItemGrid.Rows[i].Cells[5].Value = String.Format("₪ {0:n}", Math.Ceiling(newprice)) + " (" + price + ")";
                        }
                        else
                        {
                            double price = Double.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                            double sale = price * discount;
                            double newprice = price - sale;
                            NewItemGrid.Rows[i].Cells[5].Value = String.Format("₪ {0:n}", Math.Ceiling(newprice)) + " (" + price + ")";
                        }
                     }
                }
                UpdateTotal();
            }
        }
        public string DiscountOne(int x, double price)
        {
            double discount = Convert.ToDouble(x);
            discount = discount / 100;
            double sale = price * discount;            
            double newprice = price - sale;
            return String.Format("₪ {0:n}", Math.Ceiling(newprice)) + " (" + price + ")";
        }
        private void Exp_Click(object sender, EventArgs e)
        {
            string price = NewItemGrid.CurrentRow.Cells["Price"].Value.ToString();
            int currentPrice = 0;
            if (price.Contains("("))
            {
                currentPrice = int.Parse(price.Substring(price.IndexOf('(') + 1).Replace(")", ""));
            }
            else if (price.Contains(","))
            {
                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
            }
            else
            {
                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", ""));
            }
            NewItemGrid.CurrentRow.Cells[5].Value = DiscountOne(-50, currentPrice);
            UpdateTotal();
        }
        public void UpdateColor()
        {
            for(int i = 0; i < NewItemGrid.Rows.Count; i++)
            {
                if (NewItemGrid.Rows[i].Cells[3].Value== null)
                {
                    NewItemGrid.Rows[i].Cells[3].Value = "אין צורך";
                }
            }
        }
        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            int owed = Choose.u.Debt;
            int newDebt = Choose.u.Debt;
            int total = 0;
            int paid = 0;
            bool isPaid = false;
            int invoiceId = 1;
            if (Check())
            {
                List<Order> orders = new List<Order>();
                UpdateColor();
                DateTime today = DateTime.Today;
                for (int i = 0; i < NewItemGrid.Rows.Count; i++)
                {
                    int id = int.Parse(NewItemGrid.Rows[i].Cells[1].Value.ToString().Substring(NewItemGrid.Rows[i].Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                    int amount = int.Parse(NewItemGrid.Rows[i].Cells[2].Value.ToString());
                    int color = int.Parse(function.GetColorByName(NewItemGrid.Rows[i].Cells[3].Value.ToString()).Tables[0].Rows[0][0].ToString());
                    int price = 0;
                    if (NewItemGrid.Rows[i].Cells[5].Value.ToString().Contains("("))
                    {
                        price = int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Remove(NewItemGrid.Rows[i].Cells[5].Value.ToString().IndexOf(" (")).Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                    }
                    else
                    {
                        price = int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                    }
                    int work = int.Parse(NewItemGrid.Rows[i].Cells[6].Value.ToString().Remove(NewItemGrid.Rows[i].Cells[6].Value.ToString().IndexOf("-")));
                    int day = (int)today.DayOfWeek;
                    int final = day + work;
                    if (final > 6)
                        final = final - 5;
                    DateTime finish = today.AddDays(final);
                    //finish = today.AddDays(work);
                    if(owed < 0)
                    {
                        if(Math.Abs(owed) >= price && price > 0)
                        {
                            owed += price;
                            isPaid = true;
                            paid = price;
                            invoiceId = function.HighestInvoice() + 1;
                            createInvoice(price, invoiceId);
                            Choose.InvoicesToPrint.Add(invoiceId);
                        }
                        else if(Math.Abs(owed) < price)
                        {
                            paid = Math.Abs(owed);
                            owed = 0;
                        }
                    }
                    Order newOrder = new Order(Choose.u.Id, id, color, DateTime.Now, amount, price, "ללא", "בטיפול", finish, paid, isPaid, invoiceId, 1);
                    orders.Add(newOrder);
                    total += price;
                    isPaid = false;
                    paid = 0;
                    invoiceId = 1;
                }
                newDebt = newDebt + total;
                Choose.u.Debt = newDebt;
                function.SetDebt(Choose.id, newDebt);
                function.NewOrder(orders);
                Thread.Sleep(100);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private void createInvoice(int price, int id)
        {
            Invoice invoice = new Invoice(Choose.id, "חשבונית מס מספר " + id + " עבור " + Choose.u.Fname + " " + Choose.u.LName , price);
            function.NewInvoice(invoice);
        }
        private void Exp2_Click(object sender, EventArgs e)
        {
            NewItemGrid.CurrentRow.Cells[6].Value = "0" + FindDay(0) + " (אקספרס)";
            string price = NewItemGrid.CurrentRow.Cells["Price"].Value.ToString();
            int currentPrice = 0;
            if (price.Contains("("))
            {
                currentPrice = int.Parse(price.Substring(price.IndexOf('(') + 1).Replace(")", ""));
            }
            else if (price.Contains(","))
            {
                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
            }
            else
            {
                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", ""));
            }
            NewItemGrid.CurrentRow.Cells[5].Value = DiscountOne(-100, currentPrice);
            UpdateTotal();
        }
        private void UpdatePrice(int newPrice, DataGridViewCellEventArgs e)
        {
            NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = String.Format("₪ {0:n}", newPrice);
            UpdateTotal();
        }
        private void NewItemGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell cell = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int num;
                    if (!int.TryParse(e.FormattedValue.ToString(), out num))
                    {
                        NewItemGrid.CancelEdit();
                        cell.Value = previousValue;
                        MessageBox.Show("אנא רשום מספר בכמות");
                    }
                    else
                    {
                        Choose.amount = num;
                        CalculatePrice();
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    string price = e.FormattedValue.ToString();
                    
                    int num;
                    if (price.Contains("("))
                    {
                        if (!int.TryParse(price.Remove(price.IndexOf(" (")).Replace("₪ ", "").Replace(".00", "").Replace(",", ""), out num))
                        {
                            NewItemGrid.CancelEdit();
                            cell.Value = previousValue;
                            MessageBox.Show("אנא רשום מספר במחיר");
                        }
                    }
                    else if(price.Contains(","))
                    {
                        if (!int.TryParse(price.Replace("₪ ", "").Replace(".00", "").Replace(",", ""), out num))
                        {

                            NewItemGrid.CancelEdit();
                            cell.Value = previousValue;
                            MessageBox.Show("אנא רשום מספר במחיר");
                        }
                    }
                    else
                    {
                        if(!int.TryParse(price.Replace("₪ ", "").Replace(".00", "") , out num))
                        {
                            NewItemGrid.CancelEdit();
                            cell.Value = previousValue;
                            MessageBox.Show("אנא רשום מספר במחיר");
                        }
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    int num;
                    string test = e.FormattedValue.ToString();
                    if (test.Contains(("-")))
                    {
                        string result = Regex.Replace(test, @"[^\d]", "");
                        if(!int.TryParse(result, out num))
                        {
                            NewItemGrid.CancelEdit();
                            cell.Value = previousValue;
                            MessageBox.Show("אנא רשום מספר בימי עבודה");
                        }
                    }
                    else if (!int.TryParse(test, out num))
                    {
                        NewItemGrid.CancelEdit();
                        cell.Value = previousValue;
                        MessageBox.Show("אנא רשום מספר בימי עבודה");
                    }
                    
                }
            }
        }
        private void NewItemGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                previousValue = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }
        private void NewItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 & e.RowIndex >= 0)
            {
                NewItemGrid.Rows.RemoveAt(e.RowIndex);
                updateN();
                UpdateTotal();
            }
                
        }
        private void NewItemGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string price = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int newPrice = 0;
                if (price.Contains("("))
                {
                    newPrice = int.Parse(price.Remove(price.IndexOf(" (")).Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                }
                else if (price.Contains(","))
                {
                    newPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                }
                else
                {
                    newPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", ""));
                }
                UpdatePrice(newPrice, e);
            }
            
            if (e.ColumnIndex == 6)
            {
                NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + FindDay(int.Parse(NewItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
        }
        private void DiscountButton_Click(object sender, EventArgs e)
        {
            discountInShekel();
        }
        private void discountInShekel()
        {
            int discount = 0;
            int currentPrice = 0;
            int after = 0;
            string price;
            if (!int.TryParse(DiscountBox.Texts, out discount))
            {
                MessageBox.Show("אנא רשום מספרים בהנחה");
            }
            else if (discount < 0)
            {
                MessageBox.Show("הנחה קטנה מאפס");
            }
            else
            {
                Choose.discount2 = discount;
                if (NewItemGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in NewItemGrid.Rows)
                    {
                        if (discount >= 0)
                        {
                            price = row.Cells["Price"].Value.ToString();
                            if (price.Contains("("))
                            {
                                currentPrice = int.Parse(price.Substring(price.IndexOf('(') + 1).Replace(")", ""));
                            }
                            else if (discount == 0)
                                continue;
                            else if (price.Contains(","))
                            {
                                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                            }
                            else
                            {
                                currentPrice = int.Parse(price.Replace("₪ ", "").Replace(".00", ""));
                            }
                            if (currentPrice >= discount)
                            {
                                after = currentPrice - discount;
                                row.Cells["Price"].Value = String.Format("₪ {0:n}", after + " (" + currentPrice + ")");
                                discount = 0;
                                UpdateTotal();
                                continue;
                            }
                            else if (currentPrice < discount)
                            {
                                row.Cells["Price"].Value = String.Format("₪ {0:n}", 0 + " (" + currentPrice + ")");
                                discount = discount - currentPrice;
                                UpdateTotal();
                            }
                        }
                    }
                    if (discount > 0)
                    {
                        int used = Choose.discount2 - discount;
                        DiscountBox.Texts = "0";
                        MessageBox.Show("הנחה רק של " + used);
                        Choose.discount2 = used;
                    }
                }
            }
        }
        private void SetDiscount_Click(object sender, EventArgs e)
        {
            getDiscountProccents();
        }
        private void getDiscountProccents()
        {
            string text = DiscountTextBox.Texts.ToString();
            if (!int.TryParse(text, out int discount))
            {
                MessageBox.Show("אנא רשום מספר בהנחה");
            }
            else if (discount > 100)
            {
                MessageBox.Show("ההנחה גדולה מ100");
            }
            else
            {
                Discount(discount);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class NewItems : Form
    {
        public int userId;
        public int discount1;
        public DataTable table = new DataTable();
        public NewItems()
        {
            InitializeComponent();
        }
        private DataSet GetItemById(int x)
        {
            ItemService us = new ItemService();
            return us.GetItemById(x);
        }
        private DataSet GetColorById(int x)
        {
            ColorService us = new ColorService();
            return us.GetColorById(x);
        }
        private DataSet GetColorByName(string name)
        {
            ColorService us = new ColorService();
            return us.GetColorByName(name);
        }
        public void getId(int id)
        {
            userId = id;
        }
        public void getDis(int dis)
        {
            if(dis == 0)
            {
                discount1 = -500;
            }
            else
            {
                discount1 = dis;
            }
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
        }

        private void NewItems_Load(object sender, EventArgs e)
        {
            UpdateTotal();
            if(discount1 > 0 & discount1 <= 100)
            {
                DisBox.Text = string.Format("% {0}", discount1);
            }
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
                    DataSet ds = GetColorById(Choose.color);
                    Color c = new Color(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString());
                    NewItemGrid.CurrentRow.Cells[3].Value = c.Cname.ToString();
                }
            }
            if (e.ColumnIndex == 2 & e.RowIndex >= 0)
            {
                SetAmount sa = new SetAmount();
                if (sa.ShowDialog() == DialogResult.OK)
                {
                    NewItemGrid.CurrentRow.Cells[2].Value = Choose.amount;
                    if (NewItemGrid.CurrentRow.Cells[5].Value != null)
                    {
                        
                        if (NewItemGrid.CurrentRow.Cells[5].Value.ToString().Contains("("))
                        {
                            if (DisBox.Text != "0 %")
                            {
                                // int price = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                                int id = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                                DataSet ds = GetItemById(id);
                                Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
                                double discount = Convert.ToDouble(Choose.discount);
                                discount = discount / 100;
                                int price = i.Price;
                                double sale = price * discount;
                                double newprice = price - sale;
                                NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", Math.Ceiling(newprice) * Choose.amount) + " (" + price * Choose.amount + ")";
                                UpdateTotal();
                            }
                        }
                        else
                        {
                            // double x = double.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", ""));
                            int id = int.Parse(NewItemGrid.CurrentRow.Cells[1].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                            DataSet ds = GetItemById(id);
                            Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
                            NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", i.Price * Choose.amount);
                            UpdateTotal();
                        }
                    }
                }
            }
            if (e.ColumnIndex == 4 & e.RowIndex >= 0)
            {
                SetNote sn = new SetNote();
                if(sn.ShowDialog() == DialogResult.OK)
                {
                    NewItemGrid.CurrentRow.Cells[4].Value = Choose.note;
                }
            }
            if (e.ColumnIndex == 5 & e.RowIndex >= 0)
            {
                SetPrice sp = new SetPrice();
                
                if (NewItemGrid.CurrentRow.Cells[5].Value != null)
                {
                    if (NewItemGrid.CurrentRow.Cells[5].Value.ToString().Contains("("))
                    {
                        sp.l(int.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Substring(NewItemGrid.CurrentRow.Cells[5].Value.ToString().IndexOf('(') + 1).Replace(")", "")));
                    }
                    else
                    {
                        sp.l(int.Parse(NewItemGrid.CurrentRow.Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", "")));
                    }
                }
                if (sp.ShowDialog() == DialogResult.OK)
                {
                    NewItemGrid.CurrentRow.Cells[5].Value = String.Format("₪ {0:n}", Choose.price);
                    UpdateTotal();
                }
            }
        }
        private void InsertItem(int item)
        {
            DataSet ds = GetItemById(item);
            Item i = new Item(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), int.Parse(ds.Tables[0].Rows[0][2].ToString()), int.Parse(ds.Tables[0].Rows[0][3].ToString()));
            NewItemGrid.CurrentRow.Cells[1].Value = i.Name + " [" + i.Id.ToString() + "]";
            NewItemGrid.CurrentRow.Cells[6].Value = i.Length.ToString() + FindDay(i.Length);
            NewItemGrid.CurrentRow.Cells[2].Value = "1";
            
            if(DisBox.Text == "0 %")
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
        public string FindDay(int x)
        {
            DateTime today = DateTime.Today;
            int day = (int)today.DayOfWeek;
            int f = day + x;
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
            int x = 0;
            if (NewItemGrid.Rows.Count != 0)
            {
                for(int i = 0; i < NewItemGrid.Rows.Count; i++)
                {
                    if (NewItemGrid.Rows[i].Cells[5].Value != null)
                    {
                        int p = NewItemGrid.Rows[i].Cells[5].Value.ToString().IndexOf(" (");
                        if(p < 0 )
                        {
                            x += int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                        }
                        else
                        {
                            x += int.Parse(NewItemGrid.Rows[i].Cells[5].Value.ToString().Remove(p).Replace("₪ ", "").Replace(".00", "").Replace(",", ""));
                        }
                       
                    }
                        
                }
            }
            Total.Text = String.Format("₪ {0:n}", x);
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
            Ncolor(5);
        }
        private void Color9_Click(object sender, EventArgs e)
        {
            Ncolor(7);
        }
        private void Color10_Click(object sender, EventArgs e)
        {
            Ncolor(8);
        }
        public void Ncolor(int id)
        {
            if(NewItemGrid.Rows.Count > 0)
            {
                DataSet ds = GetColorById(id);
                Color c = new Color(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString());
                NewItemGrid.CurrentRow.Cells[3].Value = c.Cname.ToString();
            }

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
        private void SetDis_Click(object sender, EventArgs e)
        {
            SetDiscount sd = new SetDiscount();
            if(sd.ShowDialog() == DialogResult.OK)
            {
                DisBox.Text = String.Format("% {0}", Choose.discount);
                Discount(Choose.discount);
            }

        }

        private void Exp_Click(object sender, EventArgs e)
        {
            //int p = NewItemGrid.CurrentRow.Cells[6].Value.ToString().IndexOf("-");
            //int day = int.Parse(NewItemGrid.CurrentRow.Cells[6].Value.ToString().Remove(p));
            if(NewItemGrid.Rows.Count != 0)
            {
                NewItemGrid.CurrentRow.Cells[6].Value = "1" + FindDay(1) + " (אקספרס)";

            }           
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
            if (Check())
            {

                UpdateColor();
                DateTime today = DateTime.Today;
                for (int i = 0; i < NewItemGrid.Rows.Count; i++)
                {
                    int id = int.Parse(NewItemGrid.Rows[i].Cells[1].Value.ToString().Substring(NewItemGrid.Rows[i].Cells[1].Value.ToString().IndexOf('[') + 1).Replace("]", ""));
                    int amount = int.Parse(NewItemGrid.Rows[i].Cells[2].Value.ToString());
                    int color = int.Parse(GetColorByName(NewItemGrid.Rows[i].Cells[3].Value.ToString()).Tables[0].Rows[0][0].ToString());
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
                    Order newOrder = new Order(userId, id, color, DateTime.Now, amount, price, 5, "בטיפול", finish);
                    OrderService os = new OrderService();
                    os.NewOrder(newOrder);
                    UserService us = new UserService();
                    us.SetDebt(userId, price);
                    double price2 = price;
                    Choose.u.Debt += price2;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

    }
}

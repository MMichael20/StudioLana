using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AllOrders : Form
    {
        FunctionService function = new FunctionService();
        
        public AllOrders()
        {
            InitializeComponent();
            Populate();
        }
        public AllOrders(int id)
        {
            InitializeComponent();
            PopulateAll(id);
        }
        private void Populate()
        {
            if (Choose.u == null)
            {
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = function.GetAllSent();
                OrderGrid.DataMember = "Orders";
            }
            else
            {
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = function.GetAllSentById(Choose.id);
                OrderGrid.DataMember = "Orders";
            }
        }
        private void PopulateAll(int id)
        {
            OrderGrid.AutoGenerateColumns = false;
            OrderGrid.DataSource = function.GetAllUnfinshedOrdersById(id);
            OrderGrid.DataMember = "Orders";
            CreateInvoice.Visible = true;
        }


        private void AllOrders_Load(object sender, EventArgs e)
        {
            
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = function.GetAllOrdersById(Choose.id).Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("orderstatus like '%{0}%' or Convert([orderstatus] , System.String) like '{0}' ", SearchText.Text);
            OrderGrid.DataSource = dv.ToTable();

            // or like '%{7}%' or like or like '%{1}%'
        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void OrderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (this.OrderGrid.CurrentRow.Cells["FullName"].Value.ToString());

            int start = name.IndexOf('(') + 1;
            int end = name.IndexOf(')') - start;
            int id = int.Parse(name.Substring(start, end));
            
            Program.play.SignIn(id);
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(OrderGrid, 0, 1);
            if(ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט");
            }
            else
            {
                DialogResult result = MessageBox.Show("האם בטוח להוריד ממסירה?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    function.UpdateStatus(ids, "מוכן");
                    Populate();
                }
            }
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
        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            List<int> ids = IdSelected(OrderGrid, 0, 1);
            if(ids.Count == 0)
            {
                MessageBox.Show("אנא בחר פריט");
            }
            else
            {
                DialogResult result = MessageBox.Show("אתה רציני רוצה לפתוח חשבונית מס להזמנות אלו", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    List<int> idsWithInvoices = function.ListOfInvoices(ids);
                    if(idsWithInvoices.Count > 0)
                    {
                        MessageBox.Show("להזמנות: " + string.Join(",", idsWithInvoices) + " יש חשבונית מס");
                    }
                    else
                    {
                        int highestInvoice = function.HighestInvoice() + 1;
                        Invoice invoice = new Invoice(Choose.id, "חשבונית מס מספר " + highestInvoice + " עבור " + Choose.u.Fname + " " + Choose.u.LName, function.OrdersPriceSum(ids));
                        function.NewInvoice(invoice);
                        function.UpdateOrdersInvoice(ids, highestInvoice);
                        Choose.InvoicesToPrint.Add(highestInvoice);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AllOrders : Form
    {
        private DataSet GetOrdersById(int i )
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllOrdersById(i);
        }
        private DataSet GetAllSent()
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllSent();
        }
        private DataSet GetAllSentById(int id)
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllSentById(id);
        }
        public AllOrders()
        {
            InitializeComponent();
        }



        private void AllOrders_Load(object sender, EventArgs e)
        {
            if(Choose.u == null)
            {
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetAllSent();
                OrderGrid.DataMember = "Orders";
            }
            else
            {
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetAllSentById(Choose.id);
                OrderGrid.DataMember = "Orders";
            }
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GetOrdersById(Choose.id).Tables[0];
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
            string name = (this.OrderGrid.CurrentRow.Cells[1].Value.ToString());

            int start = name.IndexOf('(') + 1;
            int end = name.IndexOf(')') - start;
            int id = int.Parse(name.Substring(start, end));
            
            Program.play.SignIn(id);
        }
    }
}

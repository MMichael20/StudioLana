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
        private DataSet GetAllOrders()
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllOrders();
        }
        private DataSet GetUserById(int id)
        {
            UserService us = new UserService();
            return us.GetUserById(id);
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
                OrderGrid.DataSource = GetAllOrders();
                OrderGrid.DataMember = "Orders";
            }
            else
            {
                OrderGrid.AutoGenerateColumns = false;
                OrderGrid.DataSource = GetOrdersById(Choose.id);
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
    }
}

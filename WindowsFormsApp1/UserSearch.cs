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
    public partial class UserSearch : Form
    {
        private DataSet GetUsers()
        {
            UserService us = new UserService();
            return us.GetUsers();
        }
        private DataSet GetUserById(int id)
        {
            UserService us = new UserService();
            return us.GetUserById(id);
        }
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            UserGrid.AutoGenerateColumns = false;
            UserGrid.DataSource = GetUsers();
            UserGrid.DataMember = "Users";

        }

        private void UserGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int x = int.Parse(this.UserGrid.CurrentRow.Cells[0].Value.ToString());
                DataSet ds = GetUserById(x);
                User u = new User(int.Parse(ds.Tables[0].Rows[0][0].ToString()), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(),
                  int.Parse(ds.Tables[0].Rows[0][4].ToString()), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), int.Parse(ds.Tables[0].Rows[0][7].ToString()), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), int.Parse(ds.Tables[0].Rows[0][10].ToString()));
                Choose.u = u;
                Choose.id = x;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
        }

        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GetUsers().Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("username like '%{0}%' or Convert([userid] , System.String) like '{0}'", SearchText.Text);
            UserGrid.DataSource = dv.ToTable();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}

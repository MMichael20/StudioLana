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
    public partial class CityForm : Form
    {
        private DataSet GetCities()
        {
            CityService us = new CityService();
            return us.GetCities();
        }
        public CityForm()
        {
            InitializeComponent();
        }


        private void CityForm_Load(object sender, EventArgs e)
        {
            CityGrid.AutoGenerateColumns = false;
            CityGrid.DataSource = GetCities();
            CityGrid.DataMember = "Cities";
        }

        private void CityGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int x = int.Parse(this.CityGrid.CurrentRow.Cells[0].Value.ToString());
                Choose.city = x;
                Program.play.UpdateCity(x);
                this.Hide();

            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GetCities().Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("cityname like '%{0}%' or Convert([cityid] , System.String) like '{0}'", SearchText.Text);
            CityGrid.DataSource = dv.ToTable();
        }

        private void CityGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

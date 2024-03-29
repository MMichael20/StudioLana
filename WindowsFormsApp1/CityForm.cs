﻿using System;
using System.Data;
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

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GetCities().Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("cityname like '%{0}%' or Convert([cityid] , System.String) like '{0}'", SearchText.Text);
            CityGrid.DataSource = dv.ToTable();
        }

        private void SetCity(int cityId)
        {
            Choose.city = cityId;
            Program.play.UpdateCity(cityId);
            this.Hide();
        }

        private void CityGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cityId = int.Parse(this.CityGrid.CurrentRow.Cells[0].Value.ToString());
            SetCity(cityId);
        }
    }
}

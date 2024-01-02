using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ColorList : Form
    {
        public ColorList()
        {
            InitializeComponent();
        }
        private DataSet GetColors()
        {
            ColorService os = new ColorService();
            return os.GetColors();
        }
        private void ColorList_Load(object sender, EventArgs e)
        {
            ColorGrid.AutoGenerateColumns = false;
            ColorGrid.DataSource = GetColors();
            ColorGrid.DataMember = "Colors";
        }

        private void ColorGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = int.Parse(this.ColorGrid.CurrentRow.Cells[0].Value.ToString());
            Choose.color = x;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GetColors().Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("colorname like '%{0}%' or Convert([colorid] , System.String) like '{0}'", SearchText.Text);
            ColorGrid.DataSource = dv.ToTable();
        }

        private void ColorList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int x = int.Parse(this.ColorGrid.CurrentRow.Cells[0].Value.ToString());
                Choose.color = x;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
           
        }
    }
}

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
    public partial class ItemsList : Form
    {
        public ItemsList()
        {
            InitializeComponent();
        }
        private DataSet GetItems()
        {
            ItemService os = new ItemService();
            return os.GetItems();
        }
        private void ItemGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = int.Parse(this.ItemGrid.CurrentRow.Cells[0].Value.ToString());
            Choose.item = x;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            

        }

        private void ItemsList_Load(object sender, EventArgs e)
        {
            ItemGrid.AutoGenerateColumns = false;
            ItemGrid.DataSource = GetItems();
            ItemGrid.DataMember = "Items";
        }
    }
}

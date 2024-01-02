using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ItemsList : Form
    {
        FunctionService function = new FunctionService();
        private object previousValue;
        private Point mouseLocation;
        private bool isEdit = false;
        public ItemsList()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            ItemsGrid.AutoGenerateColumns = false;
            ItemsGrid.DataSource = function.GetItems();
            ItemsGrid.DataMember = "Items";
        }
        private void ItemsList_Load(object sender, EventArgs e)
        {
            Populate();
            this.Size = new System.Drawing.Size(766, 509);
        }

        private void ItemsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEdit)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    ItemsGrid.BeginEdit(true);
                }
            }
            else
            {
                int x = int.Parse(this.ItemsGrid.CurrentRow.Cells[0].Value.ToString());
                Choose.item = x;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Submit();
        }
        private void Submit()
        {
            string name = NameBox.Texts;
            int price = 0;
            int length = 0;
            if (NameBox.Texts == "")
            {
                MessageBox.Show("שם הפריט ריק");
            }
            else if (!int.TryParse(PriceBox.Texts, out price))
            {
                MessageBox.Show("אנא רשום מספר במחיר");
            }
            else if (!int.TryParse(LengthBox.Texts, out length))
            {
                MessageBox.Show("אנא רשום מספר במשך עבודה");
            }
            else
            {
                Item item = new Item(name, price, length);
                function.NewItem(item);
                MessageBox.Show("נוסף פריט בהצלחה");
                Populate();
            }
        }
        private void ItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            //{
            //    isEdit = true;
            //    ItemsGrid.Rows[e.RowIndex].Cells["ItemName"].ReadOnly = false;
            //    ItemsGrid.Rows[e.RowIndex].Cells["ItemPrice"].ReadOnly = false;
            //    ItemsGrid.Rows[e.RowIndex].Cells["ItemLength"].ReadOnly = false;

            //}
        }
        private void MovingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void MovingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }
        private void ClosingButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = function.GetItems().Tables[0];
            DataView dv = dt.DefaultView;

            // dv.RowFilter = string.Format("username LIKE '%{0}%' OR userphone LIKE '%{0}%' OR (username + ' ' + fname) LIKE '%{0}%'", SearchText.Text);
            dv.RowFilter = string.Format("itemname LIKE '%{0}%'", SearchText.Text);
            ItemsGrid.DataSource = dv.ToTable();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            
            if(this.Size == new System.Drawing.Size(766, 509))
            {
                this.Size = new System.Drawing.Size(766, 612);
                SubmitButton.Enabled = true;
            }
            else if(this.Size == new System.Drawing.Size(766, 612))
            {
                this.Size = new System.Drawing.Size(766, 509);
                SubmitButton.Enabled = false;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                isEdit = false;
                ItemName.ReadOnly = true;
                ItemPrice.ReadOnly = true;
                ItemLength.ReadOnly = true;
                EditButton.BackColor = Color.White;
            }
            else
            {
                isEdit = true;
                ItemName.ReadOnly = false;
                ItemPrice.ReadOnly = false;
                ItemLength.ReadOnly = false;
                EditButton.BackColor = Color.LightCoral;
            }
            
        }

        private void ItemsGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int num;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = ItemsGrid.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];
                
                if (e.ColumnIndex == 2)
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out num))
                    {
                        ItemsGrid.CancelEdit();
                        cell.Value = previousValue;
                        MessageBox.Show("אנא רשום מספר במחיר");
                    }
                    else
                    {
                        Item i = new Item(int.Parse(row.Cells["ItemId"].Value.ToString()), row.Cells["ItemName"].Value.ToString(), num, int.Parse(row.Cells["ItemLength"].Value.ToString()));
                        function.EditItem(i);
                    }
                }
                if (e.ColumnIndex == 3)
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out num))
                    {
                        ItemsGrid.CancelEdit();
                        cell.Value = previousValue;
                        MessageBox.Show("אנא רשום מספר במשך עבודה");
                    }
                    else
                    {
                        Item i = new Item(int.Parse(row.Cells["ItemId"].Value.ToString()), row.Cells["ItemName"].Value.ToString(), int.Parse(row.Cells["ItemPrice"].Value.ToString()), num);
                        function.EditItem(i);
                    }
                }
            }
        }

        private void ItemsGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                previousValue = ItemsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void ItemsList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!isEdit)
                {
                    int x = int.Parse(this.ItemsGrid.CurrentRow.Cells[0].Value.ToString());
                    Choose.item = x;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    Submit();
                }
            }
        }
    }
}

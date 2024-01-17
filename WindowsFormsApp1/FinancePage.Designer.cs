
namespace WindowsFormsApp1
{
    partial class FinancePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectAllOrder = new WindowsFormsApp1.MyButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.FinanceGrid = new System.Windows.Forms.DataGridView();
            this.PrintButton = new WindowsFormsApp1.MyButton();
            this.ItemIcons = new System.Windows.Forms.ImageList(this.components);
            this.CancelOrder = new WindowsFormsApp1.MyButton();
            this.NewItemB = new WindowsFormsApp1.MyButton();
            this.SearchButton = new WindowsFormsApp1.MyButton();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAllOrder
            // 
            this.SelectAllOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.SelectAllOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.SelectAllOrder.BorderColor = System.Drawing.Color.LavenderBlush;
            this.SelectAllOrder.BorderRadius = 0;
            this.SelectAllOrder.BorderSize = 0;
            this.SelectAllOrder.FlatAppearance.BorderSize = 0;
            this.SelectAllOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllOrder.ForeColor = System.Drawing.Color.Lime;
            this.SelectAllOrder.ImageKey = "checkbox.png";
            this.SelectAllOrder.ImageList = this.imageList2;
            this.SelectAllOrder.Location = new System.Drawing.Point(778, 0);
            this.SelectAllOrder.Name = "SelectAllOrder";
            this.SelectAllOrder.Size = new System.Drawing.Size(55, 32);
            this.SelectAllOrder.TabIndex = 60;
            this.SelectAllOrder.TextColor = System.Drawing.Color.Lime;
            this.SelectAllOrder.UseVisualStyleBackColor = false;
            this.SelectAllOrder.Click += new System.EventHandler(this.SelectAllOrder_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "checkbox.png");
            // 
            // FinanceGrid
            // 
            this.FinanceGrid.AllowUserToAddRows = false;
            this.FinanceGrid.AllowUserToDeleteRows = false;
            this.FinanceGrid.AllowUserToResizeColumns = false;
            this.FinanceGrid.AllowUserToResizeRows = false;
            this.FinanceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.FinanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinanceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FinanceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FinanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FinanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.IdColumn,
            this.UserId,
            this.NameColumn,
            this.Price,
            this.DateColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FinanceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FinanceGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.FinanceGrid.EnableHeadersVisualStyles = false;
            this.FinanceGrid.Location = new System.Drawing.Point(192, 0);
            this.FinanceGrid.MultiSelect = false;
            this.FinanceGrid.Name = "FinanceGrid";
            this.FinanceGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FinanceGrid.RowHeadersVisible = false;
            this.FinanceGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FinanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FinanceGrid.Size = new System.Drawing.Size(641, 571);
            this.FinanceGrid.TabIndex = 59;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PrintButton.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.PrintButton.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.PrintButton.BorderRadius = 20;
            this.PrintButton.BorderSize = 0;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.PrintButton.ImageKey = "printicon.png";
            this.PrintButton.ImageList = this.ItemIcons;
            this.PrintButton.Location = new System.Drawing.Point(40, 124);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(117, 52);
            this.PrintButton.TabIndex = 68;
            this.PrintButton.TextColor = System.Drawing.Color.LightSkyBlue;
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ItemIcons
            // 
            this.ItemIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ItemIcons.ImageStream")));
            this.ItemIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ItemIcons.Images.SetKeyName(0, "CancelItem.png");
            this.ItemIcons.Images.SetKeyName(1, "GetItems.png");
            this.ItemIcons.Images.SetKeyName(2, "GetMoney.png");
            this.ItemIcons.Images.SetKeyName(3, "History.png");
            this.ItemIcons.Images.SetKeyName(4, "PutItem2.png");
            this.ItemIcons.Images.SetKeyName(5, "ReturnItem.png");
            this.ItemIcons.Images.SetKeyName(6, "PutItems.png");
            this.ItemIcons.Images.SetKeyName(7, "deliver2.png");
            this.ItemIcons.Images.SetKeyName(8, "money.png");
            this.ItemIcons.Images.SetKeyName(9, "history3.png");
            this.ItemIcons.Images.SetKeyName(10, "printicon.png");
            this.ItemIcons.Images.SetKeyName(11, "message.png");
            this.ItemIcons.Images.SetKeyName(12, "search2.png");
            // 
            // CancelOrder
            // 
            this.CancelOrder.BackColor = System.Drawing.Color.LightPink;
            this.CancelOrder.BackgroundColor = System.Drawing.Color.LightPink;
            this.CancelOrder.BorderColor = System.Drawing.Color.LightPink;
            this.CancelOrder.BorderRadius = 20;
            this.CancelOrder.BorderSize = 0;
            this.CancelOrder.FlatAppearance.BorderSize = 0;
            this.CancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOrder.ForeColor = System.Drawing.Color.LightPink;
            this.CancelOrder.ImageKey = "CancelItem.png";
            this.CancelOrder.ImageList = this.ItemIcons;
            this.CancelOrder.Location = new System.Drawing.Point(40, 68);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(117, 50);
            this.CancelOrder.TabIndex = 67;
            this.CancelOrder.TextColor = System.Drawing.Color.LightPink;
            this.CancelOrder.UseVisualStyleBackColor = false;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // NewItemB
            // 
            this.NewItemB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NewItemB.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.NewItemB.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.NewItemB.BorderRadius = 20;
            this.NewItemB.BorderSize = 0;
            this.NewItemB.FlatAppearance.BorderSize = 0;
            this.NewItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewItemB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.NewItemB.ImageKey = "GetItems.png";
            this.NewItemB.ImageList = this.ItemIcons;
            this.NewItemB.Location = new System.Drawing.Point(40, 12);
            this.NewItemB.Name = "NewItemB";
            this.NewItemB.Size = new System.Drawing.Size(117, 50);
            this.NewItemB.TabIndex = 66;
            this.NewItemB.TextColor = System.Drawing.Color.LightSeaGreen;
            this.NewItemB.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SearchButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.SearchButton.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SearchButton.BorderRadius = 20;
            this.SearchButton.BorderSize = 0;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.SearchButton.ImageKey = "search2.png";
            this.SearchButton.ImageList = this.ItemIcons;
            this.SearchButton.Location = new System.Drawing.Point(40, 182);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 52);
            this.SearchButton.TabIndex = 69;
            this.SearchButton.TextColor = System.Drawing.Color.LightSkyBlue;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.MinimumWidth = 50;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 50;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "IdColumn";
            this.IdColumn.HeaderText = "";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "שם";
            this.NameColumn.MinimumWidth = 325;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "מחיר";
            this.Price.MinimumWidth = 60;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.DataPropertyName = "DateColumn";
            this.DateColumn.HeaderText = "תאריך";
            this.DateColumn.MinimumWidth = 300;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FinancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 571);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.NewItemB);
            this.Controls.Add(this.SelectAllOrder);
            this.Controls.Add(this.FinanceGrid);
            this.Name = "FinancePage";
            this.Text = "FinancePage";
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton SelectAllOrder;
        private System.Windows.Forms.DataGridView FinanceGrid;
        private System.Windows.Forms.ImageList imageList2;
        private MyButton PrintButton;
        private MyButton CancelOrder;
        private MyButton NewItemB;
        private System.Windows.Forms.ImageList ItemIcons;
        private MyButton SearchButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}
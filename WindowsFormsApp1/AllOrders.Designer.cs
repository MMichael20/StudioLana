namespace WindowsFormsApp1
{
    partial class AllOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ReturnButton = new WindowsFormsApp1.MyButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SelectAllOrder = new WindowsFormsApp1.MyButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.CreateInvoice = new WindowsFormsApp1.MyButton();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToAddRows = false;
            this.OrderGrid.AllowUserToDeleteRows = false;
            this.OrderGrid.AllowUserToResizeColumns = false;
            this.OrderGrid.AllowUserToResizeRows = false;
            this.OrderGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.OrderId,
            this.FullName,
            this.OrderName,
            this.ColorName,
            this.UserPhone,
            this.OrderAmount,
            this.OrderPrice,
            this.OrderFinish,
            this.Paid});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.Location = new System.Drawing.Point(0, 83);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(1103, 498);
            this.OrderGrid.TabIndex = 0;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            this.OrderGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellDoubleClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(836, 31);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(75, 30);
            this.label26.TabIndex = 16;
            this.label26.Text = "חיפוש:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(240, 28);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(590, 38);
            this.SearchText.TabIndex = 17;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.HotPink;
            this.ReturnButton.BackgroundColor = System.Drawing.Color.HotPink;
            this.ReturnButton.BorderColor = System.Drawing.Color.HotPink;
            this.ReturnButton.BorderRadius = 17;
            this.ReturnButton.BorderSize = 0;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.ImageKey = "repair.png";
            this.ReturnButton.ImageList = this.imageList1;
            this.ReturnButton.Location = new System.Drawing.Point(124, 26);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(82, 43);
            this.ReturnButton.TabIndex = 18;
            this.ReturnButton.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.ReturnButton, "החזר");
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "repair.png");
            this.imageList1.Images.SetKeyName(1, "GetItems.png");
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
            this.SelectAllOrder.Location = new System.Drawing.Point(1057, 83);
            this.SelectAllOrder.Name = "SelectAllOrder";
            this.SelectAllOrder.Size = new System.Drawing.Size(41, 32);
            this.SelectAllOrder.TabIndex = 58;
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
            // CreateInvoice
            // 
            this.CreateInvoice.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateInvoice.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.CreateInvoice.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CreateInvoice.BorderRadius = 17;
            this.CreateInvoice.BorderSize = 0;
            this.CreateInvoice.FlatAppearance.BorderSize = 0;
            this.CreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateInvoice.ForeColor = System.Drawing.Color.White;
            this.CreateInvoice.ImageKey = "GetItems.png";
            this.CreateInvoice.ImageList = this.imageList1;
            this.CreateInvoice.Location = new System.Drawing.Point(26, 26);
            this.CreateInvoice.Name = "CreateInvoice";
            this.CreateInvoice.Size = new System.Drawing.Size(82, 43);
            this.CreateInvoice.TabIndex = 59;
            this.CreateInvoice.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.CreateInvoice, "חשבונית");
            this.CreateInvoice.UseVisualStyleBackColor = false;
            this.CreateInvoice.Visible = false;
            this.CreateInvoice.Click += new System.EventHandler(this.CreateInvoice_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.MinimumWidth = 50;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 50;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "מס\'";
            this.OrderId.MinimumWidth = 40;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 40;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "שם";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // OrderName
            // 
            this.OrderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderName.DataPropertyName = "ItemName";
            this.OrderName.HeaderText = "סוג הזמנה";
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            // 
            // ColorName
            // 
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "צבע";
            this.ColorName.MinimumWidth = 100;
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPhone.DataPropertyName = "OrderDate";
            this.UserPhone.HeaderText = "תאריך";
            this.UserPhone.MinimumWidth = 125;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            this.UserPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OrderAmount
            // 
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "כמות";
            this.OrderAmount.MinimumWidth = 70;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.ReadOnly = true;
            this.OrderAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderAmount.Width = 70;
            // 
            // OrderPrice
            // 
            this.OrderPrice.DataPropertyName = "OrderPrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.OrderPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrderPrice.HeaderText = "מחיר";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // OrderFinish
            // 
            this.OrderFinish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderFinish.DataPropertyName = "OrderDelivered";
            this.OrderFinish.HeaderText = "מסירה";
            this.OrderFinish.Name = "OrderFinish";
            this.OrderFinish.ReadOnly = true;
            // 
            // Paid
            // 
            this.Paid.DataPropertyName = "OrderPaid";
            this.Paid.HeaderText = "שולם";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 581);
            this.Controls.Add(this.CreateInvoice);
            this.Controls.Add(this.SelectAllOrder);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.OrderGrid);
            this.Name = "AllOrders";
            this.Text = "UserSearch";
            this.Load += new System.EventHandler(this.AllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.DataGridView OrderGrid;
        private MyButton ReturnButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private MyButton SelectAllOrder;
        private System.Windows.Forms.ImageList imageList2;
        private MyButton CreateInvoice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
    }
}
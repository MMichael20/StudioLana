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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.UserName,
            this.OrderName,
            this.ColorName,
            this.UserPhone,
            this.OrderAmount,
            this.OrderPrice,
            this.OrderFinish,
            this.Paid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.Location = new System.Drawing.Point(0, 75);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(1047, 498);
            this.OrderGrid.TabIndex = 0;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            this.OrderGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellDoubleClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(788, 30);
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
            this.SearchText.Location = new System.Drawing.Point(192, 27);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(590, 38);
            this.SearchText.TabIndex = 17;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
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
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "FullName";
            this.UserName.HeaderText = "שם";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
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
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.OrderPrice.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.ClientSize = new System.Drawing.Size(1047, 573);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
    }
}
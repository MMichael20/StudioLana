namespace WindowsFormsApp1
{
    partial class ItemsList
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
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.CityName,
            this.ItemPrice});
            this.ItemGrid.Location = new System.Drawing.Point(40, 12);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemGrid.Size = new System.Drawing.Size(721, 426);
            this.ItemGrid.TabIndex = 1;
            this.ItemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGrid_CellDoubleClick);
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "ItemId";
            this.CityId.HeaderText = "מס\'";
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "ItemName";
            this.CityName.HeaderText = "תיאור פריט";
            this.CityName.MinimumWidth = 200;
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            this.CityName.Width = 200;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "מחיר";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // ItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemGrid);
            this.Name = "ItemsList";
            this.Text = "ItemsList";
            this.Load += new System.EventHandler(this.ItemsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
    }
}
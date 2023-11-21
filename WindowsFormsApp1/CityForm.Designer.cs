namespace WindowsFormsApp1
{
    partial class CityForm
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
            this.CityGrid = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectB = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CityGrid
            // 
            this.CityGrid.AllowUserToAddRows = false;
            this.CityGrid.AllowUserToDeleteRows = false;
            this.CityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.CityName,
            this.SelectB});
            this.CityGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CityGrid.Location = new System.Drawing.Point(0, 65);
            this.CityGrid.Name = "CityGrid";
            this.CityGrid.ReadOnly = true;
            this.CityGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CityGrid.Size = new System.Drawing.Size(800, 385);
            this.CityGrid.TabIndex = 0;
            this.CityGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CityGrid_CellClick);
            this.CityGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CityGrid_CellContentClick);
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "CityId";
            this.CityId.HeaderText = "מספר העיר";
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "שם העיר";
            this.CityName.MinimumWidth = 200;
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // SelectB
            // 
            this.SelectB.HeaderText = "בחר";
            this.SelectB.Name = "SelectB";
            this.SelectB.ReadOnly = true;
            this.SelectB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectB.Text = "בחר";
            this.SelectB.UseColumnTextForButtonValue = true;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(72, 30);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(590, 20);
            this.SearchText.TabIndex = 19;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(668, 25);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(60, 24);
            this.label26.TabIndex = 18;
            this.label26.Text = "חיפוש:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.CityGrid);
            this.Name = "CityForm";
            this.Text = "CityForm";
            this.Load += new System.EventHandler(this.CityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewButtonColumn SelectB;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label26;
    }
}
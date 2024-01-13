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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CityGrid = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CityGrid
            // 
            this.CityGrid.AllowUserToAddRows = false;
            this.CityGrid.AllowUserToDeleteRows = false;
            this.CityGrid.AllowUserToResizeColumns = false;
            this.CityGrid.AllowUserToResizeRows = false;
            this.CityGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.CityGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CityGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CityGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.CityName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CityGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CityGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CityGrid.EnableHeadersVisualStyles = false;
            this.CityGrid.Location = new System.Drawing.Point(0, 88);
            this.CityGrid.MultiSelect = false;
            this.CityGrid.Name = "CityGrid";
            this.CityGrid.ReadOnly = true;
            this.CityGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CityGrid.RowHeadersVisible = false;
            this.CityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CityGrid.Size = new System.Drawing.Size(701, 385);
            this.CityGrid.TabIndex = 0;
            this.CityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CityGrid_CellDoubleClick);
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "CityId";
            this.CityId.HeaderText = "מס";
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
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(71, 30);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(467, 35);
            this.SearchText.TabIndex = 19;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(542, 34);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(68, 27);
            this.label26.TabIndex = 18;
            this.label26.Text = "חיפוש:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 473);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.CityGrid);
            this.Name = "CityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityForm";
            this.Load += new System.EventHandler(this.CityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CityGrid;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
    }
}
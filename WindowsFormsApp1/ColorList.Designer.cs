namespace WindowsFormsApp1
{
    partial class ColorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ColorGrid = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorGrid
            // 
            this.ColorGrid.AllowUserToAddRows = false;
            this.ColorGrid.AllowUserToDeleteRows = false;
            this.ColorGrid.AllowUserToResizeColumns = false;
            this.ColorGrid.AllowUserToResizeRows = false;
            this.ColorGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.ColorGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ColorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.ColorName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColorGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColorGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorGrid.EnableHeadersVisualStyles = false;
            this.ColorGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.ColorGrid.Location = new System.Drawing.Point(0, 91);
            this.ColorGrid.MultiSelect = false;
            this.ColorGrid.Name = "ColorGrid";
            this.ColorGrid.ReadOnly = true;
            this.ColorGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ColorGrid.RowHeadersVisible = false;
            this.ColorGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ColorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ColorGrid.Size = new System.Drawing.Size(860, 401);
            this.ColorGrid.TabIndex = 2;
            this.ColorGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColorGrid_CellDoubleClick);
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "ColorId";
            this.CityId.HeaderText = "מס\'";
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            // 
            // ColorName
            // 
            this.ColorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "צבע";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(74, 27);
            this.SearchText.Name = "SearchText";
            this.SearchText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchText.Size = new System.Drawing.Size(590, 31);
            this.SearchText.TabIndex = 19;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(670, 31);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(68, 27);
            this.label26.TabIndex = 18;
            this.label26.Text = "חיפוש:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            // 
            // ColorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 492);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.ColorGrid);
            this.Name = "ColorList";
            this.Text = "ColorList";
            this.Load += new System.EventHandler(this.ColorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ColorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label26;
    }
}
namespace WindowsFormsApp1
{
    partial class UserSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectB = new System.Windows.Forms.DataGridViewImageColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGrid
            // 
            this.UserGrid.AllowUserToAddRows = false;
            this.UserGrid.AllowUserToDeleteRows = false;
            this.UserGrid.AllowUserToResizeColumns = false;
            this.UserGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UserGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Varela Round", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserLname,
            this.CityName,
            this.UserPhone,
            this.SelectB});
            this.UserGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserGrid.EnableHeadersVisualStyles = false;
            this.UserGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserGrid.Location = new System.Drawing.Point(0, 86);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ReadOnly = true;
            this.UserGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserGrid.RowHeadersVisible = false;
            this.UserGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserGrid.RowTemplate.Height = 30;
            this.UserGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.Size = new System.Drawing.Size(877, 459);
            this.UserGrid.TabIndex = 0;
            this.UserGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellClick);
            this.UserGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "מס\'";
            this.UserId.MinimumWidth = 50;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserId.Width = 50;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "שם";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserLname
            // 
            this.UserLname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserLname.DataPropertyName = "UserLname";
            this.UserLname.HeaderText = "משפחה";
            this.UserLname.Name = "UserLname";
            this.UserLname.ReadOnly = true;
            this.UserLname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "עיר";
            this.CityName.MinimumWidth = 150;
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            this.CityName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CityName.Width = 150;
            // 
            // UserPhone
            // 
            this.UserPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "טלפון";
            this.UserPhone.MinimumWidth = 125;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            this.UserPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserPhone.Width = 125;
            // 
            // SelectB
            // 
            this.SelectB.HeaderText = "בחר";
            this.SelectB.Image = global::WindowsFormsApp1.Properties.Resources.V_icon;
            this.SelectB.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelectB.Name = "SelectB";
            this.SelectB.ReadOnly = true;
            this.SelectB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectB.Width = 55;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("M PLUS 1p", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(699, 33);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(77, 30);
            this.label26.TabIndex = 16;
            this.label26.Text = "חיפוש:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Varela Round", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(102, 34);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(591, 30);
            this.SearchText.TabIndex = 17;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "בחר";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.V_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 545);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.UserGrid);
            this.Name = "UserSearch";
            this.Text = "UserSearch";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SearchText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewImageColumn SelectB;
    }
}
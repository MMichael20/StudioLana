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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorList));
            this.ColorGrid = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItem = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
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
            this.ColorGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.ColorGrid.Location = new System.Drawing.Point(0, 74);
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
            this.ColorGrid.Size = new System.Drawing.Size(712, 401);
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
            // AddItem
            // 
            this.AddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.ImageKey = "plus.png";
            this.AddItem.ImageList = this.imageList2;
            this.AddItem.Location = new System.Drawing.Point(615, 29);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(49, 30);
            this.AddItem.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.ImageKey = "search.png";
            this.label22.ImageList = this.imageList2;
            this.label22.Location = new System.Drawing.Point(34, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 30);
            this.label22.TabIndex = 51;
            // 
            // SearchText
            // 
            this.SearchText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchText.Font = new System.Drawing.Font("Varela Round", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(34, 29);
            this.SearchText.Name = "SearchText";
            this.SearchText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchText.Size = new System.Drawing.Size(582, 30);
            this.SearchText.TabIndex = 50;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "plus.png");
            this.imageList2.Images.SetKeyName(1, "search.png");
            // 
            // ColorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 475);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ColorGrid);
            this.Name = "ColorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label AddItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox SearchText;
        internal System.Windows.Forms.ImageList imageList2;
    }
}
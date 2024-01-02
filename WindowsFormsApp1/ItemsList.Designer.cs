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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsList));
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.ClosingButton = new System.Windows.Forms.PictureBox();
            this.XIcon = new System.Windows.Forms.PictureBox();
            this.AddItem = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Label();
            this.LengthBox = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.PriceBox = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.NameBox = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.SubmitButton = new WindowsFormsApp1.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.MovingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AllowUserToAddRows = false;
            this.ItemsGrid.AllowUserToDeleteRows = false;
            this.ItemsGrid.AllowUserToResizeColumns = false;
            this.ItemsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.ItemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ItemsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.ItemPrice,
            this.ItemLength});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsGrid.EnableHeadersVisualStyles = false;
            this.ItemsGrid.Location = new System.Drawing.Point(0, 81);
            this.ItemsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsGrid.MultiSelect = false;
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ItemsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ItemsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGrid.Size = new System.Drawing.Size(766, 428);
            this.ItemsGrid.TabIndex = 8;
            this.ItemsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ItemsGrid_CellBeginEdit);
            this.ItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGrid_CellClick);
            this.ItemsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGrid_CellDoubleClick);
            this.ItemsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ItemsGrid_CellValidating);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemId.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemId.Frozen = true;
            this.ItemId.HeaderText = "מס\'";
            this.ItemId.MinimumWidth = 40;
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "שם";
            this.ItemName.MinimumWidth = 170;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 170;
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemPrice.DataPropertyName = "ItemPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemPrice.HeaderText = "מחיר";
            this.ItemPrice.MinimumWidth = 70;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 150;
            // 
            // ItemLength
            // 
            this.ItemLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemLength.DataPropertyName = "ItemLength";
            this.ItemLength.HeaderText = "משך עבודה";
            this.ItemLength.Name = "ItemLength";
            this.ItemLength.ReadOnly = true;
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "plus2.png");
            this.Icons.Images.SetKeyName(1, "YesIcon.png");
            this.Icons.Images.SetKeyName(2, "HandWriting.png");
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(190, 545);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label29.Size = new System.Drawing.Size(106, 27);
            this.label29.TabIndex = 33;
            this.label29.Text = "משך עבודה:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.UseMnemonic = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(365, 545);
            this.label28.Name = "label28";
            this.label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label28.Size = new System.Drawing.Size(58, 27);
            this.label28.TabIndex = 31;
            this.label28.Text = "מחיר:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.UseMnemonic = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(669, 545);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label33.Size = new System.Drawing.Size(86, 27);
            this.label33.TabIndex = 29;
            this.label33.Text = "שם פריט:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label33.UseMnemonic = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "ערוך";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.editicon2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.Transparent;
            this.MovingPanel.Controls.Add(this.ClosingButton);
            this.MovingPanel.Controls.Add(this.XIcon);
            this.MovingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovingPanel.Location = new System.Drawing.Point(0, 0);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(766, 33);
            this.MovingPanel.TabIndex = 38;
            this.MovingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingPanel_MouseDown);
            this.MovingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovingPanel_MouseMove);
            // 
            // ClosingButton
            // 
            this.ClosingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingButton.Image = global::WindowsFormsApp1.Properties.Resources.x_icon;
            this.ClosingButton.Location = new System.Drawing.Point(737, 7);
            this.ClosingButton.Name = "ClosingButton";
            this.ClosingButton.Size = new System.Drawing.Size(19, 19);
            this.ClosingButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosingButton.TabIndex = 39;
            this.ClosingButton.TabStop = false;
            this.ClosingButton.Click += new System.EventHandler(this.ClosingButton_Click);
            // 
            // XIcon
            // 
            this.XIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XIcon.Image = global::WindowsFormsApp1.Properties.Resources.x_icon;
            this.XIcon.Location = new System.Drawing.Point(1140, 11);
            this.XIcon.Name = "XIcon";
            this.XIcon.Size = new System.Drawing.Size(19, 19);
            this.XIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.XIcon.TabIndex = 8;
            this.XIcon.TabStop = false;
            // 
            // AddItem
            // 
            this.AddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.ImageKey = "plus.png";
            this.AddItem.ImageList = this.imageList2;
            this.AddItem.Location = new System.Drawing.Point(651, 39);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(49, 30);
            this.AddItem.TabIndex = 49;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "pencil.png");
            this.imageList2.Images.SetKeyName(1, "plus.png");
            this.imageList2.Images.SetKeyName(2, "search.png");
            this.imageList2.Images.SetKeyName(3, "trash.png");
            this.imageList2.Images.SetKeyName(4, "leave.png");
            this.imageList2.Images.SetKeyName(5, "V-icon.png");
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.ImageKey = "search.png";
            this.label22.ImageList = this.imageList2;
            this.label22.Location = new System.Drawing.Point(70, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 30);
            this.label22.TabIndex = 48;
            // 
            // SearchText
            // 
            this.SearchText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchText.Font = new System.Drawing.Font("Varela Round", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(70, 39);
            this.SearchText.Name = "SearchText";
            this.SearchText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchText.Size = new System.Drawing.Size(582, 30);
            this.SearchText.TabIndex = 47;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.ImageKey = "pencil.png";
            this.EditButton.ImageList = this.imageList2;
            this.EditButton.Location = new System.Drawing.Point(15, 39);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(49, 30);
            this.EditButton.TabIndex = 50;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LengthBox
            // 
            this.LengthBox.BackColor = System.Drawing.SystemColors.Window;
            this.LengthBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.LengthBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LengthBox.BorderRadius = 10;
            this.LengthBox.BorderSize = 2;
            this.LengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LengthBox.Location = new System.Drawing.Point(122, 541);
            this.LengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthBox.Multiline = false;
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LengthBox.PasswordChar = false;
            this.LengthBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LengthBox.PlaceholderText = "";
            this.LengthBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LengthBox.Size = new System.Drawing.Size(70, 31);
            this.LengthBox.TabIndex = 37;
            this.LengthBox.Texts = "";
            this.LengthBox.UnderlinedStyle = false;
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.SystemColors.Window;
            this.PriceBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.PriceBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.PriceBox.BorderRadius = 10;
            this.PriceBox.BorderSize = 2;
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceBox.Location = new System.Drawing.Point(298, 542);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.Multiline = false;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PriceBox.PasswordChar = false;
            this.PriceBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PriceBox.PlaceholderText = "";
            this.PriceBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceBox.Size = new System.Drawing.Size(66, 31);
            this.PriceBox.TabIndex = 36;
            this.PriceBox.Texts = "";
            this.PriceBox.UnderlinedStyle = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.NameBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NameBox.BorderRadius = 10;
            this.NameBox.BorderSize = 2;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.Location = new System.Drawing.Point(425, 541);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            this.NameBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NameBox.PasswordChar = false;
            this.NameBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameBox.PlaceholderText = "";
            this.NameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameBox.Size = new System.Drawing.Size(246, 31);
            this.NameBox.TabIndex = 35;
            this.NameBox.Texts = "";
            this.NameBox.UnderlinedStyle = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.BorderColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.BorderRadius = 20;
            this.SubmitButton.BorderSize = 0;
            this.SubmitButton.Enabled = false;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.ImageKey = "YesIcon.png";
            this.SubmitButton.ImageList = this.Icons;
            this.SubmitButton.Location = new System.Drawing.Point(20, 534);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(96, 43);
            this.SubmitButton.TabIndex = 34;
            this.SubmitButton.TextColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.itemsbackground;
            this.ClientSize = new System.Drawing.Size(766, 610);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.MovingPanel);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.ItemsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsList";
            this.Load += new System.EventHandler(this.ItemsList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemsList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.MovingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ItemsGrid;
        private MyButton SubmitButton;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private MyControls.RoundedTextBox NameBox;
        private MyControls.RoundedTextBox PriceBox;
        private MyControls.RoundedTextBox LengthBox;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel MovingPanel;
        private System.Windows.Forms.PictureBox XIcon;
        private System.Windows.Forms.PictureBox ClosingButton;
        private System.Windows.Forms.Label AddItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox SearchText;
        internal System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLength;
    }
}
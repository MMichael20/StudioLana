namespace WindowsFormsApp1
{
    partial class NewItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItems));
            this.NewItemGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trash = new System.Windows.Forms.DataGridViewImageColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.BiggerIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SetDiscount = new WindowsFormsApp1.MyButton();
            this.DiscountButton = new WindowsFormsApp1.MyButton();
            this.NewC = new WindowsFormsApp1.MyButton();
            this.Exp2 = new WindowsFormsApp1.MyButton();
            this.Exp = new WindowsFormsApp1.MyButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.DiscountBox = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.SubmitOrder = new WindowsFormsApp1.MyButton();
            this.Color10 = new WindowsFormsApp1.MyButton();
            this.Color9 = new WindowsFormsApp1.MyButton();
            this.Color7 = new WindowsFormsApp1.MyButton();
            this.Color6 = new WindowsFormsApp1.MyButton();
            this.Color5 = new WindowsFormsApp1.MyButton();
            this.Color4 = new WindowsFormsApp1.MyButton();
            this.Color3 = new WindowsFormsApp1.MyButton();
            this.Color2 = new WindowsFormsApp1.MyButton();
            this.Item9 = new WindowsFormsApp1.MyButton();
            this.Item8 = new WindowsFormsApp1.MyButton();
            this.Item10 = new WindowsFormsApp1.MyButton();
            this.Item7 = new WindowsFormsApp1.MyButton();
            this.Item6 = new WindowsFormsApp1.MyButton();
            this.Item5 = new WindowsFormsApp1.MyButton();
            this.Item4 = new WindowsFormsApp1.MyButton();
            this.Item3 = new WindowsFormsApp1.MyButton();
            this.Item2 = new WindowsFormsApp1.MyButton();
            this.Item1 = new WindowsFormsApp1.MyButton();
            this.Color1 = new WindowsFormsApp1.MyButton();
            this.Color8 = new WindowsFormsApp1.MyButton();
            this.DisBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewItemGrid
            // 
            this.NewItemGrid.AllowUserToAddRows = false;
            this.NewItemGrid.AllowUserToDeleteRows = false;
            this.NewItemGrid.AllowUserToResizeRows = false;
            this.NewItemGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.NewItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewItemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NewItemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NewItemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NewItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemName,
            this.Amount,
            this.Color,
            this.Note,
            this.Price,
            this.Length,
            this.Trash});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NewItemGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.NewItemGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewItemGrid.EnableHeadersVisualStyles = false;
            this.NewItemGrid.Location = new System.Drawing.Point(0, 0);
            this.NewItemGrid.Name = "NewItemGrid";
            this.NewItemGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewItemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NewItemGrid.RowHeadersVisible = false;
            this.NewItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NewItemGrid.Size = new System.Drawing.Size(1135, 239);
            this.NewItemGrid.TabIndex = 0;
            this.NewItemGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.NewItemGrid_CellBeginEdit);
            this.NewItemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewItemGrid_CellContentClick);
            this.NewItemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewItemGrid_CellDoubleClick);
            this.NewItemGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewItemGrid_CellEndEdit);
            this.NewItemGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.NewItemGrid_CellValidating);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "מס";
            this.Id.MinimumWidth = 40;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "תיאור הפריט";
            this.ItemName.MinimumWidth = 170;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 170;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "יח";
            this.Amount.MinimumWidth = 40;
            this.Amount.Name = "Amount";
            this.Amount.Width = 40;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "צבע הפריט";
            this.Color.MinimumWidth = 100;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "הערות \\ תוספות";
            this.Note.MinimumWidth = 150;
            this.Note.Name = "Note";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "מחיר";
            this.Price.MinimumWidth = 140;
            this.Price.Name = "Price";
            this.Price.Width = 140;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "ימי עבודה";
            this.Length.MinimumWidth = 150;
            this.Length.Name = "Length";
            this.Length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Length.Width = 150;
            // 
            // Trash
            // 
            this.Trash.HeaderText = "";
            this.Trash.Image = global::WindowsFormsApp1.Properties.Resources.Goodtrash;
            this.Trash.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Trash.MinimumWidth = 55;
            this.Trash.Name = "Trash";
            this.Trash.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Trash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Trash.Width = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(759, 463);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(127, 27);
            this.label15.TabIndex = 57;
            this.label15.Text = "סכום ההזמנה: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseMnemonic = false;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(646, 464);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(0, 27);
            this.Total.TabIndex = 58;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Total.UseMnemonic = false;
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Extra.png");
            this.Icons.Images.SetKeyName(1, "ExtraBlack.png");
            this.Icons.Images.SetKeyName(2, "V-icon.png");
            // 
            // BiggerIcons
            // 
            this.BiggerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BiggerIcons.ImageStream")));
            this.BiggerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.BiggerIcons.Images.SetKeyName(0, "plus2.png");
            this.BiggerIcons.Images.SetKeyName(1, "YesIcon.png");
            // 
            // SetDiscount
            // 
            this.SetDiscount.BackColor = System.Drawing.Color.Transparent;
            this.SetDiscount.BackgroundColor = System.Drawing.Color.Transparent;
            this.SetDiscount.BorderColor = System.Drawing.Color.Transparent;
            this.SetDiscount.BorderRadius = 20;
            this.SetDiscount.BorderSize = 0;
            this.SetDiscount.FlatAppearance.BorderSize = 0;
            this.SetDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDiscount.ForeColor = System.Drawing.Color.Transparent;
            this.SetDiscount.ImageKey = "V-icon.png";
            this.SetDiscount.ImageList = this.Icons;
            this.SetDiscount.Location = new System.Drawing.Point(604, 543);
            this.SetDiscount.Name = "SetDiscount";
            this.SetDiscount.Size = new System.Drawing.Size(46, 45);
            this.SetDiscount.TabIndex = 97;
            this.SetDiscount.TextColor = System.Drawing.Color.Transparent;
            this.toolTip1.SetToolTip(this.SetDiscount, "אקספרס");
            this.SetDiscount.UseVisualStyleBackColor = false;
            this.SetDiscount.Click += new System.EventHandler(this.SetDiscount_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.BackColor = System.Drawing.Color.Transparent;
            this.DiscountButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.DiscountButton.BorderColor = System.Drawing.Color.Transparent;
            this.DiscountButton.BorderRadius = 20;
            this.DiscountButton.BorderSize = 0;
            this.DiscountButton.FlatAppearance.BorderSize = 0;
            this.DiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountButton.ForeColor = System.Drawing.Color.Transparent;
            this.DiscountButton.ImageKey = "V-icon.png";
            this.DiscountButton.ImageList = this.Icons;
            this.DiscountButton.Location = new System.Drawing.Point(604, 498);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(46, 45);
            this.DiscountButton.TabIndex = 93;
            this.DiscountButton.TextColor = System.Drawing.Color.Transparent;
            this.toolTip1.SetToolTip(this.DiscountButton, "אקספרס");
            this.DiscountButton.UseVisualStyleBackColor = false;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // NewC
            // 
            this.NewC.BackColor = System.Drawing.Color.Transparent;
            this.NewC.BackgroundColor = System.Drawing.Color.Transparent;
            this.NewC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.NewC.BorderRadius = 15;
            this.NewC.BorderSize = 0;
            this.NewC.FlatAppearance.BorderSize = 0;
            this.NewC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewC.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewC.ForeColor = System.Drawing.Color.Black;
            this.NewC.ImageKey = "plus2.png";
            this.NewC.ImageList = this.BiggerIcons;
            this.NewC.Location = new System.Drawing.Point(64, 284);
            this.NewC.Name = "NewC";
            this.NewC.Size = new System.Drawing.Size(80, 72);
            this.NewC.TabIndex = 69;
            this.NewC.TextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.NewC, "הוסף שורה");
            this.NewC.UseVisualStyleBackColor = false;
            this.NewC.Click += new System.EventHandler(this.NewC_Click);
            // 
            // Exp2
            // 
            this.Exp2.BackColor = System.Drawing.Color.MediumOrchid;
            this.Exp2.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.Exp2.BorderColor = System.Drawing.Color.LavenderBlush;
            this.Exp2.BorderRadius = 20;
            this.Exp2.BorderSize = 0;
            this.Exp2.FlatAppearance.BorderSize = 0;
            this.Exp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exp2.ForeColor = System.Drawing.Color.Lime;
            this.Exp2.ImageKey = "ExtraBlack.png";
            this.Exp2.ImageList = this.Icons;
            this.Exp2.Location = new System.Drawing.Point(46, 436);
            this.Exp2.Name = "Exp2";
            this.Exp2.Size = new System.Drawing.Size(131, 43);
            this.Exp2.TabIndex = 65;
            this.Exp2.TextColor = System.Drawing.Color.Lime;
            this.toolTip1.SetToolTip(this.Exp2, "אקספרססס");
            this.Exp2.UseVisualStyleBackColor = false;
            this.Exp2.Click += new System.EventHandler(this.Exp2_Click);
            // 
            // Exp
            // 
            this.Exp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Exp.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.Exp.BorderColor = System.Drawing.Color.LavenderBlush;
            this.Exp.BorderRadius = 20;
            this.Exp.BorderSize = 0;
            this.Exp.FlatAppearance.BorderSize = 0;
            this.Exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exp.ForeColor = System.Drawing.Color.Lime;
            this.Exp.ImageKey = "Extra.png";
            this.Exp.ImageList = this.Icons;
            this.Exp.Location = new System.Drawing.Point(202, 436);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(131, 43);
            this.Exp.TabIndex = 64;
            this.Exp.TextColor = System.Drawing.Color.Lime;
            this.toolTip1.SetToolTip(this.Exp, "אקספרס");
            this.Exp.UseVisualStyleBackColor = false;
            this.Exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Lana;
            this.pictureBox1.Location = new System.Drawing.Point(944, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 508);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 90;
            this.label2.Text = "הנחה בשקלים:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 553);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 95;
            this.label3.Text = "הנחה באחוזים:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DiscountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountTextBox.BorderRadius = 15;
            this.DiscountTextBox.BorderSize = 2;
            this.DiscountTextBox.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiscountTextBox.Location = new System.Drawing.Point(653, 546);
            this.DiscountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DiscountTextBox.Multiline = false;
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DiscountTextBox.PasswordChar = false;
            this.DiscountTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountTextBox.PlaceholderText = "";
            this.DiscountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiscountTextBox.Size = new System.Drawing.Size(105, 38);
            this.DiscountTextBox.TabIndex = 96;
            this.DiscountTextBox.Texts = "";
            this.DiscountTextBox.UnderlinedStyle = false;
            // 
            // DiscountBox
            // 
            this.DiscountBox.BackColor = System.Drawing.SystemColors.Window;
            this.DiscountBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountBox.BorderRadius = 15;
            this.DiscountBox.BorderSize = 2;
            this.DiscountBox.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiscountBox.Location = new System.Drawing.Point(653, 501);
            this.DiscountBox.Margin = new System.Windows.Forms.Padding(4);
            this.DiscountBox.Multiline = false;
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DiscountBox.PasswordChar = false;
            this.DiscountBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.DiscountBox.PlaceholderText = "";
            this.DiscountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiscountBox.Size = new System.Drawing.Size(105, 38);
            this.DiscountBox.TabIndex = 91;
            this.DiscountBox.Texts = "";
            this.DiscountBox.UnderlinedStyle = false;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackColor = System.Drawing.Color.LightSalmon;
            this.SubmitOrder.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.SubmitOrder.BorderColor = System.Drawing.Color.LavenderBlush;
            this.SubmitOrder.BorderRadius = 20;
            this.SubmitOrder.BorderSize = 0;
            this.SubmitOrder.FlatAppearance.BorderSize = 0;
            this.SubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitOrder.ForeColor = System.Drawing.Color.Lime;
            this.SubmitOrder.ImageKey = "YesIcon.png";
            this.SubmitOrder.ImageList = this.BiggerIcons;
            this.SubmitOrder.Location = new System.Drawing.Point(98, 535);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(154, 60);
            this.SubmitOrder.TabIndex = 88;
            this.SubmitOrder.TextColor = System.Drawing.Color.Lime;
            this.SubmitOrder.UseVisualStyleBackColor = false;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // Color10
            // 
            this.Color10.BackColor = System.Drawing.Color.White;
            this.Color10.BackgroundColor = System.Drawing.Color.White;
            this.Color10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color10.BorderColor = System.Drawing.Color.Black;
            this.Color10.BorderRadius = 15;
            this.Color10.BorderSize = 3;
            this.Color10.FlatAppearance.BorderSize = 0;
            this.Color10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color10.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color10.ForeColor = System.Drawing.Color.Black;
            this.Color10.Location = new System.Drawing.Point(150, 323);
            this.Color10.Name = "Color10";
            this.Color10.Size = new System.Drawing.Size(80, 72);
            this.Color10.TabIndex = 87;
            this.Color10.Text = "צבע אחר";
            this.Color10.TextColor = System.Drawing.Color.Black;
            this.Color10.UseVisualStyleBackColor = false;
            this.Color10.Click += new System.EventHandler(this.Color10_Click);
            // 
            // Color9
            // 
            this.Color9.BackColor = System.Drawing.Color.RoyalBlue;
            this.Color9.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Color9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color9.BorderColor = System.Drawing.Color.SaddleBrown;
            this.Color9.BorderRadius = 15;
            this.Color9.BorderSize = 0;
            this.Color9.FlatAppearance.BorderSize = 0;
            this.Color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color9.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color9.ForeColor = System.Drawing.Color.White;
            this.Color9.Image = global::WindowsFormsApp1.Properties.Resources.Jeans;
            this.Color9.Location = new System.Drawing.Point(240, 323);
            this.Color9.Name = "Color9";
            this.Color9.Size = new System.Drawing.Size(80, 72);
            this.Color9.TabIndex = 86;
            this.Color9.Text = "גינס";
            this.Color9.TextColor = System.Drawing.Color.White;
            this.Color9.UseVisualStyleBackColor = false;
            this.Color9.Click += new System.EventHandler(this.Color9_Click);
            // 
            // Color7
            // 
            this.Color7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Color7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Color7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color7.BorderColor = System.Drawing.Color.SaddleBrown;
            this.Color7.BorderRadius = 15;
            this.Color7.BorderSize = 0;
            this.Color7.FlatAppearance.BorderSize = 0;
            this.Color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color7.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color7.ForeColor = System.Drawing.Color.Black;
            this.Color7.Location = new System.Drawing.Point(420, 323);
            this.Color7.Name = "Color7";
            this.Color7.Size = new System.Drawing.Size(80, 72);
            this.Color7.TabIndex = 85;
            this.Color7.Text = "ירוק";
            this.Color7.TextColor = System.Drawing.Color.Black;
            this.Color7.UseVisualStyleBackColor = false;
            this.Color7.Click += new System.EventHandler(this.Color7_Click);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.SaddleBrown;
            this.Color6.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.Color6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color6.BorderColor = System.Drawing.Color.SaddleBrown;
            this.Color6.BorderRadius = 15;
            this.Color6.BorderSize = 0;
            this.Color6.FlatAppearance.BorderSize = 0;
            this.Color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color6.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color6.ForeColor = System.Drawing.Color.White;
            this.Color6.Location = new System.Drawing.Point(510, 323);
            this.Color6.Name = "Color6";
            this.Color6.Size = new System.Drawing.Size(80, 72);
            this.Color6.TabIndex = 84;
            this.Color6.Text = "חום";
            this.Color6.TextColor = System.Drawing.Color.White;
            this.Color6.UseVisualStyleBackColor = false;
            this.Color6.Click += new System.EventHandler(this.Color6_Click);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Color5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Color5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color5.BorderColor = System.Drawing.Color.White;
            this.Color5.BorderRadius = 15;
            this.Color5.BorderSize = 0;
            this.Color5.FlatAppearance.BorderSize = 0;
            this.Color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color5.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color5.ForeColor = System.Drawing.Color.Black;
            this.Color5.Location = new System.Drawing.Point(600, 323);
            this.Color5.Name = "Color5";
            this.Color5.Size = new System.Drawing.Size(80, 72);
            this.Color5.TabIndex = 83;
            this.Color5.Text = "בז";
            this.Color5.TextColor = System.Drawing.Color.Black;
            this.Color5.UseVisualStyleBackColor = false;
            this.Color5.Click += new System.EventHandler(this.Color5_Click);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Color4.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.Color4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color4.BorderColor = System.Drawing.Color.White;
            this.Color4.BorderRadius = 15;
            this.Color4.BorderSize = 0;
            this.Color4.FlatAppearance.BorderSize = 0;
            this.Color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color4.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color4.ForeColor = System.Drawing.Color.White;
            this.Color4.Location = new System.Drawing.Point(690, 323);
            this.Color4.Name = "Color4";
            this.Color4.Size = new System.Drawing.Size(80, 72);
            this.Color4.TabIndex = 82;
            this.Color4.Text = "אפור";
            this.Color4.TextColor = System.Drawing.Color.White;
            this.Color4.UseVisualStyleBackColor = false;
            this.Color4.Click += new System.EventHandler(this.Color4_Click);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.Blue;
            this.Color3.BackgroundColor = System.Drawing.Color.Blue;
            this.Color3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color3.BorderColor = System.Drawing.Color.White;
            this.Color3.BorderRadius = 15;
            this.Color3.BorderSize = 0;
            this.Color3.FlatAppearance.BorderSize = 0;
            this.Color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color3.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color3.ForeColor = System.Drawing.Color.White;
            this.Color3.Location = new System.Drawing.Point(780, 321);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(80, 72);
            this.Color3.TabIndex = 81;
            this.Color3.Text = "כחול";
            this.Color3.TextColor = System.Drawing.Color.White;
            this.Color3.UseVisualStyleBackColor = false;
            this.Color3.Click += new System.EventHandler(this.Color3_Click);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.White;
            this.Color2.BackgroundColor = System.Drawing.Color.White;
            this.Color2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color2.BorderColor = System.Drawing.Color.Black;
            this.Color2.BorderRadius = 15;
            this.Color2.BorderSize = 3;
            this.Color2.FlatAppearance.BorderSize = 0;
            this.Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Color2.Location = new System.Drawing.Point(870, 322);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(80, 72);
            this.Color2.TabIndex = 80;
            this.Color2.Text = "לבן";
            this.Color2.TextColor = System.Drawing.SystemColors.ControlText;
            this.Color2.UseVisualStyleBackColor = false;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // Item9
            // 
            this.Item9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item9.BorderRadius = 15;
            this.Item9.BorderSize = 0;
            this.Item9.FlatAppearance.BorderSize = 0;
            this.Item9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item9.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9.ForeColor = System.Drawing.Color.Black;
            this.Item9.Location = new System.Drawing.Point(150, 248);
            this.Item9.Name = "Item9";
            this.Item9.Size = new System.Drawing.Size(80, 72);
            this.Item9.TabIndex = 79;
            this.Item9.Text = "תיקון כללי";
            this.Item9.TextColor = System.Drawing.Color.Black;
            this.Item9.UseVisualStyleBackColor = false;
            this.Item9.Click += new System.EventHandler(this.Item9_Click);
            // 
            // Item8
            // 
            this.Item8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item8.BorderRadius = 15;
            this.Item8.BorderSize = 0;
            this.Item8.FlatAppearance.BorderSize = 0;
            this.Item8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item8.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item8.ForeColor = System.Drawing.Color.Black;
            this.Item8.Location = new System.Drawing.Point(240, 248);
            this.Item8.Name = "Item8";
            this.Item8.Size = new System.Drawing.Size(80, 72);
            this.Item8.TabIndex = 78;
            this.Item8.Text = "החלפת רוכסן";
            this.Item8.TextColor = System.Drawing.Color.Black;
            this.Item8.UseVisualStyleBackColor = false;
            this.Item8.Click += new System.EventHandler(this.Item8_Click);
            // 
            // Item10
            // 
            this.Item10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item10.BorderRadius = 15;
            this.Item10.BorderSize = 0;
            this.Item10.FlatAppearance.BorderSize = 0;
            this.Item10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item10.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10.ForeColor = System.Drawing.Color.Black;
            this.Item10.Location = new System.Drawing.Point(330, 245);
            this.Item10.Name = "Item10";
            this.Item10.Size = new System.Drawing.Size(80, 72);
            this.Item10.TabIndex = 77;
            this.Item10.Text = "החלפת כפתור";
            this.Item10.TextColor = System.Drawing.Color.Black;
            this.Item10.UseVisualStyleBackColor = false;
            this.Item10.Click += new System.EventHandler(this.Item10_Click);
            // 
            // Item7
            // 
            this.Item7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item7.BorderRadius = 15;
            this.Item7.BorderSize = 0;
            this.Item7.FlatAppearance.BorderSize = 0;
            this.Item7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item7.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7.ForeColor = System.Drawing.Color.Black;
            this.Item7.Location = new System.Drawing.Point(420, 245);
            this.Item7.Name = "Item7";
            this.Item7.Size = new System.Drawing.Size(80, 72);
            this.Item7.TabIndex = 76;
            this.Item7.Text = "טלאי";
            this.Item7.TextColor = System.Drawing.Color.Black;
            this.Item7.UseVisualStyleBackColor = false;
            this.Item7.Click += new System.EventHandler(this.Item7_Click);
            // 
            // Item6
            // 
            this.Item6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item6.BorderRadius = 15;
            this.Item6.BorderSize = 0;
            this.Item6.FlatAppearance.BorderSize = 0;
            this.Item6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item6.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6.ForeColor = System.Drawing.Color.Black;
            this.Item6.Location = new System.Drawing.Point(510, 245);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(80, 72);
            this.Item6.TabIndex = 75;
            this.Item6.Text = "קיצור חולצה";
            this.Item6.TextColor = System.Drawing.Color.Black;
            this.Item6.UseVisualStyleBackColor = false;
            this.Item6.Click += new System.EventHandler(this.Item6_Click);
            // 
            // Item5
            // 
            this.Item5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item5.BorderRadius = 15;
            this.Item5.BorderSize = 0;
            this.Item5.FlatAppearance.BorderSize = 0;
            this.Item5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item5.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5.ForeColor = System.Drawing.Color.Black;
            this.Item5.Location = new System.Drawing.Point(600, 245);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(80, 72);
            this.Item5.TabIndex = 74;
            this.Item5.Text = "מכפלת שמלה";
            this.Item5.TextColor = System.Drawing.Color.Black;
            this.Item5.UseVisualStyleBackColor = false;
            this.Item5.Click += new System.EventHandler(this.Item5_Click);
            // 
            // Item4
            // 
            this.Item4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item4.BorderRadius = 15;
            this.Item4.BorderSize = 0;
            this.Item4.FlatAppearance.BorderSize = 0;
            this.Item4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item4.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4.ForeColor = System.Drawing.Color.Black;
            this.Item4.Location = new System.Drawing.Point(690, 245);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(80, 72);
            this.Item4.TabIndex = 73;
            this.Item4.Text = "הצרת מכנס";
            this.Item4.TextColor = System.Drawing.Color.Black;
            this.Item4.UseVisualStyleBackColor = false;
            this.Item4.Click += new System.EventHandler(this.Item4_Click);
            // 
            // Item3
            // 
            this.Item3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item3.BorderRadius = 15;
            this.Item3.BorderSize = 0;
            this.Item3.FlatAppearance.BorderSize = 0;
            this.Item3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item3.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3.ForeColor = System.Drawing.Color.Black;
            this.Item3.Location = new System.Drawing.Point(780, 245);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(80, 72);
            this.Item3.TabIndex = 72;
            this.Item3.Text = "מדים - הצרת מכנס";
            this.Item3.TextColor = System.Drawing.Color.Black;
            this.Item3.UseVisualStyleBackColor = false;
            this.Item3.Click += new System.EventHandler(this.Item3_Click);
            // 
            // Item2
            // 
            this.Item2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item2.BorderRadius = 15;
            this.Item2.BorderSize = 0;
            this.Item2.FlatAppearance.BorderSize = 0;
            this.Item2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item2.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.ForeColor = System.Drawing.Color.Black;
            this.Item2.Location = new System.Drawing.Point(870, 245);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(80, 72);
            this.Item2.TabIndex = 71;
            this.Item2.Text = "מכפלה רגילה למכנס";
            this.Item2.TextColor = System.Drawing.Color.Black;
            this.Item2.UseVisualStyleBackColor = false;
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // Item1
            // 
            this.Item1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Item1.BorderRadius = 15;
            this.Item1.BorderSize = 0;
            this.Item1.FlatAppearance.BorderSize = 0;
            this.Item1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item1.Font = new System.Drawing.Font("Secular One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.ForeColor = System.Drawing.Color.Black;
            this.Item1.Location = new System.Drawing.Point(960, 245);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(80, 72);
            this.Item1.TabIndex = 68;
            this.Item1.Text = "מכפלה מקורית";
            this.Item1.TextColor = System.Drawing.Color.Black;
            this.Item1.UseVisualStyleBackColor = false;
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.Black;
            this.Color1.BackgroundColor = System.Drawing.Color.Black;
            this.Color1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color1.BorderColor = System.Drawing.Color.White;
            this.Color1.BorderRadius = 15;
            this.Color1.BorderSize = 0;
            this.Color1.FlatAppearance.BorderSize = 0;
            this.Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color1.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color1.ForeColor = System.Drawing.Color.White;
            this.Color1.Location = new System.Drawing.Point(960, 322);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(80, 72);
            this.Color1.TabIndex = 67;
            this.Color1.Text = "שחור";
            this.Color1.TextColor = System.Drawing.Color.White;
            this.Color1.UseVisualStyleBackColor = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color8
            // 
            this.Color8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Color8.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Color8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.multicolor;
            this.Color8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Color8.BorderRadius = 15;
            this.Color8.BorderSize = 0;
            this.Color8.FlatAppearance.BorderSize = 0;
            this.Color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color8.Font = new System.Drawing.Font("Secular One", 12F);
            this.Color8.ForeColor = System.Drawing.Color.White;
            this.Color8.Location = new System.Drawing.Point(330, 323);
            this.Color8.Name = "Color8";
            this.Color8.Size = new System.Drawing.Size(80, 72);
            this.Color8.TabIndex = 66;
            this.Color8.Text = "צבעוני";
            this.Color8.TextColor = System.Drawing.Color.White;
            this.Color8.UseVisualStyleBackColor = false;
            this.Color8.Click += new System.EventHandler(this.Color8_Click);
            // 
            // DisBox
            // 
            this.DisBox.AutoSize = true;
            this.DisBox.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisBox.Location = new System.Drawing.Point(571, 553);
            this.DisBox.Name = "DisBox";
            this.DisBox.Size = new System.Drawing.Size(0, 27);
            this.DisBox.TabIndex = 98;
            // 
            // NewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 641);
            this.Controls.Add(this.DisBox);
            this.Controls.Add(this.SetDiscount);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountButton);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.Color10);
            this.Controls.Add(this.Color9);
            this.Controls.Add(this.Color7);
            this.Controls.Add(this.Color6);
            this.Controls.Add(this.Color5);
            this.Controls.Add(this.Color4);
            this.Controls.Add(this.Color3);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Item9);
            this.Controls.Add(this.Item8);
            this.Controls.Add(this.Item10);
            this.Controls.Add(this.Item7);
            this.Controls.Add(this.Item6);
            this.Controls.Add(this.Item5);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.NewC);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.Color8);
            this.Controls.Add(this.Exp2);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NewItemGrid);
            this.Name = "NewItems";
            this.Text = "NewItems";
            this.Load += new System.EventHandler(this.NewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NewItemGrid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Total;
        private MyButton Exp;
        private System.Windows.Forms.ImageList Icons;
        private MyButton Exp2;
        private MyButton Color8;
        private MyButton Color1;
        private MyButton Item1;
        private MyButton NewC;
        private System.Windows.Forms.ImageList BiggerIcons;
        private MyButton Item2;
        private MyButton Item3;
        private MyButton Item4;
        private MyButton Item5;
        private MyButton Item6;
        private MyButton Item7;
        private MyButton Item10;
        private MyButton Item8;
        private MyButton Item9;
        private MyButton Color2;
        private MyButton Color3;
        private MyButton Color4;
        private MyButton Color5;
        private MyButton Color6;
        private MyButton Color7;
        private MyButton Color9;
        private MyButton Color10;
        private System.Windows.Forms.ToolTip toolTip1;
        private MyButton SubmitOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewImageColumn Trash;
        private System.Windows.Forms.Label label2;
        private MyControls.RoundedTextBox DiscountBox;
        private MyButton DiscountButton;
        private MyButton SetDiscount;
        private MyControls.RoundedTextBox DiscountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisBox;
    }
}
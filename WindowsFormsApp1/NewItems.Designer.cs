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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItems));
            this.NewItemGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewC = new System.Windows.Forms.Button();
            this.DeleteC = new System.Windows.Forms.Button();
            this.Item1 = new System.Windows.Forms.Button();
            this.Item2 = new System.Windows.Forms.Button();
            this.Item3 = new System.Windows.Forms.Button();
            this.Item6 = new System.Windows.Forms.Button();
            this.Item5 = new System.Windows.Forms.Button();
            this.Item4 = new System.Windows.Forms.Button();
            this.Item10 = new System.Windows.Forms.Button();
            this.Item9 = new System.Windows.Forms.Button();
            this.Item8 = new System.Windows.Forms.Button();
            this.Item7 = new System.Windows.Forms.Button();
            this.Color10 = new System.Windows.Forms.Button();
            this.Color9 = new System.Windows.Forms.Button();
            this.Color8 = new System.Windows.Forms.Button();
            this.Color7 = new System.Windows.Forms.Button();
            this.Color6 = new System.Windows.Forms.Button();
            this.Color5 = new System.Windows.Forms.Button();
            this.Color4 = new System.Windows.Forms.Button();
            this.Color3 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.Color1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SetDis = new System.Windows.Forms.Button();
            this.DisBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.Exp = new WindowsFormsApp1.MyButton();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.Exp2 = new WindowsFormsApp1.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.NewItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NewItemGrid
            // 
            this.NewItemGrid.AllowUserToAddRows = false;
            this.NewItemGrid.AllowUserToDeleteRows = false;
            this.NewItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemName,
            this.Amount,
            this.Color,
            this.Note,
            this.Price,
            this.Length});
            this.NewItemGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewItemGrid.Location = new System.Drawing.Point(0, 0);
            this.NewItemGrid.Name = "NewItemGrid";
            this.NewItemGrid.ReadOnly = true;
            this.NewItemGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NewItemGrid.Size = new System.Drawing.Size(1084, 239);
            this.NewItemGrid.TabIndex = 0;
            this.NewItemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewItemGrid_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "מס\'";
            this.Id.MinimumWidth = 40;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "תיאור הפריט";
            this.ItemName.MinimumWidth = 150;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "כמות";
            this.Amount.MinimumWidth = 40;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
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
            this.Note.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "מחיר ההזמנה";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "ימי עבודה";
            this.Length.MinimumWidth = 150;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 150;
            // 
            // NewC
            // 
            this.NewC.Location = new System.Drawing.Point(652, 507);
            this.NewC.Name = "NewC";
            this.NewC.Size = new System.Drawing.Size(130, 40);
            this.NewC.TabIndex = 35;
            this.NewC.Text = "הוסף שורה";
            this.NewC.UseVisualStyleBackColor = true;
            this.NewC.Click += new System.EventHandler(this.NewC_Click);
            // 
            // DeleteC
            // 
            this.DeleteC.Location = new System.Drawing.Point(808, 507);
            this.DeleteC.Name = "DeleteC";
            this.DeleteC.Size = new System.Drawing.Size(130, 40);
            this.DeleteC.TabIndex = 36;
            this.DeleteC.Text = "מחק שורה";
            this.DeleteC.UseVisualStyleBackColor = true;
            this.DeleteC.Click += new System.EventHandler(this.DeleteC_Click);
            // 
            // Item1
            // 
            this.Item1.Location = new System.Drawing.Point(914, 245);
            this.Item1.Name = "Item1";
            this.Item1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item1.Size = new System.Drawing.Size(89, 72);
            this.Item1.TabIndex = 37;
            this.Item1.Text = "מכפלה מקורית";
            this.Item1.UseVisualStyleBackColor = true;
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Item2
            // 
            this.Item2.Location = new System.Drawing.Point(815, 245);
            this.Item2.Name = "Item2";
            this.Item2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item2.Size = new System.Drawing.Size(89, 72);
            this.Item2.TabIndex = 38;
            this.Item2.Text = "מכפלה רגילה למכנס";
            this.Item2.UseVisualStyleBackColor = true;
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // Item3
            // 
            this.Item3.Location = new System.Drawing.Point(716, 245);
            this.Item3.Name = "Item3";
            this.Item3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item3.Size = new System.Drawing.Size(89, 72);
            this.Item3.TabIndex = 39;
            this.Item3.Text = "מדים - הצרת מכנס";
            this.Item3.UseVisualStyleBackColor = true;
            this.Item3.Click += new System.EventHandler(this.Item3_Click);
            // 
            // Item6
            // 
            this.Item6.Location = new System.Drawing.Point(417, 245);
            this.Item6.Name = "Item6";
            this.Item6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item6.Size = new System.Drawing.Size(89, 72);
            this.Item6.TabIndex = 42;
            this.Item6.Text = "קיצור חולצה";
            this.Item6.UseVisualStyleBackColor = true;
            this.Item6.Click += new System.EventHandler(this.Item6_Click);
            // 
            // Item5
            // 
            this.Item5.Location = new System.Drawing.Point(516, 245);
            this.Item5.Name = "Item5";
            this.Item5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item5.Size = new System.Drawing.Size(89, 72);
            this.Item5.TabIndex = 41;
            this.Item5.Text = "מכפלת שמלה";
            this.Item5.UseVisualStyleBackColor = true;
            this.Item5.Click += new System.EventHandler(this.Item5_Click);
            // 
            // Item4
            // 
            this.Item4.Location = new System.Drawing.Point(615, 245);
            this.Item4.Name = "Item4";
            this.Item4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item4.Size = new System.Drawing.Size(89, 72);
            this.Item4.TabIndex = 40;
            this.Item4.Text = "הצרת מכנס";
            this.Item4.UseVisualStyleBackColor = true;
            this.Item4.Click += new System.EventHandler(this.Item4_Click);
            // 
            // Item10
            // 
            this.Item10.Location = new System.Drawing.Point(18, 245);
            this.Item10.Name = "Item10";
            this.Item10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item10.Size = new System.Drawing.Size(89, 72);
            this.Item10.TabIndex = 46;
            this.Item10.Text = "החלפת כפתור";
            this.Item10.UseVisualStyleBackColor = true;
            this.Item10.Click += new System.EventHandler(this.Item10_Click);
            // 
            // Item9
            // 
            this.Item9.Location = new System.Drawing.Point(117, 245);
            this.Item9.Name = "Item9";
            this.Item9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item9.Size = new System.Drawing.Size(89, 72);
            this.Item9.TabIndex = 45;
            this.Item9.Text = "תיקון כללי";
            this.Item9.UseVisualStyleBackColor = true;
            this.Item9.Click += new System.EventHandler(this.Item9_Click);
            // 
            // Item8
            // 
            this.Item8.Location = new System.Drawing.Point(216, 245);
            this.Item8.Name = "Item8";
            this.Item8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item8.Size = new System.Drawing.Size(89, 72);
            this.Item8.TabIndex = 44;
            this.Item8.Text = "החלפת רוכסן";
            this.Item8.UseVisualStyleBackColor = true;
            this.Item8.Click += new System.EventHandler(this.Item8_Click);
            // 
            // Item7
            // 
            this.Item7.Location = new System.Drawing.Point(317, 245);
            this.Item7.Name = "Item7";
            this.Item7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Item7.Size = new System.Drawing.Size(89, 72);
            this.Item7.TabIndex = 43;
            this.Item7.Text = "טלאי";
            this.Item7.UseVisualStyleBackColor = true;
            this.Item7.Click += new System.EventHandler(this.Item7_Click);
            // 
            // Color10
            // 
            this.Color10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Color10.Location = new System.Drawing.Point(18, 323);
            this.Color10.Name = "Color10";
            this.Color10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color10.Size = new System.Drawing.Size(89, 72);
            this.Color10.TabIndex = 56;
            this.Color10.Text = "וורוד";
            this.Color10.UseVisualStyleBackColor = false;
            this.Color10.Click += new System.EventHandler(this.Color10_Click);
            // 
            // Color9
            // 
            this.Color9.BackColor = System.Drawing.Color.RoyalBlue;
            this.Color9.Location = new System.Drawing.Point(117, 323);
            this.Color9.Name = "Color9";
            this.Color9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color9.Size = new System.Drawing.Size(89, 72);
            this.Color9.TabIndex = 55;
            this.Color9.Text = "גינס";
            this.Color9.UseVisualStyleBackColor = false;
            this.Color9.Click += new System.EventHandler(this.Color9_Click);
            // 
            // Color8
            // 
            this.Color8.BackColor = System.Drawing.Color.DarkRed;
            this.Color8.Location = new System.Drawing.Point(216, 323);
            this.Color8.Name = "Color8";
            this.Color8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color8.Size = new System.Drawing.Size(89, 72);
            this.Color8.TabIndex = 54;
            this.Color8.Text = "בורדו";
            this.Color8.UseVisualStyleBackColor = false;
            this.Color8.Click += new System.EventHandler(this.Color8_Click);
            // 
            // Color7
            // 
            this.Color7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Color7.Location = new System.Drawing.Point(317, 323);
            this.Color7.Name = "Color7";
            this.Color7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color7.Size = new System.Drawing.Size(89, 72);
            this.Color7.TabIndex = 53;
            this.Color7.Text = "ירוק";
            this.Color7.UseVisualStyleBackColor = false;
            this.Color7.Click += new System.EventHandler(this.Color7_Click);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.SaddleBrown;
            this.Color6.Location = new System.Drawing.Point(417, 323);
            this.Color6.Name = "Color6";
            this.Color6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color6.Size = new System.Drawing.Size(89, 72);
            this.Color6.TabIndex = 52;
            this.Color6.Text = "חום";
            this.Color6.UseVisualStyleBackColor = false;
            this.Color6.Click += new System.EventHandler(this.Color6_Click);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Color5.Location = new System.Drawing.Point(516, 323);
            this.Color5.Name = "Color5";
            this.Color5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color5.Size = new System.Drawing.Size(89, 72);
            this.Color5.TabIndex = 51;
            this.Color5.Text = "בז";
            this.Color5.UseVisualStyleBackColor = false;
            this.Color5.Click += new System.EventHandler(this.Color5_Click);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Color4.Location = new System.Drawing.Point(615, 323);
            this.Color4.Name = "Color4";
            this.Color4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color4.Size = new System.Drawing.Size(89, 72);
            this.Color4.TabIndex = 50;
            this.Color4.Text = "אפור";
            this.Color4.UseVisualStyleBackColor = false;
            this.Color4.Click += new System.EventHandler(this.Color4_Click);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.Blue;
            this.Color3.ForeColor = System.Drawing.Color.Cornsilk;
            this.Color3.Location = new System.Drawing.Point(716, 323);
            this.Color3.Name = "Color3";
            this.Color3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color3.Size = new System.Drawing.Size(89, 72);
            this.Color3.TabIndex = 49;
            this.Color3.Text = "כחול";
            this.Color3.UseVisualStyleBackColor = false;
            this.Color3.Click += new System.EventHandler(this.Color3_Click);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.White;
            this.Color2.Location = new System.Drawing.Point(815, 323);
            this.Color2.Name = "Color2";
            this.Color2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color2.Size = new System.Drawing.Size(89, 72);
            this.Color2.TabIndex = 48;
            this.Color2.Text = "לבן";
            this.Color2.UseVisualStyleBackColor = false;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Color1.ForeColor = System.Drawing.SystemColors.Control;
            this.Color1.Location = new System.Drawing.Point(914, 323);
            this.Color1.Name = "Color1";
            this.Color1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color1.Size = new System.Drawing.Size(89, 72);
            this.Color1.TabIndex = 47;
            this.Color1.Text = "שחור";
            this.Color1.UseVisualStyleBackColor = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(499, 516);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 57;
            this.label15.Text = "סכום ההזמנה: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseMnemonic = false;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total.Location = new System.Drawing.Point(427, 516);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(0, 24);
            this.Total.TabIndex = 58;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Total.UseMnemonic = false;
            // 
            // SetDis
            // 
            this.SetDis.Location = new System.Drawing.Point(202, 510);
            this.SetDis.Name = "SetDis";
            this.SetDis.Size = new System.Drawing.Size(130, 40);
            this.SetDis.TabIndex = 59;
            this.SetDis.Text = "הוסף הנחה";
            this.SetDis.UseVisualStyleBackColor = true;
            this.SetDis.Click += new System.EventHandler(this.SetDis_Click);
            // 
            // DisBox
            // 
            this.DisBox.AutoSize = true;
            this.DisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisBox.Location = new System.Drawing.Point(202, 566);
            this.DisBox.Name = "DisBox";
            this.DisBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DisBox.Size = new System.Drawing.Size(36, 20);
            this.DisBox.TabIndex = 60;
            this.DisBox.Text = "0 %";
            this.DisBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisBox.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, 566);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "הנחה של ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_checked_checkbox_48;
            this.SubmitOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitOrder.Image = global::WindowsFormsApp1.Properties.Resources.icons8_checked_checkbox_48;
            this.SubmitOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitOrder.Location = new System.Drawing.Point(12, 516);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubmitOrder.Size = new System.Drawing.Size(144, 58);
            this.SubmitOrder.TabIndex = 63;
            this.SubmitOrder.Text = "אישור הזמנה";
            this.SubmitOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
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
            this.Exp.Location = new System.Drawing.Point(40, 437);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(131, 43);
            this.Exp.TabIndex = 64;
            this.Exp.TextColor = System.Drawing.Color.Lime;
            this.Exp.UseVisualStyleBackColor = false;
            this.Exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Extra.png");
            this.Icons.Images.SetKeyName(1, "ExtraBlack.png");
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
            this.Exp2.Location = new System.Drawing.Point(202, 437);
            this.Exp2.Name = "Exp2";
            this.Exp2.Size = new System.Drawing.Size(131, 43);
            this.Exp2.TabIndex = 65;
            this.Exp2.TextColor = System.Drawing.Color.Lime;
            this.Exp2.UseVisualStyleBackColor = false;
            this.Exp2.Click += new System.EventHandler(this.Exp2_Click);
            // 
            // NewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 622);
            this.Controls.Add(this.Exp2);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisBox);
            this.Controls.Add(this.SetDis);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Color10);
            this.Controls.Add(this.Color9);
            this.Controls.Add(this.Color8);
            this.Controls.Add(this.Color7);
            this.Controls.Add(this.Color6);
            this.Controls.Add(this.Color5);
            this.Controls.Add(this.Color4);
            this.Controls.Add(this.Color3);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.Item10);
            this.Controls.Add(this.Item9);
            this.Controls.Add(this.Item8);
            this.Controls.Add(this.Item7);
            this.Controls.Add(this.Item6);
            this.Controls.Add(this.Item5);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.DeleteC);
            this.Controls.Add(this.NewC);
            this.Controls.Add(this.NewItemGrid);
            this.Name = "NewItems";
            this.Text = "NewItems";
            this.Load += new System.EventHandler(this.NewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NewItemGrid;
        private System.Windows.Forms.Button NewC;
        private System.Windows.Forms.Button DeleteC;
        private System.Windows.Forms.Button Item1;
        private System.Windows.Forms.Button Item2;
        private System.Windows.Forms.Button Item3;
        private System.Windows.Forms.Button Item6;
        private System.Windows.Forms.Button Item5;
        private System.Windows.Forms.Button Item4;
        private System.Windows.Forms.Button Item10;
        private System.Windows.Forms.Button Item9;
        private System.Windows.Forms.Button Item8;
        private System.Windows.Forms.Button Item7;
        private System.Windows.Forms.Button Color10;
        private System.Windows.Forms.Button Color9;
        private System.Windows.Forms.Button Color8;
        private System.Windows.Forms.Button Color7;
        private System.Windows.Forms.Button Color6;
        private System.Windows.Forms.Button Color5;
        private System.Windows.Forms.Button Color4;
        private System.Windows.Forms.Button Color3;
        private System.Windows.Forms.Button Color2;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button SetDis;
        private System.Windows.Forms.Label DisBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.Button SubmitOrder;
        private MyButton Exp;
        private System.Windows.Forms.ImageList Icons;
        private MyButton Exp2;
    }
}
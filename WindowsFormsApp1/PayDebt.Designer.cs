namespace WindowsFormsApp1
{
    partial class PayDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayDebt));
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.Listbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.myButton11 = new WindowsFormsApp1.MyButton();
            this.myButton10 = new WindowsFormsApp1.MyButton();
            this.myButton9 = new WindowsFormsApp1.MyButton();
            this.myButton8 = new WindowsFormsApp1.MyButton();
            this.myButton7 = new WindowsFormsApp1.MyButton();
            this.myButton6 = new WindowsFormsApp1.MyButton();
            this.myButton5 = new WindowsFormsApp1.MyButton();
            this.myButton4 = new WindowsFormsApp1.MyButton();
            this.myButton2 = new WindowsFormsApp1.MyButton();
            this.myButton1 = new WindowsFormsApp1.MyButton();
            this.CancelB = new WindowsFormsApp1.MyButton();
            this.Submit = new WindowsFormsApp1.MyButton();
            this.myButton3 = new WindowsFormsApp1.MyButton();
            this.SuspendLayout();
            // 
            // AmountBox
            // 
            this.AmountBox.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountBox.Location = new System.Drawing.Point(35, 99);
            this.AmountBox.MinimumSize = new System.Drawing.Size(4, 40);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(322, 35);
            this.AmountBox.TabIndex = 13;
            this.AmountBox.Enter += new System.EventHandler(this.AmountBox_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(115, 34);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(168, 27);
            this.label17.TabIndex = 16;
            this.label17.Text = "הסכום לתשלום הוא:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.UseMnemonic = false;
            // 
            // AmountText
            // 
            this.AmountText.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountText.Location = new System.Drawing.Point(104, 62);
            this.AmountText.Name = "AmountText";
            this.AmountText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AmountText.Size = new System.Drawing.Size(185, 24);
            this.AmountText.TabIndex = 17;
            this.AmountText.Text = "150";
            this.AmountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AmountText.UseMnemonic = false;
            // 
            // Listbox
            // 
            this.Listbox.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Listbox.Items.AddRange(new object[] {
            "ביט",
            "כרטיס אשראי",
            "מזומן"});
            this.Listbox.Location = new System.Drawing.Point(35, 388);
            this.Listbox.Name = "Listbox";
            this.Listbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Listbox.Size = new System.Drawing.Size(322, 35);
            this.Listbox.TabIndex = 18;
            this.Listbox.Click += new System.EventHandler(this.Listbox_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Secular One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 358);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "סוג תשלום:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "YesIcon.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CancelItem.png");
            // 
            // myButton11
            // 
            this.myButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton11.BorderRadius = 15;
            this.myButton11.BorderSize = 0;
            this.myButton11.FlatAppearance.BorderSize = 0;
            this.myButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton11.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton11.ForeColor = System.Drawing.Color.Black;
            this.myButton11.Location = new System.Drawing.Point(279, 220);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(76, 127);
            this.myButton11.TabIndex = 81;
            this.myButton11.Text = "C";
            this.myButton11.TextColor = System.Drawing.Color.Black;
            this.myButton11.UseVisualStyleBackColor = false;
            this.myButton11.Click += new System.EventHandler(this.myButton11_Click);
            // 
            // myButton10
            // 
            this.myButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton10.BorderRadius = 15;
            this.myButton10.BorderSize = 0;
            this.myButton10.FlatAppearance.BorderSize = 0;
            this.myButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton10.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton10.ForeColor = System.Drawing.Color.Black;
            this.myButton10.Location = new System.Drawing.Point(37, 286);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(76, 61);
            this.myButton10.TabIndex = 80;
            this.myButton10.Text = "7";
            this.myButton10.TextColor = System.Drawing.Color.Black;
            this.myButton10.UseVisualStyleBackColor = false;
            this.myButton10.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton9
            // 
            this.myButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton9.BorderRadius = 15;
            this.myButton9.BorderSize = 0;
            this.myButton9.FlatAppearance.BorderSize = 0;
            this.myButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton9.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton9.ForeColor = System.Drawing.Color.Black;
            this.myButton9.Location = new System.Drawing.Point(117, 286);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(76, 61);
            this.myButton9.TabIndex = 79;
            this.myButton9.Text = "8";
            this.myButton9.TextColor = System.Drawing.Color.Black;
            this.myButton9.UseVisualStyleBackColor = false;
            this.myButton9.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton8
            // 
            this.myButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton8.BorderRadius = 15;
            this.myButton8.BorderSize = 0;
            this.myButton8.FlatAppearance.BorderSize = 0;
            this.myButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton8.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton8.ForeColor = System.Drawing.Color.Black;
            this.myButton8.Location = new System.Drawing.Point(199, 286);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(76, 61);
            this.myButton8.TabIndex = 78;
            this.myButton8.Text = "9";
            this.myButton8.TextColor = System.Drawing.Color.Black;
            this.myButton8.UseVisualStyleBackColor = false;
            this.myButton8.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton7
            // 
            this.myButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton7.BorderRadius = 15;
            this.myButton7.BorderSize = 0;
            this.myButton7.FlatAppearance.BorderSize = 0;
            this.myButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton7.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton7.ForeColor = System.Drawing.Color.Black;
            this.myButton7.Location = new System.Drawing.Point(117, 152);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(76, 61);
            this.myButton7.TabIndex = 77;
            this.myButton7.Text = "2";
            this.myButton7.TextColor = System.Drawing.Color.Black;
            this.myButton7.UseVisualStyleBackColor = false;
            this.myButton7.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton6.BorderRadius = 15;
            this.myButton6.BorderSize = 0;
            this.myButton6.FlatAppearance.BorderSize = 0;
            this.myButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton6.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton6.ForeColor = System.Drawing.Color.Black;
            this.myButton6.Location = new System.Drawing.Point(35, 220);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(76, 61);
            this.myButton6.TabIndex = 76;
            this.myButton6.Text = "4";
            this.myButton6.TextColor = System.Drawing.Color.Black;
            this.myButton6.UseVisualStyleBackColor = false;
            this.myButton6.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton5.BorderRadius = 15;
            this.myButton5.BorderSize = 0;
            this.myButton5.FlatAppearance.BorderSize = 0;
            this.myButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton5.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton5.ForeColor = System.Drawing.Color.Black;
            this.myButton5.Location = new System.Drawing.Point(199, 152);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(76, 61);
            this.myButton5.TabIndex = 75;
            this.myButton5.Text = "3";
            this.myButton5.TextColor = System.Drawing.Color.Black;
            this.myButton5.UseVisualStyleBackColor = false;
            this.myButton5.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton4.BorderRadius = 15;
            this.myButton4.BorderSize = 0;
            this.myButton4.FlatAppearance.BorderSize = 0;
            this.myButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton4.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton4.ForeColor = System.Drawing.Color.Black;
            this.myButton4.Location = new System.Drawing.Point(117, 220);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(76, 61);
            this.myButton4.TabIndex = 74;
            this.myButton4.Text = "5";
            this.myButton4.TextColor = System.Drawing.Color.Black;
            this.myButton4.UseVisualStyleBackColor = false;
            this.myButton4.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton2.BorderRadius = 15;
            this.myButton2.BorderSize = 0;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.Location = new System.Drawing.Point(199, 219);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(76, 61);
            this.myButton2.TabIndex = 73;
            this.myButton2.Text = "6";
            this.myButton2.TextColor = System.Drawing.Color.Black;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton1.BorderRadius = 15;
            this.myButton1.BorderSize = 0;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(35, 152);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(76, 61);
            this.myButton1.TabIndex = 72;
            this.myButton1.Text = "1";
            this.myButton1.TextColor = System.Drawing.Color.Black;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // CancelB
            // 
            this.CancelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelB.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelB.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.CancelB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.CancelB.BorderRadius = 15;
            this.CancelB.BorderSize = 0;
            this.CancelB.FlatAppearance.BorderSize = 0;
            this.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelB.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.ForeColor = System.Drawing.Color.Black;
            this.CancelB.ImageKey = "CancelItem.png";
            this.CancelB.ImageList = this.imageList1;
            this.CancelB.Location = new System.Drawing.Point(133, 496);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(126, 39);
            this.CancelB.TabIndex = 71;
            this.CancelB.TextColor = System.Drawing.Color.Black;
            this.CancelB.UseVisualStyleBackColor = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Submit.BackgroundColor = System.Drawing.Color.LightGreen;
            this.Submit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.Submit.BorderRadius = 15;
            this.Submit.BorderSize = 0;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.Black;
            this.Submit.ImageKey = "YesIcon.png";
            this.Submit.ImageList = this.Icons;
            this.Submit.Location = new System.Drawing.Point(35, 429);
            this.Submit.Name = "Submit";
            this.Submit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Submit.Size = new System.Drawing.Size(322, 61);
            this.Submit.TabIndex = 70;
            this.Submit.TextColor = System.Drawing.Color.Black;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.myButton3.BorderRadius = 15;
            this.myButton3.BorderSize = 0;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.Font = new System.Drawing.Font("Secular One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton3.ForeColor = System.Drawing.Color.Black;
            this.myButton3.Location = new System.Drawing.Point(281, 152);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(76, 61);
            this.myButton3.TabIndex = 69;
            this.myButton3.Text = "0";
            this.myButton3.TextColor = System.Drawing.Color.Black;
            this.myButton3.UseVisualStyleBackColor = false;
            this.myButton3.Click += new System.EventHandler(this.AddTextToTextBox);
            // 
            // PayDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 547);
            this.Controls.Add(this.myButton11);
            this.Controls.Add(this.myButton10);
            this.Controls.Add(this.myButton9);
            this.Controls.Add(this.myButton8);
            this.Controls.Add(this.myButton7);
            this.Controls.Add(this.myButton6);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.AmountBox);
            this.KeyPreview = true;
            this.Name = "PayDebt";
            this.Text = "PayDebt";
            this.Load += new System.EventHandler(this.PayDebt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PayDebt_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.ComboBox Listbox;
        private System.Windows.Forms.Label label1;
        private MyButton myButton3;
        private MyButton Submit;
        private MyButton CancelB;
        private System.Windows.Forms.ImageList Icons;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton4;
        private MyButton myButton5;
        private MyButton myButton6;
        private MyButton myButton7;
        private MyButton myButton8;
        private MyButton myButton9;
        private MyButton myButton10;
        private MyButton myButton11;
        private System.Windows.Forms.ImageList imageList1;
    }
}
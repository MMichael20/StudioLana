namespace WindowsFormsApp1
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Passm = new System.Windows.Forms.Label();
            this.Idm = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Passm);
            this.groupBox1.Controls.Add(this.Idm);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(59, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Passm
            // 
            this.Passm.AutoSize = true;
            this.Passm.ForeColor = System.Drawing.Color.Red;
            this.Passm.Location = new System.Drawing.Point(22, 98);
            this.Passm.Name = "Passm";
            this.Passm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Passm.Size = new System.Drawing.Size(0, 13);
            this.Passm.TabIndex = 14;
            // 
            // Idm
            // 
            this.Idm.AutoSize = true;
            this.Idm.ForeColor = System.Drawing.Color.Red;
            this.Idm.Location = new System.Drawing.Point(22, 43);
            this.Idm.Name = "Idm";
            this.Idm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Idm.Size = new System.Drawing.Size(0, 13);
            this.Idm.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(84, 37);
            this.Id.MinimumSize = new System.Drawing.Size(245, 25);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(245, 20);
            this.Id.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "שם משתמש:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(84, 91);
            this.Pass.MinimumSize = new System.Drawing.Size(245, 25);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(245, 20);
            this.Pass.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(335, 91);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(65, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "סיסמא:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.UseMnemonic = false;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(234, 511);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(114, 44);
            this.Go.TabIndex = 13;
            this.Go.Text = "כניסה";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Lana;
            this.pictureBox1.Location = new System.Drawing.Point(143, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 567);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label Passm;
        private System.Windows.Forms.Label Idm;
    }
}
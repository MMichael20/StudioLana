namespace WindowsFormsApp1
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.UserInput = new WindowsFormsApp1.MyControls.RoundedTextBox();
            this.YesIcon = new WindowsFormsApp1.MyButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Secular One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(198, 143);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChangeLabel.Size = new System.Drawing.Size(55, 30);
            this.ChangeLabel.TabIndex = 0;
            this.ChangeLabel.Text = "בחר:";
            // 
            // UserInput
            // 
            this.UserInput.BackColor = System.Drawing.SystemColors.Window;
            this.UserInput.BorderColor = System.Drawing.Color.MediumBlue;
            this.UserInput.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.UserInput.BorderRadius = 15;
            this.UserInput.BorderSize = 2;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserInput.Location = new System.Drawing.Point(99, 177);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4);
            this.UserInput.Multiline = false;
            this.UserInput.Name = "UserInput";
            this.UserInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UserInput.PasswordChar = false;
            this.UserInput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UserInput.PlaceholderText = "";
            this.UserInput.Size = new System.Drawing.Size(250, 31);
            this.UserInput.TabIndex = 1;
            this.UserInput.Texts = "";
            this.UserInput.UnderlinedStyle = false;
            // 
            // YesIcon
            // 
            this.YesIcon.BackColor = System.Drawing.Color.LightSalmon;
            this.YesIcon.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.YesIcon.BorderColor = System.Drawing.Color.LavenderBlush;
            this.YesIcon.BorderRadius = 20;
            this.YesIcon.BorderSize = 0;
            this.YesIcon.FlatAppearance.BorderSize = 0;
            this.YesIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesIcon.ForeColor = System.Drawing.Color.Lime;
            this.YesIcon.ImageKey = "YesIcon.png";
            this.YesIcon.ImageList = this.imageList1;
            this.YesIcon.Location = new System.Drawing.Point(169, 215);
            this.YesIcon.Name = "YesIcon";
            this.YesIcon.Size = new System.Drawing.Size(118, 43);
            this.YesIcon.TabIndex = 26;
            this.YesIcon.TextColor = System.Drawing.Color.Lime;
            this.YesIcon.UseVisualStyleBackColor = false;
            this.YesIcon.Click += new System.EventHandler(this.YesIcon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "YesIcon.png");
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 353);
            this.Controls.Add(this.YesIcon);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.ChangeLabel);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeLabel;
        private MyControls.RoundedTextBox UserInput;
        private MyButton YesIcon;
        private System.Windows.Forms.ImageList imageList1;
    }
}
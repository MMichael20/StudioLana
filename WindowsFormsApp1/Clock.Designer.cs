namespace WindowsFormsApp1
{
    partial class Clock
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
            this.WorkersList = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkersList
            // 
            this.WorkersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkersList.FormattingEnabled = true;
            this.WorkersList.Items.AddRange(new object[] {
            "אינה"});
            this.WorkersList.Location = new System.Drawing.Point(261, 165);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(238, 33);
            this.WorkersList.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(505, 169);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(52, 24);
            this.label26.TabIndex = 17;
            this.label26.Text = "עובד:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.UseMnemonic = false;
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndButton.Location = new System.Drawing.Point(281, 232);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(96, 50);
            this.EndButton.TabIndex = 54;
            this.EndButton.Text = "יציאה";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(403, 232);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 50);
            this.StartButton.TabIndex = 55;
            this.StartButton.Text = "כניסה";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.WorkersList);
            this.Name = "Clock";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WorkersList;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button StartButton;
    }
}
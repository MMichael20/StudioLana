namespace WindowsFormsApp1
{
    partial class SetNote
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
            this.Msg = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SumbitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Msg.ForeColor = System.Drawing.Color.Red;
            this.Msg.Location = new System.Drawing.Point(400, 236);
            this.Msg.Name = "Msg";
            this.Msg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Msg.Size = new System.Drawing.Size(0, 20);
            this.Msg.TabIndex = 43;
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Msg.UseMnemonic = false;
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(231, 202);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(339, 20);
            this.NoteBox.TabIndex = 42;
            this.NoteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(377, 155);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 41;
            this.label13.Text = "הערה";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.UseMnemonic = false;
            // 
            // SumbitB
            // 
            this.SumbitB.Location = new System.Drawing.Point(335, 271);
            this.SumbitB.Name = "SumbitB";
            this.SumbitB.Size = new System.Drawing.Size(130, 24);
            this.SumbitB.TabIndex = 40;
            this.SumbitB.Text = "אישור";
            this.SumbitB.UseVisualStyleBackColor = true;
            this.SumbitB.Click += new System.EventHandler(this.SumbitB_Click);
            // 
            // SetNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SumbitB);
            this.Name = "SetNote";
            this.Text = "ChangeNote";
            this.Load += new System.EventHandler(this.SetNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SumbitB;
    }
}
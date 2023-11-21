namespace WindowsFormsApp1
{
    partial class PaymentStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CheckTable = new System.Windows.Forms.DataGridView();
            this.CheckId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.Label();
            this.BitLabel = new System.Windows.Forms.Label();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(821, 23);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(245, 186);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "סוגי תשלומים";
            this.Chart1.Titles.Add(title1);
            // 
            // CheckTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CheckTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CheckTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckId,
            this.CheckName,
            this.UserName,
            this.CheckPrice,
            this.CheckDate,
            this.TypeName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.CheckTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckTable.Location = new System.Drawing.Point(0, 237);
            this.CheckTable.Name = "CheckTable";
            this.CheckTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckTable.Size = new System.Drawing.Size(1137, 344);
            this.CheckTable.TabIndex = 1;
            // 
            // CheckId
            // 
            this.CheckId.DataPropertyName = "CheckId";
            this.CheckId.HeaderText = "מס\'";
            this.CheckId.MinimumWidth = 20;
            this.CheckId.Name = "CheckId";
            // 
            // CheckName
            // 
            this.CheckName.DataPropertyName = "CheckName";
            this.CheckName.HeaderText = "שם הקבלה";
            this.CheckName.Name = "CheckName";
            this.CheckName.Width = 250;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "שם הלקוח";
            this.UserName.Name = "UserName";
            this.UserName.Width = 200;
            // 
            // CheckPrice
            // 
            this.CheckPrice.DataPropertyName = "CheckPrice";
            this.CheckPrice.HeaderText = "תשלום";
            this.CheckPrice.Name = "CheckPrice";
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckDate.DataPropertyName = "CheckDate";
            this.CheckDate.FillWeight = 200F;
            this.CheckDate.HeaderText = "תאריך";
            this.CheckDate.Name = "CheckDate";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "סוג";
            this.TypeName.Name = "TypeName";
            // 
            // Total
            // 
            this.Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(615, 52);
            this.Total.MinimumSize = new System.Drawing.Size(200, 0);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(200, 13);
            this.Total.TabIndex = 2;
            this.Total.Text = "מספר תשלומים כולל";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BitLabel
            // 
            this.BitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BitLabel.AutoSize = true;
            this.BitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BitLabel.Location = new System.Drawing.Point(615, 93);
            this.BitLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.BitLabel.Name = "BitLabel";
            this.BitLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BitLabel.Size = new System.Drawing.Size(200, 13);
            this.BitLabel.TabIndex = 3;
            this.BitLabel.Text = "מספר תשלומים בביט";
            this.BitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreditLabel
            // 
            this.CreditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditLabel.Location = new System.Drawing.Point(615, 131);
            this.CreditLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreditLabel.Size = new System.Drawing.Size(200, 13);
            this.CreditLabel.TabIndex = 4;
            this.CreditLabel.Text = "מספר תשלומים באשראי";
            this.CreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CashLabel.Location = new System.Drawing.Point(615, 171);
            this.CashLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CashLabel.Size = new System.Drawing.Size(200, 13);
            this.CashLabel.TabIndex = 5;
            this.CashLabel.Text = "מספר תשלומים בביט";
            this.CashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(194, 122);
            this.label1.MinimumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "לפי תאריך:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(84, 125);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 20);
            this.FromDate.TabIndex = 7;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 124);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "מיין";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "מיין";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(84, 164);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 20);
            this.ToDate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 161);
            this.label2.MinimumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "עד לתאריך:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.BitLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.CheckTable);
            this.Controls.Add(this.Chart1);
            this.Name = "PaymentStats";
            this.Text = "PaymentStats";
            this.Load += new System.EventHandler(this.PaymentStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.DataGridView CheckTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label BitLabel;
        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label label2;
    }
}
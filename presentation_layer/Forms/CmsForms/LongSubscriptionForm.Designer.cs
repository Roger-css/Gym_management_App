﻿namespace presentation_layer.Forms.CmsForms
{
    partial class LongSubscriptionForm
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
            this.SubPrices = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlUp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.TbPaid = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.PnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubPrices
            // 
            this.SubPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubPrices.Cursor = System.Windows.Forms.Cursors.Default;
            this.SubPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubPrices.FormatString = "N0";
            this.SubPrices.FormattingEnabled = true;
            this.SubPrices.ItemHeight = 32;
            this.SubPrices.Items.AddRange(new object[] {
            "0",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000"});
            this.SubPrices.Location = new System.Drawing.Point(368, 215);
            this.SubPrices.Name = "SubPrices";
            this.SubPrices.Size = new System.Drawing.Size(154, 36);
            this.SubPrices.TabIndex = 35;
            this.SubPrices.SelectedValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = ":سعر الاشتراك";
            // 
            // DtpEnd
            // 
            this.DtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEnd.CalendarForeColor = System.Drawing.Color.Black;
            this.DtpEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEnd.Location = new System.Drawing.Point(317, 566);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(201, 39);
            this.DtpEnd.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = ":بداية الاشتراك";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = ":نهاية الاشتراك";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = ":اسم اللاعب";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = ":المبلغ المدفوع";
            // 
            // PnlUp
            // 
            this.PnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.PnlUp.Controls.Add(this.label2);
            this.PnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUp.Location = new System.Drawing.Point(0, 0);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(785, 96);
            this.PnlUp.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(493, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "تجديد الاشتراك اليدوي";
            // 
            // DtpStart
            // 
            this.DtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.CalendarForeColor = System.Drawing.Color.Black;
            this.DtpStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStart.Location = new System.Drawing.Point(317, 480);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(201, 39);
            this.DtpStart.TabIndex = 25;
            this.DtpStart.Value = new System.DateTime(2024, 10, 10, 19, 16, 55, 0);
            this.DtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // TbPaid
            // 
            this.TbPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPaid.Location = new System.Drawing.Point(368, 298);
            this.TbPaid.Name = "TbPaid";
            this.TbPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbPaid.Size = new System.Drawing.Size(154, 39);
            this.TbPaid.TabIndex = 23;
            this.TbPaid.TextChanged += new System.EventHandler(this.PaidAmount_valueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(536, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 21;
            this.button1.Text = "اشتراك";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(362, 134);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(115, 32);
            this.LblName.TabIndex = 36;
            this.LblName.Text = "غير معرف";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = ":موعد الدفع";
            // 
            // DtpPayDate
            // 
            this.DtpPayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpPayDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPayDate.CalendarForeColor = System.Drawing.Color.Black;
            this.DtpPayDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtpPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPayDate.Location = new System.Drawing.Point(321, 391);
            this.DtpPayDate.Name = "DtpPayDate";
            this.DtpPayDate.Size = new System.Drawing.Size(201, 39);
            this.DtpPayDate.TabIndex = 37;
            // 
            // LongSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpPayDate);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.SubPrices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpStart);
            this.Controls.Add(this.TbPaid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PnlUp);
            this.MaximizeBox = false;
            this.Name = "LongSubscriptionForm";
            this.Text = "LongSubscriptionForm";
            this.Load += new System.EventHandler(this.LongSubscriptionForm_Load);
            this.PnlUp.ResumeLayout(false);
            this.PnlUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox SubPrices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.MaskedTextBox TbPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpPayDate;
    }
}
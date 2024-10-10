namespace presentation_layer
{
    partial class AddPlayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PayDate = new System.Windows.Forms.DateTimePicker();
            this.LbPrices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.TbPaidPrice = new System.Windows.Forms.MaskedTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.OfdPicture = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PayDate);
            this.panel1.Controls.Add(this.LbPrices);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DtpEndDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DtpStartDate);
            this.panel1.Controls.Add(this.TbPaidPrice);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TbPhone);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 955);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1063, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 40);
            this.label2.TabIndex = 41;
            this.label2.Text = ":تاريخ الدفع";
            // 
            // PayDate
            // 
            this.PayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PayDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDate.CalendarForeColor = System.Drawing.Color.Black;
            this.PayDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.PayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PayDate.Location = new System.Drawing.Point(960, 559);
            this.PayDate.Name = "PayDate";
            this.PayDate.Size = new System.Drawing.Size(259, 48);
            this.PayDate.TabIndex = 40;
            // 
            // LbPrices
            // 
            this.LbPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPrices.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrices.FormatString = "N0";
            this.LbPrices.FormattingEnabled = true;
            this.LbPrices.ItemHeight = 40;
            this.LbPrices.Items.AddRange(new object[] {
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
            this.LbPrices.Location = new System.Drawing.Point(960, 424);
            this.LbPrices.MinimumSize = new System.Drawing.Size(211, 44);
            this.LbPrices.Name = "LbPrices";
            this.LbPrices.Size = new System.Drawing.Size(259, 44);
            this.LbPrices.TabIndex = 39;
            this.LbPrices.SelectedValueChanged += new System.EventHandler(this.Lb_valueChange);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1023, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = ":سعر الاشتراك";
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.CalendarForeColor = System.Drawing.Color.Black;
            this.DtpEndDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtpEndDate.CustomFormat = "";
            this.DtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEndDate.Location = new System.Drawing.Point(631, 693);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(259, 48);
            this.DtpEndDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1024, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 40);
            this.label7.TabIndex = 36;
            this.label7.Text = ":بداية الاشتراك";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(693, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 40);
            this.label6.TabIndex = 35;
            this.label6.Text = ":نهاية الاشتراك";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(719, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 40);
            this.label9.TabIndex = 34;
            this.label9.Text = ":المبلغ المدفوع";
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.CalendarForeColor = System.Drawing.Color.Black;
            this.DtpStartDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStartDate.Location = new System.Drawing.Point(960, 693);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(259, 48);
            this.DtpStartDate.TabIndex = 33;
            this.DtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);
            // 
            // TbPaidPrice
            // 
            this.TbPaidPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPaidPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPaidPrice.Location = new System.Drawing.Point(633, 424);
            this.TbPaidPrice.Name = "TbPaidPrice";
            this.TbPaidPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbPaidPrice.Size = new System.Drawing.Size(259, 48);
            this.TbPaidPrice.TabIndex = 32;
            this.TbPaidPrice.TextChanged += new System.EventHandler(this.PaidAmount_valueChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(1101, 781);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(116, 61);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1057, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = ":اسم اللاعب";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1068, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 40);
            this.label3.TabIndex = 25;
            this.label3.Text = ":رقم الهاتف";
            // 
            // TbPhone
            // 
            this.TbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPhone.Location = new System.Drawing.Point(633, 268);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbPhone.Size = new System.Drawing.Size(586, 48);
            this.TbPhone.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(89, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TbName
            // 
            this.TbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.Location = new System.Drawing.Point(633, 118);
            this.TbName.Name = "TbName";
            this.TbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbName.Size = new System.Drawing.Size(586, 48);
            this.TbName.TabIndex = 20;
            // 
            // OfdPicture
            // 
            this.OfdPicture.FileName = "openFileDialog1";
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 955);
            this.Controls.Add(this.panel1);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TbPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.ListBox LbPrices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.MaskedTextBox TbPaidPrice;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.OpenFileDialog OfdPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PayDate;
    }
}
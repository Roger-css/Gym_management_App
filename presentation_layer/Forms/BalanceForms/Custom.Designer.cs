namespace presentation_layer.Forms.BalanceForms
{
    partial class Custom
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(817, 201);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(108, 29);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "نهاية التاريخ";
            // 
            // DtpStart
            // 
            this.DtpStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtpStart.CustomFormat = "yyyy-mm-dd";
            this.DtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.Location = new System.Drawing.Point(367, 78);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(414, 44);
            this.DtpStart.TabIndex = 6;
            this.DtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(819, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "بداية التاريخ";
            // 
            // DtpEnd
            // 
            this.DtpEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtpEnd.CustomFormat = "yyyy-mm-dd";
            this.DtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEnd.Location = new System.Drawing.Point(367, 189);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(414, 44);
            this.DtpEnd.TabIndex = 8;
            this.DtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.DtpStart);
            this.Name = "Custom";
            this.Text = "Custom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpEnd;
    }
}
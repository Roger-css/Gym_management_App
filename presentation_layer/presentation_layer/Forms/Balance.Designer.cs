namespace presentation_layer.Forms
{
    partial class Balance
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CbCalcType = new System.Windows.Forms.ComboBox();
            this.Test = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbCalcType
            // 
            this.CbCalcType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbCalcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCalcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbCalcType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCalcType.FormattingEnabled = true;
            this.CbCalcType.Items.AddRange(new object[] {
            "جميع السنين",
            "سنوي",
            "شهري",
            "يومي",
            "يدوي"});
            this.CbCalcType.Location = new System.Drawing.Point(502, 22);
            this.CbCalcType.Name = "CbCalcType";
            this.CbCalcType.Size = new System.Drawing.Size(251, 45);
            this.CbCalcType.TabIndex = 6;
            this.CbCalcType.SelectedValueChanged += new System.EventHandler(this.ValueChanged_event);
            // 
            // Test
            // 
            this.Test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Test.AutoSize = true;
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.ForeColor = System.Drawing.Color.Black;
            this.Test.Location = new System.Drawing.Point(792, 31);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(118, 29);
            this.Test.TabIndex = 8;
            this.Test.Text = "طرق الحساب";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Test);
            this.panel2.Controls.Add(this.CbCalcType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 93);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 487);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormsPanel
            // 
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormsPanel.Location = new System.Drawing.Point(0, 93);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1303, 214);
            this.FormsPanel.TabIndex = 9;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 580);
            this.Controls.Add(this.FormsPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox CbCalcType;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel FormsPanel;
    }
}
﻿namespace presentation_layer.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CbCalcType = new System.Windows.Forms.ComboBox();
            this.Test = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
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
            "سنوي",
            "شهري",
            "يومي",
            "يدوي"});
            this.CbCalcType.Location = new System.Drawing.Point(502, 67);
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
            this.Test.Location = new System.Drawing.Point(774, 76);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(118, 29);
            this.Test.TabIndex = 8;
            this.Test.Text = "طرق الحساب";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblTotalAmount);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Test);
            this.panel2.Controls.Add(this.CbCalcType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 183);
            this.panel2.TabIndex = 7;
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.LblTotalAmount.Location = new System.Drawing.Point(85, 75);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(35, 37);
            this.LblTotalAmount.TabIndex = 10;
            this.LblTotalAmount.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1019, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 75);
            this.button1.TabIndex = 9;
            this.button1.Text = "حساب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 385);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv.RowTemplate.Height = 28;
            this.Dgv.Size = new System.Drawing.Size(1303, 195);
            this.Dgv.TabIndex = 8;
            // 
            // FormsPanel
            // 
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormsPanel.Location = new System.Drawing.Point(0, 183);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1303, 202);
            this.FormsPanel.TabIndex = 9;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 580);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.FormsPanel);
            this.Controls.Add(this.panel2);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox CbCalcType;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Panel FormsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblTotalAmount;
    }
}
﻿namespace presentation_layer.Forms
{
    partial class NoSubsPlayers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.LblSearchMethod = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.CmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddSub = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.CmsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBSearch);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.LblSearchMethod);
            this.panel1.Controls.Add(this.TbSearch);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 178);
            this.panel1.TabIndex = 12;
            // 
            // CBSearch
            // 
            this.CBSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Items.AddRange(new object[] {
            "الاسم",
            "رقم البطاقة"});
            this.CBSearch.Location = new System.Drawing.Point(162, 86);
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(167, 45);
            this.CBSearch.TabIndex = 5;
            this.CBSearch.SelectedIndexChanged += new System.EventHandler(this.CBSearch_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.RefreshBtn.Image = global::presentation_layer.Properties.Resources.Refresh1;
            this.RefreshBtn.Location = new System.Drawing.Point(1162, 121);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(43, 42);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LblSearchMethod
            // 
            this.LblSearchMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSearchMethod.AutoSize = true;
            this.LblSearchMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchMethod.ForeColor = System.Drawing.Color.Black;
            this.LblSearchMethod.Location = new System.Drawing.Point(424, 26);
            this.LblSearchMethod.Name = "LblSearchMethod";
            this.LblSearchMethod.Size = new System.Drawing.Size(182, 46);
            this.LblSearchMethod.TabIndex = 2;
            this.LblSearchMethod.Text = ":اسم اللاعب";
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearch.Location = new System.Drawing.Point(384, 86);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbSearch.Size = new System.Drawing.Size(250, 44);
            this.TbSearch.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.Location = new System.Drawing.Point(697, 72);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 71);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.ContextMenuStrip = this.CmsList;
            this.DgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvList.Location = new System.Drawing.Point(0, 178);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvList.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvList.RowTemplate.Height = 35;
            this.DgvList.Size = new System.Drawing.Size(1217, 416);
            this.DgvList.TabIndex = 13;
            // 
            // CmsList
            // 
            this.CmsList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSub});
            this.CmsList.Name = "contextMenuStrip1";
            this.CmsList.Size = new System.Drawing.Size(252, 48);
            // 
            // AddSub
            // 
            this.AddSub.Name = "AddSub";
            this.AddSub.Size = new System.Drawing.Size(251, 44);
            this.AddSub.Text = "اضافة اشتراك";
            this.AddSub.Click += new System.EventHandler(this.AddSub_Click);
            // 
            // NoSubsPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 594);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.panel1);
            this.Name = "NoSubsPlayers";
            this.Text = "noSubsPlayers";
            this.Load += new System.EventHandler(this.NoSubsPlayers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.CmsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label LblSearchMethod;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ContextMenuStrip CmsList;
        private System.Windows.Forms.ToolStripMenuItem AddSub;
    }
}
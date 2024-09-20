namespace presentation_layer
{
    partial class SearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowAutoCompleteCheckBox = new System.Windows.Forms.CheckBox();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.LblSearchMethod = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلبياناتاللاعبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تجديدالاشتراكToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickSubBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualSubBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSub = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoCompleteList = new System.Windows.Forms.ListBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.CmsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowAutoCompleteCheckBox);
            this.panel1.Controls.Add(this.CBSearch);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.LblSearchMethod);
            this.panel1.Controls.Add(this.TbSearch);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 178);
            this.panel1.TabIndex = 4;
            // 
            // ShowAutoCompleteCheckBox
            // 
            this.ShowAutoCompleteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAutoCompleteCheckBox.AutoSize = true;
            this.ShowAutoCompleteCheckBox.Checked = true;
            this.ShowAutoCompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAutoCompleteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAutoCompleteCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAutoCompleteCheckBox.Location = new System.Drawing.Point(1004, 59);
            this.ShowAutoCompleteCheckBox.Name = "ShowAutoCompleteCheckBox";
            this.ShowAutoCompleteCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.ShowAutoCompleteCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowAutoCompleteCheckBox.Size = new System.Drawing.Size(174, 56);
            this.ShowAutoCompleteCheckBox.TabIndex = 6;
            this.ShowAutoCompleteCheckBox.Text = "تكملة النص";
            this.ShowAutoCompleteCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowAutoCompleteCheckBox.UseVisualStyleBackColor = true;
            this.ShowAutoCompleteCheckBox.CheckedChanged += new System.EventHandler(this.ShowAutoCompleteCheckBox_CheckedChanged);
            // 
            // CBSearch
            // 
            this.CBSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Items.AddRange(new object[] {
            "الاسم",
            "رقم البطاقة",
            "رقم الهاتف"});
            this.CBSearch.Location = new System.Drawing.Point(149, 86);
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
            this.RefreshBtn.Location = new System.Drawing.Point(1135, 121);
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
            this.LblSearchMethod.Location = new System.Drawing.Point(425, 37);
            this.LblSearchMethod.Name = "LblSearchMethod";
            this.LblSearchMethod.Size = new System.Drawing.Size(182, 46);
            this.LblSearchMethod.TabIndex = 2;
            this.LblSearchMethod.Text = ":اسم اللاعب";
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearch.Location = new System.Drawing.Point(371, 86);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbSearch.Size = new System.Drawing.Size(250, 44);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.Location = new System.Drawing.Point(684, 72);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 71);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CmsList
            // 
            this.CmsList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلبياناتاللاعبToolStripMenuItem,
            this.تجديدالاشتراكToolStripMenuItem,
            this.QuickAddMoney,
            this.DeleteSub});
            this.CmsList.Name = "contextMenuStrip1";
            this.CmsList.Size = new System.Drawing.Size(319, 180);
            // 
            // تعديلبياناتاللاعبToolStripMenuItem
            // 
            this.تعديلبياناتاللاعبToolStripMenuItem.Name = "تعديلبياناتاللاعبToolStripMenuItem";
            this.تعديلبياناتاللاعبToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.تعديلبياناتاللاعبToolStripMenuItem.Text = "تعديل بيانات اللاعب";
            this.تعديلبياناتاللاعبToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // تجديدالاشتراكToolStripMenuItem
            // 
            this.تجديدالاشتراكToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickSubBtn,
            this.ManualSubBtn});
            this.تجديدالاشتراكToolStripMenuItem.Name = "تجديدالاشتراكToolStripMenuItem";
            this.تجديدالاشتراكToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.تجديدالاشتراكToolStripMenuItem.Text = "تجديد الاشتراك";
            // 
            // QuickSubBtn
            // 
            this.QuickSubBtn.Name = "QuickSubBtn";
            this.QuickSubBtn.Size = new System.Drawing.Size(254, 46);
            this.QuickSubBtn.Text = "تجديد سريع";
            this.QuickSubBtn.Click += new System.EventHandler(this.QuickSubBtn_Click);
            // 
            // ManualSubBtn
            // 
            this.ManualSubBtn.Name = "ManualSubBtn";
            this.ManualSubBtn.Size = new System.Drawing.Size(254, 46);
            this.ManualSubBtn.Text = "تجديد يدوي";
            this.ManualSubBtn.Click += new System.EventHandler(this.ManualSub_click);
            // 
            // QuickAddMoney
            // 
            this.QuickAddMoney.Name = "QuickAddMoney";
            this.QuickAddMoney.Size = new System.Drawing.Size(318, 44);
            this.QuickAddMoney.Text = "تسديد الفاتورة";
            this.QuickAddMoney.Click += new System.EventHandler(this.QuickAddMoney_click);
            // 
            // DeleteSub
            // 
            this.DeleteSub.Name = "DeleteSub";
            this.DeleteSub.Size = new System.Drawing.Size(318, 44);
            this.DeleteSub.Text = "حذف الاشتراك";
            this.DeleteSub.Click += new System.EventHandler(this.DeleteSub_Click);
            // 
            // AutoCompleteList
            // 
            this.AutoCompleteList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AutoCompleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCompleteList.FormattingEnabled = true;
            this.AutoCompleteList.ItemHeight = 32;
            this.AutoCompleteList.Location = new System.Drawing.Point(330, 149);
            this.AutoCompleteList.Name = "AutoCompleteList";
            this.AutoCompleteList.Size = new System.Drawing.Size(368, 228);
            this.AutoCompleteList.TabIndex = 6;
            this.AutoCompleteList.SelectedValueChanged += new System.EventHandler(this.AutoCompleteSelected);
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
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvList.RowTemplate.Height = 35;
            this.DgvList.Size = new System.Drawing.Size(1190, 358);
            this.DgvList.TabIndex = 8;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 536);
            this.Controls.Add(this.AutoCompleteList);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CmsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label LblSearchMethod;
        private System.Windows.Forms.ContextMenuStrip CmsList;
        private System.Windows.Forms.ToolStripMenuItem تعديلبياناتاللاعبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تجديدالاشتراكToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickSubBtn;
        private System.Windows.Forms.ToolStripMenuItem ManualSubBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ToolStripMenuItem QuickAddMoney;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.ToolStripMenuItem DeleteSub;
        private System.Windows.Forms.ListBox AutoCompleteList;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.CheckBox ShowAutoCompleteCheckBox;
    }
}
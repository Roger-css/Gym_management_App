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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.CmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلبياناتاللاعبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تجديدالاشتراكToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickSubBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualSubBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.QuickAddMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.CmsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbSearch);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 178);
            this.panel1.TabIndex = 4;
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
            this.RefreshBtn.Location = new System.Drawing.Point(1062, 121);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(43, 42);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = ":اسم اللاعب";
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearch.Location = new System.Drawing.Point(334, 86);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(250, 44);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.Location = new System.Drawing.Point(647, 72);
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
            this.DgvList.AllowUserToOrderColumns = true;
            this.DgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.ContextMenuStrip = this.CmsList;
            this.DgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvList.Location = new System.Drawing.Point(0, 178);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(1117, 272);
            this.DgvList.TabIndex = 5;
            // 
            // CmsList
            // 
            this.CmsList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلبياناتاللاعبToolStripMenuItem,
            this.تجديدالاشتراكToolStripMenuItem,
            this.QuickAddMoney});
            this.CmsList.Name = "contextMenuStrip1";
            this.CmsList.Size = new System.Drawing.Size(319, 136);
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
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleEnter_key);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.CmsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ContextMenuStrip CmsList;
        private System.Windows.Forms.ToolStripMenuItem تعديلبياناتاللاعبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تجديدالاشتراكToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickSubBtn;
        private System.Windows.Forms.ToolStripMenuItem ManualSubBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ToolStripMenuItem QuickAddMoney;
    }
}
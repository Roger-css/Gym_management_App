namespace presentation_layer.Forms
{
    partial class Expired
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
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.CmsExpired = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsQuickSub = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsManualSub = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.CmsExpired.SuspendLayout();
            this.SuspendLayout();
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
            this.DgvList.ContextMenuStrip = this.CmsExpired;
            this.DgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvList.Location = new System.Drawing.Point(0, 0);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersWidth = 62;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(800, 450);
            this.DgvList.TabIndex = 6;
            // 
            // CmsExpired
            // 
            this.CmsExpired.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsExpired.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsQuickSub,
            this.CmsManualSub});
            this.CmsExpired.Name = "contextMenuStrip1";
            this.CmsExpired.Size = new System.Drawing.Size(241, 101);
            // 
            // CmsQuickSub
            // 
            this.CmsQuickSub.Name = "CmsQuickSub";
            this.CmsQuickSub.Size = new System.Drawing.Size(240, 32);
            this.CmsQuickSub.Text = "اشتراك سريع";
            this.CmsQuickSub.Click += new System.EventHandler(this.CmsQuickSub_Click);
            // 
            // CmsManualSub
            // 
            this.CmsManualSub.Name = "CmsManualSub";
            this.CmsManualSub.Size = new System.Drawing.Size(240, 32);
            this.CmsManualSub.Text = "اشتراك يدوي";
            this.CmsManualSub.Click += new System.EventHandler(this.CmsManualSub_Click);
            // 
            // Expired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvList);
            this.Name = "Expired";
            this.Text = "Expired";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.CmsExpired.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ContextMenuStrip CmsExpired;
        private System.Windows.Forms.ToolStripMenuItem CmsQuickSub;
        private System.Windows.Forms.ToolStripMenuItem CmsManualSub;
    }
}
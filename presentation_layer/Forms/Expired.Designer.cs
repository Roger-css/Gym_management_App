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
            this.Cmd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.QuickSub = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualSub = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.Cmd.SuspendLayout();
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
            this.DgvList.ContextMenuStrip = this.Cmd;
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
            // Cmd
            // 
            this.Cmd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Cmd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickSub,
            this.ManualSub});
            this.Cmd.Name = "Cmd";
            this.Cmd.Size = new System.Drawing.Size(241, 101);
            // 
            // QuickSub
            // 
            this.QuickSub.Name = "QuickSub";
            this.QuickSub.Size = new System.Drawing.Size(240, 32);
            this.QuickSub.Text = "تجديد سريع";
            this.QuickSub.Click += new System.EventHandler(this.QuickSub_Click);
            // 
            // ManualSub
            // 
            this.ManualSub.Name = "ManualSub";
            this.ManualSub.Size = new System.Drawing.Size(240, 32);
            this.ManualSub.Text = "تجديد يدوي";
            this.ManualSub.Click += new System.EventHandler(this.ManualSub_Click);
            // 
            // Expired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvList);
            this.Name = "Expired";
            this.Text = "Expired";
            this.Load += new System.EventHandler(this.Expired_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.Cmd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ContextMenuStrip Cmd;
        private System.Windows.Forms.ToolStripMenuItem QuickSub;
        private System.Windows.Forms.ToolStripMenuItem ManualSub;
    }
}
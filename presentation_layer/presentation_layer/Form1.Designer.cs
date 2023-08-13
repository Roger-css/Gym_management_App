namespace presentation_layer
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.playersListBtn = new System.Windows.Forms.Button();
            this.ExpiredListBtn = new System.Windows.Forms.Button();
            this.UncompleteSubs = new System.Windows.Forms.Button();
            this.BalanceBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Controls.Add(this.panelLogo);
            this.flowLayoutPanel1.Controls.Add(this.AddBtn);
            this.flowLayoutPanel1.Controls.Add(this.SearchBtn);
            this.flowLayoutPanel1.Controls.Add(this.playersListBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExpiredListBtn);
            this.flowLayoutPanel1.Controls.Add(this.UncompleteSubs);
            this.flowLayoutPanel1.Controls.Add(this.BalanceBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 720);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "نظام ادارة النادي الرياضي";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.Image = global::presentation_layer.Properties.Resources.Plus_Math;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(3, 84);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AddBtn.Size = new System.Drawing.Size(217, 99);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "  إضافة لاعب";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.Image = global::presentation_layer.Properties.Resources.Add4;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(3, 189);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SearchBtn.Size = new System.Drawing.Size(217, 99);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = " البحث عن لاعب";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // playersListBtn
            // 
            this.playersListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.playersListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.playersListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.playersListBtn.FlatAppearance.BorderSize = 0;
            this.playersListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.playersListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.playersListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playersListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.playersListBtn.Image = global::presentation_layer.Properties.Resources.list;
            this.playersListBtn.Location = new System.Drawing.Point(3, 294);
            this.playersListBtn.Name = "playersListBtn";
            this.playersListBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.playersListBtn.Size = new System.Drawing.Size(217, 99);
            this.playersListBtn.TabIndex = 4;
            this.playersListBtn.Text = "  قائمة الاشتراكات";
            this.playersListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playersListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playersListBtn.UseVisualStyleBackColor = false;
            this.playersListBtn.Click += new System.EventHandler(this.playersListBtn_Click);
            // 
            // ExpiredListBtn
            // 
            this.ExpiredListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ExpiredListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpiredListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ExpiredListBtn.FlatAppearance.BorderSize = 0;
            this.ExpiredListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ExpiredListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ExpiredListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpiredListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredListBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExpiredListBtn.Image = global::presentation_layer.Properties.Resources.Cancel1;
            this.ExpiredListBtn.Location = new System.Drawing.Point(3, 399);
            this.ExpiredListBtn.Name = "ExpiredListBtn";
            this.ExpiredListBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExpiredListBtn.Size = new System.Drawing.Size(217, 99);
            this.ExpiredListBtn.TabIndex = 5;
            this.ExpiredListBtn.Text = " المنتهي اشتراكهم";
            this.ExpiredListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpiredListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExpiredListBtn.UseVisualStyleBackColor = false;
            this.ExpiredListBtn.Click += new System.EventHandler(this.ExpiredListBtn_Click);
            // 
            // UncompleteSubs
            // 
            this.UncompleteSubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.UncompleteSubs.Dock = System.Windows.Forms.DockStyle.Top;
            this.UncompleteSubs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.UncompleteSubs.FlatAppearance.BorderSize = 0;
            this.UncompleteSubs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.UncompleteSubs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.UncompleteSubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UncompleteSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UncompleteSubs.ForeColor = System.Drawing.Color.Gainsboro;
            this.UncompleteSubs.Image = global::presentation_layer.Properties.Resources.Donate1;
            this.UncompleteSubs.Location = new System.Drawing.Point(3, 504);
            this.UncompleteSubs.Name = "UncompleteSubs";
            this.UncompleteSubs.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UncompleteSubs.Size = new System.Drawing.Size(217, 99);
            this.UncompleteSubs.TabIndex = 7;
            this.UncompleteSubs.Text = "  الاشتراكات غير المكتملة";
            this.UncompleteSubs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UncompleteSubs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UncompleteSubs.UseVisualStyleBackColor = false;
            this.UncompleteSubs.Click += new System.EventHandler(this.UncompleteSubs_Click);
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BalanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BalanceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.BalanceBtn.FlatAppearance.BorderSize = 0;
            this.BalanceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.BalanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.BalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.BalanceBtn.Image = global::presentation_layer.Properties.Resources.MoneyBag;
            this.BalanceBtn.Location = new System.Drawing.Point(3, 609);
            this.BalanceBtn.Name = "BalanceBtn";
            this.BalanceBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BalanceBtn.Size = new System.Drawing.Size(217, 99);
            this.BalanceBtn.TabIndex = 6;
            this.BalanceBtn.Text = " الحسابات والأموال";
            this.BalanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BalanceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BalanceBtn.UseVisualStyleBackColor = false;
            this.BalanceBtn.Click += new System.EventHandler(this.BalanceBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 80);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(425, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(96, 28);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "إضافة لاعب";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(224, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(950, 640);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 720);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Gym Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button playersListBtn;
        private System.Windows.Forms.Button ExpiredListBtn;
        private System.Windows.Forms.Button BalanceBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button UncompleteSubs;
    }
}


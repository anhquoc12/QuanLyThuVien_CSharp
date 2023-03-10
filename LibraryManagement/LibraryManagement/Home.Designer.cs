namespace LibraryManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.menuQuanLy = new System.Windows.Forms.MenuStrip();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuon_Tra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1288, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuQuanLy.AutoSize = false;
            this.menuQuanLy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuQuanLy.Dock = System.Windows.Forms.DockStyle.None;
            this.menuQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDanhMuc,
            this.menuMuon_Tra,
            this.menuStat,
            this.menuExit});
            this.menuQuanLy.Location = new System.Drawing.Point(-2, 92);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(1290, 58);
            this.menuQuanLy.TabIndex = 1;
            this.menuQuanLy.Text = "menuStrip1";
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLSach,
            this.menuQLDG,
            this.menuQLOthers});
            this.menuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(268, 54);
            this.menuDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // menuQLSach
            // 
            this.menuQLSach.Name = "menuQLSach";
            this.menuQLSach.Size = new System.Drawing.Size(314, 42);
            this.menuQLSach.Text = "Quản Lý Sách";
            this.menuQLSach.Click += new System.EventHandler(this.menuQLSach_Click);
            // 
            // menuQLDG
            // 
            this.menuQLDG.Name = "menuQLDG";
            this.menuQLDG.Size = new System.Drawing.Size(314, 42);
            this.menuQLDG.Text = "Quản Lý Độc Giả";
            this.menuQLDG.Click += new System.EventHandler(this.menuQLDG_Click);
            // 
            // menuQLOthers
            // 
            this.menuQLOthers.Name = "menuQLOthers";
            this.menuQLOthers.Size = new System.Drawing.Size(314, 42);
            this.menuQLOthers.Text = "Quản Lý Khác";
            this.menuQLOthers.Click += new System.EventHandler(this.menuQLOthers_Click);
            // 
            // menuMuon_Tra
            // 
            this.menuMuon_Tra.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMuon_Tra.Name = "menuMuon_Tra";
            this.menuMuon_Tra.Size = new System.Drawing.Size(259, 54);
            this.menuMuon_Tra.Text = "Quản Lý Mượn Trả";
            this.menuMuon_Tra.Click += new System.EventHandler(this.menuMuon_Tra_Click);
            // 
            // menuStat
            // 
            this.menuStat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStat.Name = "menuStat";
            this.menuStat.Size = new System.Drawing.Size(277, 54);
            this.menuStat.Text = "Báo Cáo - Thống Kê";
            this.menuStat.Click += new System.EventHandler(this.menuStat_Click);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(101, 54);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuMuon_Tra;
        private System.Windows.Forms.ToolStripMenuItem menuStat;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuQLSach;
        private System.Windows.Forms.ToolStripMenuItem menuQLDG;
        private System.Windows.Forms.ToolStripMenuItem menuQLOthers;
    }
}


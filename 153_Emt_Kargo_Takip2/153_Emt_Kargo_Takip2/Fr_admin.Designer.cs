namespace _153_Emt_Kargo_Takip2
{
    partial class Fr_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_admin));
            this.dgv_tablo = new System.Windows.Forms.DataGridView();
            this.bt_newadmin = new System.Windows.Forms.Button();
            this.pcbox_admn = new System.Windows.Forms.PictureBox();
            this.pcbox_adminpnl = new System.Windows.Forms.PictureBox();
            this.bt_drmliste = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_krgolst = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.bt_mstlistesi = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.grpbox_drmguncelle = new System.Windows.Forms.GroupBox();
            this.bt_drmguncelle = new System.Windows.Forms.Button();
            this.cmbox_kargodurumu = new System.Windows.Forms.ComboBox();
            this.cmbox_kargotakipno = new System.Windows.Forms.ComboBox();
            this.lb_krgdrm = new System.Windows.Forms.Label();
            this.lb_krgtakpno = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_admn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_adminpnl)).BeginInit();
            this.grpbox_drmguncelle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tablo
            // 
            this.dgv_tablo.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgv_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablo.Location = new System.Drawing.Point(40, 214);
            this.dgv_tablo.Name = "dgv_tablo";
            this.dgv_tablo.Size = new System.Drawing.Size(809, 139);
            this.dgv_tablo.TabIndex = 1;
            // 
            // bt_newadmin
            // 
            this.bt_newadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_newadmin.Location = new System.Drawing.Point(414, 383);
            this.bt_newadmin.Name = "bt_newadmin";
            this.bt_newadmin.Size = new System.Drawing.Size(139, 37);
            this.bt_newadmin.TabIndex = 4;
            this.bt_newadmin.Text = "Yeni Admin Ekle";
            this.bt_newadmin.UseVisualStyleBackColor = true;
            this.bt_newadmin.Click += new System.EventHandler(this.bt_newadmin_Click);
            // 
            // pcbox_admn
            // 
            this.pcbox_admn.Image = ((System.Drawing.Image)(resources.GetObject("pcbox_admn.Image")));
            this.pcbox_admn.Location = new System.Drawing.Point(617, 12);
            this.pcbox_admn.Name = "pcbox_admn";
            this.pcbox_admn.Size = new System.Drawing.Size(99, 82);
            this.pcbox_admn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbox_admn.TabIndex = 13;
            this.pcbox_admn.TabStop = false;
            // 
            // pcbox_adminpnl
            // 
            this.pcbox_adminpnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbox_adminpnl.Image = ((System.Drawing.Image)(resources.GetObject("pcbox_adminpnl.Image")));
            this.pcbox_adminpnl.Location = new System.Drawing.Point(164, 12);
            this.pcbox_adminpnl.Name = "pcbox_adminpnl";
            this.pcbox_adminpnl.Size = new System.Drawing.Size(447, 82);
            this.pcbox_adminpnl.TabIndex = 14;
            this.pcbox_adminpnl.TabStop = false;
            // 
            // bt_drmliste
            // 
            this.bt_drmliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_drmliste.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_drmliste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_drmliste.ImageKey = "refresh.png";
            this.bt_drmliste.ImageList = this.ımageList1;
            this.bt_drmliste.Location = new System.Drawing.Point(149, 110);
            this.bt_drmliste.Name = "bt_drmliste";
            this.bt_drmliste.Size = new System.Drawing.Size(124, 98);
            this.bt_drmliste.TabIndex = 15;
            this.bt_drmliste.Text = "\r\n\r\nKargo Durumu Güncelleme\r\n";
            this.bt_drmliste.UseVisualStyleBackColor = true;
            this.bt_drmliste.Click += new System.EventHandler(this.bt_drmliste_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "refresh.png");
            this.ımageList1.Images.SetKeyName(1, "Bus-icon.png");
            // 
            // bt_krgolst
            // 
            this.bt_krgolst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_krgolst.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_krgolst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_krgolst.ImageKey = "Bus-icon.png";
            this.bt_krgolst.ImageList = this.ımageList2;
            this.bt_krgolst.Location = new System.Drawing.Point(367, 110);
            this.bt_krgolst.Name = "bt_krgolst";
            this.bt_krgolst.Size = new System.Drawing.Size(123, 98);
            this.bt_krgolst.TabIndex = 16;
            this.bt_krgolst.Text = "\r\n\r\nKargo Listesi";
            this.bt_krgolst.UseVisualStyleBackColor = true;
            this.bt_krgolst.Click += new System.EventHandler(this.bt_krgolst_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Bus-icon.png");
            // 
            // bt_mstlistesi
            // 
            this.bt_mstlistesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mstlistesi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_mstlistesi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_mstlistesi.ImageIndex = 0;
            this.bt_mstlistesi.ImageList = this.ımageList3;
            this.bt_mstlistesi.Location = new System.Drawing.Point(577, 110);
            this.bt_mstlistesi.Name = "bt_mstlistesi";
            this.bt_mstlistesi.Size = new System.Drawing.Size(124, 98);
            this.bt_mstlistesi.TabIndex = 17;
            this.bt_mstlistesi.Text = "\r\nMüşteri Listesi";
            this.bt_mstlistesi.UseVisualStyleBackColor = true;
            this.bt_mstlistesi.Click += new System.EventHandler(this.bt_mstlistesi_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "msteri.png");
            // 
            // grpbox_drmguncelle
            // 
            this.grpbox_drmguncelle.Controls.Add(this.bt_drmguncelle);
            this.grpbox_drmguncelle.Controls.Add(this.cmbox_kargodurumu);
            this.grpbox_drmguncelle.Controls.Add(this.cmbox_kargotakipno);
            this.grpbox_drmguncelle.Controls.Add(this.lb_krgdrm);
            this.grpbox_drmguncelle.Controls.Add(this.lb_krgtakpno);
            this.grpbox_drmguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_drmguncelle.ForeColor = System.Drawing.Color.MintCream;
            this.grpbox_drmguncelle.Location = new System.Drawing.Point(40, 359);
            this.grpbox_drmguncelle.Name = "grpbox_drmguncelle";
            this.grpbox_drmguncelle.Size = new System.Drawing.Size(354, 175);
            this.grpbox_drmguncelle.TabIndex = 18;
            this.grpbox_drmguncelle.TabStop = false;
            this.grpbox_drmguncelle.Text = "Kargo Durumu Güncelleme";
            // 
            // bt_drmguncelle
            // 
            this.bt_drmguncelle.BackColor = System.Drawing.Color.Teal;
            this.bt_drmguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_drmguncelle.Location = new System.Drawing.Point(145, 110);
            this.bt_drmguncelle.Name = "bt_drmguncelle";
            this.bt_drmguncelle.Size = new System.Drawing.Size(157, 29);
            this.bt_drmguncelle.TabIndex = 4;
            this.bt_drmguncelle.Text = "Durumu Güncelle";
            this.bt_drmguncelle.UseVisualStyleBackColor = false;
            this.bt_drmguncelle.Click += new System.EventHandler(this.bt_drmguncelle_Click);
            // 
            // cmbox_kargodurumu
            // 
            this.cmbox_kargodurumu.BackColor = System.Drawing.Color.Teal;
            this.cmbox_kargodurumu.ForeColor = System.Drawing.Color.MintCream;
            this.cmbox_kargodurumu.FormattingEnabled = true;
            this.cmbox_kargodurumu.Location = new System.Drawing.Point(145, 70);
            this.cmbox_kargodurumu.Name = "cmbox_kargodurumu";
            this.cmbox_kargodurumu.Size = new System.Drawing.Size(157, 23);
            this.cmbox_kargodurumu.TabIndex = 3;
            // 
            // cmbox_kargotakipno
            // 
            this.cmbox_kargotakipno.BackColor = System.Drawing.Color.Teal;
            this.cmbox_kargotakipno.FormattingEnabled = true;
            this.cmbox_kargotakipno.Location = new System.Drawing.Point(145, 31);
            this.cmbox_kargotakipno.Name = "cmbox_kargotakipno";
            this.cmbox_kargotakipno.Size = new System.Drawing.Size(157, 23);
            this.cmbox_kargotakipno.TabIndex = 2;
            // 
            // lb_krgdrm
            // 
            this.lb_krgdrm.AutoSize = true;
            this.lb_krgdrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_krgdrm.Location = new System.Drawing.Point(28, 70);
            this.lb_krgdrm.Name = "lb_krgdrm";
            this.lb_krgdrm.Size = new System.Drawing.Size(93, 16);
            this.lb_krgdrm.TabIndex = 1;
            this.lb_krgdrm.Text = "Kargo Durumu";
            // 
            // lb_krgtakpno
            // 
            this.lb_krgtakpno.AutoSize = true;
            this.lb_krgtakpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_krgtakpno.Location = new System.Drawing.Point(28, 31);
            this.lb_krgtakpno.Name = "lb_krgtakpno";
            this.lb_krgtakpno.Size = new System.Drawing.Size(106, 16);
            this.lb_krgtakpno.TabIndex = 0;
            this.lb_krgtakpno.Text = "Kargo Takip No ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(846, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(174, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Fr_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(908, 593);
            this.Controls.Add(this.grpbox_drmguncelle);
            this.Controls.Add(this.bt_mstlistesi);
            this.Controls.Add(this.bt_krgolst);
            this.Controls.Add(this.bt_drmliste);
            this.Controls.Add(this.pcbox_adminpnl);
            this.Controls.Add(this.pcbox_admn);
            this.Controls.Add(this.bt_newadmin);
            this.Controls.Add(this.dgv_tablo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_admin";
            this.Text = "Admin Ekranı";
            this.Load += new System.EventHandler(this.Fr_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_admn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_adminpnl)).EndInit();
            this.grpbox_drmguncelle.ResumeLayout(false);
            this.grpbox_drmguncelle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tablo;
        private System.Windows.Forms.Button bt_newadmin;
        private System.Windows.Forms.PictureBox pcbox_admn;
        private System.Windows.Forms.PictureBox pcbox_adminpnl;
        private System.Windows.Forms.Button bt_drmliste;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button bt_krgolst;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button bt_mstlistesi;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.GroupBox grpbox_drmguncelle;
        private System.Windows.Forms.Button bt_drmguncelle;
        private System.Windows.Forms.ComboBox cmbox_kargodurumu;
        private System.Windows.Forms.ComboBox cmbox_kargotakipno;
        private System.Windows.Forms.Label lb_krgdrm;
        private System.Windows.Forms.Label lb_krgtakpno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
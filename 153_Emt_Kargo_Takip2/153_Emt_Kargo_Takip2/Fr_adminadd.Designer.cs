namespace _153_Emt_Kargo_Takip2
{
    partial class Fr_adminadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_adminadd));
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.lb_isim = new System.Windows.Forms.Label();
            this.lb_sifre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_admin
            // 
            this.dgv_admin.BackgroundColor = System.Drawing.Color.Teal;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(20, 189);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(608, 106);
            this.dgv_admin.TabIndex = 0;
            // 
            // tx_name
            // 
            this.tx_name.BackColor = System.Drawing.Color.Teal;
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_name.ForeColor = System.Drawing.Color.MintCream;
            this.tx_name.Location = new System.Drawing.Point(67, 319);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(100, 21);
            this.tx_name.TabIndex = 1;
            // 
            // tx_sifre
            // 
            this.tx_sifre.BackColor = System.Drawing.Color.Teal;
            this.tx_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_sifre.ForeColor = System.Drawing.Color.MintCream;
            this.tx_sifre.Location = new System.Drawing.Point(266, 319);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(100, 21);
            this.tx_sifre.TabIndex = 2;
            // 
            // bt_ekle
            // 
            this.bt_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_ekle.Location = new System.Drawing.Point(648, 189);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(118, 26);
            this.bt_ekle.TabIndex = 3;
            this.bt_ekle.Text = "Ekle";
            this.bt_ekle.UseVisualStyleBackColor = true;
            this.bt_ekle.Click += new System.EventHandler(this.bt_ekle_Click);
            // 
            // bt_update
            // 
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_update.Location = new System.Drawing.Point(648, 232);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(118, 26);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "Güncelle";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_delete.Location = new System.Drawing.Point(648, 276);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(118, 26);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "Sil";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // lb_isim
            // 
            this.lb_isim.AutoSize = true;
            this.lb_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_isim.Location = new System.Drawing.Point(21, 319);
            this.lb_isim.Name = "lb_isim";
            this.lb_isim.Size = new System.Drawing.Size(44, 16);
            this.lb_isim.TabIndex = 6;
            this.lb_isim.Text = "İsim   :";
            // 
            // lb_sifre
            // 
            this.lb_sifre.AutoSize = true;
            this.lb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sifre.Location = new System.Drawing.Point(213, 322);
            this.lb_sifre.Name = "lb_sifre";
            this.lb_sifre.Size = new System.Drawing.Size(47, 16);
            this.lb_sifre.TabIndex = 7;
            this.lb_sifre.Text = "Şİfre   :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(722, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(54, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // Fr_adminadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(780, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_sifre);
            this.Controls.Add(this.lb_isim);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_ekle);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_adminadd";
            this.Text = "Admin Ekleme";
            this.Load += new System.EventHandler(this.Fr_adminadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label lb_isim;
        private System.Windows.Forms.Label lb_sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}
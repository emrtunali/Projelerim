using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace _153_Emt_Kargo_Takip2
{
    public partial class Fr_admin : Form
    {
        public Fr_admin()
        {
            InitializeComponent();
        }
        private void Fr_admin_Load(object sender, EventArgs e)
        {
            Combo_Doldur(cmbox_kargotakipno, "kargo");
            Combo_Doldur1(cmbox_kargodurumu, "durum");
 
        }
        private void Combo_Doldur(ComboBox cb_box, string t_adi)
        {
            cb_box.DataSource = baglanti.Get_table_bySQL("Select * From " + t_adi);
            cb_box.DisplayMember = t_adi + "_no";
            cb_box.ValueMember = t_adi + "_ID";
        }
        private void Combo_Doldur1(ComboBox cb_box, string t_adi)
        {
            cb_box.DataSource = baglanti.Get_table_bySQL("Select * From " + t_adi);
            cb_box.DisplayMember = t_adi + "_ismi";
            cb_box.ValueMember = t_adi + "_ID";
        }
        string Tablo_adi = "kargo";
        Cl_baglanti baglanti = new Cl_baglanti();
        private void Grid_Doldur()
        {
            string sorgu_metni = "SELECT  kargo_no, durum_ID FROM kargo"; 
            dgv_tablo.DataSource = baglanti.Get_table_bySQL(sorgu_metni);
        }
        private void Grid_Doldur1()
        {
            string sorgu_metni1 = "SELECT * FROM users ";
            dgv_tablo.DataSource = baglanti.Get_table_bySQL(sorgu_metni1);
            dgv_tablo.Columns[0].Visible = false;
        }
        private void Grid_Doldur2()
        {
            string sorgu_metni2 = "SELECT kargo_no, durum_ID, alicinin_ismi, alicinin_soyadi, alicinin_tcno, alicinin_tel, desi, kargocinsi_ID, gonderen_tarih, teslim_tarihi   FROM kargo";
            dgv_tablo.DataSource = baglanti.Get_table_bySQL(sorgu_metni2);
            dgv_tablo.Columns[0].Visible = false;
        }
        public void bt_gncl()
        {
            cmbox_kargotakipno.Items.Clear();
            grpbox_drmguncelle.Enabled = true;
            //string sorgu_metni4 = "SELECT kargo_no, durum From kargo";
        }

        private void bt_drmliste_Click(object sender, EventArgs e)
        {
            Grid_Doldur();
            baglanti.grid_bicimlendir(dgv_tablo);
            //bt_gncl();
        }

        private void bt_drmguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu_metni = "UPDATE " + Tablo_adi + " SET "
                + "durum_ID='" + cmbox_kargodurumu.SelectedValue.ToString() + "', "
                + "kargo_no='" + cmbox_kargotakipno.SelectedValue.ToString() + "' "
                +" Where " + Tablo_adi + "_ID=" + dgv_tablo.SelectedRows[0].Cells[0].Value.ToString();
                int secili_indexs = dgv_tablo.SelectedRows[0].Index;
                baglanti.SqlRun(sorgu_metni);
                Grid_Doldur();
                dgv_tablo.Rows[secili_indexs].Selected = true;
                dgv_tablo.CurrentCell = dgv_tablo.Rows[secili_indexs].Cells[1];
                //bt_gncl();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                
            }
            
        }
        private void bt_mstlistesi_Click(object sender, EventArgs e)
        {
            Grid_Doldur1();
            baglanti.grid_bicimlendir(dgv_tablo);
        }
        private void bt_krgolst_Click(object sender, EventArgs e)
        {
            Grid_Doldur2();
            baglanti.grid_bicimlendir(dgv_tablo);
        }
        private void dgv_tablo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tablo.SelectedRows.Count > 0)
            {
                cmbox_kargotakipno.Text = dgv_tablo.SelectedRows[0].Cells["kargo_no"].Value.ToString();
                cmbox_kargodurumu.Text = dgv_tablo.SelectedRows[0].Cells["durum_ID"].Value.ToString();
                
            }
        }
        private void bt_newadmin_Click(object sender, EventArgs e)
        {
            Fr_adminadd add = new Fr_adminadd();
            add.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

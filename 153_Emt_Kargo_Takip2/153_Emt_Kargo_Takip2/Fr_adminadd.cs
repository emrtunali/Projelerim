using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _153_Emt_Kargo_Takip2
{
    public partial class Fr_adminadd : Form
    {
        public Fr_adminadd()
        {
            InitializeComponent();
        }

        private void Fr_adminadd_Load(object sender, EventArgs e)
        {
            Grid_Doldur();
            baglanti.grid_bicimlendir(dgv_admin);
        }
        string Tablo_adi = "admin";
        Cl_baglanti baglanti = new Cl_baglanti();

        private void Grid_Doldur()
        {
            string sorgu_metni = "SELECT * FROM " + Tablo_adi;
            dgv_admin.DataSource = baglanti.Get_table_bySQL(sorgu_metni);
            dgv_admin.Columns[0].Visible = false;
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            string sorgu_metni = "INSERT INTO " + Tablo_adi
           + " (a_kullanici,a_sifre)"
           + "VALUES('" + tx_name.Text + "','" + tx_sifre.Text + "')";

            baglanti.SqlRun(sorgu_metni);
            Grid_Doldur();
            dgv_admin.Rows[dgv_admin.Rows.Count - 1].Selected = true;
            dgv_admin.CurrentCell = dgv_admin.Rows[dgv_admin.Rows.Count - 1].Cells[1];

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string sorgu_metni = "Delete From admin Where admin_ID=" + dgv_admin.SelectedRows[0].Cells[0].Value.ToString();
            baglanti.SqlRun(sorgu_metni);
            int secili_indexs = dgv_admin.SelectedRows[0].Index;
            Grid_Doldur();
            if (secili_indexs > 0)
            {
                dgv_admin.Rows[secili_indexs - 1].Selected = true;
                dgv_admin.CurrentCell = dgv_admin.Rows[secili_indexs - 1].Cells[1];
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string sorgu_metni = "UPDATE " + Tablo_adi + " SET "
           + "a_kullanici='" + tx_name.Text + "',"
           + "a_sifre='" + tx_sifre.Text + "' "
           + " Where " + Tablo_adi + "_ID=" + dgv_admin.SelectedRows[0].Cells[0].Value.ToString();
            baglanti.SqlRun(sorgu_metni);
            int secili_indexs = dgv_admin.SelectedRows[0].Index;
            Grid_Doldur();
            dgv_admin.Rows[secili_indexs].Selected = true;
            dgv_admin.CurrentCell = dgv_admin.Rows[secili_indexs].Cells[1];
        }
        private void dgv_admin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_admin.SelectedRows.Count > 0)
            {
                tx_name.Text = dgv_admin.SelectedRows[0].Cells["a_kullanici"].Value.ToString();
               tx_sifre.Text = dgv_admin.SelectedRows[0].Cells["a_sifre"].Value.ToString();

            }
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

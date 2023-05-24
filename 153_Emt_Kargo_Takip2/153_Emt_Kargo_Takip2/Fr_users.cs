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
    public partial class Fr_users : Form
    {
        public Fr_users()
        {
            InitializeComponent();
        }
        private void Fr_users_Load(object sender, EventArgs e)
        {

            Combo_Doldur(cmbox_kargocinsi, "kargocinsi");
        }
        private void Combo_Doldur(ComboBox cb_box, string t_adi)
        {
            cb_box.DataSource = baglanti.Get_table_bySQL("Select * From " + t_adi);
            cb_box.DisplayMember = t_adi + "_adi";
            cb_box.ValueMember = t_adi + "_ID";
        }
        string Tablo_adi = "kargo";
        Cl_baglanti baglanti = new Cl_baglanti();

       
        private void bt_gonder_Click(object sender, EventArgs e)
        {
            Random rst = new Random();
            int takipno = rst.Next(100001, 999999);
            try
            {
                
                string sorgu_metni = "INSERT INTO " + Tablo_adi
               + "(kargotakipno,alicinin_ismi,alicinin_soyadi,alicinin_tcno,alicinin_adres,alicinin_tel,desi,kargocinsi_ID,gonderen_tarih)"
                + "VALUES('" + takipno.ToString() + "','" + tx_aliciismi.Text + "','" + tx_alicisoyadi.Text + "','" + tx_alicitcno.Text + "','"
                + tx_aliciadres.Text + "','" + tx_alicitel.Text + "','" + tx_kargodesi.Text  + "','" + cmbox_kargocinsi.Text + "','" +date_kargo.Value.ToString()+ "')";
                baglanti.SqlRun(sorgu_metni);
                MessageBox.Show("Gönderiniz Kaydedildi. Kargonuz Ekiplerimizce Kapıdan Alınacak." + Environment.NewLine + "Bizi Tercih Ettiğiniz İçin Teşekkürler.");
            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
            
        }

        private void cmbox_kargocinsi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_pstiny_Click(object sender, EventArgs e)
        {
            Fr_userinfo info = new Fr_userinfo();
            info.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

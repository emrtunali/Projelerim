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
    public partial class Fr_register : Form
    {
        public Fr_register()
        {
            InitializeComponent();
        }
        private void Fr_register_Load(object sender, EventArgs e)
        {
            Grid_Doldur();
            Combo_Doldur(cmbox_il, "il");
            Combo_Doldur(cmbox_ilce, "ilce");
            Combo_Doldur(cmbox_semt, "semt");
            Combo_Doldur(cmbox_mahalle, "mahalle");

        }
        private void Combo_Doldur(ComboBox cb_box, string t_adi)
        {
            cb_box.DataSource = baglanti.Get_table_bySQL("Select * From " + t_adi);
            cb_box.DisplayMember = t_adi + "_ad";
            cb_box.ValueMember = t_adi + "_ID";
        }
        string Tablo_adi = "users";
        Cl_baglanti baglanti = new Cl_baglanti();

        private void Grid_Doldur()
        {
            
        }
        public void kaydet()
        {
            try
            {
                string sorgu_metni = "INSERT INTO " + Tablo_adi
                + "(kullanici_adi,kullanici_soyadi,kullanici_tcno,kullanici_eposta,kullanici_sifre,İl_İlce_Semt_Mah,Acik_Adres)"
                + "VALUES('" + tx_signname.Text + "','" + tx_signsurname.Text + "','" + tx_identyno.Text + "','" + tx_mailadress.Text + "','"
                + tx_signpass.Text + "','" + cmbox_il.Text + "/" + cmbox_ilce.Text + "/ " +cmbox_semt.Text+ " / "+ cmbox_mahalle.Text  + "','"+ tx_acikadres.Text + "')";
                baglanti.SqlRun(sorgu_metni);
                Fr_login l = new Fr_login();
                l.Show();
                this.Hide();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            if (tx_mailadress.Text.Contains("@") && tx_mailadress.Text.Contains(".com"))
            {
                kaydet();
                MessageBox.Show("Bilgileriniz Başarıyla Kaydedilmiştir." + Environment.NewLine +"Bizi Tercih Ettiğiniz İçin Teşekkürler.");
            }
            else
            {
                MessageBox.Show("Lütfen Mail Adresini Doğru Giriniz!!!");
            }
        }

       
    }
}

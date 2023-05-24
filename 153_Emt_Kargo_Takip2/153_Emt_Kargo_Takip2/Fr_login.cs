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
    public partial class Fr_login : Form
    {
        OleDbConnection kopru = new OleDbConnection();
        OleDbCommand postacı = new OleDbCommand();
        OleDbDataReader okuyucu;
        string baglantı_metni = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = cargotracking_database.mdb";

        public Fr_login()
        {
            InitializeComponent();
        }
        public static string girismail;
        string girisifre;
        private void bt_login_Click(object sender, EventArgs e)
        {
            string kontrolname = tx_username.Text;
            string kontrolsifre = tx_userpassword.Text;
            string sorgu_metni = "SELECT * FROM users WHERE kullanici_eposta ='" + tx_username.Text + "'AND kullanici_sifre ='" + tx_userpassword.Text +"'" ;

            try
            {
                kopru.ConnectionString = baglantı_metni;
                kopru.Open();
                postacı.CommandText = sorgu_metni;  
                postacı.Connection = kopru;

                okuyucu = postacı.ExecuteReader();
                while (okuyucu.Read())
                {
                    girismail = okuyucu["kullanici_eposta"].ToString();
                    girisifre = okuyucu["kullanici_sifre"].ToString();
                }

                if (girismail == kontrolname && girisifre == kontrolsifre)
                {
                    Fr_users f = new Fr_users();
                    f.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Email adresinizi veya Şifrenizi Kontrol Ediniz!!!" + Environment.NewLine +"Düzeltip Tekrar Deneyiniz !!!");
                    tx_username.Clear();
                    tx_userpassword.Clear();
                    tx_username.Focus();
                }
                kopru.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());

            }
            finally { kopru.Close(); }


        }

        private void ch_boxshw_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_boxshw.Checked)
            {
                tx_userpassword.PasswordChar = '\0';
            }

            else
            {
                tx_userpassword.PasswordChar = '*';
            }
        }

        private void chbox_admn_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_admn.Checked)
            {

                tx_admnpass.PasswordChar = '\0';
            }

            else
            {
                tx_admnpass.PasswordChar = '*';
            }
        }

        private void lb_createacnt_Click(object sender, EventArgs e)
        {

            Fr_register register = new Fr_register();
            register.Show();
            this.Hide();
        }

        private void bt_log_admn_Click(object sender, EventArgs e)
        {
            string kontrolname = tx_admnname.Text;
            string kontrolsifre = tx_admnpass.Text;
            string sorgu_metni = "SELECT * FROM admin WHERE a_kullanici ='" + tx_admnname.Text + "'AND a_sifre ='" +  tx_admnpass.Text +"'";

            try
            {
                kopru.ConnectionString = baglantı_metni;
                kopru.Open();
                postacı.CommandText = sorgu_metni; 
                postacı.Connection = kopru;

                okuyucu = postacı.ExecuteReader();
                while (okuyucu.Read())
                {
                    girismail = okuyucu["a_kullanici"].ToString();
                    girisifre = okuyucu["a_sifre"].ToString();
                }
                if (girismail == kontrolname && girisifre == kontrolsifre)
                {
                    Fr_admin ad = new Fr_admin();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz!!!" + Environment.NewLine + "Düzeltip Tekrar Deneyiniz !!!");
                    tx_admnname.Clear();
                    tx_admnpass.Clear();
                    tx_admnname.Focus();
                }
                kopru.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());

            }
            finally { kopru.Close(); }
        }

        private void tx_userpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

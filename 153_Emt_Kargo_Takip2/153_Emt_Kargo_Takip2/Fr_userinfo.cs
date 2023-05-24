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
    public partial class Fr_userinfo : Form
    {
        int id = 0;
        Cl_baglanti bg = new Cl_baglanti();
        public Fr_userinfo()
        {
            InitializeComponent();
            this.id = id;
        }

        private void Fr_userinfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bg.Get_table_bySQL("SELECT * FROM users WHERE kullanici_ID = " + id);
               
                lb_isim.Text = dt.Rows[0]["kullanici_adi"].ToString();
                lb_soyadi.Text = dt.Rows[0]["kullanici_soyadi"].ToString();
                lb_tcno.Text = dt.Rows[0]["kullanici_tcno"].ToString();
                lb_eposta.Text = dt.Rows[0]["kullanici_eposta"].ToString();
                lb_acikadres.Text = dt.Rows[0]["Acik_adres"].ToString();


            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

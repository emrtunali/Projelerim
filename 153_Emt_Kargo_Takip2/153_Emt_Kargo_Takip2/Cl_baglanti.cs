using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace _153_Emt_Kargo_Takip2
{
    class Cl_baglanti
    {
        OleDbConnection kopru;
        OleDbCommand postaci;
        OleDbDataAdapter veri_tutucu;
        DataTable veri_tablosu;
        string baglanti_metni = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = cargotracking_database.mdb";

        public void SqlRun(string sql_metni)
        {
            postaci = new OleDbCommand();
            try
            {
                kopru.ConnectionString = baglanti_metni;
                kopru.Open();
                postaci.Connection = kopru;
                postaci.CommandText = sql_metni;
                postaci.ExecuteNonQuery();

                kopru.Close();

            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally { kopru.Close(); }
        }
        public DataTable Get_table_bySQL(string sql_Query)
        {
            kopru = new OleDbConnection();
            postaci = new OleDbCommand();
            veri_tutucu = new OleDbDataAdapter();
            veri_tablosu = new DataTable();
            try
            {
                kopru.ConnectionString = baglanti_metni; 
                kopru.Open();                           
                postaci.Connection = kopru;            
                postaci.CommandText = sql_Query;     
                veri_tutucu.SelectCommand = postaci;
                veri_tutucu.Fill(veri_tablosu);
                kopru.Close();
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally { kopru.Close(); }
            return veri_tablosu;
        }
        public void grid_bicimlendir(DataGridView dt)
        {
            dt.AllowUserToAddRows = false;
            dt.AllowUserToDeleteRows = false;
            dt.MultiSelect = false;
            dt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

    }
}

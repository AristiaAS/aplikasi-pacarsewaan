using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace aplikasipacarsewaan
{
    public class koneksi
    {
        String database = "server = localhost; uid=root; pwd=''; database= pacar;";
        public MySqlConnection konek;

        public void tampil()
        {
            konek = new MySqlConnection(database);
            konek.Open();
        }
        public void tutup()
        {
            konek = new MySqlConnection(database);
            konek.Close();
        }
        public void QUERY(string query)
        {
            konek = new MySqlConnection(database);
            MySqlCommand cmd;
            try
            {
                konek.Open();
                cmd = new MySqlCommand(query, konek);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                konek.Close();
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace aplikasipacarsewaan
{
    public class tampil
    {
        public DataTable baca ()
        {
            koneksi conn = new koneksi();
            string sql = "select * from sewa";
            DataTable dt = new DataTable();

            try
            {
                conn.tampil();
                MySqlCommand cmd = new MySqlCommand(sql, conn.konek);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.tutup();
            return dt;
        }
    }
}

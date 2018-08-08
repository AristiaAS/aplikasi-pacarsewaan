using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aplikasipacarsewaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampil tamm = new tampil();
            DataTable dt = new DataTable();
            dt = tamm.baca();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi conn = new koneksi();
            conn.tampil();
            conn.QUERY("insert into sewa (nama,jenkel,napac,alasan) values ('"
            + this.nama.Text + "', '" + this.jenkel.Text + "', '" + this.napac.Text + "', '" + this.alasan.Text
            + "')");
            MessageBox.Show("insert data success");
            int hasil, a, b;

            a = Convert.ToInt16(lama.Text);
            b = Convert.ToInt16(honor.Text);
            hasil = a * b;
            total.Text = hasil.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksi conn = new koneksi();
            conn.tampil();
            conn.QUERY("update sewa set nama='" + this.nama.Text + "',jenkel='" +
            jenkel.Text + "',napac='" + napac.Text + "',alasan='" + alasan.Text + "'");
            MessageBox.Show("Update data success");
            int hasil, a, b;

            a = Convert.ToInt16(lama.Text);
            b = Convert.ToInt16(honor.Text);
            hasil = a * b;
            total.Text = hasil.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi conn = new koneksi();
            conn.tampil();
            conn.QUERY("delete from sewa where id='" + id.Text + "'");
            MessageBox.Show("delete data success");

        }
    }
}

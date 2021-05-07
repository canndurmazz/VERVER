using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VeriTabanıProje
{
    public partial class bilgiyonetici : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public bilgiyonetici()
        {
            InitializeComponent();
        }
        public void Grid()
        {

            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Kullanicilar", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
              

                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        public DataTable Ara(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                return null;
            }
        }
        private void bilgiyonetici_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ara("Select * from Kullanicilar where kullanici_ad like'" + textBox1.Text + "%'");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilgimesaj bilgimesaj = new bilgimesaj();
            bilgimesaj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void bilgiyonetici_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void bilgiyonetici_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bilgiyonetici_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciekle kullaniciekle = new kullaniciekle();
            kullaniciekle.Show();
        }
    }
}

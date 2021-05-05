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
    public partial class finansyonetici : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");

        public finansyonetici()
        {
            InitializeComponent();
        }
        public void Grid()
        {

            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select alim_id as 'Alım No',Tedarikci.tedarikci_adsoyad as Tedarikci,alim_adet as Adet, alim_fiyat as Fiyat, alis_tarih as Tarih from Alım inner join tedarikci on tedarikci.tedarikci_id=Alım.tedarikci_id", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;

                SqlDataAdapter da2 = new SqlDataAdapter("Select satis_id as 'Satış No', urun.urun_ad as Urun,musteri.musteri_adsoyad as Musteri, personel.personel_ad as 'Satışı yapan',satıs_adet as Adet, satıs_fiyat as Fiyat, satis_tarihi as Tarih from satis inner join urun on urun.urun_id=satis.urun_id inner join musteri on musteri.musteri_id=satis.musteri_id inner join personel on personel.personel_id=satis.personel_id order by satis_id desc", baglanti);
                DataTable tablo2 = new DataTable();
                da2.Fill(tablo2);
                dataGridView2.DataSource = tablo2;

                SqlDataAdapter da3 = new SqlDataAdapter("Select * From Personel where departman_id = 4 ", baglanti);
                DataTable tablo3 = new DataTable();
                da3.Fill(tablo3);
                dataGridView3.DataSource = tablo3;

                SqlDataAdapter da4 = new SqlDataAdapter("Select * from Adres where adres_id in(select adres_id from Tedarikci)", baglanti);
                DataTable tablo4 = new DataTable();
                da4.Fill(tablo4);
                dataGridView4.DataSource = tablo4;

                SqlDataAdapter da5 = new SqlDataAdapter("Select * from Adres where adres_id in(select adres_id from Musteri)", baglanti);
                DataTable tablo5 = new DataTable();
                da4.Fill(tablo5);
                dataGridView5.DataSource = tablo5;

                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void finansyonetici_Load(object sender, EventArgs e)
        {
            Grid();

                      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            finansmesaj finansmesaj = new finansmesaj();
            finansmesaj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finans finans = new finans();
            finans.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void finansyonetici_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void finansyonetici_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void finansyonetici_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        public DataTable Ara2(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView2.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                return null;
            }
        }
        public DataTable Ara3(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView3.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                return null;
            }
        }
        public DataTable Ara4(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView4.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                return null;
            }
        }
        public DataTable Ara5(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView5.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                return null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ara("Select alim_id as 'Alım No',Tedarikci.tedarikci_adsoyad as Tedarikci,alim_adet as Adet, alim_fiyat as Fiyat, alis_tarih as Tarih from Alım inner join tedarikci on tedarikci.tedarikci_id=Alım.tedarikci_id and Tedarikci.Tedarikci_id like'" + textBox1.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Ara2("Select satis_id as 'Satış No', urun.urun_ad as Urun,musteri.musteri_adsoyad as Musteri, personel.personel_ad as 'Satışı yapan',satıs_adet as Adet, satıs_fiyat as Fiyat, satis_tarihi as Tarih from satis inner join urun on urun.urun_id=satis.urun_id inner join musteri on musteri.musteri_id=satis.musteri_id inner join personel on personel.personel_id=satis.personel_id and Musteri.Musteri_id like'" + textBox2.Text + "%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Ara3("Select * From Personel where departman_id = 4 and personel_ad like'" + textBox3.Text + "%'");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Ara4("Select * from Adres where adres_id in(select adres_id from Tedarikci and ilce like '" + textBox4.Text + "%'");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Ara5("Select * from Adres where adres_id in(select adres_id from Musteri and ilce like'" + textBox5.Text + "%'");
        }
    }

}

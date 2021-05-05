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
    public partial class finans : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");

        public finans()
        {
            InitializeComponent();
        }
        void Combo()
        {
            try
            {

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM departman";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    departmancombo.Items.Add(dr["departman_ad"]);
                }
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            string sorgu = "Select personel_id from personel where Departman_id in(select departman_id from departman where departman_ad=@departman)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@departman", departmancombo.Text);
            string a = Convert.ToString(komut.ExecuteScalar());
            personelsayi.Text = a;
       
            string sorgu2 = "Select sum(personel_maas) from personel where Departman_id in(select departman_id from departman where departman_ad=@departman)"; 
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@departman", departmancombo.Text);
            String b = Convert.ToString(komut2.ExecuteScalar());
            depmaas.Text = Convert.ToString(b);

            string sorgu3 = "Select max(personel_maas) from personel where Departman_id in(select departman_id from departman where departman_ad=@departman)";  
            SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);
            komut3.Parameters.AddWithValue("@departman", departmancombo.Text);
            String c = Convert.ToString(komut3.ExecuteScalar());
            yuksekmaas.Text = Convert.ToString(c);

            string sorgu4 = "Select min(personel_maas) from personel where Departman_id in(select departman_id from departman where departman_ad=@departman)";
            SqlCommand komut4 = new SqlCommand(sorgu4, baglanti);
            komut4.Parameters.AddWithValue("@departman", departmancombo.Text);
            String d = Convert.ToString(komut4.ExecuteScalar());
            dusukmaas.Text = Convert.ToString(d);

            baglanti.Close();
        }
        public void maas()
        {
            baglanti.Open();
            try
            {

                SqlCommand al = new SqlCommand("select sum(personel_maas) as maas from Personel ", baglanti);
                SqlDataReader oku = al.ExecuteReader();
                while (oku.Read())
                {
                    maasyuku.Text = (Double.Parse(oku["maas"].ToString()).ToString());
                }                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
        }
        public void toplamb()
        {
            baglanti.Open();
            try
            {
              
                SqlCommand al = new SqlCommand("select sum(satıs_fiyat) as satis from satis ", baglanti);
                SqlDataReader oku = al.ExecuteReader();               
                    while (oku.Read())
                    {
                        toplamsatis.Text = (Double.Parse(oku["satis"].ToString()).ToString());
                    }
                SqlCommand al2 = new SqlCommand("select sum(alim_fiyat) as alim from Alım ", baglanti);
                SqlDataReader oku2 = al2.ExecuteReader();
                while (oku2.Read())
                {
                    toplamalis.Text = (Double.Parse(oku2["alim"].ToString()).ToString());
                }
              
                double a = double.Parse(toplamsatis.Text) - double.Parse(toplamalis.Text);
                bilanco.Text = a.ToString();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
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
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void finans_Load(object sender, EventArgs e)
        {
            toplamb();
            Combo();
            maas();
            Grid();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            finansmesaj finansmesaj = new finansmesaj();
            finansmesaj.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void finans_MouseEnter(object sender, EventArgs e)
        {

        }

        private void finans_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void finans_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void finans_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
        public DataTable Araa(string araa)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(araa, baglanti);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ara("Select alim_id as 'Alım No', Tedarikci.tedarikci_adsoyad as Tedarikci, alim_adet as Adet, alim_fiyat as Fiyat, alis_tarih as Tarih from Alım inner join tedarikci on tedarikci.tedarikci_id = Alım.tedarikci_id and Tedarikci.Tedarikci_id like'"  + textBox1.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Araa("Select satis_id as 'Satış No', urun.urun_ad as Urun,musteri.musteri_adsoyad as Musteri, personel.personel_ad as 'Satışı yapan',satıs_adet as Adet, satıs_fiyat as Fiyat, satis_tarihi as Tarih from satis inner join urun on urun.urun_id=satis.urun_id inner join musteri on musteri.musteri_id=satis.musteri_id inner join personel on personel.personel_id=satis.personel_id and Musteri.Musteri_id like'" + textBox2.Text + "%'");
        }
    }
}

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
    public partial class uretimyonetici : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public uretimyonetici()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Getir()
        {
            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("Select urun_ad as 'Ürün Adı',urun_miktar as 'Ürün Miktar',hammadde.hammadde_ad as 'Hammaddesi',urun.hammadde_miktar as 'Gereken Hammadde Miktarı',hammadde_aciklama as 'Açıklama' from Urun inner join hammadde on hammadde.hammadde_id=urun.hammadde_id", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;

            DataTable dTable2 = new DataTable();

            SqlDataAdapter dAdapter2 = new SqlDataAdapter("select hammadde_ad as 'Hammadde Ad',hammadde_miktar as 'Hammadde Stok',hammadde_aciklama as 'Açıklama' from hammadde", baglanti);
            {
                dAdapter2.Fill(dTable2);
            }
            dataGridView2.DataSource = dTable2;

            DataTable dTable3 = new DataTable();

            SqlDataAdapter dAdapter3 = new SqlDataAdapter("select uretim_id as 'Uretim Numarası',urun.urun_ad as 'Ürün Adı',uretim_adet as 'Üretim Adedi',uretim_tarihi as 'Üretim Tarihi' from uretim inner join urun on urun.urun_id=uretim.urun_id order by uretim_id desc", baglanti);
            {
                dAdapter3.Fill(dTable3);
            }
            dataGridView3.DataSource = dTable3;
        }
        private void uretimyonetici_Load(object sender, EventArgs e)
        {
            Getir();
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

        private void button1_Click(object sender, EventArgs e)
        {
            uretim uretim = new uretim();
            uretim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunekleme urunekleme = new urunekleme();
            urunekleme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uretimmesaj uretimmesaj = new uretimmesaj();
            uretimmesaj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
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
        public DataTable Araaa(string araaa)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(araaa, baglanti);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ara("Select urun_ad as 'Ürün Adı', urun_miktar as 'Ürün Miktar', hammadde.hammadde_ad as 'Hammaddesi', urun.hammadde_miktar as 'Gereken Hammadde Miktarı', hammadde_aciklama as 'Açıklama' from Urun inner join hammadde on hammadde.hammadde_id = urun.hammadde_id and urun.urun_ad like '" + textBox1.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Araa("select hammadde_ad as 'Hammadde Ad',hammadde_miktar as 'Hammadde Stok',hammadde_aciklama as 'Açıklama' from hammadde where hammadde.hammadde_ad like '" + textBox2.Text + "%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Araaa("select uretim_id as 'Uretim Numarası',urun.urun_ad as 'Ürün Adı',uretim_adet as 'Üretim Adedi',uretim_tarihi as 'Üretim Tarihi' from uretim inner join urun on urun.urun_id=uretim.urun_id where urun.urun_ad like '" + textBox3.Text + "%'");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class urunekleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public urunekleme()
        {
            InitializeComponent();
        }

        void uruncek()
        {
            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("Select urun_ad as Ad, urun_brfiyat as 'Birim fiyat',urun_miktar as 'STOK',urun_aciklama as 'Açıklama' from Urun", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;



        }
        private void urunekleme_Load(object sender, EventArgs e)
        {
            uruncek();


             SqlCommand komutp = new SqlCommand();
            komutp.CommandText = "SELECT hammadde_ad FROM hammadde";
            komutp.Connection = baglanti;
            komutp.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komutp.ExecuteReader();
            while (dr.Read())
            {
                
                hamcombo.Items.Add(dr["hammadde_ad"]);
            }
            baglanti.Close();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select max(urun_id) from urun";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);         
            string a = Convert.ToString(komut.ExecuteScalar());
            int b = Convert.ToInt32(a) + 1;
             baglanti.Close();
            
            
            if (string.IsNullOrEmpty(urunad.Text) == true || string.IsNullOrEmpty(birimfiyat.Text) == true
                || string.IsNullOrEmpty(hamcombo.Text) == true || string.IsNullOrEmpty(urun_miktar.Text) == true)
              
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                string sorgu2 = "Select hammadde_id from hammadde where hammadde_ad=@ad";
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                komut2.Parameters.AddWithValue("@ad", hamcombo.Text);
                string h = Convert.ToString(komut2.ExecuteScalar());
                int hh = Convert.ToInt32(h);
                baglanti.Close();
                
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayitt = "insert into Urun(urun_id,urun_ad,urun_brfiyat,urun_miktar,hammadde_id,hammadde_miktar,urun_aciklama) values (@urun_id,@urun_ad,@urun_brfiyat,@urun_miktar,@hammadde_id,@hammadde_miktar,@urun_aciklama)";
                    SqlCommand komutt = new SqlCommand(kayitt, baglanti);
                    komutt.Parameters.AddWithValue("@urun_id", b);
                    komutt.Parameters.AddWithValue("@urun_ad", urunad.Text);
                    komutt.Parameters.AddWithValue("@urun_brfiyat", birimfiyat.Text);   
                    komutt.Parameters.AddWithValue("@urun_miktar", 0); 
                    komutt.Parameters.AddWithValue("@hammadde_id", hh);                
                    komutt.Parameters.AddWithValue("@hammadde_miktar", urun_miktar.Text);
                    komutt.Parameters.AddWithValue("@urun_aciklama", aciklama.Text);

                    komutt.ExecuteNonQuery();
                    baglanti.Close();                  
                    MessageBox.Show("Ürün Kaydı Başarılı !");
                    urunad.Text = null;
                    birimfiyat.Text = null;
                    hamcombo.Text = null;
                    urun_miktar.Text = null;
                    uruncek();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void birimfiyat_TextChanged(object sender, EventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void urunekleme_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void urunekleme_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void urunekleme_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }

        private void labelbirim_Click(object sender, EventArgs e)
        {

        }

        private void urunadlabel_Click(object sender, EventArgs e)
        {

        }

        private void urun_miktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            uretimsecim uretimsecim = new uretimsecim();
            uretimsecim.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uretimmesaj uretimmesaj = new uretimmesaj();
            uretimmesaj.Show();
        }
    }
}

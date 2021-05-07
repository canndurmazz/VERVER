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
    public partial class bilgisifre : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True");
        public bilgisifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            if (string.IsNullOrEmpty(kullanici_ad.Text) == true || string.IsNullOrEmpty(kullanici_sifre.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand al = new SqlCommand("Select kullanici_ad,kullanici_sifre from kullanicilar where yetki_id=(select yetki_id from yetki where yetki_ad='Personel') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='Bilgi İşlem'))", baglanti);
                    al.Parameters.Add("@kullanici_ad", SqlDbType.VarChar, 50).Value = kullanici_ad.Text;
                    al.Parameters.Add("@kullanici_sifre", SqlDbType.VarChar, 530).Value = kullanici_sifre.Text;

                    SqlDataReader oku = al.ExecuteReader();
                    if (!oku.HasRows)
                    {

                        MessageBox.Show("Böyle Bir Kullanıcı Yok.", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        while (oku.Read())
                        {
                            string ad = (oku["kullanici_ad"].ToString());
                            string sifre = (oku["kullanici_sifre"].ToString());
                            if (ad == kullanici_ad.Text && sifre == kullanici_sifre.Text)
                            {
                                kullaniciekle kullaniciekle = new kullaniciekle();
                                kullaniciekle.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilgiyoneticisifre bilgiyoneticisifre = new bilgiyoneticisifre();
            bilgiyoneticisifre.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void bilgisifre_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void bilgisifre_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bilgisifre_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}

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
using System.Collections;

namespace VeriTabanıProje
{
    public partial class iksifre : Form
    {
        public iksifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=SSPI;MultipleActiveResultSets=True";
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            if (string.IsNullOrEmpty(kullaniciAd.Text) == true || string.IsNullOrEmpty(kullaniciSifre.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
  
                    baglanti.Open();
                    SqlCommand al = new SqlCommand("Select kullanici_ad,kullanici_sifre from kullanicilar where yetki_id=(select yetki_id from yetki where yetki_ad='Personel') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='İnsan Kaynakları'))", baglanti);
                    SqlDataReader oku = al.ExecuteReader();
                    if (!oku.HasRows)
                    {
                        oku.Close();
                        baglanti.Close();
                    }
                    else
                    {
                        while (oku.Read())
                        {
                            string a = (oku["kullanici_ad"].ToString()).ToString();
                            string b = (oku["kullanici_sifre"].ToString()).ToString();

                            if (kullaniciAd.Text == a && kullaniciSifre.Text == b)
                            {
                                sayac = sayac + 1;
                                ikMenu menu = new ikMenu();
                                menu.Show();
                                this.Hide();
                            }
                        }
                        if (sayac == 0)
                        {
                            MessageBox.Show("Giriş başarısız");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                ikgirisyonetici ikyonsifre = new ikgirisyonetici();
            this.Hide();
            ikyonsifre.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void kullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void iksifre_Load(object sender, EventArgs e)
        {

        }

        private void iksifre_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void iksifre_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void iksifre_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

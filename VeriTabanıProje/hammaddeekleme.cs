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
    public partial class hammaddeekleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public hammaddeekleme()
        {
            InitializeComponent();
        }
        void Getir()
        {
            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("select hammadde_id 'ID',hammadde_ad as 'Hammadde Ad',hammadde_miktar as 'Hammadde Stok',hammadde_aciklama as 'Açıklama' from hammadde", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;
        }
        void Temizle()
        {
            textaciklama.Text = null;
            textad.Text = null;
            textbrfiyat.Text = null;
            textmiktar.Text = null;
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

            if (string.IsNullOrEmpty(textad.Text) || string.IsNullOrEmpty(textbrfiyat.Text))
            {
                MessageBox.Show("ÜRün adını ve Birim Fiyatını Belirtiniz!");
            }
            if (string.IsNullOrEmpty(textaciklama.Text))
            {
                textaciklama.Text = null;
            }
            if (string.IsNullOrEmpty(textmiktar.Text))
            {
                textmiktar.Text = "0";
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string sorgu4 = "select top 1 hammadde_id from hammadde order by hammadde_id desc";
                    SqlCommand cmd3 = new SqlCommand(sorgu4, baglanti);
                    int hid = 1;
                    if (cmd3.ExecuteScalar() != null)
                    {
                        hid = Convert.ToInt32(cmd3.ExecuteScalar());
                        hid = hid + 1;
                    }

                    string sorgu3 = "insert into hammadde values (@hid,@had,@hmiktar,@hbr,@haciklama)";

                    SqlCommand komut1 = new SqlCommand(sorgu3, baglanti);
                    komut1.Parameters.AddWithValue("@hid", hid);
                    komut1.Parameters.AddWithValue("@had", textad.Text);
                    komut1.Parameters.AddWithValue("@hmiktar", Convert.ToInt32(textmiktar.Text));
                    komut1.Parameters.AddWithValue("@hbr", Convert.ToDouble(textbrfiyat.Text));
                    komut1.Parameters.AddWithValue("@haciklama", textaciklama.Text);
                    komut1.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Hammadde Eklendi.");
                    Getir();
                    Temizle();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            
        }

        private void hammaddeekleme_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textad = null;
            textbrfiyat = null;
            textmiktar = null;
            textaciklama = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uretimmesaj uretimmesaj = new uretimmesaj();
            uretimmesaj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void hammaddeekleme_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void hammaddeekleme_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void hammaddeekleme_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

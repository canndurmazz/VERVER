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
    public partial class istek : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public istek()
        {
            InitializeComponent();
        }

        private void istek_Load(object sender, EventArgs e)
        {
            try
            {


                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM Departman";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    istekcombo.Items.Add(dr["Departman_ad"]);
                }
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }


        }
        private void istekcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (istekcombo.SelectedIndex == 0)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 1);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");


                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }
            if (istekcombo.SelectedIndex == 1)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 2);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");

                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }
            if (istekcombo.SelectedIndex == 2)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 3);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");

                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }
            if (istekcombo.SelectedIndex == 3)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 4);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");


                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }
            if (istekcombo.SelectedIndex == 4)
            {


                baglanti.Open();
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 5);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");

                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            baglanti.Close();
            if (istekcombo.SelectedIndex == 5)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 6);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");


                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }
            if (istekcombo.SelectedIndex == 6)
            {
                baglanti.Open();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Istek(ileti,departman_ad,departman_id) values (@ileti,@departman_ad,@departman_id)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ileti", ileti.Text);
                    komut.Parameters.AddWithValue("@departman_id", 7);
                    komut.Parameters.AddWithValue("@departman_ad", istekcombo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Mesaj Başarıyla Gönderildi !");


                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                baglanti.Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void istek_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void istek_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void istek_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void istekcombo_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}

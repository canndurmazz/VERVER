using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace VeriTabanıProje
{
    public partial class finansGelirGider : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public finansGelirGider()
        {
            InitializeComponent();
        }

        private void finansGelirGider_Load(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                baglanti = new SqlConnection("server =CANPC\\SQLEXPRESS; Initial Catalog = fabrikavt; Integrated Security = SSPI");
                baglanti.Open();

                string sorgu = "Select sum(personel_maas) from personel";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                if (komut.ExecuteScalar().ToString() == "")
                {
                    a = 0;
                    textMaasgider.Text = a.ToString();
                }
                else
                {
                    a = Convert.ToDouble(komut.ExecuteScalar());
                    textMaasgider.Text = a.ToString();
                }
                
                string sorgu1 = "Select sum(alim_fiyat) from alım";
                SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
                if(komut1.ExecuteScalar().ToString()=="")
                {
                    b = 0;
                    textAlisGider.Text = b.ToString();
                }
                else
                {
                    b = Convert.ToDouble(komut1.ExecuteScalar());
                    textAlisGider.Text = b.ToString();
                }
                
                string sorgu2 = "Select sum(satıs_fiyat) from satis";
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                if (komut2.ExecuteScalar().ToString() == "")
                {
                    c = 0;
                    textSatisgelir.Text = c.ToString();
                }
                else
                {
                    c = Convert.ToDouble(komut2.ExecuteScalar());
                    textSatisgelir.Text = c.ToString();
                }
                
                baglanti.Close();

                double sonuc = -a - b + c;
                textToplam.Text = sonuc.ToString();
                if (sonuc>0)
                {
                    labelDurum.Text = "Kar Sağlandı";
                    labelDurum.ForeColor = Color.Green;
                }
                else if (sonuc==0)
                {
                    labelDurum.Text = "Gelir-Gider Eşit";
                    labelDurum.ForeColor = Color.White;
                }
                else
                {
                    labelDurum.Text = "ZARAR";
                    labelDurum.ForeColor = Color.Red;
                }
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
            }


            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            yonetim yonetim = new yonetim();
            yonetim.Show();
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void finansGelirGider_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void finansGelirGider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void finansGelirGider_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

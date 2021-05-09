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
    public partial class satisyönetici : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public satisyönetici()
        {
            InitializeComponent();
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

        private void satisyönetici_Load(object sender, EventArgs e)
        {
               DataTable dTableeee = new DataTable();

            SqlDataAdapter dAdapterrrr = new SqlDataAdapter("Select * from Urun", baglanti);
            {
                dAdapterrrr.Fill(dTableeee);
            }
            dataGridView4.DataSource = dTableeee;


            DataTable dTableee = new DataTable();

            SqlDataAdapter dAdapterrr = new SqlDataAdapter("Select * from Musteri", baglanti);
            {
                dAdapterrr.Fill(dTableee);
            }
            dataGridView1.DataSource = dTableee;


            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("Select * from Adres where adres_id in(select adres_id from Musteri)", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView2.DataSource = dTable;
            DataTable dTablee = new DataTable();

            SqlDataAdapter dAdapterr = new SqlDataAdapter("Select * From Personel where departman_id =1 ",baglanti);
            {
                dAdapterr.Fill(dTablee);
            }
            dataGridView3.DataSource = dTablee;


       //KAYNAK https://www.yazilimkodlama.com/programlama/c-sql-server-veritabani-baglantisi-select-insert-update-delete/


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
        public DataTable Araaaa(string araaaa)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(araaaa, baglanti);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ara("select * from musteri where musteri_adsoyad like '" + textBox1.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Araa("Select * from Adres where adres_id in(select adres_id from Musteri) and ilce like'" + textBox2.Text + "%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             Araaa("select * from personel where departman_id =1 and personel_ad like'" + textBox3.Text + "%'");
        } 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           Araaaa( "select * from Urun where urun_ad like '" + textBox4.Text + "%'");
        }
         /*KAYNAK : https://www.youtube.com/watch?v=me1FB6OpCeI*/
        private void button1_Click(object sender, EventArgs e)
        {
            siparis siparis = new siparis();
            siparis.Show();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();           
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            yenimüsteri yenimüsteri = new yenimüsteri();
            yenimüsteri.Show();
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            satismesaj satismesaj = new satismesaj();
            satismesaj.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void satisyönetici_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void satisyönetici_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void satisyönetici_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

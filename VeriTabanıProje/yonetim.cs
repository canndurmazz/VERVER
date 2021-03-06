using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıProje
{
    public partial class yonetim : Form
    {
        public yonetim()
        {
            InitializeComponent();
        }

        private void yonetim_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            yoneticimaaszam ymz = new yoneticimaaszam();
           
            ymz.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yoneticimaasveri ymv = new yoneticimaasveri();
           
            ymv.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            ikPersonelislem ikper = new ikPersonelislem();
            ikper.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikDepartmanislem ikdep = new ikDepartmanislem();
            ikdep.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            kmc baslangic = new kmc();
            this.Hide();
            baslangic.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void yonetim_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void yonetim_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void yonetim_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            finansGelirGider finansGelirGider = new finansGelirGider();
            finansGelirGider.Show();
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            finansGelirGider finansGelirGider = new finansGelirGider();
            finansGelirGider.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yonetimmesaj yonetimmesaj = new yonetimmesaj();
            yonetimmesaj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            satisyönetici satisyönetici = new satisyönetici();
            satisyönetici.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satinyonetici satinyonetici = new satinyonetici();
            satinyonetici.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uretimyonetici uretimyonetici = new uretimyonetici();
            uretimyonetici.Show();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ikyoneticimenu ikyoneticimenu = new ikyoneticimenu();
            ikyoneticimenu.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bilgiyonetici bilgiyonetici = new bilgiyonetici();
            bilgiyonetici.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            depoyoneticimenu depoyoneticimenu = new depoyoneticimenu();
            depoyoneticimenu.Show();
        }
    }
}

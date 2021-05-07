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
    public partial class uretimsecim : Form
    {
        public uretimsecim()
        {
            InitializeComponent();
        }

        private void uretimsecim_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uretim uretim = new uretim();
            uretim.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunekleme urunekleme = new urunekleme();
            urunekleme.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void uretimsecim_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void uretimsecim_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void uretimsecim_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hammaddeekleme hammaddeekleme = new hammaddeekleme();
            hammaddeekleme.Show();
            this.Hide();
        }
    }
}

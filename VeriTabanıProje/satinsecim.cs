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
    public partial class satinsecim : Form
    {
        public satinsecim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satinalma satinalma = new satinalma();
            satinalma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenitedarikci yenitedarikci = new yenitedarikci();
            yenitedarikci.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void satinsecim_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void satinsecim_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void satinsecim_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

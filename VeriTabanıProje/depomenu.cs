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
    public partial class depomenu : Form
    {
        public depomenu()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnstokdurum_Click(object sender, EventArgs e)
        {
            depostokdurum depostokdurum = new depostokdurum();
            depostokdurum.Show();
            this.Hide();
        }

        private void buttonKargo_Click(object sender, EventArgs e)
        {
            depogonderim depogonderim = new depogonderim();
            depogonderim.Show();
            this.Hide();
        }

        private void buttonTeslim_Click(object sender, EventArgs e)
        {
            depogonderimteslim depogonderimteslim = new depogonderimteslim();
            depogonderimteslim.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void depomenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void depomenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void depomenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

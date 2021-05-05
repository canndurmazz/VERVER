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
    public partial class ikMenu : Form
    {
        public ikMenu()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
           
            ikPersonelislem ikper = new ikPersonelislem();
            ikper.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ikDepartmanislem ikdep = new ikDepartmanislem();
            ikdep.Show();this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           
            kmc giris = new kmc();
            giris.Show(); this.Hide();
        }

        private void ikMenu_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void ikMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ikMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ikMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

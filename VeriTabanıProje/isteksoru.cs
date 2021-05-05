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
    public partial class isteksoru : Form
    {
        public isteksoru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();           
        }
        private bool mouseDown;
        private Point lastLocation;
        private void isteksoru_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void isteksoru_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void isteksoru_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

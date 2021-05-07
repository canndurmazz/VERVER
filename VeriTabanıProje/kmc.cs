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
    public partial class kmc : Form
    {
       
        public kmc()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            satissifre satissifre = new satissifre();
            satissifre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satinsifre satinsifre = new satinsifre();
            satinsifre.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uretimsifre uretimsifre = new uretimsifre();
            uretimsifre.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            finanssifre finanssifre = new finanssifre();
            finanssifre.Show();
            this.Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iksifre iksifre = new iksifre();
            iksifre.Show();
            this.Hide();
         

        }

        private void button6_Click(object sender, EventArgs e)
        {
            yonetimgiris yonetimgiris = new yonetimgiris();
            yonetimgiris.Show();
            this.Hide();
        
        }

        private void kmc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
                this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;

                else
                    this.WindowState = FormWindowState.Maximized;
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            destek destek = new destek();
            destek.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hakkımızda hakkımızda = new hakkımızda();
            hakkımızda.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {                    
                mouseDown = true;
                lastLocation = e.Location;
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        { 
            if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                    this.Update();
                }
        }
        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
 mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bilgisifre bilgisifre = new bilgisifre();
            bilgisifre.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deposifre deposifre = new deposifre();
            deposifre.Show();
            this.Hide();
        }
    }
}

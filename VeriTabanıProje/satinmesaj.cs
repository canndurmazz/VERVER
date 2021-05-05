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
    public partial class satinmesaj : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public satinmesaj()
        {
            InitializeComponent();
        }

        private void satinmesaj_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT departman_ad,ileti FROM Istek WHERE departman_id=2", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void satinmesaj_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void satinmesaj_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void satinmesaj_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

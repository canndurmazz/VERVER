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
    public partial class satismesaj : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public satismesaj()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void satismesaj_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT departman_ad,ileti FROM Istek WHERE departman_id=1", baglanti);
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;
        }
        private bool mouseDown;
        private Point lastLocation;
        private void satismesaj_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void satismesaj_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void satismesaj_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

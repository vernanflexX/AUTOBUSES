using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOBUSES
{
    public partial class RUTAS : Form
    {
        public RUTAS()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");
        private void RUTAS_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM rutas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void aggRUTA_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into rutas values ('" + textRUTA.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registo agregado.");
            conexion.Close();

            string consulta1 = "SELECT * FROM rutas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            textRUTA.Text = "";
           
        }
    }
}

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
    public partial class AUTOBUSES : Form
    {
        public AUTOBUSES()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");
        private void AUTOBUSES_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM autobuses";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            textMARCA.Text = "";
            textMODELO.Text = "";
            textCOLOR.Text = "";
            textAÑO.Text = "";
            textPLACA.Text = "";
           
        }

        private void aggAUTOBUS_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into autobuses values ('" + textMARCA.Text + "', '" + textMODELO.Text + "', '" + textPLACA.Text + "', '" + textCOLOR.Text + "', '"+textAÑO.Text+"')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registo agregado.");
            conexion.Close();

            string consulta1 = "SELECT * FROM autobuses";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}

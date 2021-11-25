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
    public partial class CHOFERES : Form
    {
        public CHOFERES()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");

        private void CHOFERES_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM choferes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void aggCHOFER_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into choferes values ('" + textNOMBRE.Text + "', '" + textAPELLIDO.Text + "', '" + textFECHA.Text + "', '" + textCEDULA.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registo agregado.");
            conexion.Close();

            string consulta1 = "SELECT * FROM choferes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            
            textNOMBRE.Text = "";
            textAPELLIDO.Text = "";
            textFECHA.Text = "";
            textCEDULA.Text = "";

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class SISTEMA_DE_CONTROL : Form
    {
        public SISTEMA_DE_CONTROL()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");

        private void SISTEMA_DE_CONTROL_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM asignacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void asgRUTA_Click(object sender, EventArgs e)
        {
            Form form = new ASIGNACION();
            form.Show();
        }

        private void aggCHOFER_Click(object sender, EventArgs e)
        {
            Form form = new CHOFERES();
            form.Show();
        }

        private void aggAUTOBUS_Click(object sender, EventArgs e)
        {
            Form form = new AUTOBUSES();
            form.Show();
        }

        private void aggRUTA_Click(object sender, EventArgs e)
        {
            Form form = new RUTAS();
            form.Show();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
         
            string consulta = "SELECT * FROM asignacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}

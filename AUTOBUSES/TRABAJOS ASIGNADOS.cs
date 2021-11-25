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
    public partial class TRABAJOS_ASIGNADOS : Form
    {
        public TRABAJOS_ASIGNADOS()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TRABAJOS_ASIGNADOS_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM asignacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}

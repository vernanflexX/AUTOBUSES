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
    public partial class ASIGNACION : Form
    {
        public ASIGNACION()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-5DT4I13; database=AUTOBUSES ; integrated security = true");

        private void ASIGNACION_Load(object sender, EventArgs e)
        {
            string consulta0 = "SELECT * FROM choferes";
            SqlDataAdapter adaptador0 = new SqlDataAdapter(consulta0, conexion);
            DataTable dt0 = new DataTable();
            adaptador0.Fill(dt0);

            dataGridView1.DataSource = dt0;

            string consulta1 = "SELECT * FROM autobuses";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);

            dataGridView2.DataSource = dt1;

            string consulta2 = "SELECT * FROM rutas";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion);
            DataTable dt2 = new DataTable();
            adaptador2.Fill(dt2);

            dataGridView3.DataSource = dt2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textCHOFER.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textAUTOBUS.Text = dataGridView2.SelectedCells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textRUTA.Text = dataGridView3.SelectedCells[1].Value.ToString();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            textCHOFER.Text = "";
            textAUTOBUS.Text = "";
            textRUTA.Text = "";

        }

        private void asgTRABAJO_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta0 = "select * from asignacion";
            SqlCommand command = new SqlCommand(consulta0, conexion);
            SqlDataReader datos;
            datos = command.ExecuteReader();
            if (datos.Read())
            {
                    if (textCHOFER.Text == datos[1].ToString())
                    {

                        MessageBox.Show("El chofer ya existe.");

                    }
                    else if (textAUTOBUS.Text == datos[2].ToString())
                    {
                        MessageBox.Show("El autobus ya existe.");
                    }
                    else if (textRUTA.Text == datos[3].ToString())
                    {
                        MessageBox.Show("La ruta ya existe.");
                    }

                    else
                    {

                        conexion.Close();
                        conexion.Open();
                        string consulta = "insert into asignacion values ('" + textCHOFER.Text + "', '" + textAUTOBUS.Text + "', '" + textRUTA.Text + "')";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado.");
                        conexion.Close();
                    }
                
             }
            else
            {
                conexion.Close();
                conexion.Open();
                string consulta = "insert into asignacion values ('" + textCHOFER.Text + "', '" + textAUTOBUS.Text + "', '" + textRUTA.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro agregado.");
                conexion.Close();
            }




            conexion.Close();

        }
    }          
  }
    


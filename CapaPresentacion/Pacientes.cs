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

namespace CapaPresentacion
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void historialMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Medico historial = new Historial_Medico();
            this.Hide();
            historial.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            this.Hide();
            personal.Show();
        }

        private void personalMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Medico pm = new Personal_Medico();
            this.Hide();
            pm.Show();
        }

        private void ciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            this.Hide();
            citas.Show();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            connection.Open();

            string consulta = "select * from Pacientes";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                SqlConnection conn = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                conn.Open();
                string query = "insert into Pacientes(Nombres, Apellidos, FechaNacimiento,Tiposangre,Sexo,EstadoCivil,Correo,Telefono,ContactoEmergencia,Direccion,CodigoPostal,NIF,NumeroSeguridadSocial) values ('" + txtnombres.Text + "','" + txtapellidos.Text + "','" + dateTime.Value + "','" + cbtiposangre.Text + "','" + cbsexo.Text + "','" + cbestadocivil.Text + "','" + txtcorreo.Text + "','" + txttelefono.Text + "','" + txtcontactoemergencia.Text + "','"+txtdireccion.Text+"','"+int.Parse(txtcodigopostal.Text)+"','"+txtnif.Text+"','"+txtseguridadsocial.Text+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                MessageBox.Show("Datos agregados correctamente");

            }
            catch
            {
                MessageBox.Show("Hubo un error al agregar los datos");
            }




        }
    }
}

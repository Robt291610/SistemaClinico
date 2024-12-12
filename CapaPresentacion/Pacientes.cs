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

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from Pacientes";
                DataTable dataTable = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(consulta, co);
                a.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                MessageBox.Show("Datos agregados correctamente");

            }
            catch
            {
                MessageBox.Show("Hubo un error al agregar los datos");
            }




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //regresar al menu
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtapellidos.Clear();
            txtcodigopostal.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            txtcontactoemergencia.Clear();
            txtdireccion.Clear();
            txtnif.Clear();
            txtseguridadsocial.Clear();
            txtnombres.Clear();
            cbestadocivil.Text = String.Empty;
            cbsexo.Text = String.Empty;
            cbtiposangre.Text = String.Empty;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void cbtiposangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Enfermedades : Form
    {
        public Enfermedades()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();
            string consulta = "SELECT * from EnfermedadCronica";
            DataTable dataTable = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter(consulta, con);
            a.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                con.Open();
                string add = "insert into EnfermedadCronica(idPaciente, Descripcion, FechaDiagnostico) values('" + txtidpaciente.Text + "','" + txtdescripcion.Text + "','" + dateTime.Value + "')";
                SqlCommand cmd = new SqlCommand(add, con);
                SqlDataReader lector;
                lector = cmd.ExecuteReader();

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from EnfermedadCronica";
                DataTable dataTable = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(consulta, co);
                a.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch 
            {
                MessageBox.Show("Algo salio mal");
            }





                MessageBox.Show("Datos agregados correctamente", "Validación");
            
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdescripcion.Clear();
            txtidpaciente.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

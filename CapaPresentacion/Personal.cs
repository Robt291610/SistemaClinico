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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();
            string consulta = "select * from Empleados";
            SqlDataAdapter a = new SqlDataAdapter(consulta, con);
            DataTable dataTable = new DataTable();
            a.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void label17_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Hide();
            t.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                con.Open();

                string add = "insert into Empleados(Nombre, Direccion, Telefono, Poblacion, Provincia, CodigoPostal,NIF, NumeroSeguridadSocial, periodoVacaciones) values ('"+txtnombre.Text+"','"+txtdireccion.Text+"','"+txttelefono.Text+"','"+txtpoblacion.Text+"','"+txtprovincia.Text+"','"+int.Parse(textBox1.Text)+"','"+txtnif.Text+"','"+textBox13.Text+"','"+textBox2.Text+"')";

                SqlCommand cmd = new SqlCommand(add, con);
                SqlDataReader lector;
               
                lector = cmd.ExecuteReader();

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from Empleados";
                DataTable dataTable = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(consulta, co);
                a.Fill(dataTable);
                dataGridView1.DataSource = dataTable;








                MessageBox.Show("Datos agregados correctamente", "Validación");
            }
            catch
            {
                MessageBox.Show("Hubo un error en los datos", "Error");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            


        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtpoblacion.Clear();
            txtprovincia.Clear();
            textBox1.Clear();
            txtnif.Clear();
            textBox13.Clear();
            textBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

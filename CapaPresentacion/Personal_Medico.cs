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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Personal_Medico : Form
    {
        public Personal_Medico()
        {
            InitializeComponent();
        }

        private void Personal_Medico_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();
            string consulta = "SELECT * from medicos";
            DataTable dataTable = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter(consulta, con);
            a.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
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
                string add = "insert into medicos(Nombre, Direccion, Telefono, Poblacion, Provincia, CodigoPostal, NIF, NumeroSeguridadSocial,TipoMedico,periodoVacaciones, idHistoria,Documento, Detalles,NumeroColegiado) values ('"+txtnombre.Text+"','"+txtdireccion.Text+"','"+txttelefono.Text+"','"+txtpoblacion.Text+"','"+txtprovincia.Text+"','"+int.Parse(txtcodigopostal.Text)+"','"+txtnif.Text+"','"+txtseguridadsocial.Text+"','"+txttipomedico.Text+"','"+txtvacaciones.Text+"','"+Convert.ToInt32(txtidhistoria.Text)+"','"+txtdocumento.Text+"','"+txtdetalles.Text+"','"+txtnumerocolegiado.Text+"') ";
                SqlCommand cmd = new SqlCommand(add, con);
                SqlDataReader lector;
               
                lector = cmd.ExecuteReader();

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from medicos";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            this.Hide();
            y.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtpoblacion.Clear();
            txtprovincia.Clear();
            txtcodigopostal.Clear();
            txtnif.Clear();
            txtseguridadsocial.Clear();
            txttipomedico.Clear();
            txtvacaciones.Clear();
            txtidhistoria.Clear();
            txtdocumento.Clear();
            txtdetalles.Clear();
            txtnumerocolegiado.Clear();
        }
    }
}

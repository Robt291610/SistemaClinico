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
using CapaDatos;
using CapaDatos.Repositorios;


namespace CapaPresentacion
{
    public partial class Historial_Medico : Form
    {
        public object CapaDatos { get; private set; }

        public Historial_Medico()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {









        }

        private void agendaDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas h = new Citas();
            this.Hide();
            h.Show();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                con.Open();

                string add = "insert into HistoriaMedica(Motivo, Sintomas, Diagnostico, Tratamiento, Detalles, PresionArterial, Temperatura) values ('" + txtmotivo.Text + "', '" + txtsintomas.Text + "', '" + txtdiagnostico.Text + "', '" + txttratamiento.Text + "', '" + txtdetalles.Text + "', '" + txtpresion_arterial.Text + "', '" + Convert.ToDouble(txttemperatura.Text) + "')";

                SqlCommand cmd = new SqlCommand(add, con);
                SqlDataReader lector;
                lector = cmd.ExecuteReader();

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from HistoriaMedica";
                DataTable dataTable = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(consulta, co);
                a.Fill(dataTable);
                Data_Historial_Medico.DataSource = dataTable;





                MessageBox.Show("Datos agregados correctamente", "Validación");
            }
            catch
            {
                MessageBox.Show("Hubo un error en los datos", "Error");
            }





        }

        private void personalMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Medico h = new Personal_Medico();
            this.Hide();
            h.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes h = new Pacientes();
            this.Hide();
            h.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal h = new Personal();
            this.Hide();
            h.Show();
        }

        private void enfermedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enfermedades h = new Enfermedades();
            this.Hide();
            h.Show();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtpresion_arterial.Clear();
            txtmotivo.Clear();
            txtdiagnostico.Clear();
            txtdetalles.Clear();
            txtsintomas.Clear();
            txttemperatura.Clear();
            txttratamiento.Clear();
        }

        private void Historial_Medico_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();

            string consulta = "select * from HistoriaMedica";
            SqlDataAdapter a = new SqlDataAdapter(consulta, con);
            DataTable dataTable = new DataTable();
            a.Fill(dataTable);
            Data_Historial_Medico.DataSource = dataTable;
        }

        private void Data_Historial_Medico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void historialMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void personalMédicoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 u = new Form1();
            this.Hide();
            u.Show();
        }
    }
}

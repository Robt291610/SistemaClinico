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
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("insert into HistoriaMedica(Paciente,)"
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
    }
}

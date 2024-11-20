using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection x = new SqlConnection("Data Source=Robertlaptop\\SQLEXPRESS01;Initial Catalog=HistorialMedico;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            x.Open();

            string consulta = "select * from Usuarios where Usuario = '"+textBox1.Text+"' and  Contrasena = '"+textBox2.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, x);
            SqlDataReader Lector;
            Lector = comando.ExecuteReader();

            if (Lector.HasRows == true)
            {
                Historial_Medico a = new Historial_Medico();
                this.Hide();
                a.Show();
            }
            else 
            {
                MessageBox.Show("El nombre de usuario o la contraseña ha sido incorrecto","Error",MessageBoxButtons.OK);
                textBox1.Clear();
                textBox2.Clear();
            }

            x.Close();
        }
    }
}

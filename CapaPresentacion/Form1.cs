using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Historial_Medico a = new Historial_Medico();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personal s = new Personal();    
            this.Hide();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pacientes w = new Pacientes();
            this.Hide();
            w.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Citas o = new Citas();
            this.Hide();
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personal_Medico p = new Personal_Medico();
            this.Hide(); p.Show();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Enfermedades enfermedades = new Enfermedades();
            this.Hide();
            enfermedades.Show();
        }
    }
}

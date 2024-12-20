﻿using System;
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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void agendaDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void historialMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Medico x = new Historial_Medico();
            this.Hide();
            x.Show();
        }

        private void pacientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pacientes x = new Pacientes();
            this.Hide();
            x.Show();
        }

        private void personalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Personal x = new Personal();
            this.Hide(); x.Show();

        }

        private void personalMédicoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Personal_Medico x = new Personal_Medico();
            this.Hide(); x.Show();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
            con.Open();
            string consulta = "select * from Citas";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                con.Open();
                string query = "insert into Citas(idPaciente,idUsuario,Fecha,Motivo, Detalles) values('" + Convert.ToInt32(txtpaciente.Text) + "','" + Convert.ToInt32(txtusuario.Text) + "','" + dateTimePicker1.Value + "','" + txtmotivo.Text + "','" + txtdetalles.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader x;
                x = cmd.ExecuteReader();

                SqlConnection co = new SqlConnection("Data Source = Robertlaptop\\SQLEXPRESS01; Initial Catalog = HistorialMedico; Integrated Security = True; Encrypt = False; TrustServerCertificate = True");
                co.Open();
                string consulta = "SELECT * from Citas";
                DataTable dataTable = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(consulta, co);
                a.Fill(dataTable);
                dataGridView1.DataSource = dataTable;


                MessageBox.Show("Datos agregados correctamente");

            }
            catch
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdetalles.Clear();
            txtmotivo.Clear();
            txtpaciente.Clear();
            txtusuario.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

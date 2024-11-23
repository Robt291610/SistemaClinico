namespace CapaPresentacion
{
    partial class Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.txtcontactoemergencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbestadocivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.cbtiposangre = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcodigopostal = new System.Windows.Forms.TextBox();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.txtseguridadsocial = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1316, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 570);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorDeDatosToolStripMenuItem
            // 
            this.administradorDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialMédicoToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.personalMédicoToolStripMenuItem,
            this.ciToolStripMenuItem});
            this.administradorDeDatosToolStripMenuItem.Name = "administradorDeDatosToolStripMenuItem";
            this.administradorDeDatosToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.administradorDeDatosToolStripMenuItem.Text = "Administrador de datos";
            // 
            // historialMédicoToolStripMenuItem
            // 
            this.historialMédicoToolStripMenuItem.Name = "historialMédicoToolStripMenuItem";
            this.historialMédicoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.historialMédicoToolStripMenuItem.Text = "Historial Médico";
            this.historialMédicoToolStripMenuItem.Click += new System.EventHandler(this.historialMédicoToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // personalMédicoToolStripMenuItem
            // 
            this.personalMédicoToolStripMenuItem.Name = "personalMédicoToolStripMenuItem";
            this.personalMédicoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalMédicoToolStripMenuItem.Text = "Personal Médico";
            this.personalMédicoToolStripMenuItem.Click += new System.EventHandler(this.personalMédicoToolStripMenuItem_Click);
            // 
            // ciToolStripMenuItem
            // 
            this.ciToolStripMenuItem.Name = "ciToolStripMenuItem";
            this.ciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ciToolStripMenuItem.Text = "Agenda de Citas";
            this.ciToolStripMenuItem.Click += new System.EventHandler(this.ciToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1392, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(154, 14);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(205, 22);
            this.txtnombres.TabIndex = 4;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(154, 76);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(205, 22);
            this.txtapellidos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(154, 198);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(205, 22);
            this.txtcorreo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(6, 142);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(132, 16);
            this.la.TabIndex = 7;
            this.la.Text = "Fecha de nacimiento";
            // 
            // txtcontactoemergencia
            // 
            this.txtcontactoemergencia.Location = new System.Drawing.Point(673, 23);
            this.txtcontactoemergencia.Name = "txtcontactoemergencia";
            this.txtcontactoemergencia.Size = new System.Drawing.Size(176, 22);
            this.txtcontactoemergencia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contacto de emergencia";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(154, 260);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(205, 22);
            this.txttelefono.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Teléfono";
            // 
            // cbestadocivil
            // 
            this.cbestadocivil.FormattingEnabled = true;
            this.cbestadocivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.cbestadocivil.Location = new System.Drawing.Point(673, 78);
            this.cbestadocivil.Name = "cbestadocivil";
            this.cbestadocivil.Size = new System.Drawing.Size(121, 24);
            this.cbestadocivil.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estado civil";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1392, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo de sangre";
            // 
            // cbsexo
            // 
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Neutro"});
            this.cbsexo.Location = new System.Drawing.Point(673, 196);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(121, 24);
            this.cbsexo.TabIndex = 28;
            // 
            // cbtiposangre
            // 
            this.cbtiposangre.FormattingEnabled = true;
            this.cbtiposangre.Items.AddRange(new object[] {
            "+A",
            "-A",
            "-B",
            "+B",
            "+AB",
            "-AB",
            "O"});
            this.cbtiposangre.Location = new System.Drawing.Point(673, 142);
            this.cbtiposangre.Name = "cbtiposangre";
            this.cbtiposangre.Size = new System.Drawing.Size(121, 24);
            this.cbtiposangre.TabIndex = 29;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "dd-mm-yyyy";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(159, 142);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Dirección";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(673, 257);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(221, 22);
            this.txtdireccion.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(942, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Número seguridad social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(942, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "NIF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(942, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Código Postal";
            // 
            // txtcodigopostal
            // 
            this.txtcodigopostal.Location = new System.Drawing.Point(1106, 139);
            this.txtcodigopostal.Name = "txtcodigopostal";
            this.txtcodigopostal.Size = new System.Drawing.Size(145, 22);
            this.txtcodigopostal.TabIndex = 36;
            // 
            // txtnif
            // 
            this.txtnif.Location = new System.Drawing.Point(1106, 193);
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(221, 22);
            this.txtnif.TabIndex = 37;
            // 
            // txtseguridadsocial
            // 
            this.txtseguridadsocial.Location = new System.Drawing.Point(1106, 257);
            this.txtseguridadsocial.Name = "txtseguridadsocial";
            this.txtseguridadsocial.Size = new System.Drawing.Size(221, 22);
            this.txtseguridadsocial.TabIndex = 38;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 570);
            this.Controls.Add(this.txtseguridadsocial);
            this.Controls.Add(this.txtnif);
            this.Controls.Add(this.txtcodigopostal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.cbtiposangre);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbestadocivil);
            this.Controls.Add(this.txtcontactoemergencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.la);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txtcontactoemergencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbestadocivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.ComboBox cbtiposangre;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcodigopostal;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.TextBox txtseguridadsocial;
    }
}
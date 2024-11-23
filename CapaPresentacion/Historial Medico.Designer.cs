namespace CapaPresentacion
{
    partial class Historial_Medico
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
            this.Data_Historial_Medico = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtsintomas = new System.Windows.Forms.TextBox();
            this.txtdiagnostico = new System.Windows.Forms.TextBox();
            this.txttratamiento = new System.Windows.Forms.TextBox();
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.txtpresion_arterial = new System.Windows.Forms.TextBox();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Historial_Medico)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_Historial_Medico
            // 
            this.Data_Historial_Medico.AllowUserToOrderColumns = true;
            this.Data_Historial_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Historial_Medico.Location = new System.Drawing.Point(0, 299);
            this.Data_Historial_Medico.Name = "Data_Historial_Medico";
            this.Data_Historial_Medico.RowHeadersWidth = 51;
            this.Data_Historial_Medico.RowTemplate.Height = 24;
            this.Data_Historial_Medico.Size = new System.Drawing.Size(1480, 395);
            this.Data_Historial_Medico.TabIndex = 0;
            this.Data_Historial_Medico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Historial_Medico_CellContentClick);
            this.Data_Historial_Medico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Historial_Medico_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1090, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 694);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaDeCitasToolStripMenuItem,
            this.personalMédicoToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(383, 24);
            this.ToolStripMenuItem.Text = "Administrador de datos";
            // 
            // agendaDeCitasToolStripMenuItem
            // 
            this.agendaDeCitasToolStripMenuItem.Name = "agendaDeCitasToolStripMenuItem";
            this.agendaDeCitasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agendaDeCitasToolStripMenuItem.Text = "Agenda de citas";
            this.agendaDeCitasToolStripMenuItem.Click += new System.EventHandler(this.agendaDeCitasToolStripMenuItem_Click);
            // 
            // personalMédicoToolStripMenuItem
            // 
            this.personalMédicoToolStripMenuItem.Name = "personalMédicoToolStripMenuItem";
            this.personalMédicoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalMédicoToolStripMenuItem.Text = "Personal Médico";
            this.personalMédicoToolStripMenuItem.Click += new System.EventHandler(this.personalMédicoToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(1090, 182);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(89, 37);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Registrar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1090, 121);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(89, 37);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sintomas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tratamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detalles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Presion Arterial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Temperatura";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(141, 146);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(100, 22);
            this.txtmotivo.TabIndex = 14;
            // 
            // txtsintomas
            // 
            this.txtsintomas.Location = new System.Drawing.Point(419, 88);
            this.txtsintomas.Name = "txtsintomas";
            this.txtsintomas.Size = new System.Drawing.Size(100, 22);
            this.txtsintomas.TabIndex = 16;
            // 
            // txtdiagnostico
            // 
            this.txtdiagnostico.Location = new System.Drawing.Point(419, 149);
            this.txtdiagnostico.Name = "txtdiagnostico";
            this.txtdiagnostico.Size = new System.Drawing.Size(100, 22);
            this.txtdiagnostico.TabIndex = 17;
            // 
            // txttratamiento
            // 
            this.txttratamiento.Location = new System.Drawing.Point(419, 200);
            this.txttratamiento.Name = "txttratamiento";
            this.txttratamiento.Size = new System.Drawing.Size(100, 22);
            this.txttratamiento.TabIndex = 18;
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(141, 85);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(100, 22);
            this.txttemperatura.TabIndex = 21;
            // 
            // txtpresion_arterial
            // 
            this.txtpresion_arterial.Location = new System.Drawing.Point(141, 203);
            this.txtpresion_arterial.Name = "txtpresion_arterial";
            this.txtpresion_arterial.Size = new System.Drawing.Size(100, 22);
            this.txtpresion_arterial.TabIndex = 20;
            // 
            // txtdetalles
            // 
            this.txtdetalles.Location = new System.Drawing.Point(785, 88);
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(100, 22);
            this.txtdetalles.TabIndex = 19;
            // 
            // Historial_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 694);
            this.Controls.Add(this.txttemperatura);
            this.Controls.Add(this.txtpresion_arterial);
            this.Controls.Add(this.txtdetalles);
            this.Controls.Add(this.txttratamiento);
            this.Controls.Add(this.txtdiagnostico);
            this.Controls.Add(this.txtsintomas);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.Data_Historial_Medico);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Historial_Medico";
            this.Text = "Historial Medico";
            this.Load += new System.EventHandler(this.Historial_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Historial_Medico)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Historial_Medico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.TextBox txtsintomas;
        private System.Windows.Forms.TextBox txtdiagnostico;
        private System.Windows.Forms.TextBox txttratamiento;
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.TextBox txtpresion_arterial;
        private System.Windows.Forms.TextBox txtdetalles;
    }
}


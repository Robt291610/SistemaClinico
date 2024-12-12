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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial_Medico));
            this.Data_Historial_Medico = new System.Windows.Forms.DataGridView();
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
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.txtpresion_arterial = new System.Windows.Forms.TextBox();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttratamiento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Historial_Medico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_Historial_Medico
            // 
            this.Data_Historial_Medico.AllowUserToOrderColumns = true;
            this.Data_Historial_Medico.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.Data_Historial_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Historial_Medico.Location = new System.Drawing.Point(-10, 432);
            this.Data_Historial_Medico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_Historial_Medico.Name = "Data_Historial_Medico";
            this.Data_Historial_Medico.ReadOnly = true;
            this.Data_Historial_Medico.RowHeadersWidth = 51;
            this.Data_Historial_Medico.RowTemplate.Height = 24;
            this.Data_Historial_Medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Historial_Medico.Size = new System.Drawing.Size(1541, 299);
            this.Data_Historial_Medico.TabIndex = 0;
            this.Data_Historial_Medico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Historial_Medico_CellContentClick);
            this.Data_Historial_Medico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Historial_Medico_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1389, 379);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 37);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Registrar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(1278, 379);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sintomas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tratamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detalles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Presion Arterial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Temperatura";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(119, 170);
            this.txtmotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(215, 22);
            this.txtmotivo.TabIndex = 14;
            // 
            // txtsintomas
            // 
            this.txtsintomas.Location = new System.Drawing.Point(739, 170);
            this.txtsintomas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsintomas.Name = "txtsintomas";
            this.txtsintomas.Size = new System.Drawing.Size(204, 22);
            this.txtsintomas.TabIndex = 16;
            // 
            // txtdiagnostico
            // 
            this.txtdiagnostico.Location = new System.Drawing.Point(739, 230);
            this.txtdiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiagnostico.Name = "txtdiagnostico";
            this.txtdiagnostico.Size = new System.Drawing.Size(204, 22);
            this.txtdiagnostico.TabIndex = 17;
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(233, 117);
            this.txttemperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(100, 22);
            this.txttemperatura.TabIndex = 21;
            // 
            // txtpresion_arterial
            // 
            this.txtpresion_arterial.Location = new System.Drawing.Point(233, 224);
            this.txtpresion_arterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpresion_arterial.Name = "txtpresion_arterial";
            this.txtpresion_arterial.Size = new System.Drawing.Size(100, 22);
            this.txtpresion_arterial.TabIndex = 20;
            // 
            // txtdetalles
            // 
            this.txtdetalles.Location = new System.Drawing.Point(706, 112);
            this.txtdetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(319, 22);
            this.txtdetalles.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "HISTORIAL MEDICO";
            // 
            // txttratamiento
            // 
            this.txttratamiento.Location = new System.Drawing.Point(180, 284);
            this.txttratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttratamiento.Name = "txttratamiento";
            this.txttratamiento.Size = new System.Drawing.Size(204, 22);
            this.txttratamiento.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1098, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 53);
            this.panel1.TabIndex = 61;
            // 
            // Historial_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1604, 731);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttratamiento);
            this.Controls.Add(this.txttemperatura);
            this.Controls.Add(this.txtpresion_arterial);
            this.Controls.Add(this.txtdetalles);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Historial_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Medico";
            this.Load += new System.EventHandler(this.Historial_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Historial_Medico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Historial_Medico;
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
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.TextBox txtpresion_arterial;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttratamiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}


using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    partial class Alta_Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Viaje));
            this.btnSeleccionarRuta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSeleccionarAeronave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblCiudadOrigen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFabricanteAeronave = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMatriculaAeronave = new System.Windows.Forms.Label();
            this.lblModeloAeronave = new System.Windows.Forms.Label();
            this.lblCantButacasAeronave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKgDisponiblesEncomiendasAeronave = new System.Windows.Forms.Label();
            this.lblTipoServicioAeronave = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFechaLlegadaEstimadaVuelo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSalidaVuelo = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(398, 176);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(131, 23);
            this.btnSeleccionarRuta.TabIndex = 8;
            this.btnSeleccionarRuta.Text = "Seleccionar ruta";
            this.btnSeleccionarRuta.UseVisualStyleBackColor = true;
            this.btnSeleccionarRuta.Click += new System.EventHandler(this.btnSeleccionarRuta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarAeronave
            // 
            this.btnSeleccionarAeronave.Location = new System.Drawing.Point(398, 270);
            this.btnSeleccionarAeronave.Name = "btnSeleccionarAeronave";
            this.btnSeleccionarAeronave.Size = new System.Drawing.Size(131, 23);
            this.btnSeleccionarAeronave.TabIndex = 10;
            this.btnSeleccionarAeronave.Text = "Seleccionar aeronave";
            this.btnSeleccionarAeronave.UseVisualStyleBackColor = true;
            this.btnSeleccionarAeronave.Click += new System.EventHandler(this.btnSeleccionarAeronave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lblCiudadDestino);
            this.groupBox1.Controls.Add(this.lblCiudadOrigen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la ruta";
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(229, 50);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(0, 13);
            this.lblCiudadDestino.TabIndex = 14;
            // 
            // lblCiudadOrigen
            // 
            this.lblCiudadOrigen.AutoSize = true;
            this.lblCiudadOrigen.Location = new System.Drawing.Point(229, 28);
            this.lblCiudadOrigen.Name = "lblCiudadOrigen";
            this.lblCiudadOrigen.Size = new System.Drawing.Size(0, 13);
            this.lblCiudadOrigen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ciudad Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad Origen";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.lblFabricanteAeronave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMatriculaAeronave);
            this.groupBox2.Controls.Add(this.lblModeloAeronave);
            this.groupBox2.Controls.Add(this.lblCantButacasAeronave);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblKgDisponiblesEncomiendasAeronave);
            this.groupBox2.Controls.Add(this.lblTipoServicioAeronave);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(17, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la aeronave";
            // 
            // lblFabricanteAeronave
            // 
            this.lblFabricanteAeronave.AutoSize = true;
            this.lblFabricanteAeronave.Location = new System.Drawing.Point(226, 162);
            this.lblFabricanteAeronave.Name = "lblFabricanteAeronave";
            this.lblFabricanteAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblFabricanteAeronave.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fabricante";
            // 
            // lblMatriculaAeronave
            // 
            this.lblMatriculaAeronave.AutoSize = true;
            this.lblMatriculaAeronave.Location = new System.Drawing.Point(226, 105);
            this.lblMatriculaAeronave.Name = "lblMatriculaAeronave";
            this.lblMatriculaAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblMatriculaAeronave.TabIndex = 36;
            // 
            // lblModeloAeronave
            // 
            this.lblModeloAeronave.AutoSize = true;
            this.lblModeloAeronave.Location = new System.Drawing.Point(226, 133);
            this.lblModeloAeronave.Name = "lblModeloAeronave";
            this.lblModeloAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblModeloAeronave.TabIndex = 35;
            // 
            // lblCantButacasAeronave
            // 
            this.lblCantButacasAeronave.AutoSize = true;
            this.lblCantButacasAeronave.Location = new System.Drawing.Point(226, 75);
            this.lblCantButacasAeronave.Name = "lblCantButacasAeronave";
            this.lblCantButacasAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblCantButacasAeronave.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Matrícula";
            // 
            // lblKgDisponiblesEncomiendasAeronave
            // 
            this.lblKgDisponiblesEncomiendasAeronave.AutoSize = true;
            this.lblKgDisponiblesEncomiendasAeronave.Location = new System.Drawing.Point(226, 50);
            this.lblKgDisponiblesEncomiendasAeronave.Name = "lblKgDisponiblesEncomiendasAeronave";
            this.lblKgDisponiblesEncomiendasAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblKgDisponiblesEncomiendasAeronave.TabIndex = 33;
            // 
            // lblTipoServicioAeronave
            // 
            this.lblTipoServicioAeronave.AutoSize = true;
            this.lblTipoServicioAeronave.Location = new System.Drawing.Point(226, 25);
            this.lblTipoServicioAeronave.Name = "lblTipoServicioAeronave";
            this.lblTipoServicioAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblTipoServicioAeronave.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cantidad de Butacas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kg Disponibles para Encomiendas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tipo de Servicio";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.dtpFechaLlegadaEstimadaVuelo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpFechaSalidaVuelo);
            this.groupBox3.Location = new System.Drawing.Point(17, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 91);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del vuelo";
            // 
            // dtpFechaLlegadaEstimadaVuelo
            // 
            this.dtpFechaLlegadaEstimadaVuelo.CustomFormat = "dd/MM/yyy - HH:mm:ss";
            this.dtpFechaLlegadaEstimadaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLlegadaEstimadaVuelo.Location = new System.Drawing.Point(158, 64);
            this.dtpFechaLlegadaEstimadaVuelo.Name = "dtpFechaLlegadaEstimadaVuelo";
            this.dtpFechaLlegadaEstimadaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLlegadaEstimadaVuelo.TabIndex = 17;
            this.dtpFechaLlegadaEstimadaVuelo.ValueChanged += new System.EventHandler(this.dtpFechaLlegadaEstimadaVuelo_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fecha Llegada Estimada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha Salida";
            // 
            // dtpFechaSalidaVuelo
            // 
            this.dtpFechaSalidaVuelo.CustomFormat = "dd/MM/yyy - HH:mm:ss";
            this.dtpFechaSalidaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalidaVuelo.Location = new System.Drawing.Point(158, 20);
            this.dtpFechaSalidaVuelo.Name = "dtpFechaSalidaVuelo";
            this.dtpFechaSalidaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalidaVuelo.TabIndex = 0;
            this.dtpFechaSalidaVuelo.ValueChanged += new System.EventHandler(this.dtpFechaSalidaVuelo_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(417, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(417, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alta_Viaje
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarAeronave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSeleccionarRuta);
            this.KeyPreview = true;
            this.Name = "Alta_Viaje";
            this.Text = "Generar viaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarRuta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeleccionarAeronave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiudadOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblModeloAeronave;
        private System.Windows.Forms.Label lblCantButacasAeronave;
        private System.Windows.Forms.Label lblKgDisponiblesEncomiendasAeronave;
        private System.Windows.Forms.Label lblTipoServicioAeronave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaVuelo;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaEstimadaVuelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private Label lblMatriculaAeronave;
        private Label label1;
        private Label lblFabricanteAeronave;
        private Label label4;
        private Button button1;
    }
}
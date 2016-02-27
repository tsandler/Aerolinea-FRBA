using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.dtpFechaYHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFabricanteAeronave = new System.Windows.Forms.Label();
            this.lblKgEncomiendasAeronave = new System.Windows.Forms.Label();
            this.lblTipoServicioAeronave = new System.Windows.Forms.Label();
            this.lblMatriculaAeronave = new System.Windows.Forms.Label();
            this.lblModeloAeronave = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCantButacasAeronave = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaYHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarAeronave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matriculasComboBox = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaYHoraLlegada
            // 
            this.dtpFechaYHoraLlegada.CustomFormat = "dd/MM/yyy - HH:mm:ss";
            this.dtpFechaYHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaYHoraLlegada.Location = new System.Drawing.Point(9, 210);
            this.dtpFechaYHoraLlegada.Name = "dtpFechaYHoraLlegada";
            this.dtpFechaYHoraLlegada.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaYHoraLlegada.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha y hora de llegada destino";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lblFabricanteAeronave);
            this.groupBox1.Controls.Add(this.lblKgEncomiendasAeronave);
            this.groupBox1.Controls.Add(this.lblTipoServicioAeronave);
            this.groupBox1.Controls.Add(this.lblMatriculaAeronave);
            this.groupBox1.Controls.Add(this.lblModeloAeronave);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblCantButacasAeronave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Aeronave";
            // 
            // lblFabricanteAeronave
            // 
            this.lblFabricanteAeronave.AutoSize = true;
            this.lblFabricanteAeronave.Location = new System.Drawing.Point(214, 159);
            this.lblFabricanteAeronave.Name = "lblFabricanteAeronave";
            this.lblFabricanteAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblFabricanteAeronave.TabIndex = 28;
            // 
            // lblKgEncomiendasAeronave
            // 
            this.lblKgEncomiendasAeronave.AutoSize = true;
            this.lblKgEncomiendasAeronave.Location = new System.Drawing.Point(215, 75);
            this.lblKgEncomiendasAeronave.Name = "lblKgEncomiendasAeronave";
            this.lblKgEncomiendasAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblKgEncomiendasAeronave.TabIndex = 24;
            // 
            // lblTipoServicioAeronave
            // 
            this.lblTipoServicioAeronave.AutoSize = true;
            this.lblTipoServicioAeronave.Location = new System.Drawing.Point(215, 50);
            this.lblTipoServicioAeronave.Name = "lblTipoServicioAeronave";
            this.lblTipoServicioAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblTipoServicioAeronave.TabIndex = 23;
            // 
            // lblMatriculaAeronave
            // 
            this.lblMatriculaAeronave.AutoSize = true;
            this.lblMatriculaAeronave.Location = new System.Drawing.Point(215, 25);
            this.lblMatriculaAeronave.Name = "lblMatriculaAeronave";
            this.lblMatriculaAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblMatriculaAeronave.TabIndex = 12;
            // 
            // lblModeloAeronave
            // 
            this.lblModeloAeronave.AutoSize = true;
            this.lblModeloAeronave.Location = new System.Drawing.Point(215, 132);
            this.lblModeloAeronave.Name = "lblModeloAeronave";
            this.lblModeloAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblModeloAeronave.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fabricante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Modelo";
            // 
            // lblCantButacasAeronave
            // 
            this.lblCantButacasAeronave.AutoSize = true;
            this.lblCantButacasAeronave.Location = new System.Drawing.Point(214, 103);
            this.lblCantButacasAeronave.Name = "lblCantButacasAeronave";
            this.lblCantButacasAeronave.Size = new System.Drawing.Size(0, 13);
            this.lblCantButacasAeronave.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad de Butacas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kg Disponibles para Encomiendas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo de Servicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-224, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fabricante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-224, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Matrícula";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-224, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aeropuerto Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Aeropuerto Origen";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dtpFechaYHoraSalida);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.destinoComboBox);
            this.groupBox2.Controls.Add(this.origenComboBox);
            this.groupBox2.Controls.Add(this.dtpFechaYHoraLlegada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(325, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 250);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Vuelo";
            // 
            // dtpFechaYHoraSalida
            // 
            this.dtpFechaYHoraSalida.CustomFormat = "dd/MM/yyy - HH:mm:ss";
            this.dtpFechaYHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaYHoraSalida.Location = new System.Drawing.Point(12, 153);
            this.dtpFechaYHoraSalida.Name = "dtpFechaYHoraSalida";
            this.dtpFechaYHoraSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaYHoraSalida.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Fecha y hora de salida del vuelo";
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Location = new System.Drawing.Point(12, 96);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinoComboBox.TabIndex = 8;
            // 
            // origenComboBox
            // 
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(12, 43);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(121, 21);
            this.origenComboBox.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(459, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarAeronave
            // 
            this.btnBuscarAeronave.AccessibleName = "buscarAeronave";
            this.btnBuscarAeronave.Location = new System.Drawing.Point(213, 290);
            this.btnBuscarAeronave.Name = "btnBuscarAeronave";
            this.btnBuscarAeronave.Size = new System.Drawing.Size(84, 34);
            this.btnBuscarAeronave.TabIndex = 9;
            this.btnBuscarAeronave.Text = "Buscar Aeronave";
            this.btnBuscarAeronave.UseVisualStyleBackColor = true;
            this.btnBuscarAeronave.Click += new System.EventHandler(this.btnBuscarAeronave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione la matrícula de la Aeronave";
            // 
            // matriculasComboBox
            // 
            this.matriculasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriculasComboBox.FormattingEnabled = true;
            this.matriculasComboBox.Location = new System.Drawing.Point(36, 298);
            this.matriculasComboBox.Name = "matriculasComboBox";
            this.matriculasComboBox.Size = new System.Drawing.Size(150, 21);
            this.matriculasComboBox.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(21, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Registro
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.matriculasComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarAeronave);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Registro";
            this.Text = "Registro de llegada a destino";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaYHoraLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarAeronave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMatriculaAeronave;
        private System.Windows.Forms.Label lblFabricanteAeronave;
        private System.Windows.Forms.Label lblModeloAeronave;
        private System.Windows.Forms.Label lblCantButacasAeronave;
        private System.Windows.Forms.Label lblKgEncomiendasAeronave;
        private System.Windows.Forms.Label lblTipoServicioAeronave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox matriculasComboBox;
        private ComboBox destinoComboBox;
        private ComboBox origenComboBox;
        private DateTimePicker dtpFechaYHoraSalida;
        private Label label12;
        private Button btnCancelar;
    }
}
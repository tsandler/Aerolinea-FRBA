namespace AerolineaFrba.Listado_Estadistico
{
    partial class Estadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadistica));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcEstadisticas = new System.Windows.Forms.TabControl();
            this.tablaDestinosMasComprados = new System.Windows.Forms.TabPage();
            this.dgvDestinosMasPasajesComprados = new System.Windows.Forms.DataGridView();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajesComprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDestinosConAeronavesMasVacias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantAcientosVacios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvClientesConMasPuntos = new System.Windows.Forms.DataGridView();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDestinosConPasajesCancelados = new System.Windows.Forms.DataGridView();
            this.ciudadPasajeCancelados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPasajesCancelados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvAeronavesConMayorCantDiasFueraDeServicio = new System.Windows.Forms.DataGridView();
            this.matriculaAeronave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDiasFueraDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tcEstadisticas.SuspendLayout();
            this.tablaDestinosMasComprados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosMasPasajesComprados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosConAeronavesMasVacias)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesConMasPuntos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosConPasajesCancelados)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronavesConMayorCantDiasFueraDeServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(200, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado Estadístico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(255, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOP 5";
            // 
            // tcEstadisticas
            // 
            this.tcEstadisticas.Controls.Add(this.tablaDestinosMasComprados);
            this.tcEstadisticas.Controls.Add(this.tabPage2);
            this.tcEstadisticas.Controls.Add(this.tabPage3);
            this.tcEstadisticas.Controls.Add(this.tabPage4);
            this.tcEstadisticas.Controls.Add(this.tabPage5);
            this.tcEstadisticas.Location = new System.Drawing.Point(12, 94);
            this.tcEstadisticas.Name = "tcEstadisticas";
            this.tcEstadisticas.SelectedIndex = 0;
            this.tcEstadisticas.Size = new System.Drawing.Size(602, 238);
            this.tcEstadisticas.TabIndex = 8;
            // 
            // tablaDestinosMasComprados
            // 
            this.tablaDestinosMasComprados.Controls.Add(this.dgvDestinosMasPasajesComprados);
            this.tablaDestinosMasComprados.Location = new System.Drawing.Point(4, 22);
            this.tablaDestinosMasComprados.Name = "tablaDestinosMasComprados";
            this.tablaDestinosMasComprados.Padding = new System.Windows.Forms.Padding(3);
            this.tablaDestinosMasComprados.Size = new System.Drawing.Size(594, 212);
            this.tablaDestinosMasComprados.TabIndex = 0;
            this.tablaDestinosMasComprados.Text = "Distinos con más pasajes comprados";
            this.tablaDestinosMasComprados.UseVisualStyleBackColor = true;
            // 
            // dgvDestinosMasPasajesComprados
            // 
            this.dgvDestinosMasPasajesComprados.AllowUserToAddRows = false;
            this.dgvDestinosMasPasajesComprados.AllowUserToDeleteRows = false;
            this.dgvDestinosMasPasajesComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosMasPasajesComprados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudad,
            this.pasajesComprados});
            this.dgvDestinosMasPasajesComprados.Location = new System.Drawing.Point(6, 6);
            this.dgvDestinosMasPasajesComprados.Name = "dgvDestinosMasPasajesComprados";
            this.dgvDestinosMasPasajesComprados.ReadOnly = true;
            this.dgvDestinosMasPasajesComprados.Size = new System.Drawing.Size(585, 210);
            this.dgvDestinosMasPasajesComprados.TabIndex = 0;
            // 
            // ciudad
            // 
            this.ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudad.HeaderText = "Cuidad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // pasajesComprados
            // 
            this.pasajesComprados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pasajesComprados.HeaderText = "Cantidad de pasajes comprados";
            this.pasajesComprados.Name = "pasajesComprados";
            this.pasajesComprados.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDestinosConAeronavesMasVacias);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Destinos con aeronaves mas vacías";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDestinosConAeronavesMasVacias
            // 
            this.dgvDestinosConAeronavesMasVacias.AllowUserToAddRows = false;
            this.dgvDestinosConAeronavesMasVacias.AllowUserToDeleteRows = false;
            this.dgvDestinosConAeronavesMasVacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosConAeronavesMasVacias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cantAcientosVacios});
            this.dgvDestinosConAeronavesMasVacias.Location = new System.Drawing.Point(6, 6);
            this.dgvDestinosConAeronavesMasVacias.Name = "dgvDestinosConAeronavesMasVacias";
            this.dgvDestinosConAeronavesMasVacias.ReadOnly = true;
            this.dgvDestinosConAeronavesMasVacias.Size = new System.Drawing.Size(585, 206);
            this.dgvDestinosConAeronavesMasVacias.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantAcientosVacios
            // 
            this.cantAcientosVacios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantAcientosVacios.HeaderText = "Cantidad de asientos vacios";
            this.cantAcientosVacios.Name = "cantAcientosVacios";
            this.cantAcientosVacios.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvClientesConMasPuntos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(594, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clientes con más puntos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvClientesConMasPuntos
            // 
            this.dgvClientesConMasPuntos.AllowUserToAddRows = false;
            this.dgvClientesConMasPuntos.AllowUserToDeleteRows = false;
            this.dgvClientesConMasPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesConMasPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.apellidoCliente,
            this.cantPuntos});
            this.dgvClientesConMasPuntos.Location = new System.Drawing.Point(6, 6);
            this.dgvClientesConMasPuntos.Name = "dgvClientesConMasPuntos";
            this.dgvClientesConMasPuntos.ReadOnly = true;
            this.dgvClientesConMasPuntos.Size = new System.Drawing.Size(585, 206);
            this.dgvClientesConMasPuntos.TabIndex = 1;
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCliente.HeaderText = "Nombre";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoCliente.HeaderText = "Apellido";
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.ReadOnly = true;
            // 
            // cantPuntos
            // 
            this.cantPuntos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantPuntos.HeaderText = "Cantidad de puntos";
            this.cantPuntos.Name = "cantPuntos";
            this.cantPuntos.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDestinosConPasajesCancelados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(594, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Destinos con pasajes cancelados";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dgvDestinosConPasajesCancelados
            // 
            this.dgvDestinosConPasajesCancelados.AllowUserToAddRows = false;
            this.dgvDestinosConPasajesCancelados.AllowUserToDeleteRows = false;
            this.dgvDestinosConPasajesCancelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosConPasajesCancelados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadPasajeCancelados,
            this.cantPasajesCancelados});
            this.dgvDestinosConPasajesCancelados.Location = new System.Drawing.Point(6, 6);
            this.dgvDestinosConPasajesCancelados.Name = "dgvDestinosConPasajesCancelados";
            this.dgvDestinosConPasajesCancelados.ReadOnly = true;
            this.dgvDestinosConPasajesCancelados.Size = new System.Drawing.Size(585, 203);
            this.dgvDestinosConPasajesCancelados.TabIndex = 2;
            // 
            // ciudadPasajeCancelados
            // 
            this.ciudadPasajeCancelados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadPasajeCancelados.HeaderText = "Destino";
            this.ciudadPasajeCancelados.Name = "ciudadPasajeCancelados";
            this.ciudadPasajeCancelados.ReadOnly = true;
            // 
            // cantPasajesCancelados
            // 
            this.cantPasajesCancelados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantPasajesCancelados.HeaderText = "Cantidad de pasajes cancelados";
            this.cantPasajesCancelados.Name = "cantPasajesCancelados";
            this.cantPasajesCancelados.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvAeronavesConMayorCantDiasFueraDeServicio);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(594, 212);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Aeronaves con mayor cantidad de días fuera de servicio";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvAeronavesConMayorCantDiasFueraDeServicio
            // 
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.AllowUserToAddRows = false;
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.AllowUserToDeleteRows = false;
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaAeronave,
            this.cantidadDiasFueraDeServicio});
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.Location = new System.Drawing.Point(6, 6);
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.Name = "dgvAeronavesConMayorCantDiasFueraDeServicio";
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.ReadOnly = true;
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.Size = new System.Drawing.Size(585, 206);
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.TabIndex = 3;
            this.dgvAeronavesConMayorCantDiasFueraDeServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAeronavesConMayorCantDiasFueraDeServicio_CellContentClick);
            // 
            // matriculaAeronave
            // 
            this.matriculaAeronave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matriculaAeronave.HeaderText = "Matrícula";
            this.matriculaAeronave.Name = "matriculaAeronave";
            this.matriculaAeronave.ReadOnly = true;
            // 
            // cantidadDiasFueraDeServicio
            // 
            this.cantidadDiasFueraDeServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadDiasFueraDeServicio.HeaderText = "Cantidad de días fuera de servicio";
            this.cantidadDiasFueraDeServicio.Name = "cantidadDiasFueraDeServicio";
            this.cantidadDiasFueraDeServicio.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(535, 352);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(647, 395);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tcEstadisticas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadistica";
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.Estadistica_Load);
            this.tcEstadisticas.ResumeLayout(false);
            this.tablaDestinosMasComprados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosMasPasajesComprados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosConAeronavesMasVacias)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesConMasPuntos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosConPasajesCancelados)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronavesConMayorCantDiasFueraDeServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcEstadisticas;
        private System.Windows.Forms.TabPage tablaDestinosMasComprados;
        private System.Windows.Forms.DataGridView dgvDestinosMasPasajesComprados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDestinosConAeronavesMasVacias;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvClientesConMasPuntos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDestinosConPasajesCancelados;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvAeronavesConMayorCantDiasFueraDeServicio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasajesComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadPasajeCancelados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPasajesCancelados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantAcientosVacios;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaAeronave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDiasFueraDeServicio;
    }
}
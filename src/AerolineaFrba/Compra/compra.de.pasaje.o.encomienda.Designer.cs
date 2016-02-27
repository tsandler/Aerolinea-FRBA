namespace AerolineaFrba.Compra
{
    partial class compraPasaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compraPasaje));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSalidaVuelo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.viajeDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantButacasLibres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViajar = new System.Windows.Forms.Button();
            this.btnEncomienda = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(257, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Compra de Pasaje/Encomienda";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpFechaSalidaVuelo);
            this.groupBox3.Location = new System.Drawing.Point(212, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 53);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del vuelo";
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
            this.dtpFechaSalidaVuelo.Location = new System.Drawing.Point(158, 20);
            this.dtpFechaSalidaVuelo.Name = "dtpFechaSalidaVuelo";
            this.dtpFechaSalidaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalidaVuelo.TabIndex = 0;
            this.dtpFechaSalidaVuelo.ValueChanged += new System.EventHandler(this.dtpFechaSalidaVuelo_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(212, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la ruta";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(158, 45);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(172, 21);
            this.cmbDestino.TabIndex = 43;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(158, 19);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(172, 21);
            this.cmbOrigen.TabIndex = 42;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
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
            // dgvViajesDisponibles
            // 
            this.dgvViajesDisponibles.AllowUserToAddRows = false;
            this.dgvViajesDisponibles.AllowUserToDeleteRows = false;
            this.dgvViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viajeDisponible,
            this.cantButacasLibres,
            this.kgDisponibles,
            this.horaSalida,
            this.horaLlegada,
            this.tipoServicio,
            this.costoViaje,
            this.costoEncomienda});
            this.dgvViajesDisponibles.Location = new System.Drawing.Point(12, 238);
            this.dgvViajesDisponibles.MultiSelect = false;
            this.dgvViajesDisponibles.Name = "dgvViajesDisponibles";
            this.dgvViajesDisponibles.ReadOnly = true;
            this.dgvViajesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajesDisponibles.Size = new System.Drawing.Size(845, 133);
            this.dgvViajesDisponibles.TabIndex = 18;
            this.dgvViajesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajesDisponibles_CellContentClick);
            // 
            // viajeDisponible
            // 
            this.viajeDisponible.HeaderText = "Viajes Disponibles";
            this.viajeDisponible.Name = "viajeDisponible";
            this.viajeDisponible.ReadOnly = true;
            this.viajeDisponible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantButacasLibres
            // 
            this.cantButacasLibres.HeaderText = "Cantidad de Butacas Libres";
            this.cantButacasLibres.Name = "cantButacasLibres";
            this.cantButacasLibres.ReadOnly = true;
            this.cantButacasLibres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kgDisponibles
            // 
            this.kgDisponibles.HeaderText = "Kg Disponibles para Encomienda";
            this.kgDisponibles.Name = "kgDisponibles";
            this.kgDisponibles.ReadOnly = true;
            this.kgDisponibles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horaSalida
            // 
            this.horaSalida.HeaderText = "Hora de Salida";
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.ReadOnly = true;
            this.horaSalida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horaLlegada
            // 
            this.horaLlegada.HeaderText = "Hora de Llegada";
            this.horaLlegada.Name = "horaLlegada";
            this.horaLlegada.ReadOnly = true;
            this.horaLlegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            this.tipoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // costoViaje
            // 
            this.costoViaje.HeaderText = "Costo Viaje ($)";
            this.costoViaje.Name = "costoViaje";
            this.costoViaje.ReadOnly = true;
            this.costoViaje.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // costoEncomienda
            // 
            this.costoEncomienda.HeaderText = "Costo Encomienda ($)";
            this.costoEncomienda.Name = "costoEncomienda";
            this.costoEncomienda.ReadOnly = true;
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(581, 401);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(75, 23);
            this.btnViajar.TabIndex = 20;
            this.btnViajar.Text = "Viajar";
            this.btnViajar.UseVisualStyleBackColor = true;
            this.btnViajar.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnEncomienda
            // 
            this.btnEncomienda.Location = new System.Drawing.Point(677, 401);
            this.btnEncomienda.Name = "btnEncomienda";
            this.btnEncomienda.Size = new System.Drawing.Size(115, 23);
            this.btnEncomienda.TabIndex = 21;
            this.btnEncomienda.Text = "Enviar encomienda";
            this.btnEncomienda.UseVisualStyleBackColor = true;
            this.btnEncomienda.Click += new System.EventHandler(this.btnEncomienda_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 401);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 21);
            this.btnMenu.TabIndex = 22;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // compraPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(863, 436);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEncomienda);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.dgvViajesDisponibles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "compraPasaje";
            this.Text = "Compra de pasaje/encomienda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaVuelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvViajesDisponibles;
        private System.Windows.Forms.Button btnViajar;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajeDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantButacasLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoEncomienda;
        private System.Windows.Forms.Button btnEncomienda;
        private System.Windows.Forms.Button btnMenu;
    }
}
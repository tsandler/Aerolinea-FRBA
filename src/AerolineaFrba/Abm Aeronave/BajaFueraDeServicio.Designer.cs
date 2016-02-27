namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaFueraDeServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaFueraDeServicio));
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMatricula = new System.Windows.Forms.ComboBox();
            this.dtpFechaFueraServicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaReinicioServicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDarDeBaja.Location = new System.Drawing.Point(624, 154);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.btnDarDeBaja.TabIndex = 27;
            this.btnDarDeBaja.Text = "Aceptar";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(529, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cbMatricula);
            this.groupBox1.Controls.Add(this.dtpFechaFueraServicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaReinicioServicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 104);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes campos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMatricula
            // 
            this.cbMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatricula.FormattingEnabled = true;
            this.cbMatricula.Location = new System.Drawing.Point(131, 30);
            this.cbMatricula.Name = "cbMatricula";
            this.cbMatricula.Size = new System.Drawing.Size(121, 21);
            this.cbMatricula.TabIndex = 34;
            // 
            // dtpFechaFueraServicio
            // 
            this.dtpFechaFueraServicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFueraServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFueraServicio.Location = new System.Drawing.Point(414, 30);
            this.dtpFechaFueraServicio.Name = "dtpFechaFueraServicio";
            this.dtpFechaFueraServicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFueraServicio.TabIndex = 33;
            this.dtpFechaFueraServicio.ValueChanged += new System.EventHandler(this.dtpFechaFueraServicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número de matrícula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaReinicioServicio
            // 
            this.dtpFechaReinicioServicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaReinicioServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaReinicioServicio.Location = new System.Drawing.Point(414, 56);
            this.dtpFechaReinicioServicio.Name = "dtpFechaReinicioServicio";
            this.dtpFechaReinicioServicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReinicioServicio.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha de reinicio de servicio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de fuera de servicio";
            // 
            // BajaFueraDeServicio
            // 
            this.AcceptButton = this.btnDarDeBaja;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnDarDeBaja;
            this.ClientSize = new System.Drawing.Size(711, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDarDeBaja);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaFueraDeServicio";
            this.Text = "Suspención de aeronave por estar fuera de servicio";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaFueraServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaReinicioServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMatricula;

    }
}
namespace AerolineaFrba.Abm_Rol
{
    partial class quitarFuncionalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quitarFuncionalidad));
            this.dgvShowRoles = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowRoles
            // 
            this.dgvShowRoles.AllowUserToAddRows = false;
            this.dgvShowRoles.AllowUserToDeleteRows = false;
            this.dgvShowRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcionalidad});
            this.dgvShowRoles.Location = new System.Drawing.Point(22, 113);
            this.dgvShowRoles.MultiSelect = false;
            this.dgvShowRoles.Name = "dgvShowRoles";
            this.dgvShowRoles.ReadOnly = true;
            this.dgvShowRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowRoles.Size = new System.Drawing.Size(468, 164);
            this.dgvShowRoles.TabIndex = 58;
            this.dgvShowRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowRoles_CellContentClick);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(18, 33);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(143, 23);
            this.buscar.TabIndex = 56;
            this.buscar.Text = "Buscar funcionalidades";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(22, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 82);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la funcionalidad que desee dar de baja";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(22, 293);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 60;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // funcionalidad
            // 
            this.funcionalidad.HeaderText = "Funcionalidad";
            this.funcionalidad.Name = "funcionalidad";
            this.funcionalidad.ReadOnly = true;
            this.funcionalidad.Width = 450;
            // 
            // quitarFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 324);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvShowRoles);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quitarFuncionalidad";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowRoles;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidad;
    }
}
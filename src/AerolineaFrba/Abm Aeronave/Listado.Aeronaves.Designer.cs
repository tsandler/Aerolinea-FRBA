namespace AerolineaFrba.Abm_Aeronave
{
    partial class Listado_Aeronaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Aeronaves));
            this.listadoAeronaves = new System.Windows.Forms.DataGridView();
            this.seleccionarAeronave = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoAeronaves
            // 
            this.listadoAeronaves.AllowUserToAddRows = false;
            this.listadoAeronaves.AllowUserToDeleteRows = false;
            this.listadoAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAeronaves.Location = new System.Drawing.Point(40, 121);
            this.listadoAeronaves.Name = "listadoAeronaves";
            this.listadoAeronaves.ReadOnly = true;
            this.listadoAeronaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoAeronaves.Size = new System.Drawing.Size(666, 370);
            this.listadoAeronaves.TabIndex = 0;
            this.listadoAeronaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoAeronaves_CellContentClick);
            // 
            // seleccionarAeronave
            // 
            this.seleccionarAeronave.Location = new System.Drawing.Point(504, 511);
            this.seleccionarAeronave.Name = "seleccionarAeronave";
            this.seleccionarAeronave.Size = new System.Drawing.Size(163, 46);
            this.seleccionarAeronave.TabIndex = 1;
            this.seleccionarAeronave.Text = "Seleccionar Aeronave";
            this.seleccionarAeronave.UseVisualStyleBackColor = true;
            this.seleccionarAeronave.Click += new System.EventHandler(this.seleccionarAeronave_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(74, 511);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(163, 46);
            this.btnMenuPrincipal.TabIndex = 2;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de aeronaves";
            // 
            // Listado_Aeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.seleccionarAeronave);
            this.Controls.Add(this.listadoAeronaves);
            this.Name = "Listado_Aeronaves";
            this.Text = "Listado_Aeronaves";
            this.Load += new System.EventHandler(this.Listado_Aeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoAeronaves;
        private System.Windows.Forms.Button seleccionarAeronave;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label label1;
    }
}
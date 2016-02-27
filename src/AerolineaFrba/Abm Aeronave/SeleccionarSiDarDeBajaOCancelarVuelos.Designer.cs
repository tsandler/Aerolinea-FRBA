namespace AerolineaFrba.Abm_Aeronave
{
    partial class SeleccionarSiDarDeBajaOCancelarVuelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarVuelos = new System.Windows.Forms.Button();
            this.btnReemplazarAeronave = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione si desea cancelar los vuelos o reemplazar la aeronave.";
            // 
            // btnCancelarVuelos
            // 
            this.btnCancelarVuelos.Location = new System.Drawing.Point(68, 54);
            this.btnCancelarVuelos.Name = "btnCancelarVuelos";
            this.btnCancelarVuelos.Size = new System.Drawing.Size(126, 23);
            this.btnCancelarVuelos.TabIndex = 1;
            this.btnCancelarVuelos.Text = "Cancelar Vuelos";
            this.btnCancelarVuelos.UseVisualStyleBackColor = true;
            this.btnCancelarVuelos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReemplazarAeronave
            // 
            this.btnReemplazarAeronave.Location = new System.Drawing.Point(243, 54);
            this.btnReemplazarAeronave.Name = "btnReemplazarAeronave";
            this.btnReemplazarAeronave.Size = new System.Drawing.Size(126, 23);
            this.btnReemplazarAeronave.TabIndex = 2;
            this.btnReemplazarAeronave.Text = "Reemplazar Aeronave";
            this.btnReemplazarAeronave.UseVisualStyleBackColor = true;
            this.btnReemplazarAeronave.Click += new System.EventHandler(this.btnReemplazarAeronave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(182, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SeleccionarSiDarDeBajaOCancelarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 129);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReemplazarAeronave);
            this.Controls.Add(this.btnCancelarVuelos);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarSiDarDeBajaOCancelarVuelos";
            this.Text = "Baja Aeronave";
            this.Load += new System.EventHandler(this.SeleccionarSiDarDeBajaOCancelarVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarVuelos;
        private System.Windows.Forms.Button btnReemplazarAeronave;
        private System.Windows.Forms.Button btnCancelar;
    }
}
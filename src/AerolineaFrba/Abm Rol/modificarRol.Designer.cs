namespace AerolineaFrba.Abm_Rol
{
    partial class modificarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarRol));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.modificarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agregarFuncionalidad = new System.Windows.Forms.Button();
            this.quitarFunc = new System.Windows.Forms.Button();
            this.btn_altaRolExistente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(22, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de modificación que desee realizar";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(172, 304);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // modificarNombre
            // 
            this.modificarNombre.Location = new System.Drawing.Point(26, 205);
            this.modificarNombre.Name = "modificarNombre";
            this.modificarNombre.Size = new System.Drawing.Size(156, 27);
            this.modificarNombre.TabIndex = 5;
            this.modificarNombre.Text = "Modificar el nombre de un rol";
            this.modificarNombre.UseVisualStyleBackColor = true;
            this.modificarNombre.Click += new System.EventHandler(this.modificarNombre_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el rol que desea modificar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 82);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre del rol";
            // 
            // agregarFuncionalidad
            // 
            this.agregarFuncionalidad.Location = new System.Drawing.Point(230, 205);
            this.agregarFuncionalidad.Name = "agregarFuncionalidad";
            this.agregarFuncionalidad.Size = new System.Drawing.Size(156, 27);
            this.agregarFuncionalidad.TabIndex = 62;
            this.agregarFuncionalidad.Text = "Agregar una funcionalidad";
            this.agregarFuncionalidad.UseVisualStyleBackColor = true;
            this.agregarFuncionalidad.Click += new System.EventHandler(this.agregarFuncionalidad_Click);
            // 
            // quitarFunc
            // 
            this.quitarFunc.Location = new System.Drawing.Point(230, 254);
            this.quitarFunc.Name = "quitarFunc";
            this.quitarFunc.Size = new System.Drawing.Size(156, 27);
            this.quitarFunc.TabIndex = 63;
            this.quitarFunc.Text = "Quitar una funcionalidad";
            this.quitarFunc.UseVisualStyleBackColor = true;
            this.quitarFunc.Click += new System.EventHandler(this.quitarFunc_Click);
            // 
            // btn_altaRolExistente
            // 
            this.btn_altaRolExistente.Location = new System.Drawing.Point(26, 254);
            this.btn_altaRolExistente.Name = "btn_altaRolExistente";
            this.btn_altaRolExistente.Size = new System.Drawing.Size(156, 27);
            this.btn_altaRolExistente.TabIndex = 64;
            this.btn_altaRolExistente.Text = "Habilitar un rol existente";
            this.btn_altaRolExistente.UseVisualStyleBackColor = true;
            this.btn_altaRolExistente.Click += new System.EventHandler(this.btn_altaRolExistente_Click);
            // 
            // modificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(429, 341);
            this.Controls.Add(this.btn_altaRolExistente);
            this.Controls.Add(this.quitarFunc);
            this.Controls.Add(this.agregarFuncionalidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificarNombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label1);
            this.Name = "modificarRol";
            this.Text = "Modificar Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button modificarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregarFuncionalidad;
        private System.Windows.Forms.Button quitarFunc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_altaRolExistente;
    }
}
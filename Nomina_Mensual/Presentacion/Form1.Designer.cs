namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Identificacion = new System.Windows.Forms.Label();
            this.lbl_SalarioB = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_Identificacion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Registar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_SalarioB = new System.Windows.Forms.TextBox();
            this.Rb_Activo = new System.Windows.Forms.RadioButton();
            this.Rb_Inactivo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_Identificacion
            // 
            this.lbl_Identificacion.AutoSize = true;
            this.lbl_Identificacion.Location = new System.Drawing.Point(9, 13);
            this.lbl_Identificacion.Name = "lbl_Identificacion";
            this.lbl_Identificacion.Size = new System.Drawing.Size(92, 13);
            this.lbl_Identificacion.TabIndex = 0;
            this.lbl_Identificacion.Text = "IDENTIFICACION";
            // 
            // lbl_SalarioB
            // 
            this.lbl_SalarioB.AutoSize = true;
            this.lbl_SalarioB.Location = new System.Drawing.Point(9, 79);
            this.lbl_SalarioB.Name = "lbl_SalarioB";
            this.lbl_SalarioB.Size = new System.Drawing.Size(84, 13);
            this.lbl_SalarioB.TabIndex = 1;
            this.lbl_SalarioB.Text = "SALARIO BASE";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(9, 117);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(51, 13);
            this.lbl_Estado.TabIndex = 2;
            this.lbl_Estado.Text = "ESTADO";
            // 
            // Txt_Identificacion
            // 
            this.Txt_Identificacion.Location = new System.Drawing.Point(99, 10);
            this.Txt_Identificacion.Name = "Txt_Identificacion";
            this.Txt_Identificacion.Size = new System.Drawing.Size(204, 20);
            this.Txt_Identificacion.TabIndex = 3;
            this.Txt_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Identificacion_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(99, 43);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(203, 20);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Salario_KeyPress);
            // 
            // Btn_Registar
            // 
            this.Btn_Registar.Location = new System.Drawing.Point(165, 138);
            this.Btn_Registar.Name = "Btn_Registar";
            this.Btn_Registar.Size = new System.Drawing.Size(101, 38);
            this.Btn_Registar.TabIndex = 6;
            this.Btn_Registar.Text = "REGISTRAR";
            this.Btn_Registar.UseVisualStyleBackColor = true;
            this.Btn_Registar.Click += new System.EventHandler(this.Btn_Registar_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(9, 46);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "NOMBRE ";
            // 
            // Txt_SalarioB
            // 
            this.Txt_SalarioB.Location = new System.Drawing.Point(99, 76);
            this.Txt_SalarioB.Name = "Txt_SalarioB";
            this.Txt_SalarioB.Size = new System.Drawing.Size(204, 20);
            this.Txt_SalarioB.TabIndex = 8;
            this.Txt_SalarioB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SalarioB_KeyPress);
            // 
            // Rb_Activo
            // 
            this.Rb_Activo.AutoSize = true;
            this.Rb_Activo.Location = new System.Drawing.Point(99, 115);
            this.Rb_Activo.Name = "Rb_Activo";
            this.Rb_Activo.Size = new System.Drawing.Size(64, 17);
            this.Rb_Activo.TabIndex = 9;
            this.Rb_Activo.TabStop = true;
            this.Rb_Activo.Text = "ACTIVO";
            this.Rb_Activo.UseVisualStyleBackColor = true;
            // 
            // Rb_Inactivo
            // 
            this.Rb_Inactivo.AutoSize = true;
            this.Rb_Inactivo.Location = new System.Drawing.Point(208, 115);
            this.Rb_Inactivo.Name = "Rb_Inactivo";
            this.Rb_Inactivo.Size = new System.Drawing.Size(75, 17);
            this.Rb_Inactivo.TabIndex = 10;
            this.Rb_Inactivo.TabStop = true;
            this.Rb_Inactivo.Text = "INACTIVO";
            this.Rb_Inactivo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 188);
            this.Controls.Add(this.Rb_Inactivo);
            this.Controls.Add(this.Rb_Activo);
            this.Controls.Add(this.Txt_SalarioB);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.Btn_Registar);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Identificacion);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_SalarioB);
            this.Controls.Add(this.lbl_Identificacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Identificacion;
        private System.Windows.Forms.Label lbl_SalarioB;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Identificacion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Registar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_SalarioB;
        private System.Windows.Forms.RadioButton Rb_Activo;
        private System.Windows.Forms.RadioButton Rb_Inactivo;
    }
}


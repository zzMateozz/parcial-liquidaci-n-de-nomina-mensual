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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Año = new System.Windows.Forms.TextBox();
            this.Txt_Mes = new System.Windows.Forms.TextBox();
            this.Txt_Nombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.List_Productos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Estados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Identificacion
            // 
            this.lbl_Identificacion.AutoSize = true;
            this.lbl_Identificacion.Location = new System.Drawing.Point(9, 45);
            this.lbl_Identificacion.Name = "lbl_Identificacion";
            this.lbl_Identificacion.Size = new System.Drawing.Size(92, 13);
            this.lbl_Identificacion.TabIndex = 0;
            this.lbl_Identificacion.Text = "IDENTIFICACION";
            // 
            // lbl_SalarioB
            // 
            this.lbl_SalarioB.AutoSize = true;
            this.lbl_SalarioB.Location = new System.Drawing.Point(9, 111);
            this.lbl_SalarioB.Name = "lbl_SalarioB";
            this.lbl_SalarioB.Size = new System.Drawing.Size(84, 13);
            this.lbl_SalarioB.TabIndex = 1;
            this.lbl_SalarioB.Text = "SALARIO BASE";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(9, 149);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(51, 13);
            this.lbl_Estado.TabIndex = 2;
            this.lbl_Estado.Text = "ESTADO";
            // 
            // Txt_Identificacion
            // 
            this.Txt_Identificacion.Location = new System.Drawing.Point(99, 42);
            this.Txt_Identificacion.Name = "Txt_Identificacion";
            this.Txt_Identificacion.Size = new System.Drawing.Size(204, 20);
            this.Txt_Identificacion.TabIndex = 3;
            this.Txt_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Identificacion_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(99, 75);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(203, 20);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Salario_KeyPress);
            // 
            // Btn_Registar
            // 
            this.Btn_Registar.Location = new System.Drawing.Point(116, 188);
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
            this.lbl_Nombre.Location = new System.Drawing.Point(9, 78);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "NOMBRE ";
            // 
            // Txt_SalarioB
            // 
            this.Txt_SalarioB.Location = new System.Drawing.Point(99, 108);
            this.Txt_SalarioB.Name = "Txt_SalarioB";
            this.Txt_SalarioB.Size = new System.Drawing.Size(204, 20);
            this.Txt_SalarioB.TabIndex = 8;
            this.Txt_SalarioB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SalarioB_KeyPress);
            // 
            // Rb_Activo
            // 
            this.Rb_Activo.AutoSize = true;
            this.Rb_Activo.Location = new System.Drawing.Point(99, 147);
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
            this.Rb_Inactivo.Location = new System.Drawing.Point(208, 147);
            this.Rb_Inactivo.Name = "Rb_Inactivo";
            this.Rb_Inactivo.Size = new System.Drawing.Size(75, 17);
            this.Rb_Inactivo.TabIndex = 10;
            this.Rb_Inactivo.TabStop = true;
            this.Rb_Inactivo.Text = "INACTIVO";
            this.Rb_Inactivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "GESTION EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "GESTION LIQUIDACION";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "REALIZAR LIQUIDACION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "AÑO Y MES DE LIQUIDACION (NOMINA)";
            // 
            // Txt_Año
            // 
            this.Txt_Año.Location = new System.Drawing.Point(12, 346);
            this.Txt_Año.Name = "Txt_Año";
            this.Txt_Año.Size = new System.Drawing.Size(59, 20);
            this.Txt_Año.TabIndex = 25;
            // 
            // Txt_Mes
            // 
            this.Txt_Mes.Location = new System.Drawing.Point(77, 346);
            this.Txt_Mes.Name = "Txt_Mes";
            this.Txt_Mes.Size = new System.Drawing.Size(59, 20);
            this.Txt_Mes.TabIndex = 26;
            // 
            // Txt_Nombres
            // 
            this.Txt_Nombres.Location = new System.Drawing.Point(494, 232);
            this.Txt_Nombres.Name = "Txt_Nombres";
            this.Txt_Nombres.Size = new System.Drawing.Size(204, 20);
            this.Txt_Nombres.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Estado";
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Location = new System.Drawing.Point(606, 281);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(92, 25);
            this.Btn_Filtrar.TabIndex = 31;
            this.Btn_Filtrar.Text = "FILTRAR";
            this.Btn_Filtrar.UseVisualStyleBackColor = true;
            this.Btn_Filtrar.Click += new System.EventHandler(this.Btn_Filtrar_Click);
            // 
            // List_Productos
            // 
            this.List_Productos.FormattingEnabled = true;
            this.List_Productos.Location = new System.Drawing.Point(382, 41);
            this.List_Productos.Name = "List_Productos";
            this.List_Productos.Size = new System.Drawing.Size(316, 173);
            this.List_Productos.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre";
            // 
            // Txt_Estados
            // 
            this.Txt_Estados.FormattingEnabled = true;
            this.Txt_Estados.Items.AddRange(new object[] {
            "Activos",
            "Inactivos",
            "Todos"});
            this.Txt_Estados.Location = new System.Drawing.Point(494, 254);
            this.Txt_Estados.Name = "Txt_Estados";
            this.Txt_Estados.Size = new System.Drawing.Size(121, 21);
            this.Txt_Estados.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Estados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.List_Productos);
            this.Controls.Add(this.Btn_Filtrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Nombres);
            this.Controls.Add(this.Txt_Mes);
            this.Controls.Add(this.Txt_Año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Año;
        private System.Windows.Forms.TextBox Txt_Mes;
        private System.Windows.Forms.TextBox Txt_Nombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.ListBox List_Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Txt_Estados;
        private System.Windows.Forms.Label label5;
    }
}


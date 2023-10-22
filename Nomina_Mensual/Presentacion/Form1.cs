using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empleado empleado = new Empleado(); 
        Manejo_Formulario mf = new Manejo_Formulario();
        Servicio_Empleado Se = new Servicio_Empleado();

        private void Txt_Nombre_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            mf.ValidarLetras(e, Txt_Nombre);
                       
        }

        private void Btn_Registar_Click(object sender, EventArgs e)
        {
            bool Id_vacia=true;
            bool Nombre_vacia = true;
            bool Salario_vacia = true;
            bool Estado_vacia = true;
            Id_vacia = Se.Casilla_IdVacia(Txt_Identificacion);
            empleado.N_Identificacion = Txt_Identificacion.Text;
            Nombre_vacia = Se.Casilla_NombreVacia(Txt_Nombre);
            empleado.Nombre = Txt_Nombre.Text;
            Salario_vacia = Se.Casilla_SalarioVacia(Txt_SalarioB);
            empleado.Salario = float.Parse(Txt_SalarioB.Text);
            Estado_vacia = Se.Casillas_VaciasEstado(Rb_Activo, Rb_Inactivo);
            Se.Registrar(Id_vacia,Nombre_vacia,Salario_vacia,Estado_vacia,empleado,Txt_Identificacion);

        }

        private void Txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            mf.validarN(e,Txt_Identificacion);
        }

        private void Txt_SalarioB_KeyPress(object sender, KeyPressEventArgs e)
        {
            mf.validarN(e, Txt_SalarioB);
        }
    }
}

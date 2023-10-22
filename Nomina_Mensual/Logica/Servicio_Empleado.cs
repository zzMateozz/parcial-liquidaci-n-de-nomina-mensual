using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Servicio_Empleado
    {
        Archivos archivos = new Archivos();
        List<Empleado> empleados = new List<Empleado>();
        
        public bool Casillas_VaciasEstado(RadioButton activo,RadioButton inactivo)
        {
            bool verificar = false;
            if (activo.Checked==false && inactivo.Checked == false)
            {
                MessageBox.Show("Datos vacios en ESTADO");
                verificar = true;
            }
            return verificar;
        }
        public bool Casilla_SalarioVacia(TextBox salario)
        {
            bool Verificar_salario = false;
            if (salario.Text == "")
            {
                Verificar_salario = true;
                MessageBox.Show("Datos vacios en SALARIO");
            }
            return Verificar_salario;
        }
        public bool Casilla_IdVacia(TextBox id)
        {
            bool Verificar_ID = false;
            if(id.Text == "")
            {
                Verificar_ID = true;
                MessageBox.Show("Datos vacios en IDENTIFIACION");
            }
            return Verificar_ID;
        }
        public bool Casilla_NombreVacia(TextBox nombre)
        {
            bool verificarNombre = false;
            if (nombre.Text == "")
            {
                MessageBox.Show("Datos vacios en NOMBRE");
                verificarNombre = true;
            }
            return verificarNombre;
        }


        public void Registrar(bool identificacion,bool nombre,bool salario,bool estado,Empleado empleado,TextBox id)
        {
            if (identificacion == false)
            {
                if(nombre == false)
                {
                    if(salario == false)
                    {
                        if(estado == false)
                        {
                            GuardarEmpleado(id.Text,empleado);
                            MessageBox.Show("Empleado Registrado");
                        }
                    }
                }
            }
        }
        public void GuardarEmpleado(string id,Empleado empleado)
        {
            bool encontrado = false;
            try
            {
                if (empleado != null)
                {
                    if (empleados == null)
                    {
                        archivos.GuardarEstablecimiento(empleado);
                        Console.WriteLine("Empleado registrado correctamente");
                    }
                    else
                    {
                        foreach (var item in empleados)
                        {

                            if (item.N_Identificacion == id)
                            {
                                Console.WriteLine("Empleado ya existe");
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            archivos.GuardarEstablecimiento(empleado);
                            Console.WriteLine("Empleado registrado correctamente");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Empleado no puede ser nulo");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error al guardar Empleado");
            }
        }

        void Refresh()
        {
            try
            {
                empleados = archivos.GetAll();
            }
            catch (Exception)
            {

            }
        }
    }
}

using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool Casillas_VaciasEstado(RadioButton activo, RadioButton inactivo)
        {
            bool verificar = false;
            if (activo.Checked == false && inactivo.Checked == false)
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
            if (id.Text == "")
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


        public void Registrar(bool identificacion, bool nombre, bool salario, bool estado, Empleado empleado, TextBox id)
        {
            if (identificacion == false)
            {
                if (nombre == false)
                {
                    if (salario == false)
                    {
                        if (estado == false)
                        {
                            GuardarEmpleado(id.Text, empleado);
                            MessageBox.Show("Empleado Registrado");
                        }
                    }
                }
            }
        }
        public void GuardarEmpleado(string id, Empleado empleado)
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

                            if (item.N_Identificacion.Equals(id))
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
        public void FilterDataGridView(TextBox filtro, DataGridView tabla)
        {
            string nameFilter = filtro.Text;
            string stateFilter = filtro.Text;
            DataTable dataSource = (DataTable)tabla.DataSource;
            if (dataSource != null)
            {
                dataSource.DefaultView.RowFilter = $"Nombre LIKE '%{nameFilter}%' OR Estado LIKE '%{stateFilter}%'";
            }
        }
        public Empleado BuscarId(string id)
        {
            foreach (var item in empleados)
            {
                if (item.Nombre == id || item.Estado == id)
                {
                    return item;
                }
            }
            return null;
        }

        public ConsultaPersonaResponse ConsultarTodos()
        {

            try
            {
                List<Empleado> empleado = archivos.GetAll();
                if (empleado != null)
                {
                    return new ConsultaPersonaResponse(empleado);
                }
                else
                {
                    return new ConsultaPersonaResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new ConsultaPersonaResponse("Error de Aplicacion: " + e.Message);
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
        public class ConsultaPersonaResponse
        {
            public List<Empleado> Empleados { get; set; }
            public string Message { get; set; }
            public bool Encontrado { get; set; }

            public ConsultaPersonaResponse(List<Empleado> empleado)
            {
                Empleados = new List<Empleado>();
                Empleados = empleado;
                Encontrado = true;
            }
            public ConsultaPersonaResponse(string message)
            {
                Message = message;
                Encontrado = false;
            }
        }
    }
}

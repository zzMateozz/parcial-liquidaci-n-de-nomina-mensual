using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivos
    {
        string ruta = "Empleados.txt";
        public void GuardarEstablecimiento(Empleado empleados)
        {
            StreamWriter writer = new StreamWriter(ruta, true);
            writer.WriteLine(empleados.ToString());
            writer.Close();
        }

        public Empleado Mapper(string linea)
        {
            var empleados = new Empleado();
            string[] datos = linea.Split(';');
            empleados.N_Identificacion = datos[0];
            empleados.Nombre = datos[1];
            empleados.Salario = float.Parse(datos[2]);
            return empleados;
        }

        public List<Empleado> GetAll()
        {
            try
            {
                List<Empleado> empleados = new List<Empleado>();
                StreamReader reader = new StreamReader(ruta);
                while (!reader.EndOfStream)
                {
                    empleados.Add(Mapper(reader.ReadLine()));
                }
                reader.Close();
                return empleados;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void EliminarEmpleado(List<Empleado> empleados)
        {
            string rutatemp = "Temporal.txt";
            try
            {
                StreamWriter sw = new StreamWriter(rutatemp, true);
                foreach (var item in empleados)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                File.Delete(ruta);
                File.Move(rutatemp, ruta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo_Liquidacion
    {

        string ruta = "liquidacion.txt";
        public void GuardarLiquidacion(Liquidacion liquidacion)
        {
            StreamWriter writer = new StreamWriter(ruta, true);
            writer.WriteLine(liquidacion.ToString());
            writer.Close();
        }

        public Liquidacion Mapper(string linea)
        {
            var liquidacion = new Liquidacion();
            string[] datos = linea.Split(';');
            liquidacion.ID_Factura = datos[0];
            liquidacion.Año = datos[1];
            liquidacion.Mes = datos[2];
            liquidacion.Total_Salario = double.Parse(datos[3]);
            liquidacion.Total_Pension = double.Parse(datos[4]);
            liquidacion.Total_Auxilio_Transporte = double.Parse(datos[5]);
            liquidacion.Total = double.Parse(datos[6]);
            return liquidacion;
        }
        public List<Liquidacion> GetAll()
        {
            try
            {
                List<Liquidacion> liquidacion = new List<Liquidacion>();
                StreamReader reader = new StreamReader(ruta);
                while (!reader.EndOfStream)
                {
                    liquidacion.Add(Mapper(reader.ReadLine()));
                }
                reader.Close();
                return liquidacion;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}

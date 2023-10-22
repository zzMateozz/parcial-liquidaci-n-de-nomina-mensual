using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Servicio_Liquidacion
    {
        Archivo_Liquidacion Archivo_Liquidacion = new Archivo_Liquidacion();
        List<Liquidacion> liquidaciones = new List<Liquidacion>();
        public bool VerificarAño(TextBox año,TextBox mes)
        {
            bool verificado = false;
            foreach (var item in liquidaciones)
            {
                if (item.Año.Equals(año.Text) && item.Mes.Equals(mes.Text))
                {
                    
                }
                else
                {
                    return true;
                }
            }
            return verificado;
        }
        public void RegistrarLiq(Liquidacion liquidacion)
        {
            Archivo_Liquidacion.GuardarLiquidacion(liquidacion);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        public Liquidacion() { }
        public string ID_Factura { get; set; }
        public string Año { get; set; }
        public string Mes { get; set; }
        public double Total_Salario { get; set; }
        public double Total_Salud { get; set; }
        public double Total_Pension { get; set; }
        public double Total_Auxilio_Transporte { get; set; }
        public double Total { get; set; }

        public Liquidacion(string iD_Factura, string año, string mes, int total_Salario, double total_Pension,double total_Salud, double total_Auxilio_Transporte, double total)
        {
            ID_Factura = iD_Factura;
            Año = año;
            Mes = mes;
            Total_Salario = total_Salario;
            Total_Pension = total_Pension;
            Total_Auxilio_Transporte = total_Auxilio_Transporte;
            Total = total;
        }
        public void TotalSalario(double salario)
        {
            Total_Salario = salario;
        }   
        public void TotalPension()
        {
            Total_Pension = Total_Salario * 0.04;
        }
        public void TotalSalud()
        {
            Total_Salud = Total_Salario * 0.004;
        }
        public void TotalTransporte()
        {
            Total_Auxilio_Transporte = 106.454;
        }
        public void Total_SalarioD()
        {
            Total = Total_Salario -  Total_Salud - Total_Pension + Total_Auxilio_Transporte;
        }
        public override string ToString()
        {
            return $"{ID_Factura};{Año};{Mes},{Total_Salario},{Total_Pension},{Total_Auxilio_Transporte},{Total}";
        }
    }
}

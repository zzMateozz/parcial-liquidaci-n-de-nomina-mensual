﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public Empleado() { }
        public string N_Identificacion { get; set; }
        public string Nombre { get; set; }
        public float Salario { get; set; }
        public string Estado { get; set; }

        public Empleado(string n_Identificacion, string nombre, float salario,string estado)
        {
            N_Identificacion = n_Identificacion;
            Nombre = nombre;
            Salario = salario;
            Estado = estado;
        }
        public override string ToString()
        {
            return $"{N_Identificacion};{Nombre};{Salario},{Estado}";
        }
    }
}

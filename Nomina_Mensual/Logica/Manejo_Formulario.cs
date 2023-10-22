﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Manejo_Formulario
    {
        ErrorProvider Validar = new ErrorProvider();

        public void ValidarLetras(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                Validar.Clear();

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false; Validar.Clear();
            }
            else
            {
                e.Handled = true;
                Validar.SetError(h, "Solo Puede Digitar Letras");
            }
        }
        public ErrorProvider validarN(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            bool error = SoloNumeros(e);
            if (!error)
            {
                Validar.SetError(h, "Solo Puede Digitar Numeros");
                return null;
            }
            else
            {
                Validar.Clear();
                return null;
            }
        }
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false; return true;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false; return true;
            }
            else
            {
                e.Handled = true; return false;
            }
        }
        public void LimitarLongitudTextBox(TextBox textBox, int longitudMaxima, KeyPressEventArgs e)
        {
            if (textBox.Text.Length >= longitudMaxima && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

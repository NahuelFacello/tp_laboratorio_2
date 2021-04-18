using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre dos clases de tipo numero.
        /// </summary>
        /// <param name="num1">Operando 1</param>
        /// <param name="num2">Operando 2</param>
        /// <param name="operador">Operador de tipo string</param>
        /// <returns>Retorna el resultado de la operacion.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            char auxOperador = operador.ToArray()[0];

            switch(ValidarOperador(auxOperador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el operador sea +, -, / o *.
        /// </summary>
        /// <param name="operador">Char a validar si es operador</param>
        /// <returns> Retorna en operador en tipo string. Si no es valido retorna +.</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            switch(operador)
            {
                case '+':
                    retorno = "+";
                    break;
                case '-':
                    retorno = "-";
                    break;
                case '/':
                    retorno = "/";
                    break;
                case '*':
                    retorno = "*";
                    break;
            }
            return retorno;
        }
    }
}

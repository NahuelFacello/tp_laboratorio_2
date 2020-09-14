using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Entidades
{
    public class Calculadora
    {
      

        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double num1 = numero1.numero;
            double num2 = numero2.numero;

            double retorno = 0;
            char operadorChar;
            char.TryParse(operador, out operadorChar);
            if(char.TryParse(operador, out operadorChar) == true &&
                ValidarOperador(operadorChar) != "+.")
            {
                switch(operadorChar)
                {
                    case '+':
                        retorno = num1 + num2;
                        break;
                    case '-':
                        retorno = num1 - num2;
                        break;
                    case '*':
                        retorno = num1 * num2;
                        break;
                    case '/':
                        if(num2 != 0)
                            retorno = num1 / num2;
                        break;
                }
            }

            return retorno;
        }

        static private string ValidarOperador(char operador)
        {
            string retorno;
            switch(operador)
            {
                case '/':
                case '*':
                case '+':
                case '-':
                    retorno = operador.ToString();
                    break;
                default:
                    retorno = "+.";
                    break;
            }

            return retorno;
        }
    }
}

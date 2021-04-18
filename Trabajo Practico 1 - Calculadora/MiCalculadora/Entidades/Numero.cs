using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Propiedad que setea el valor de tipo double en la clase Numero luego validar el string.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// Constructor por defecto, asigna 0
        /// </summary>
        public Numero():this (0)
        {
            
        }
        /// <summary>
        /// Asigna el numero de tipo double a la clase
        /// </summary>
        /// <param name="numero">Numero de tipo double.</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Asigna el numero de tipo string comom double a la clase. Si no es numerico, asigna 0
        /// </summary>
        /// <param name="strNumero">Numero de tipo string</param>
        public Numero(string strNumero) 
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// Valida que el la cadena de string sean numero.Si el valor es invalido retorna 0.
        /// </summary>
        /// <param name="strNumero">string a validar</param>
        /// <returns>Retorna el numero en tipo double.</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double auxRetorno = 0;
            if(double.TryParse(strNumero, out auxRetorno) && !string.IsNullOrEmpty(strNumero))
            {
                retorno = auxRetorno;
            }
            return retorno;
        }
        /// <summary>
        /// Realiza la suma entre dos clases Numero.
        /// </summary>
        /// <param name="num1">Clase Numero</param>
        /// <param name="num2">Clase Numero</param>
        /// <returns>Retorna la suma de las clases.</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        /// <summary>
        /// Realiza la resta entre dos clases Numero.
        /// </summary>
        /// <param name="num1">Clase Numero</param>
        /// <param name="num2">Clase Numero</param>
        /// <returns>Retorna la resta de las clases.</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        /// <summary>
        /// Realiza la multiplicacion entre dos clases Numero.
        /// </summary>
        /// <param name="num1">Clase Numero</param>
        /// <param name="num2">Clase Numero</param>
        /// <returns>Retorna la multiplicacion de las clases.</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        /// <summary>
        /// Realiza la division entre dos clases Numero. En caso el divisor sea 0 retorna double.MinValue
        /// </summary>
        /// <param name="num1">Dividendo</param>
        /// <param name="num2">Divisor</param>
        /// <returns>Retorna la division de las clases.</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double retorno;
            if(num2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = num1.numero / num2.numero;
            }
            return retorno;
        }
        /// <summary>
        /// Valida que el string recibido solo contenga 0 y 1
        /// </summary>
        /// <param name="binario">Tipo string</param>
        /// <returns>true: Es binario; false: No es binario </returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] auxCharArray = new char[binario.Length];

            auxCharArray = binario.ToCharArray();
            for (int i = 0; i < auxCharArray.Length; i++)
            {
                if(auxCharArray[i]!= '0' && auxCharArray[i] != '1')
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario">Numero binario</param>
        /// <returns> Retorna el valor aboluto en decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            int numeroDecimal = 0;
            if(EsBinario(binario))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario.ToArray()[i] == '1')
                    {
                        //Suma elevando a la potencia el valor de la posicion donde se encuentre 1
                        numeroDecimal += Convert.ToInt32(Math.Pow(2, binario.Length - i - 1));
                    }
                }
                retorno = numeroDecimal.ToString();
            }
            return retorno;

        }
        /// <summary>
        /// Convierte un valor de tipo double a binario.
        /// </summary>
        /// <param name="numero">valor de tipo double</param>
        /// <returns>retorna el valor en binario</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            int numeroDecimal = (int)numero;
            if (numero > -1)
            {
                while (numeroDecimal > 0)
                {
                    switch (numeroDecimal % 2)
                    {
                        case 1:
                            numeroBinario = "1" + numeroBinario;
                            break;
                        case 0:
                            numeroBinario = "0" + numeroBinario;
                            break;
                    }
                    numeroDecimal = numeroDecimal / 2;
                }
            }
            else if(numero == 0)
            {
                numeroBinario = "0";
            }
            else
            {
                numeroBinario = "Valor Invalido";
            }
            return numeroBinario;
        }
        /// <summary>
        /// Recibe un valor numerico tipo string decimal y lo convierte a binario. En caso de error retorna "Valor invalido".
        /// </summary>
        /// <param name="numero">Valor de tipo string</param>
        /// <returns>numero en binario</returns>
        public static string DecimalBinario(string numero)
        {
            string numeroBinario = "";
            string retorno = "Valor invalido";
            int auxNumero;

            if(int.TryParse(numero, out auxNumero))
            {
                if (auxNumero > -1)
                {
                    while (auxNumero > 0)
                    {
                        switch (auxNumero % 2)
                        {
                            case 1:
                                numeroBinario = "1" + numeroBinario;
                                break;
                            case 0:
                                numeroBinario = "0" + numeroBinario;
                                break;
                        }
                        auxNumero = auxNumero / 2;
                    }
                }
                else if (auxNumero == 0)
                {
                    numeroBinario = "0";
                }
                else
                {
                    numeroBinario = "Valor Invalido";
                }
                retorno = numeroBinario;
            }
            return retorno; 
        }
    }
}

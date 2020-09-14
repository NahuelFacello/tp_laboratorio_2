using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public double numero;


        private double ValidarNumero (string strNumero)
        {
            double retorno = 0;
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                retorno = numero;
            }
            
            return retorno;
        }
        public string SetNumero
        {

            set { this.numero = ValidarNumero(value); }
        }

        private bool EsBinario (string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            string retorno = "";
            double acumulador = 0;
            int acumulador1 = 1;
            if (EsBinario(binario))
            {

                for (int i = 0 ; i < binario.Length ; i++)
                {
                    if( binario[i] == '1')
                    {

                        for(int j = i+1; j < binario.Length; j++)
                        {
                            acumulador1 = acumulador1 * 2;      
                        }

                        acumulador += acumulador1;
                        acumulador1 = 0;
                        if(i == binario.Length -1 && binario[i] == '1')
                        {
                            acumulador += 1;
                        }
                    }
                }
                retorno =  acumulador.ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }
        public string DecimalBinario(string decimalstr)
        {
            
            int decimalInt;
            string retorno = "";
            
            if (ValidarNumero(decimalstr) != 0)
            {
                if( int.TryParse(decimalstr, out decimalInt))
                {
                    //decimalInt = int.Parse(decimalstr);

                    while (decimalInt > 0)
                    {
                        if(decimalInt % 2 != 0)
                        {
                            retorno = "1" + retorno;
                        }
                        else
                        {
                            retorno = "0" + retorno;
                        }

                        decimalInt = decimalInt / 2;

                    }
                }
                else
                {
                    retorno = "Valor Invalido";
                }
               
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }



    }
}

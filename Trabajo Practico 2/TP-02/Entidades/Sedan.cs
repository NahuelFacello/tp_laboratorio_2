using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {

        #region Atributos

        ETipo tipo;

        #endregion

        #region Constructores
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del vehiculo tipo EMarca</param>
        /// <param name="chasis">Recibe nombre de chasis tipo string</param>
        /// <param name="color">Recibe color tipo console.color</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Crea la instancia de Sedan 
        /// </summary>
        /// <param name="marca">Marca del vehiculo tipo EMarca</param>
        /// <param name="chasis">Recibe nombre de chasis tipo string</param>
        /// <param name="color">Recibe color tipo console.color</param>
        /// <param name="tipo">Recibe tipo de auto de ETipe</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobreesribe la funcion mostrar heredada de Vehiculo agregando la informacion de la propia clase
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

        #region Enumerados
        public enum ETipo { CuatroPuertas, CincoPuertas }

        #endregion
    }
}

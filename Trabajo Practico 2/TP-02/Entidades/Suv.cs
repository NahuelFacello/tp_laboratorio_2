using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Crea una clase SUV heredado de vehiculo
        /// </summary>
        /// <param name="marca">Marca del vehiculo tipo EMarca </param>
        /// <param name="chasis">Recibe nombre de chasis tipo string</param>
        /// <param name="color">Recibe color tipo console.color</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
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

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}" , this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

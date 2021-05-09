using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Atributos

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region Constructores
        /// <summary>
        /// Crea una clase base de tipo vehiculo
        /// </summary>
        /// <param name="chasis"> Chasis del vehiculo </param>
        /// <param name="marca"> Marca del Vehiculo </param>
        /// <param name="color"> Color del vehiculo </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }


        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }


        /// <summary>
        /// Casteo explicito a string para mostrar los datos del vehiculo
        /// </summary>
        /// <param name="vehiculoAMostrar"></param>
        public static explicit operator string(Vehiculo vehiculoAMostrar)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", vehiculoAMostrar.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", vehiculoAMostrar.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", vehiculoAMostrar.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Vehiculo);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }


        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="vehiculo1"></param>
        /// <param name="vehiculo2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1.chasis == vehiculo2.chasis);
        }

        #endregion

        #region Enumerados
        /// <summary>
        /// Lista de Marcas de vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Lista de Tamaño de vehiculo
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion

    }
}

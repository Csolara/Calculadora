using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClase.Servicios
{
    /// <summary>
    /// Interfaz que declara los métodos operativos de la calculadora
    /// 171023 - csl
    /// </summary>
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// Solicita al usuario dos operandos y los suma
        /// </summary>
        /// 171023 - csl
        public void sumar();
        /// <summary>
        /// Solicita al usuario dos operandos y los resta
        /// </summary>
        /// 171023 - csl
        public void restar();
        /// <summary>
        /// Solicita al usuario dos operandos y los multiplica
        /// </summary>
        /// 171023 - csl
        public void multiplicar();
        /// <summary>
        /// Solicita al usuario dos operandos y los divide
        /// </summary>
        /// 171023 - csl
        public void dividir();

    }
}

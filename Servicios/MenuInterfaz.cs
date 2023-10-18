using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClase.Servicios
{
    /// <summary>
    /// Interfaz que declara los métodos relacionados con el funcionamiento del menú
    /// </summary>
    /// 171023 - csl
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra las opciones del menú y solicita al usuario la opción
        /// </summary>
        /// <returns>opción de menú seleccionada</returns>
        public int mostrarMenuYSeleccion();       
    }
}

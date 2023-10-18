using CalculadoraClase.Servicios;

namespace CalculadoraClase.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 171023 - csl
    /// </summary>
    class program
    {
        /// <summary>
        /// Método main de la aplicación, s el núcleo procedimental
        /// </summary>
        /// 171023 - csl
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionesInterfaz oi = new OperacionesImplementacion();

            int opcionSeleccionada;
            bool cerraMenu = false;
            
            while (!cerraMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        cerraMenu = true;
                        break;
                    case 1:
                        oi.sumar();
                        break;
                    case 2:
                        oi.restar();
                        break;
                    case 3:
                        oi.multiplicar();
                        break;
                    case 4:
                        oi.dividir();
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción correcta");
                        break;
                }
            }
        }
    }
}

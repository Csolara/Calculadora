using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClase.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        private double pedirOperando()
        {
            double operando;
            Console.WriteLine("Indique un operando:");
            operando = double.Parse(Console.ReadLine());
            return operando;
        }
        public void dividir()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            Console.WriteLine(operandoUno / operandoDos);
        }
        public void multiplicar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            Console.WriteLine(operandoUno * operandoDos);
        }
        public void restar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            Console.WriteLine(operandoUno - operandoDos);
        }
        public void sumar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            Console.WriteLine(operandoUno + operandoDos);
        }
    }
}

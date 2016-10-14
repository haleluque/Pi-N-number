using System;
using System.Globalization;

namespace PINNumber
{
    internal class Program
    {
        /// <summary>
        /// Método main
        /// </summary>
        private static void Main()
        {
            ////Se inicia el programa
            Console.WriteLine("Bienvenido al programa de generación del número PI");

            var pr = new Program();
            var programa = 0;

            while (programa == 0)
            {
                /* Se ingresa la cantidad de dígitos a los cuales se va a imprimir el numero
                   con un mínimo de 0 y un maximo de la longitud del número capturado
                */
                Console.WriteLine("Por favor ingrese la cantidad de dígitos decimales que quiere observar de PI, el límite es 16");
                var numDigitos = Console.ReadLine();

                try
                {
                    programa = pr.ManejoPrograma(Convert.ToInt32(numDigitos));
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato ingresado debe ser un número entero");
                    programa = 1;
                }
            }

            Console.WriteLine("El programa ha terminado");
            Console.ReadLine();
        }

        /// <summary>
        /// Método para validar si el programa debe seguir o no
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int ManejoPrograma(int valor)
        {
            var pi = Math.PI.ToString(CultureInfo.CurrentCulture);
            var longitud = pi.Length;
            //Se convierte el dato ingresado, para verificar que el dato ingresado es un números
            var digitosNum = Convert.ToInt32(valor);

            if (digitosNum > 0)
            {
                if (digitosNum <= pi.Length)
                {
                    pi = pi.Substring(0, digitosNum);

                    Console.WriteLine($"El valor del número pi es {pi}");

                    return 0;
                }
                Console.WriteLine($"El número de dígitos no puede ser mayor a {longitud}");
                return 1;
            }
            Console.WriteLine("El número de dígitos decimales no puede ser menor o igual a cero");
            return 1;
        }
    }
}

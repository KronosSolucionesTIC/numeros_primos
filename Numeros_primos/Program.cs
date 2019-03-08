using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int limite = 0;
            int cont = 0;

            //Solicita un numero entero al usuario
            Console.Write("Escribe un numero entero que se tomara como limite:");
            //Convierte el valor a entero de 32
            limite = Convert.ToInt32(Console.ReadLine());

            //Realiza ciclo desde 2 hasta el limite ingresado
            for (int i = 2; i <= limite; i++)
            {
                //Realiza ciclo desde 1 hasta el valor del contador i
                for (int j = 1; j <= i; j++)
                {
                    //Verifica el residuo si es igual a 0 para sumar al contador
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                //Verifica el valor del contador ya que si el numero es divisible por 1 y por si
                //mismo es un numero primo, si tiene mas divisiones no es primo
                if (cont < 3)
                {
                    //Muestra en consola el numero primo
                    Console.WriteLine("El numero es primo " + i);
                }
                cont = 0;
            }
            //Muestra en consola el numero limite
            Console.WriteLine("El numero limite es " + limite);
            Console.ReadLine();
        }
    }
}

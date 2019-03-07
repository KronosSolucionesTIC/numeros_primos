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
            int limite = 0;
            int cont = 0;

            Console.Write("Escribe un numero entero:");
            limite = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= limite; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont < 3)
                {
                    Console.WriteLine("El numero es primo " + i);
                }
                cont = 0;
            }
            Console.WriteLine("El numero limite es " + limite);
            Console.ReadLine();
        }
    }
}

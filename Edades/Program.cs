using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            int menor = 0;
            int mayor = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese la edad de la persona " + i + ": ");

                edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 18)
                {
                    menor++;
                }
                else
                {
                    mayor++;
                }
            }
            Console.WriteLine("El número de personas menores de 18 años son : " + menor + " y el número de personas mayores a 18 años son: " + mayor);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            int result = 1;
            Console.WriteLine("ingrese el factorial a calcular");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                result = result * (i + 1);



                Console.WriteLine(" " + (i + 1));
            }
            Console.WriteLine("El factorial de " + num + " es " + result);
            Console.ReadKey();
        }
    }
}

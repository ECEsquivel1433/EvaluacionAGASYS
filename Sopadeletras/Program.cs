using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopadeletras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Console.WriteLine("Ingrese la palabra: ");
            palabra = Console.ReadLine();
            string palabraordenada = new String(palabra.OrderBy(x => x).ToArray());

            Console.WriteLine(palabraordenada);
            Console.ReadKey();
        }
    }
}

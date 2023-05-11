using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palabramaslarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el texto para buscar la palabra mas larga: ");
            string txt = Console.ReadLine();
            string[] palabras = txt.Split();
            string palabramaslarga = "";
            
            foreach(string palabra in palabras)
            {
                if (palabra.Length > palabramaslarga.Length)
                {
                    palabramaslarga = palabra;
                }
            }
            Console.WriteLine("La palabra mas larga es: "+ palabramaslarga);
            Console.ReadKey();
        }

    }
}

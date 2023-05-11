using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabra, palabra2, result = "";
            string[] abc = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            palabra2 = palabra.ToLower();
            string[] letras = new string[palabra2.Length];
            for(int i = 0;i<= palabra2.Length - 1; i++)
            {
                letras[i] = palabra2.Substring(i, 1);
            }
            for(int j = 0; j<= letras.Length - 1; j++)
            {
                for(int k=0; k<= abc.Length - 1; k++)
                {
                    if (letras[j] == abc[k])
                    {
                        result = result + abc[k + 1];
                    }
                }
                
            }
            Console.WriteLine("La palabra resultado es " + "(" + result + ")");
            Console.ReadKey();
        }
    }
}

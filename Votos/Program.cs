using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votos = new int[3];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Voto numero: " + (i + 1));
                int voto = Convert.ToInt32(Console.ReadLine());
                votos[voto - 1]++;
            }
            int maxVotos = votos.Max();
            int minVotos = votos.Min();
            int ganador = Array.IndexOf(votos, maxVotos) + 1;
            int perdedor = Array.IndexOf(votos, minVotos) + 1;
            Console.WriteLine("El ganador es el candidato " + ganador + " con " + maxVotos + " votos.");
            Console.WriteLine("El candidato con menos votos es el " + perdedor + " con " + minVotos + " votos.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            foreach ( string x in vet)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}

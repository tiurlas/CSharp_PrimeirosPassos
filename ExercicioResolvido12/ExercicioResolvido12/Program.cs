using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            
            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');

            
            // Preencher vetor
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);               
            }

            // Imprimir vetor
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");                
            }
            Console.WriteLine();

            // Somar vetor
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));           
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

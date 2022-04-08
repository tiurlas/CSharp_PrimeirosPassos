using System;
using System.Globalization;

namespace ExercicioResolvido13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            // Leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            // Calculo da altura media das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + altura[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // Porcentagem de pessoas abaixo de 16 anos            
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }                     
            double porcentagem = (double) cont / N * 100.00;
            Console.WriteLine("Pessoas com menos de 16 anos: "
                + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}

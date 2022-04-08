using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, porcentagem, salarioNovo;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                porcentagem = 15.0;

            }
            else if (salario <= 800.00)
            {
                porcentagem = 12.0;
            }
            else if (salario <= 1200.0)
            {
                porcentagem = 10.0;
            }
            else if (salario <= 2000.0)
            {
                porcentagem = 7.0;
            }
            else
            {
                porcentagem = 4.0;
            }
            reajuste = salario * porcentagem / 100;
            salarioNovo = reajuste + salario;
            Console.WriteLine("Novo salario: " + salarioNovo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + porcentagem + " %");
        }
    }
}

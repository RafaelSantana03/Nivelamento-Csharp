using System;
using System.Globalization;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] A = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(A[0]);
            int numeroPeca1 = int.Parse(A[1]);
            double valorPeca1 = double.Parse(A[2], CultureInfo.InvariantCulture);

            string[] B = Console.ReadLine().Split(" ");
            int codigoPeca2 = int.Parse(B[0]);
            int numeroPeca2 = int.Parse(B[1]);
            double valorPeca2 = double.Parse(B[2], CultureInfo.InvariantCulture);

            double total = numeroPeca1 * valorPeca1 + numeroPeca2 * valorPeca2;

            Console.WriteLine($"VALOR A PAGAR: {total.ToString("F2")}",CultureInfo.InvariantCulture);
        }
    }
}

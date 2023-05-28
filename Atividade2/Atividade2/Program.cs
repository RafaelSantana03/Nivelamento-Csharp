using System;
using System.Globalization;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double circulo = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = circulo * Math.Pow(raio, 2);
            Console.WriteLine(resultado.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
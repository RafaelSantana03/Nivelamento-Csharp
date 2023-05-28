﻿using System;
using System.Globalization;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2;
            double circulo = Math.Pow(C, 2) * pi;
            double trapezio = (A + B) * C / 2;
            double quadrado = B * B;
            double retangulo = A * B;


            Console.WriteLine($"TRIANGULO {triangulo.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}", CultureInfo.InvariantCulture);
        }
    }
}
  


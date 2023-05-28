using System;
using System.Globalization;

namespace atividade4
{
    class Program
    {
        static void Main(string[] args)
        {           
            int funcionario = int.Parse(Console.ReadLine());
            int horasTB = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTB * valorHora;
            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}", CultureInfo.InvariantCulture);
        }
    }
}
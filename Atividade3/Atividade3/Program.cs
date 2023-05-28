using System;
using System.Globalization;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            int diferença = (A * B - C * D);

            Console.WriteLine($"DIFERENÇA = {diferença}");
        }
    }
}

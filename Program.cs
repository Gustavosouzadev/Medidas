using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string entrada;
            double metros, cm, km;

            Console.Write("Entre com a medida (em metros): ");

            entrada = Console.ReadLine();

            metros = Convert.ToDouble(entrada);
            cm = metros * 100;
            km = metros / 1000;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---Equivalência---");
            
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{cm:N2}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" cm");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{metros:N1}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" m");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{km:N3}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" km");

            Console.ResetColor();

        }
    }
}

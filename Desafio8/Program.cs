using System;

namespace Passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if ((data.Year % 400 == 0) || ((data.Year % 4 == 0) && (data.Year % 100 != 0)))
            {
                Console.WriteLine(data.Year + " é um ano bissexto.");
            }
            else
            {
                Console.WriteLine(data.Year + " não é um ano bissexto.");
            }
            Console.ReadKey();
        }
    }
}
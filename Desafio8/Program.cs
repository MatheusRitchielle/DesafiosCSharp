/*Faça um programa que leia uma data qualquer e mostre se o ano dela é BISSEXTO.*/

using System;

namespace Passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data;

            Console.Write("Informe uma data: ");
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.Write("\nInforme uma data por favor seguindo o padrão DD/MM/AAAA ou DD-MM-AAAA: ");
            }

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
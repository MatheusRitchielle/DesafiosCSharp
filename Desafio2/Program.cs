using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dolar = 5.13;
            Double saldo;

            Console.WriteLine("***** Calculadora de câmbio *****\n");
            Console.Write("Informe quanto você tem na carteira: ");

            while (!Double.TryParse(Console.ReadLine(), out saldo))
            {
                Console.WriteLine("\nNesse campo só são aceitos números");
                Console.Write("Informe quanto você tem na carteira: ");
            }

            var compra = saldo / dolar;
            Console.WriteLine("\nVocê consegue comprar U$" + Math.Round(compra, 2) + " com R$" + Math.Round(saldo, 2));
        }
    }
}
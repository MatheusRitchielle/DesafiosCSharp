using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dolar = 5.13;

            Console.WriteLine("***** Calculadora de câmbio *****\n");
            Console.Write("Informe quanto você tem na carteira: ");
            double saldo = double.Parse(Console.ReadLine());
            var compra = saldo / dolar;

            Console.WriteLine("Você consegue comprar U$" + Math.Round(compra, 2) + " com R$" + Math.Round(saldo, 2));
        }
    }
}

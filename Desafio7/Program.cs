using System;

namespace Passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Double viagemCurta = 0.50;
            Double viagemLonga = 0.45;
            int pontoDeConversao = 200;
            Double valorPassagem;
            Double km;

            Console.WriteLine("Qual a distância da sua viagem (Km): ");

            km = double.Parse(Console.ReadLine());
            if (km <= pontoDeConversao)
            {
                valorPassagem = km * viagemCurta;
                Console.WriteLine("O valor da passagem é: R$" + Math.Round(valorPassagem, 2));
            }
            else
            {
                valorPassagem = km * viagemLonga;
                Console.WriteLine("O valor da passagem é: R$" + Math.Round(valorPassagem, 2));
            }
            Console.ReadKey();
        }
    }
}
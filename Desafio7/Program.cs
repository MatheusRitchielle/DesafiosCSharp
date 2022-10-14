/*Desenvolva um programa que pergunte a distância de uma viagem em km. 
 * Calcule o preço da passagem, cobrando R$ 0,50 por km para viagens de até 200 km 
 * e R$ 0,45 para viagens mais longas.*/

using System;

namespace Desafio7
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

            Console.Write("Informe a distância da sua viagem (Km): ");
            while (!Double.TryParse(Console.ReadLine(), out km))
            {
                Console.Write("Por favor, informe uma Km válida: ");
            }

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
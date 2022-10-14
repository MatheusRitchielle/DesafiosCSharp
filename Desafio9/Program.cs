/*Crie um programa que leia o ano de nascimento de sete pessoas. 
 * No final, mostre quantas pessoas ainda não atingiram a maioridade e quantas já são maiores. 
 * Considere até 17 anos, não atingiram a maioridade de 18 em diante já são maiores.*/

using System;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] anoNascimento = new int[7];
            int menores = 0;
            int maiores = 0;
            int menor = 17;

            for (int i = 0; i < anoNascimento.Length; i++)
            {
                Console.Write("Digite o ano de nascimento: ");
                while(!int.TryParse(Console.ReadLine(), out anoNascimento[i]))
                {
                    Console.Write("\nPor favor, informe apenas o ano: ");
                }

                if (anoNascimento[i] > DateTime.Now.Year)
                {
                    Console.WriteLine("\nEssa pessoa ainda não nasceu, verifique o ano por favor!");
                    i = i - 1;
                }
            }

            foreach (int anoNasc in anoNascimento)
            {
                int anoCorrente = (DateTime.Now.Year - anoNasc);
                if ((DateTime.Now.Year - anoNasc) <= menor)
                {
                    menores = menores + 1;
                }
                else
                {
                    maiores = maiores + 1;
                }
            }

            Console.WriteLine("\n\nEntre " + anoNascimento.Length + " pessoas, " + menores + " são menores e " + maiores + " são maiores");
            Console.ReadKey();
        }
    }
}
/* Escreva um programa que faça o computador "pensar" em um número inteiro entre 0 e 5 
 * e peça para o usuário tentar descobrir qual foi o número escolhido pelo computador. 
 * O programa deverá escrever na tela se o usuário venceu ou perdeu.*/

using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numSorteado = random.Next(6);
            int resposta;

            Console.WriteLine("O computador pensou em um número inteiro de 0 a 5, qual você acha que foi?");
            while (!int.TryParse(Console.ReadLine(), out resposta))
            {
                Console.Write("\nPor favor, tente um número inteiro: ");
            }

            if (resposta == numSorteado)
            {
                Console.WriteLine("\nParabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("\nVocê errou, o número era " + numSorteado);
            }
        }
    }
}
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
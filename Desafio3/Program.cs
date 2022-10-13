using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 3, 19, 10, 22, 23, 9, 7, 32, 2, 16, 21, 13 };
            int maiorValor = lista.Max();
            int menorValor = lista.Min();

            Console.WriteLine("O maior numero é: " + maiorValor);
            Console.WriteLine("O menor numero é: " + menorValor);
            int divisao = maiorValor / menorValor;
            Console.WriteLine("\n" + maiorValor + " dividido por " + menorValor + " é igual a: " + divisao);

            if (lista.Contains(divisao))
            {
                Console.WriteLine("\nExiste uma variável na lista que tem o mesmo valor do resultado da divisão: " + divisao);
            }
            else
            {
                Console.WriteLine("Não uma variável na lista que tem o mesmo valor do resultado da divisão" + divisao);
            }
        }
    }
}
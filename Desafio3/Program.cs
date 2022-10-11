using System;
using System.Collections.Generic;
using System.Linq;

/* Foram removidos os acentos do código para evitar erros do compilador https://www.programiz.com/csharp-programming/online-compiler/ */

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int> { 3, 19, 10, 22, 23, 9, 7, 32, 2, 16, 21, 13 };

            int maiorValor = lista.Max();
            int menorValor = lista.Min();

            Console.WriteLine("O maior numero e: " + maiorValor);
            Console.WriteLine("O menor numero e: " + menorValor);

            int divisao = maiorValor / menorValor;

            Console.WriteLine(maiorValor + " dividido por " + menorValor + " e igual a: " + divisao);

            if (lista.Contains(divisao))
            {
                Console.WriteLine("Existe uma variavel na lista que tem o mesmo valor do resultado da divisao: " + divisao);
            }
            else
            {
                Console.WriteLine("Nao uma variável na lista que tem o mesmo valor do resultado da divisao" + divisao);
            }

        }
    }
}
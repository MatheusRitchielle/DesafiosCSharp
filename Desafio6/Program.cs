using System;

//Foram removidos os acentos do código para evitar erros do compilador >> https://www.programiz.com/csharp-programming/online-compiler/

namespace OrdemDeApresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sorteado = random.Next(6);

            Console.WriteLine("O computador pensou em um numero de 0 a 5, qual voce acha que foi?");

            int resposta = int.Parse(Console.ReadLine());

            if (resposta == sorteado)
            {
                Console.WriteLine("Parabens, voce acertou!");
            }
            else
            {
                Console.WriteLine("Voce errou, o numero era " + sorteado);
            }
        }
    }
}
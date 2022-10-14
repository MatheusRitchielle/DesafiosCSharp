/* Um professor quer sortear um dos seus seis alunos para apagar o quadro. 
 Faça um programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido.*/

using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] alunos = new String[6];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write("Digite o nome do aluno(a): ");
                alunos[i] = Console.ReadLine().ToUpper();
            }

            Random random = new Random();
            int sorteado = random.Next(alunos.Length);
            Console.WriteLine("\n\nO sorteado(a) foi: " + alunos[sorteado]);
        }
    }
}
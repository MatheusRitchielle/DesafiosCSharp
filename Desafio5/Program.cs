using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] alunos = new String[6];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write("Digite o nome do aluno(a): ");
                alunos[i] = Console.ReadLine();
            }

            Random random = new Random();
            for (int i = 0; i < alunos.Length - 1; i++)
            {
                int j = random.Next(i, alunos.Length);
                var temp = alunos[i];
                alunos[i] = alunos[j];
                alunos[j] = temp;
            }

            Console.WriteLine("\nA ordem de apresentacao é: ");
            foreach (string ordem in alunos)
            {
                Console.WriteLine( "- " + ordem);
            }
        }
    }
}
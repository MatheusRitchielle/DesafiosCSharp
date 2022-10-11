using System;

namespace SorteandoAlunos
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] alunos = new String[6];

            Console.WriteLine("Digite o nome dos alunos: ");
            for (int qtdNomes = 0; qtdNomes < alunos.Length; qtdNomes++)
            {
                alunos[qtdNomes] = Console.ReadLine();
            }

            Random random = new Random();
            int sorteado = random.Next(alunos.Length);
            Console.WriteLine("\n\nO aluno(a) sorteado foi: " + alunos[sorteado]);

        }
    }
}
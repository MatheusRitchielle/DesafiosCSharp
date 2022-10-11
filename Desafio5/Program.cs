using System;

//Foram removidos os acentos do código para evitar erros do compilador >> https://www.programiz.com/csharp-programming/online-compiler/

namespace OrdemDeApresentacao
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] alunos = new String[6];

            Console.WriteLine("Digite o nome dos alunos:");
            for (int qtdNomes = 0; qtdNomes < alunos.Length; qtdNomes++)
            {
                alunos[qtdNomes] = Console.ReadLine();
            }

            Random random = new Random();
            int sorteado = random.Next(alunos.Length);

            for (int i = 0; i < alunos.Length - 1; i++)
            {
                int j = random.Next(i, alunos.Length);
                var temp = alunos[i];
                alunos[i] = alunos[j];
                alunos[j] = temp;
            }

            Console.WriteLine("A orde de apresentacao é: ");
            foreach (string ordem in alunos)
            {
                Console.WriteLine(" > " + ordem);
            }
        }
    }
}
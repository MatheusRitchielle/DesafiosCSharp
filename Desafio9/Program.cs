using System;

namespace MenoresMaiores
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
                    Console.Write("Por favor, informe apenas o ano: ");
                }
                //Colocar validação de ano maior que o atual.
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

            Console.WriteLine("Entre " + anoNascimento.Length + " pessoas, " + menores + " são menores e " + maiores + " são maiores");
            Console.ReadKey();
        }
    }
}
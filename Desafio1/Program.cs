using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            string msgErro = "Nesse campo só são aceitos números";

            Console.WriteLine("***** Calculadora de média *****\n");
            Console.Write("Informe a primeira nota: ");

            while(!Double.TryParse(Console.ReadLine(), out nota1))
            {
                Console.WriteLine("\n" + msgErro);
                Console.Write("Informe a primeira nota: ");
            }

            Console.Write("\nInforme a segunda nota: ");
            while (!Double.TryParse(Console.ReadLine(), out nota2))
            {
                Console.WriteLine("\n" + msgErro);
                Console.Write("Informe a segunda nota: ");
            }

            var media = (nota1 + nota2) / 2;
            Console.WriteLine("\n\nA média de notas do aluno(a) é de: " + media);
        }
    }
}
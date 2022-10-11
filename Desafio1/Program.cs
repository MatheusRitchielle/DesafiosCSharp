using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Calculadora de média *****\n");

            Console.Write("Informe a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            var media = (nota1 + nota2) / 2;

            Console.WriteLine("A média de notas do aluno(a) é de: " + media);
        }
    }
}

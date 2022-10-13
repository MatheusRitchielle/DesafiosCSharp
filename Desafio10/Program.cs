using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nome = new List<string>();
            List<int> idade = new List<int>();
            List<String> pais = new List<String>();

            int bebe = 0;   // 0 - 2 anos
            int crianca = 0;// 3 - 12 anos
            int jovem = 0;  // 13 - 17 anos
            int adulto = 0; // 18 - 64 anos
            int idoso = 0;  // 65 anos em diante

            for (int i = 0; i <= 14; i++)
            {
                Console.Write("\n\nDigite o nome: ");
                String cadastroNome = Console.ReadLine().ToUpper();
                if (nome.Contains(cadastroNome))
                {
                    Console.WriteLine("Esse nome já consta em nossa base de dados, verifique por favor =) \n\n");
                    i = i - 1;
                }
                else
                {
                    Console.Write("Digite sua idade: "); 
                    String cadastroIdade = Console.ReadLine();
                    
                    // verifica se a string e composta por numeros
                    if (cadastroIdade.All(Char.IsDigit))
                    {
                        Console.Write("Informe o seu Pais de origem: ");
                        String cadastroPais = Console.ReadLine().ToUpper();

                        nome.Add(cadastroNome);
                        idade.Add(int.Parse(cadastroIdade));
                        pais.Add(cadastroPais);
                    }
                    else
                    {
                        Console.WriteLine("Nesse campo só são aceitos numeros, preecha todo o cadastro novamente!");
                        i = i - 1;
                    }
                }
            }

            Console.WriteLine("\n\n ********** Nacionalidades ********** ");
            //Verifica na lista "pais" todos os que são únicos.
            var unicos = pais.GroupBy(p => p)
                        .Where(g => g.Count() == 1)
                        .Select(p => new { p.Key, Quantidade = p.Count() })
                        .ToList();

            Console.WriteLine(String.Join("\n", unicos));

            //Verifica na lista "pais" todos os que estão duplicados e conta quantas vezes ele repete.
            var duplicados = pais.GroupBy(p => p)
                            .Where(g => g.Count() > 1)
                            .Select(p => new {p.Key, Quantidade = p.Count() })
                            .ToList();

            Console.WriteLine(String.Join("\n", duplicados));

            Console.WriteLine("\n\n ********** Faixa etária ********** ");
            foreach (int fxEtaria in idade)
            {
                if(fxEtaria < 3)
                {
                   bebe = bebe + 1;
                }
                else if (fxEtaria > 2 && fxEtaria < 13)
                {
                    crianca = crianca + 1;
                }
                else if (fxEtaria > 12 && fxEtaria < 18)
                {
                    jovem = jovem + 1;
                }
                else if ( fxEtaria > 17 && fxEtaria < 65)
                {
                    adulto = adulto + 1; 
                }
                else if (fxEtaria > 64)
                {
                     idoso = idoso + 1;
                }
            }

            if (bebe > 0)
            {
                Console.WriteLine("Bebes: " + bebe);
            }
            if (crianca > 0)
            {
                Console.WriteLine("Criancas: " + crianca);
            }
            if (jovem > 0)
            {
                Console.WriteLine("Jovens: " + jovem);
            }
            if (adulto > 0)
            {
                Console.WriteLine("Adultos: " + adulto);
            }
            if (idoso > 0)
            {
                Console.WriteLine("Idosos: " + idoso);
            }

            Console.ReadKey();
        }
    }
}

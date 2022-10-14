/*Faça um programa que recebe os seguintes dados de pessoas:
Nome, Idade, Nacionalidade

- Inserir 15 pessoas na sua lista.
- O atributo Nome deverá ser único, ou seja, a lista não poderá ter dois registros com o mesmo nome, mesmo que para idades ou nacionalidades diferentes.
- retornar a lista de nacionalidade com o respectivo somatório de pessoas; e
- retornar a lista das pessoas agrupadas na faixa etária em cada uma se enquadra (bebe, criança, ..., idoso).*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nome = new List<string>();
            List<int> idade = new List<int>();
            List<String> pais = new List<String>();

            int cadastroIdade;
            int bebe = 0;   // 0 - 2 anos
            int crianca = 0;// 3 - 12 anos
            int jovem = 0;  // 13 - 17 anos
            int adulto = 0; // 18 - 64 anos
            int idoso = 0;  // 65 anos em diante

            for (int i = 0; i <= 14; i++)
            {
                Console.Write("\nDigite o nome: ");
                String cadastroNome = Console.ReadLine().ToUpper();
                if (nome.Contains(cadastroNome))
                {
                    Console.WriteLine("Esse nome já consta em nossa base de dados, verifique por favor =)");
                    i = i - 1;
                }
                else
                {
                    Console.Write("Digite sua idade: "); 
                    while(!int.TryParse(Console.ReadLine(), out cadastroIdade))
                    {
                        Console.Write("Verifique os dados e informe novamente por favor!" +
                            "\n\nDigite sua idade: ");
                    }
                    
                    Console.Write("Informe o seu Pais de origem: ");
                    pais.Add(Console.ReadLine().ToUpper());
                    nome.Add(cadastroNome);
                    idade.Add(cadastroIdade);
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

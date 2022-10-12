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
            String[] nome = new String[5];
            int[] idade = new int[5];
            String[] CadastroPaises = new String[5];

            int bebe = 0;   // 0 - 2 anos
            int crianca = 0;// 3 - 12 anos
            int jovem = 0;  // 13 - 17 anos
            int adulto = 0; // 18 - 64 anos
            int idoso = 0;  // 65 anos em diante

            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write("\n\nDigite o nome: ");
                String cadastroNome = Console.ReadLine().ToUpper();
               
                if (nome.Contains(cadastroNome))
                {
                    Console.WriteLine("Esse nome já consta em nossa base de dados, verifique por favor =) \n\n");
                    /* Como existe um limite na quantidade de cadastros o contador "i" aumenta a cada cadastro 
                     * o que permite uma sequência e uma "posicao", 
                     * mas caso haja algum erro no meio do cadastro esse valor e subtraido por - 1, 
                     * possibilitando utilizar a mesma posiçao onde o erro*/
                    i = i - 1; 
                }
                else
                {
                    Console.Write("Digite sua idade: "); 
                    String cadastroIdade = Console.ReadLine();

                    if (cadastroIdade.All(Char.IsDigit))// verifica se a string e composta por numeros
                    {
                        Console.Write("Informe o seu Pais de origem: ");
                        CadastroPaises[i] = Console.ReadLine().ToUpper();
                        nome[i] = cadastroNome;
                        idade[i] = int.Parse(cadastroIdade);
                    }
                    else
                    {
                        Console.WriteLine("Nesse campo só são aceitos numeros, preecha todo o cadastro novamente!");
                        i = i - 1;
                    }
                }
            }

            Console.WriteLine("\n\n ********** Nacionalidades ********** ");

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

        public enum paises {

            ALEMANHA,
            AUSTRALIA,
            CANADA,
            ESTADOS_UNIDOS,
            FRANCA,
            ITALIA, 
            JAPAO,
            ARGENTINA,
            BRASIL,
            CHINA, 
            TURQUIA,
            RUSSIA,
            MEXICO,
            INDONESIA,
            INDIA,
        }
    }
}

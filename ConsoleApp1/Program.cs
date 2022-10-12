using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string procurar = "cachorro";
            string nomes = "vaca cachorro vaca cachorro gato cavalo cachorro cachorro cachorro cachorro cachorro cachorro";
            MatchCollection matches = Regex.Matches(nomes, procurar);
            foreach (Match item in matches)
            {
                Console.WriteLine(string.Format("{0} = {1}", procurar, item.Index));
            }
            Console.WriteLine(string.Format("achado {0} nomes ", matches.Count));
            Console.ReadKey();
        }
    }
}

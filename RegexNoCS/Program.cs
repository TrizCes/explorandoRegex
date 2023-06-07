using System;
using System.Text.RegularExpressions;

namespace RegexNoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            String alvo = "11a22b33c";
            String pattern = @"(\d\d)(\w)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(alvo);

            Console.WriteLine(match.Value);
            Console.WriteLine(match.Index);
            Console.WriteLine(match.Length);

            Console.WriteLine(match.Groups[0].Value);
            Console.WriteLine(match.Groups[1].Value);
            Console.WriteLine(match.Groups[2].Value);


            MatchCollection matches = regex.Matches(alvo);

            foreach(Match match1 in matches)
            {
                Console.WriteLine("--------------------------");
                Console.Write("Valor: ");
                Console.WriteLine(match1.Value);
                Console.Write("Index: ");
                Console.WriteLine(match1.Index);
                Console.Write("Tamanho: ");
                Console.WriteLine(match1.Length);

                Console.WriteLine(match1.Groups[0].Value);
                Console.WriteLine(match1.Groups[1].Value);
                Console.WriteLine(match1.Groups[2].Value);
                Console.WriteLine("--------------------------");
            }



            Console.WriteLine("-------------------------------");
            Console.WriteLine("----Segunda parte do código----");
            Console.WriteLine("-------------------------------");
            String date = "2007-12-31";

            Regex regexp = new Regex(@"(\d{4})(-)(\d{2})(-)(\d{2})");

            MatchCollection resultados = regexp.Matches(date);

            foreach (Match resultado in resultados)
            {

                string ano = resultado.Groups[1].Value;
                string mes = resultado.Groups[3].Value;
                string dia = resultado.Groups[5].Value;

                string separador1 = resultado.Groups[2].Value;
                string separador2 = resultado.Groups[4].Value;

                Console.WriteLine(string.Format("{0}/{1}/{2}", dia, mes, ano));
            }

            date.Replace("-", "/");
            Console.WriteLine(date);
        }
    }
}

using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.90m; //MOEDAS EM GERAL USAR DECIMAL, SE NÃO ATENDER, UTILIZA OUTRO TIPO DE DADOS.
            Console.WriteLine(valor.ToString("C",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("N",
                CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
using System;
using System.Globalization;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 10.35784;
            int idade = 32;
            char sexo = 'F';
            string nome = "Maria";

            Console.Write("Olá Mundo! ");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.\n");

            Console.WriteLine("Resultado = " + valor + "\n");
            Console.WriteLine("O valor do troco é = " + valor.ToString("F2") + " reais");
            Console.WriteLine("O valor do troco é =" + valor.ToString("F4") + " reais");
            Console.WriteLine("O valor do troco é = " + valor.ToString("F2", CultureInfo.InvariantCulture) +"\n");

            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e seu sexo é: " + sexo);
        }
    }
}
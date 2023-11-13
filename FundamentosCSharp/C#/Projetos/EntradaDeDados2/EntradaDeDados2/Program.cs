using System;
using System.Globalization;

namespace EntradaDeDados2
{
    class Program
    { 
        static void Main(string[] args) 
        {
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou\n{numero1}");

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou\n{ch}");

            double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Você digitou\n{numero2}");

            string[] palavras = Console.ReadLine().Split(", ");

            string nome = palavras[0];
            char sexo = char.Parse(palavras[1]);
            int idade = int.Parse(palavras[2]);
            double altura = double.Parse(palavras[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Ola {nome}, tudo bem? " +
                $"\nSeu sexo é {sexo}" +
                $"\nVocê tem {idade} anos" +
                $"\nSua altura é: {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }   
    }
}
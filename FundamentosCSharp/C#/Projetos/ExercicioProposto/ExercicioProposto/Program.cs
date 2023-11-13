using System.Globalization;

namespace ExercicioProposto
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string NomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separada por virgula seguido de espçao(, ))");
            string[] conjuntoDeInformacoes = Console.ReadLine().Split(", ");
            string sobrenome = conjuntoDeInformacoes[0];
            int idade = int.Parse(conjuntoDeInformacoes[1]);
            double altura = double.Parse(conjuntoDeInformacoes[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Saida:\n");
            Console.WriteLine(NomeCompleto);
            Console.WriteLine(qtdeQuartos);
            Console.WriteLine(Preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
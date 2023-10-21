using System.Globalization;

namespace MedidasLargua
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;
            Console.WriteLine("CALCULADORA DE AREA E PRECO DE TERRENO \n\n");

            Console.WriteLine("Infomr a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Infomr o comprimenta do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Infomr o preço do metro quardado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            preco = area * precoMetroQuadrado;
            Console.WriteLine("A area do terreno é = " + area.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("O preço do terreno é = " + preco.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
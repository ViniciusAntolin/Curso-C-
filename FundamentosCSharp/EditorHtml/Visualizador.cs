using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Visualizador
    {
        public static void Exibir(string texto)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Substituir(texto);
            Console.WriteLine("-----------------");
            Console.ReadLine();
            Menu.Exibir();
        }

        public static void Substituir(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            foreach (var palavra in palavras)
            {
                if (strong.IsMatch(palavra))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavra.Substring(
                            palavra.IndexOf('>') + 1,
                            (
                                (palavra.LastIndexOf('<') - 1) -
                                palavra.IndexOf('>')
                            )
                        ));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavra);
                    Console.Write(" ");
                }
            }

        }
    }
}

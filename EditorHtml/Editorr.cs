using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Exibir()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            System.Console.WriteLine("Modo de Edição");
            System.Console.WriteLine("--------------");
            Iniciar();
        }

        private static void Iniciar()
        {
            var arquivo = new StringBuilder();
            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine.);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            System.Console.WriteLine("--------------");
            System.Console.WriteLine(" Deseja salvar o arquivo?");
            var resposta = Console.ReadLine();
        }
    }
}
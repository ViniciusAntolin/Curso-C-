using System;
using System.Linq.Expressions;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            DesenharTela();
            EscrevasAsOpcoes();
            var opcao = short.Parse(Console.ReadLine());
            ManipularMenuDeOpcoes(opcao);
        }

        public static void DesenharTela()
        {
            CriarMargemInicialFinal();

            CriarMargensLaterais();

            CriarMargemInicialFinal();
        }

        private static void CriarMargensLaterais()
        {
            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        private static void CriarMargemInicialFinal()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        private static void EscrevasAsOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("------------");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("SeIecione uma opção abaixo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 -Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        private static void ManipularMenuDeOpcoes(short opcao) //Handler é usado para manipular algo, é comum ser usado com essa nomenclatura
        {
            switch (opcao)
            {
                case 1: Editor.Exibir(); break;
                case 2: System.Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Exibir(); break;
            }
        }
    }
}
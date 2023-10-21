class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo! \nO que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        System.Console.WriteLine("5 - Sair");
        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine("Selecione uma das opções acima: ");
        short selecao = short.Parse(Console.ReadLine());

        OpcaoSelecionada(selecao);
    }

    private static void OpcaoSelecionada(short selecao)
    {
        switch (selecao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: break;
            default: Console.WriteLine("Você não selecionou nenhuma das opções acima."); Menu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        System.Console.WriteLine("Primeiro valor");
        float? valor1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");
        System.Console.WriteLine("Segundo valor");
        float? valor2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");

        var resultado = valor1 + valor2;

        System.Console.WriteLine($"O resultado da soma é = {resultado}"); //interpolação de strings
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        System.Console.WriteLine("Primeiro valor");
        float valor1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Segundo valor");
        float valor2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");

        float resultado = valor1 - valor2;
        Console.WriteLine($"O resultado da subtração é = {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        System.Console.WriteLine("Primeiro valor");
        float valor1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Segundo valor");
        float valor2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");

        float resultado = valor1 / valor2;
        Console.WriteLine($"O resultado da subtração é = {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        System.Console.WriteLine("Primeiro valor");
        float valor1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Segundo valor");
        float valor2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");

        float resultado = valor1 * valor2;
        Console.WriteLine($"O resultado da subtração é = {resultado}");

        Console.ReadKey();
        Menu();
    }
}
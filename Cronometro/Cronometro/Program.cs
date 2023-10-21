class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem vindo ao Cronometro!");
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine()
            .ToLower();

        char tipo = Char.Parse(data.Substring(data.Length - 1, 1));
        int tempo = int.Parse(data.Substring(0, data.Length - 1));
        int multiplicador = 1;

        if (tipo == 'm')
            multiplicador = 60;

        if (tempo == 0)
            System.Environment.Exit(0);

        PreStart(tempo * multiplicador);
    }

    static void PreStart(int tempo)
    {
        Console.Clear();
        System.Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        System.Console.WriteLine("Apontar...");
        Thread.Sleep(1000);
        System.Console.WriteLine("Fogo...");
        Thread.Sleep(1000);

        IniciarCronometro(tempo);
    }

    static void IniciarCronometro(int tempo)
    {
        int tempoAtual = 0;

        while (tempoAtual != tempo)
        {
            Console.Clear();
            System.Console.WriteLine(tempo);
            tempo--;
            Thread.Sleep(1000);
        }

        Console.WriteLine("Cronometro finalizado");
        Thread.Sleep(2500);

        Menu();
    }
}
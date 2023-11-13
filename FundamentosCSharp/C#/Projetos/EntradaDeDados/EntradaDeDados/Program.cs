namespace EntradaDeDados
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite uma frase:");
            string frase = Console.ReadLine();
            Console.WriteLine($"Digite uma cor:");
            string cor1 = Console.ReadLine();
            Console.WriteLine($"Digite uma cor:");
            string cor2 = Console.ReadLine();
            Console.WriteLine($"Digite uma cor:");
            string cor3 = Console.ReadLine();

            Console.WriteLine($"\nFrase digitada: {frase}");
            Console.WriteLine($"Primeira cor digitada: {cor1}");
            Console.WriteLine($"Segunda cor digitada: {cor2}");
            Console.WriteLine($"Terceira cor digitada: {cor3} \n");

            Console.WriteLine($"Digite tres palavras com virgulas:");
            string[] vetorPalavra = Console.ReadLine().Split(", ");
            string palavra1 = vetorPalavra[0];
            string palavra2 = vetorPalavra[1];
            string palavra3 = vetorPalavra[2];

            Console.WriteLine($"\nPrimeira Palavra digitada: {palavra1}");
            Console.WriteLine($"Segunda Palavra digitada: {palavra2}");
            Console.WriteLine($"Terceira Palavra digitada: {palavra3}");
        }
    }
}
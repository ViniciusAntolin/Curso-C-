using Pagamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        var pessoaA = new Pessoa(1, "Teste");
        var pessoaB = new Pessoa(1, "Teste");
        Console.WriteLine(pessoaA == pessoaB);
        Console.WriteLine(pessoaA.Equals(pessoaB));
    }
}
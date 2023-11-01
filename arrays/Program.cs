using System.Globalization;
//ARRAYs SÃO REFERNCETYPES, OU SEJA, QUANDO EU COLOCAR OUTRO ARRAY IGUAL A ELE E MUDAR O OUTRO TAMBÉM SERÁ MUDADO
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        ArrayComStruct();
        ArrayComFor();
        ArrayComForEach();

        AlterarValoresDoArray();
    }

    private static void AlterarValoresDoArray()
    {
        var primeiro = new int[4];
        //var segundo = primeiro;
        var segundo = new int[4];

        segundo[0] = 2;

        primeiro[0] = 4;

        primeiro.CopyTo(segundo, 0);

        Console.WriteLine(segundo[0]);
    }

    private static void ArrayComFor()
    {
        var meuArray = new int[5] { 1, 2, 3, 4, 5 };

        for (var index = 0; index < meuArray.Length; index++)
            Console.WriteLine(meuArray[index]);
    }

    private static void ArrayComStruct()
    {
        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() { Id = 23412, Nome = "Teste" };// Padrão para inicialização de qualquer objeto em c#
        funcionarios[1] = new Funcionario() { Id = 25674, Nome = "Teste1" };
        funcionarios[2] = new Funcionario() { Id = 12451, Nome = "Teste2" };
        funcionarios[3] = new Funcionario() { Id = 76987, Nome = "Teste3" };
        funcionarios[4] = new Funcionario() { Id = 54454, Nome = "Teste4" };

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.Id} {funcionario.Nome}");
        }
    }

    private static int[] ArrayComForEach()
    {
        var meuArray = new int[5] { 1, 2, 3, 4, 5 };

        meuArray[0] = 12;

        foreach (int item in meuArray)//each significa cada, ou seja, para cada item do meu array vai passar dentro.
            Console.WriteLine(item);

        return meuArray;
    }
}

struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
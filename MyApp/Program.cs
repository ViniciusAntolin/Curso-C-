using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder();
    }

    static void GuidS(string[] args)
    {
        var id = Guid.NewGuid();

        Console.WriteLine(id);

        id = new Guid("dc683472-6272-4229-9db8-b80f3e10ef90");

        Console.WriteLine(id);

        id = new Guid();

        Console.WriteLine(id);
    }

    static void InterpolacaoDeStrings()
    {
        var preco = 10.2;
        // var texto = "O preço do produto é " + preco + " até Sexta-feira";
        //var texto = string.Format("O preço do produto é {0} apenas na promoção! {1}", preco, true);
        var texto = $@"O preço do produto 
        é {preco} apenas na promoção!
        Legal o uso do arroba";
        System.Console.WriteLine(texto);
    }

    static void ComparacaoDeStrings()
    {
        var texto = "Este texto é um teste";
        //System.Console.WriteLine(texto.CompareTo("Testando"));
        //System.Console.WriteLine(texto.CompareTo("testando"));
        Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(texto.Contains("teste"));
        // Console.WriteLine(texto.Contains(null));
    }

    static void StartsWihEndsWith()
    {
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este"));
        Console.WriteLine(texto.StartsWith("texto"));


        Console.WriteLine(texto.EndsWith("teste"));
        Console.WriteLine(texto.EndsWith("Teste"));
        Console.WriteLine(texto.EndsWith(""));
    }

    static void Equals()
    {
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.Equals("Este texto é um teste"));
        Console.WriteLine(texto.Equals("Este texto é um Teste"));
        Console.WriteLine(texto.Equals("este texto é um Teste", StringComparison.OrdinalIgnoreCase));
    }

    static void IndicesPosicaoEmUmArrayLista()
    {
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.IndexOf("é"));
        Console.WriteLine(texto.IndexOf("t"));
        Console.WriteLine(texto.IndexOf("teste"));

        Console.WriteLine(texto.LastIndexOf("s"));
    }

    static void ConverterMinusculoMaiusculo()
    {
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Insert(5, "AQUI "));
        Console.WriteLine(texto.Remove(5, 5));
        Console.WriteLine(texto.Length);
    }

    static void ManipulandoString()
    {
        var texto = "Este texto é um teste";
        System.Console.WriteLine(texto.Replace("Este", "isto"));

        var divisao = texto.Split(" ");

        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);

        // var resultado = texto.Substring(5, 5);
        var resultado = texto.Substring(5, texto.LastIndexOf("o"));

        Console.WriteLine(resultado);

        System.Console.WriteLine(texto.Trim());
    }

    static void StringBuilder()
    {
        var texto = new StringBuilder();
        texto.Append("Este texto é um teste");
        texto.Append("Este texto é um teste2");
        texto.Append("Este texto é um teste3");
        texto.Append("Este texto é um teste4");

        System.Console.WriteLine(texto);
    }
}

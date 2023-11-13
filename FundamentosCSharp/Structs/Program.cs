internal class Program
{
    private static void Main(string[] args)
    {
        //Se não colocar os parametros, o código não passa pelo construtor.
        var mouse = new Produto(1, "Mouse gamer", 200.50, ETipoProduto.Produto);
        var manutencaoEletrica = new Produto(1, "Manutenção elétrica residencial", 500.00, ETipoProduto.Servico);

        mouse.Id = 55;

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Preco);
        Console.WriteLine(mouse.Tipo);
        Console.WriteLine(mouse.PrecoEmDolar(5.08));
    }

    private struct Produto
    {
        public Produto(int id, string name, double preco, ETipoProduto tipo)
        {
            Id = id;
            Name = name;
            Preco = preco;
            Tipo = tipo;
        }
        public int Id;
        public string Name;
        public double Preco;
        public ETipoProduto Tipo;

        public double PrecoEmDolar(double dolar)
        {
            return Preco * dolar;
        }
    }

    private enum ETipoProduto
    {
        Produto = 1,
        Servico = 2
    }

}

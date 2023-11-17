using Pagamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        TrabalhandoComEventos();

        TrabalhandoComTipoGenericos();

        var pessoas = new List<Pessoa>
        {
            new Pessoa(1, "teste"),
            new Pessoa(2, "teste1"),
            new Pessoa(3, "teste2"),
            new Pessoa(4, "teste3"),
            new Pessoa(1, "teste4")
        };


        //var pessoaRemover = pessoas.FirstOrDefault(pessoa => pessoa.Id == 1);
        //Console.WriteLine(pessoaRemover?.Id);
        //pessoas.Remove(pessoaRemover);

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Id} {pessoa.Nome}");
        }

        var pessoas1 = new List<Pessoa>(pessoas);
        pessoas.RemoveRange(pessoas1.Count(pessoa => pessoa.Id == 1), 2);

        var pessoaExiste = pessoas.Any(pessoa => pessoa.Id == 1);
        Console.WriteLine(pessoaExiste);

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Id} {pessoa.Nome}");
        }
    }

    private static void TrabalhandoComTipoGenericos()
    {
        var pessoa = new Pessoa(1, "teste");
        var pagamento = new PagamentoApplePay();
        var subscription = new Subscription();

        var context = new DataContext<Pessoa, PagamentoApplePay, Subscription>();

        context.Salvar(pessoa);
        context.Salvar(pagamento);
        context.Salvar(subscription);
    }

    private static void TrabalhandoComEventos()
    {
        var pessoaA = new Pessoa(1, "Teste");
        var pessoaB = new Pessoa(1, "Teste");
        Console.WriteLine(pessoaA == pessoaB);
        Console.WriteLine(pessoaA.Equals(pessoaB));
        var sala = new Sala(3);
        sala.SalaLotadaEvent += AoSalaFicarLotada;
        sala.AcentosReservados();
        sala.AcentosReservados();
        sala.AcentosReservados();
        sala.AcentosReservados();
        sala.AcentosReservados();
        sala.AcentosReservados();
    }

    static void AoSalaFicarLotada(object sender, EventArgs e)
    {
        Console.WriteLine("Sala lotada");
    }

}

public class DataContext<P, PG, S>
    where P : Pessoa
    where PG : Pagamento
    where S : Subscription
{
    public void Salvar(P entidade) { }
    public void Salvar(PG entidade) { }
    public void Salvar(S entidade) { }
}

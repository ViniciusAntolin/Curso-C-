namespace Pagamentos
{
    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa? pessoa) => Id == pessoa.Id;
    }
}

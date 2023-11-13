using Pagamentos.Interface;

namespace Pagamentos
{
    public abstract class Pagamento : IPagamento, IDisposable
    {

        public int VariavelA { get; set; }
        public DateTime Vencimeno { get; set; }

        public void Dispose() => Console.WriteLine("Finalizando o pagamento");

        public virtual void Pagar(double Valor)
        {
            ConsultarSaldoDoCartao();
        }

        private void ConsultarSaldoDoCartao()
        {

        }
    }
}


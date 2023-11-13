namespace Pagamentos
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double Valor)
        {
            Valor *= 100;
            base.Pagar(Valor);
        }
    }
}


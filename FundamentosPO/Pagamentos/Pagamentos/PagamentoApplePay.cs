namespace Pagamentos
{
    public class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double Valor)
        {
            Valor *= 100;
            base.Pagar(Valor);
        }
    }
}


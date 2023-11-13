namespace Pagamentos
{
    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double Valor)
        {
            Valor *= 100;
            base.Pagar(Valor);
        }
    }
}


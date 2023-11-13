namespace Pagamentos.Interface
{
    public interface IPagamento
    {
        DateTime Vencimeno { get; set; }

        void Pagar(double Valor);

    }
}


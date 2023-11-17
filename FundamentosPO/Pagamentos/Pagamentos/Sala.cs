public class Sala
{
    public Sala(int assentos)
    {
        Assentos = assentos;
        assentosEmUso = 0;
    }

    private int assentosEmUso = 0;

    public int Assentos { get; set; }

    public void AcentosReservados()
    {
        assentosEmUso++;

        if (assentosEmUso >= Assentos)
        {
            AoSalaFicarLotada(EventArgs.Empty);
        }
        else
        {
            Console.WriteLine("Assento reservados");
        }
    }

    public event EventHandler SalaLotadaEvent;

    protected virtual void AoSalaFicarLotada(EventArgs e)
    {
        EventHandler handler = SalaLotadaEvent;

        handler?.Invoke(this, e);
    }
}
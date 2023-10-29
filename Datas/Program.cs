internal class Program
{
    private static void Main(string[] args)
    {
        //var data = new DateTime(2020, 10, 12, 8, 23, 14);// instância uma variável com a data padrão do datetime 01/01/0001 00:00:00
        var data = DateTime.Now;

        AtribuicaoDeData(data);
    }

    private static void AtribuicaoDeData(DateTime data)
    {
        Console.WriteLine(data);
        Console.WriteLine(data.AddDays(10));
        Console.WriteLine(data.AddMonths(2));
        Console.WriteLine(data.AddYears(2));
        Console.WriteLine(data.AddHours(2));
        Console.WriteLine(data.AddMinutes(2));
        Console.WriteLine(data.AddTicks(2));
    }

    private static void FormataData(DateTime data)
    {
        var formatada = string.Format("{0: dd/MM/yyyy HH:mm:ss ff z}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var t = string.Format("{0: t}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var f = string.Format("{0: f}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var g = string.Format("{0: g}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var D = String.Format("{0: D}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var d = string.Format("{0: d}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var r = string.Format("{0: r}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var s = string.Format("{0: s}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        var u = string.Format("{0: u}", data); //FORMATA QUALQUER TIPO DE DATA DESTA FORMA.
        Console.WriteLine(formatada);
        Console.WriteLine(t);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(D);
        Console.WriteLine(d);
        Console.WriteLine(r);
        Console.WriteLine(u);
    }

    private static void FormasData(DateTime data)
    {
        Console.WriteLine(data);
        Console.WriteLine(data.Year);
        Console.WriteLine(data.Month);
        Console.WriteLine(data.DayOfWeek);
        Console.WriteLine(data.Hour);
        Console.WriteLine(data.Minute);
        Console.WriteLine(data.Second);
    }
}
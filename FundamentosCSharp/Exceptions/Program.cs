internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[3];
        try
        {   // No dotnet tudo que é erro é tratado como Exception.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Salvar("");
        }
        catch (IndexOutOfRangeException iex)
        {
            //Sempre tratar do mais especifico para o mais generico
            Console.WriteLine($"Não encontrei o indice na lista! {iex.InnerException}{iex.Message}");
        }
        catch (ArgumentNullException iex)
        {
            //Sempre tratar do mais especifico para o mais generico
            Console.WriteLine($"Falha ao cadastrar o texto! {iex.InnerException}{iex.Message}");
        }
        catch (MinhaException mex)
        {
            //Sempre tratar do mais especifico para o mais generico
            Console.WriteLine($"Exceção customizada! {mex.InnerException}{mex.Message}{mex.QuandoAconteceu}");
        }
        catch (Exception ex)
        {
            //Sempre tratar do mais especifico para o mais generico
            Console.WriteLine($"Ops. algo deu errado! {ex.InnerException}{ex.Message}");
        }
        finally //finalmente, sempre passa aqui.
        {
            //Realizar processo que sempre tem que passar, por exemplo, fechar a conexão com o banco ou algo do sentido.
            Console.WriteLine("Chegou ao fim.");
        }

        static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) throw new MinhaException(DateTime.Now);
        }

    }

    public class MinhaException : Exception //Exception customizada.
    {
        public MinhaException(DateTime date) //metodo construtor não retorna nada.
        {
            QuandoAconteceu = date;

        }

        public DateTime QuandoAconteceu { get; private set; }
    }
}
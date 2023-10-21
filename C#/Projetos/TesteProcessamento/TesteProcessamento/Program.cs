namespace TesteProcessamento
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Processando int--------------------\n");
            int x, y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x + y);

            //////////////////////////////////////////////////
            Console.WriteLine("Processando double com int---------\n");
            int x1;
            double y1;
            

            x1 = 5;
            y1 = 2 * x1;

            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(x + y);
            //////////////////////////////////////////////////
            Console.WriteLine("Calculando a área do quadrado-------\n");

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine($"A area do quadrado é {area}");

            //////////////////////////////////////////////////
            Console.WriteLine("Usando o casting -------------------\n");

            int a, c;
            double resultado;

            a = 5;
            c = 2;

            resultado = (double) a / c; //CONVERTENDO O RESULTADO PARA DOUBLE

            Console.WriteLine($"O resultado é {resultado}");

            //////////////////////////////////////////////////
            Console.WriteLine("Usando o casting double com int ----\n");

            double d;
            int e;

            d = 5.1;
            e = (int)d; // CONVERTENDO O RESULTADO PARA INT

            Console.WriteLine($"Convertido de {d} para {e}");

            Console.ReadLine();
        }
    }
}
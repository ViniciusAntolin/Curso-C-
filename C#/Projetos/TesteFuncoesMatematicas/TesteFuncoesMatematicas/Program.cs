namespace TesteFuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine("Raiz quadrade de " + x + " = " + A);
            Console.WriteLine("Raiz quadrade de " + y + " = " + B);
            Console.WriteLine("Raiz quadrade de 25 = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(y + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + y + " = " + B);

            Console.ReadLine();
        }
    }
}
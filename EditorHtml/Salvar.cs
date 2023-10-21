using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Salvar
    {
        public static void SalvarArquivo(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(path: caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo salvo com sucesso no caminho: {caminho}");
            Console.ReadLine();
        }
    }
}

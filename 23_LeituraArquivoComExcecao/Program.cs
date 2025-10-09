using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true) 
            {
                Console.WriteLine("Informe o caminho do arquivo:");
                string arquivo = Console.ReadLine();

                try
                {
                    // Tenta ler o conteúdo do arquivo
                    string conteudo = File.ReadAllText(arquivo); // Lê todo o conteúdo do arquivo
                    Console.WriteLine("\nConteudo do arquivo");
                    Console.WriteLine(conteudo);
                    break;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Caminho não encontrado ");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe nomes de pessoas");
            List<string> listNome = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Digite o {i}° Nome: ");
                listNome.Add(Console.ReadLine());
                
            }

            foreach (string nome in listNome)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaNome = new Queue<string>();

            Console.WriteLine("Digite o nome das Pessoas  (mínimo de 3 caracteres)");
            int contador = 0;
            while (contador < 4)
            {
                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();
                
                if (nome.Length >= 3)
                {
                    filaNome.Enqueue(nome);
                    contador++;
                }
                else
                {
                    Console.WriteLine("Nome muito curto");
                }
            }

            int i = 1;
            foreach (string nome in filaNome)
            {
                if (i <= 3)
                    Console.WriteLine($"{i}° Nome: {nome}");
                    i++;
            }
        }
    }
}

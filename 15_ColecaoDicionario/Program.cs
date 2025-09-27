using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> aluno = new Dictionary<int, string>();

            int contador = 0;
            while (contador < 3) 
            {
                Console.WriteLine("Informe o RA: ");
                int ra = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o nome do Aluno: ");
                string nome = Console.ReadLine();

                if (nome.Length >= 3)
                {
                    aluno.Add(ra, nome);
                    contador++;
                }
                else 
                {
                    Console.WriteLine("Nome invalido");
                }

            }
            foreach (var pessoa in aluno)
            {
                Console.WriteLine($" RA: {pessoa.Key}, Aluno: {pessoa.Value}");
            }
        }
    }
}

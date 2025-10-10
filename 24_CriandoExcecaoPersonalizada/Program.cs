using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("Informe a Nota do aluno");
                    int valor = int.Parse(Console.ReadLine());
                    SituacaoAluno nota = new SituacaoAluno(valor);
                    Console.WriteLine(nota.Resultado(valor));
                    break;
                }
                catch (NotaInvalidaException)
                {
                    Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Digite um numero inteiro: ");
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Número inválido, informe apenas numeros inteiros!.\nPressione qualquer tecla para continuar");
                    Console.ReadKey();
                    continue;

                }
                finally //sempre executa
                {
                    Console.Clear();
                }
            }

            if(numero % 2 == 0)
                Console.WriteLine("Número par!");
            else
                Console.WriteLine("Número ímpar!");
        }
    }
}

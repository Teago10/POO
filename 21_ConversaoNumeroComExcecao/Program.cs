using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
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
                    Calculo calculo = new Calculo(numero);
                    Console.WriteLine($"O dobro do numero é {calculo.Dobro()}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
                    Console.WriteLine(ex.Message);
                }

                
            }
        }
    }
}

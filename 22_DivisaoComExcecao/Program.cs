using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            while (true)
            {

                try
                {
                    Console.WriteLine("Digite um numero inteiro:");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro numero inteiro:");
                    numero2 = int.Parse(Console.ReadLine());

                    Calculo calculo = new Calculo(numero1, numero2);
                    Console.WriteLine($"A divisão entre eles é {calculo.GetNumero()}");
                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Divisão por zero será sempre zero");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Valor inválido. Digite um numero inteiro");
                    Console.WriteLine(ex.Message);
                }
                finally 
                {
                    Console.WriteLine("Operação finalizada. Obrigado por utilizar o programa!");
                }
            }
        }
    }
}

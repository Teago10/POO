using System;
using System.Linq;
using System.Text.RegularExpressions;
using _18_ValidaCPF;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CPF");
            string cpf = Console.ReadLine();

            CPF numero = new CPF(cpf);
            bool valido = numero.Validar();

            if (valido) 
            {
                Console.WriteLine("CPF Válido!");
            }
            else
            {
                Console.WriteLine("CPF Inválido!");
            }
        }

        

    }
}



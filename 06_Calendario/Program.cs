using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine()); // lê o ano do usuário

            Calendario calendario; // declaração do objeto calendário

            for (int mes = 1; mes <= 12; mes++) // para cada mês do ano
            {
               
                calendario = new Calendario(ano, mes); // instancia o calendário do mês
                calendario.ImprimirCalendario(); //imprime o calendário do mês

                Console.WriteLine("\n----------------------------------------------------\n");
            }
            //Espera o usuário teclar qualquer tecla
            Console.ReadKey();
        }
    }
}
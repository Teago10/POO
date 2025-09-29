using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Sem Utilizar Enum");
            //List<int> diasSemEnum = new List<int> { 0,1,2,3,4,5,6};
            List<int> diasSemEnum = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in diasSemEnum)
            {
                /*if(item == 0) Console.WriteLine("Domingo");
                else if (item == 1) Console.WriteLine("Segunda");
                else if (item == 2) Console.WriteLine("Terça");
                else if (item == 3) Console.WriteLine("Quarta");
                else if (item == 4) Console.WriteLine("Quinta");
                else if (item == 5) Console.WriteLine("Sexta");
                else if (item == 6) Console.WriteLine("Sábado");*/

                if (item == 1) Console.WriteLine("Domingo - Numero: 1");
                else if (item == 2) Console.WriteLine("Segunda - Numero: 2");
                else if (item == 3) Console.WriteLine("Terça - Numero: 3");
                else if (item == 4) Console.WriteLine("Quarta - Numero: 4");
                else if (item == 5) Console.WriteLine("Quinta - Numero: 5");
                else if (item == 6) Console.WriteLine("Sexta - Numero: 6");
                else if (item == 7) Console.WriteLine("Sábado - Numero: 7");

            }

            Console.WriteLine("\n\n Com utilização de Enum");
            List<DiaDaSemana> diasComEnum = new List<DiaDaSemana>() { DiaDaSemana.Domingo, DiaDaSemana.Segunda, DiaDaSemana.Terca, DiaDaSemana.Quarta, DiaDaSemana.Quita, DiaDaSemana.Sexta, DiaDaSemana.Sabado };
            foreach(var item in diasComEnum)
            {
                Console.WriteLine($"{item} Numero: { (int)item}");
            }
        }
    }

    public enum DiaDaSemana
    {
        Domingo = 1,
        Segunda,
        Terca,
        Quarta,
        Quita,
        Sexta,
        Sabado

    }
}

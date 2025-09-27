using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNum = new HashSet<int>();
            setNum.Add(1);
            setNum.Add(2);
            setNum.Add(3);
            setNum.Add(5);
            setNum.Add(5);
            setNum.Add(3);
            setNum.Add(7);
            setNum.Add(1);
            setNum.Add(2);
            setNum.Add(3);

            Console.WriteLine("Impressão dos Hashsets");
            foreach (int numero in setNum) 
            {
                Console.WriteLine($"Numero: {numero}");
            }
        }
    }
}

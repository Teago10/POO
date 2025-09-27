using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNum = new Stack<int>();
            stackNum.Push(1);
            stackNum.Push(2);
            stackNum.Push(3);
            stackNum.Push(4);
            stackNum.Push(5);
            stackNum.Push(6);
            stackNum.Push(7);

            Console.WriteLine($" 1°) {stackNum.Pop()}");
        }
    }
}

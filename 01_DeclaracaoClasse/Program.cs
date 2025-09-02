using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimirArea();

            obj1.Lado = 15;
            obj1.ImprimirArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimirArea();

            Retangulo obj3 = new Retangulo();
            obj3.Base = 10;
            obj3.Altura = 20;
            obj3.ImprimirAreaR();

            //Circulo
            Circulo obj4 = new Circulo();
            obj4.Raio = 5;
            obj4.ImprimirAreaC();

            //Triangulo
            Triangulo obj5 = new Triangulo();
            obj5.Base = 10;
            obj5.Altura = 20;
            obj5.ImprimirAreaT();
        }
    }


    public class Quadrado
    {
        public int Lado;
        public int CalculoArea()
        {
            //Atributos
            int area = Lado * Lado;
            return area;
            //Metodos
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadro com lado de {Lado}, possui Area de {CalculoArea()} ");
        }
    }

    public class Retangulo
    {
        public int Base;
        public int Altura;

        public int CalculoDaArea()
        {
            return Base * Altura;

        }
        public void ImprimirAreaR()
        {
            Console.WriteLine($"Retangulo com base de {Base} e altura de {Altura}, possui Area de {CalculoDaArea()} ");
        }
    }

    public class Circulo
    {
        public double Raio;
        public double CalculoArea()
        {
            //return Math.Pow(Raio, 2) * Math.PI; para numero ao quadrado
            return Math.PI * (Raio * Raio);
        }
        public void ImprimirAreaC()
        {
            Console.WriteLine($"Circulo com raio de {Raio:N2}, possui Area de {CalculoArea():N2} ");
        }
    }

    public class Triangulo
    {
        public int Base;
        public int Altura;
        public double CalculoArea()
        {
            return (Base * Altura) / 2;
        }
        public void ImprimirAreaT()
        {
            Console.WriteLine($"Triangulo com base de {Base} e altura de {Altura}, possui Area de {CalculoArea():N2} ");
        }
    }
}
    

     

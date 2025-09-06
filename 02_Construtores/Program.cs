using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.ImprimirArea();

            Quadrado quadrado2 = new Quadrado(10);
            quadrado2.ImprimirArea();

            Retangulo retangulo = new Retangulo(4,5);
            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(5);
            circulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(8, 9);
            triangulo.ImprimirArea();
        }
        
    }

    public class Quadrado
    {
        //Modificar de acesso Private
        //pode ser acessado apenas dentro da classe
        private int Lado;

        //Overload (Sobrecarga) de Construtor
        //Declarar mais de um construtor com a lista de argumentos diferentes
        public Quadrado()
        {
            this.Lado = 5; 
        }

        //Construtor serve para instanciar o objeto e inicializar os atributos
        public Quadrado(int Lado)
        {
            //Acessando o atributo Lado da classe
            this.Lado = Lado;
        }

        public int CalcularArea()
        {
            return Lado * Lado;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalcularArea()}");
        }
    }

    public class Retangulo
    {
        private int Largura;
        private int Altura;

        public Retangulo(int Largura, int Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }

        public int CalcularArea()
        {
            return Largura * Altura;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura} e altura de {Altura} possui uma área de {CalcularArea()}");
        }
    }

    public class Circulo
    {
        private double Raio;

        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de {CalcularArea():N2}");
        }
    }

    public class Triangulo
    {
        private int Base;
        private int Altura;

        public Triangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;

        }

        public double ClacularArea()
        {
            return (Base * Altura) / 2;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma área de {ClacularArea():N2}");
        }
    }
}

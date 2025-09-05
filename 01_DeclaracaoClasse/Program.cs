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

            //Conta
            conta conta1 = new conta();
            conta1.Banco = 237;
            conta1.Agencia = "1234-X";
            conta1.Numero = "123456-7";
            conta1.Saldo = 0.00;
            conta1.Limite = 500.00;
            
            conta1.Depositar(500.00);
            Console.WriteLine($"Saldo Atual: {conta1.Saldo}");
            conta1.Sacar(200.00);
            Console.WriteLine($"Saldo Atual: {conta1.Saldo}");

            //Aluno
            Aluno aluno1 = new Aluno();
            aluno1.Codigo = 1;
            aluno1.Nome = "Thiago";
             //inicializando o vetor com 4 posicoes

            aluno1.LancarNota(0, 9.6);
            aluno1.LancarNota(1, 8.0);
            aluno1.LancarNota(2, 9.5);
            aluno1.LancarNota(3, 10.0);

            Console.WriteLine($"Aluno: {aluno1.Nome}, Media: {aluno1.CalcularMedia():N1} , Situação: {aluno1.Mencao()}");

        }

    }

    public class conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor; 
        }

        public double ConsultarSaldo()
        {
            return Saldo;
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

    public class Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];

        public void LancarNota(int indice, double nota) //int trimestre, double nota, Professor fez assim
        {
            Notas[indice] = nota;  //Notas[trimestre - 1] = nota;
        }
        public double CalcularMedia()
        {
            double soma = 0; //local que vai acumular a soma das notas.
            for (int i = 0; i < Notas.Length; i++) //percorrer o vetor
            {
                soma += Notas[i]; //acumular as notas
            }
            return soma / Notas.Length; //retornar a media; Notas.Length = quantidade de notas
        }

        //public double CalcularMedia()    OBS: Outra forma de fazer a media, Professor fez assim
        //{
        //    double media = 0;
        //    foreach (double nota in Notas)
        //    {
        //        media += nota;
        //    }
        //}

        public string Mencao()
        {
           
            if (CalcularMedia() >= 5)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

    }
}
    

     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota do aluno:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno:");
            double nota2 = double.Parse(Console.ReadLine());
            
            Aluno aluno = new Aluno(nome, idade, nota1, nota2);
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Nota 1: {aluno.Nota1}");
            Console.WriteLine($"Nota 2: {aluno.Nota2}");
            Console.WriteLine($"Média: {aluno.Media}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
        }
    }
}

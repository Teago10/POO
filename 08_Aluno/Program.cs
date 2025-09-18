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
            //string nome = Console.ReadLine();
            Aluno aluno = new Aluno(Console.ReadLine());

            Console.WriteLine("Digite a idade do aluno:");
            aluno.Idade = int.Parse(Console.ReadLine()); // Lê a idade do aluno, jogando na variável idade em formato int
            Console.WriteLine("Digite a primeira nota do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine()); // Lê a primeira nota do aluno, jogando na variável nota1 em formato double
            Console.WriteLine("Digite a segunda nota do aluno:");
            aluno.Nota2 = double.Parse(Console.ReadLine()); // Lê a segunda nota do aluno, jogando na variável nota2 em formato double

            
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Nota 1: {aluno.Nota1}");
            Console.WriteLine($"Nota 2: {aluno.Nota2}");
            Console.WriteLine($"Média: {aluno.Media}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
        }
    }
}

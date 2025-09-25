using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <Genéric>
            List<string> nomes = new List<string>();
            nomes.Add("Suely");
            nomes.Add("Celso");


            List<Aluno> alunos = new List<Aluno>();
            Aluno suely = new Aluno { id = 1, Nome = "Suely"};
            AlunoEspecial celso = new AlunoEspecial { id = 2, Nome = "Celso", Deficiencia = "Mudo" };
            alunos.Add(suely);
            alunos.Add(celso);

            alunos.Add(new Aluno { id = 3, Nome = "Gustavo" }); // aqui esta criando um novo objeto aluno e ja adicionando na lista
            //nomes.Add(celso.Nome); // aqui esta puxando apenas o nome do objeto celso
            nomes.Add(suely.Nome); // aqui esta puxando o nome do objeto suely.a lista permite vc colocar mais de um nome

            Console.WriteLine("Impressão dos Nomes");
            foreach(string nome in nomes) // aqui esta puxando apenas o nome
            {
                Console.WriteLine($"Nome: {nome}");
            }

            foreach(Aluno aluno in alunos) // aqui esta puxando o objeto aluno completo
            {
                aluno.ImprimirAluno();
            }
        }
    }

    class Aluno
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        // metodo virtual pode ser sobrescrito pelas classes filhas
        public virtual void ImprimirAluno()
        {
            Console.WriteLine($"Id: {id}, Nome: {Nome}");
            
        }
    }

    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        // override sobrescreve o metodo da classe pai
        public override void ImprimirAluno()
        {
            Console.WriteLine($"Id: {id}, Nome: {Nome}, Deficiencia: {Deficiencia}");
        }
    }
}

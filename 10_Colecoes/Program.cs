using System;
using System.Collections;
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

            Console.WriteLine("\n");

            Console.WriteLine("Impressão dos dicNomes");
            Dictionary<int,String> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "Suely");
            dicNomes.Add(2, "Celso");
            dicNomes.Add(3, "Gustavo");

            //dicNomes.Add(3, "Gustavo"); // nao permiti chaves duplicadas no Dictionary

            
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($"- {dicNomes[i]}");
            }

            Console.WriteLine("\nImpressão dos dicAlunos");

            Dictionary<int,Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(suely.id, suely);
            dicAlunos.Add(celso.id, celso);
            /*
            for(int i = 1; i <= dicAlunos.Count; i++)
            {
                dicAlunos[i].ImprimirAluno(); // aqui esta puxando o objeto aluno completo
            }*/

            foreach(Aluno aluno in dicAlunos.Values) // aqui esta puxando o objeto aluno completo
            {
                aluno.ImprimirAluno();
            }


            Queue<String> filaNomes = new Queue<String>(); // FIFO - First In First Out (Primeiro a entrar, primeiro a sair)
            filaNomes.Enqueue("Suely");
            filaNomes.Enqueue("Celso");
            filaNomes.Enqueue("Gustavo");

            Console.WriteLine("\nImpressão dos Queue");
            Console.WriteLine($" 1°) {filaNomes.Dequeue()}"); // remove o primeiro da fila e retorna o valor
            foreach (String nome in filaNomes)
            {
                Console.WriteLine($"- {nome}");
            }

            Stack<String> stackNomes = new Stack<string>(); // LIFO - Last In First Out (Ultimo a entrar, primeiro a sair)
            stackNomes.Push("Suely");
            stackNomes.Push("Celso");
            stackNomes.Push("Gustavo");

            Console.WriteLine("\nImpressão dos Stack");
            Console.WriteLine($" 1°) {stackNomes.Pop()}");
            foreach (String nome in stackNomes)
            {
                Console.WriteLine($"- {nome}");
            }

            HashSet<String> hashNomes = new HashSet<string>(); // nao permite valores duplicados
            hashNomes.Add("Suely");
            hashNomes.Add("Celso");
            hashNomes.Add("Gustavo");

            // Ignora valores duplicados
            hashNomes.Add("Gustavo"); // nao vai adicionar pois ja existe na lista

            Console.WriteLine("\nImpressão dos HashSet");
            foreach (String nome in hashNomes)
            {
                Console.WriteLine($"- {nome}");
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

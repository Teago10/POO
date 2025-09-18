using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Aluno
    {
        private string nome;
        private int idade;
        private double nota1, nota2;

        public Aluno(string nome)
        {
            this.nome = nome;
        }
        public string Nome
        {
            get { return nome; } 
        }
        public int Idade
        {
            get { return idade; }
            set { 
                if (value >= 0)
                    idade = value;
                else
                    Console.WriteLine("Idade invalida");
            }
        }
        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }

        }
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Media // média das notas
        {
            get { return(nota1 + nota2)/ 2.0 ; } // get = retorna a média das notas
        }

        public string Situacao
        {
            get
            {
                if (Media >= 6)
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
}

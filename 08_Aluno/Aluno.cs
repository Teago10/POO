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
        private double media;
        private string situacao;

        public Aluno(string nome, int idade, double nota1, double nota2)
        {
            this.nome = nome;
            this.idade = idade;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public string Nome
        {
            get { return nome; } 
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
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

        public double Media
        {
            get { return(nota1 + nota2)/ 2.0 ; }
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

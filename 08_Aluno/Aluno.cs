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
        public int idade;
        public double nota1, nota2;
        public double media;
        public string situacao;

        public double CalcularMedia(double nota1, double nota2)
        {
            media = (nota1 + nota2) / 2;
            return media;
        }
        public string VerificarSituacao()
        {
            if(media >= 6)
            {
                situacao = "Aprovado";
            }
            else
            {
                situacao = "Reprovado";
            }
            return situacao;
        }



    }
}

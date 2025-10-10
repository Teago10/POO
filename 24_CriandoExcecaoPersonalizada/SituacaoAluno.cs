using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class SituacaoAluno
    {
        private int nota { get; }

        public SituacaoAluno(int nota)
        {
            this.nota = nota;
        }

        public string Resultado(int nota) 
        {
            if (nota < 0 || nota > 10 )
            {
                throw new NotaInvalidaException();
            }

            if (nota >= 6)
                return "Aluno Aprovado";
            else
                return "Aluno Reprovado";

            
        }
    }
}

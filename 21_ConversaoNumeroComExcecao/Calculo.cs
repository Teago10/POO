using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Calculo
    {
        private int codigo { get; }

        public Calculo(int codigo)
        {
            this.codigo = codigo;
        }
        public int Dobro()
        {
            return codigo * 2;
        }
    }
}

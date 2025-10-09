using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Calculo
    {
        private int numero1 { get; }
        private int numero2 { get; }

        public Calculo(int numero1, int numero2) 
        { 
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int GetNumero() 
        {
            return numero1 / numero2;
        }
    }
}

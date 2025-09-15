using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalendarioComFeriado
{
    internal class Feriado
    {
        public int Dia { get; set; } // dia do feriado
        public string Descricao { get; set; } // descrição do feriado
        public Feriado(int dia, string descricao) // construtor
        {
            this.Dia = dia;
            this.Descricao = descricao;
        }
    }
}

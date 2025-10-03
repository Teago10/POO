using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado> // classe que representa um feriado e implementa a interface IComparable
    {
        public int Dia { get; set; } // dia do feriado
        public string Descricao { get; set; } // descrição do feriado
        public Feriado(int dia, string descricao) // construtor
        {
            this.Dia = dia;
            this.Descricao = descricao;

        }
        // Implementa a interface IComparable para permitir a comparação entre feriados
        public int CompareTo(Feriado outro) // método para comparar dois feriados
        {
            if (outro == null) return 1; // se o outro feriado for nulo, retorna 1
            return this.Dia.CompareTo(outro.Dia); // compara os dias dos feriados
        }

    }
}

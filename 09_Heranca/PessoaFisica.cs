using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class PessoaFisica: Pessoa // herda da classe Pessoa
    {
        public string CPF;

        public override string GetDocumento() // sobrescreve o método abstrato da classe base
        {
            return $"CPF: {this.CPF}";
        }
    }
}

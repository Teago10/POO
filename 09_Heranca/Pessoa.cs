using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa // classe abstrata = não pode ser instanciada
    {
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento(); // método abstrato = não tem implementação, deve ser sobrescrito nas classes derivadas

        public void Imprimir()
        {
            Console.WriteLine($"Lista de Pessoas\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pessoa é uma classe abstrata, não pode ser instanciada
            //Pessoa obj = new Pessoa();

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "João da Silva";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(99) 99999-9999";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Empresa XYZ";
            pessoaJuridica.CNPJ = "99.999.999/0001-99";
            pessoaJuridica.Telefone = "(014) 9599-9989";
            pessoaJuridica.Imprimir();
        }
    }
}

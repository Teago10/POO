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
            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "João da Silva";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(99) 99999-9999";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Empresa XYZ";
            pessoaJuridica.CNPJ = "99.999.999/0001-99";
            pessoaJuridica.Telefone = "(014) 9599-9989";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if(pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine("É a mesma pessoa");
            else
            {
                Console.WriteLine("Não é a mesma pessoa");
            }

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}

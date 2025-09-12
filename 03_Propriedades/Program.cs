using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static _03_Propriedades.Program;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("999-88");

            //conta.Nome = "Thiago Silva";
            conta.setNome("Thiago Silva"); //Utilizando metodo acessador

            //Não é possível atribuir valor ao campo numero, pois ele é privado
            //conta.Numero = "999-88";


            //conta.saldo = -1000.00m;  --Erro, pois saldo é privado
            conta.Depositar(-1000.00m) ; // m de valor monetário

            //Utilizando metodo acessador
            conta.setSaldo(1000.00m);

            //Console.WriteLine(conta.getSaldo():c2);
            conta.ImprimirSaldo();


            while (true)
            {
                Console.WriteLine("Informe a Operação: [D] - Depositar, [S] - Sacar ou [E] - Sair");
                string operacao = Console.ReadLine(); // Colocar .ToUpper() para evitar erro de digitação (Letras maiusculas)

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor do Depósito");
                    decimal valorDepositado = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDepositado);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para Saque");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo():c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para depositar, [S] para Sacar e [E] para Sair");
                }
            }
        }

        public class Conta
        {
            private string numero;
            private string nome;

            public string getNome() //metodo acessador
            {
                return nome; 
            }
            public void setNome(string nome) //metodo acessador
            {
                this.nome = nome; //This.nome referencia o campo da classe, já o nome sem o this referencia o parametro do metodo
            }

            public string getNumero()
            {
                return numero; 
            }
            public Conta(string numero) //Construtor é executado apenas uma vez quando o objeto é instanciado
            {
                this.numero = numero;
            }

            //Transformar o campo Saldo em privado
            //public decimal Saldo;
            private decimal saldo;

            //metodos acessadores
            public decimal getSaldo()
            {
                return saldo;
            }

            public void setSaldo(decimal saldo)
            {
                this.Depositar(saldo);
            }

            public void Depositar(decimal valor)
            {
                if (valor > 0 )
                    saldo += valor;
                else
                    Console.WriteLine("Valor de depósito incorreto, deve ser maior do que zero");

            }
            public void Sacar(decimal valor)
            {
                if (valor > 0)
                {
                    saldo -= valor;
                }
                else
                {
                    Console.WriteLine("Valor de saque incorreto, deve ser maior do que zero");
                }

            }

            public void ImprimirSaldo()
            {
                Console.WriteLine($"Saldo atual da conta é {saldo:C2}");
            }
        }
    }
}

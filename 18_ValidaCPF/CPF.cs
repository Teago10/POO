using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_ValidaCPF
{
    public class CPF : IDocumento
    {
        public string Numero { get; private set; }
        public CPF(string numero)
        {
            Numero = numero;
        }

        public bool Validar()
        {
            // 1 - Eliminar caractres não numéricos
            string cpf = Regex.Replace(Numero, "[^0-9]", "");

            // 2 - Validar se tem 11 digitos
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF deve conter 11 digitos");
                return false;
            }

            if (cpf.Distinct().Count() == 1)
            {
                Console.WriteLine("CPF inválido! Números repetidos não são permitidos");
                return false;
            }

            //4 - Cálculo do 1º Digito verificador 
            int digX = CalculaDV(cpf, 9, 10);

            //5 - Cálculo do 2º Digito Verificador 
            int digY = CalculaDV(cpf, 10, 11);

            //6 - Comparar os dígitos 
            if (int.Parse(cpf[9].ToString()) == digX && int.Parse(cpf[10].ToString()) == digY) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
            }
            int resto = soma % 11;

            int digito = 0;
            if (resto >= 2)
            {
                digito = 11 - resto;
            }
            return digito;
        }
    }
}

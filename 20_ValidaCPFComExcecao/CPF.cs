using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPF : IDocumento
    {
        public string Numero { get; } // private set serve para impedir alteração externa
        public CPF(string numero)
        {
            // 1 - Eliminar caractres não numéricos
            this.Numero = Regex.Replace(numero, "[^0-9]", "");

            // 2 - Validar se tem 11 digitos
            if (this.Numero.Length != 11)
            {
                throw new CPFQtdeDigitosException(); //lançar exceção. throw é usado para lançar exceções
            }

            if (this.Numero.Distinct().Count() == 1)
            {
                throw new CPFMesmoNumeroException();
            }
        }

        // private set serve para impedir alteração externa do codigo abaixo
        /*public void AlteraCPF(string numero)
        {
            //Numero = numero;
        }*/

        public bool Validar()
        {


            

            //4 - Cálculo do 1º Digito verificador 
            int digX = CalculaDV(Numero, 9, 10);

            //5 - Cálculo do 2º Digito Verificador 
            int digY = CalculaDV(Numero, 10, 11);

            //6 - Comparar os dígitos 
            if (int.Parse(Numero[9].ToString()) == digX && int.Parse(Numero[10].ToString()) == digY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculaDV(string cpf, int qtdeNumeros, int peso)
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

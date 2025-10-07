using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _20_ValidaCPFComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //string cpf = Console.ReadLine();
            IDocumento documento;
            while (true)
            {
                Console.WriteLine("Informe o CPF");

                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine($"CPF Inválido! {ex.Message}");
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine($"CPF Inválido! {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF Inválido! {ex.Message}");
                }

                finally 
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            if (documento.Validar())
            {
                Console.WriteLine("CPF Válido!");
            }
            else
            {
                Console.WriteLine("CPF Inválido!");
            }

            while (true) 
            {
                Console.WriteLine("Informe o CNPJ");

                try
                {
                    documento = new CNPJ(Console.ReadLine());
                    break;
                }
                catch (CNPJQtdeDigitosException ex)
                {
                    Console.WriteLine($"CNPJ Inválido! {ex.Message}");
                }
                catch (CNPJSequenciaException ex)
                {
                    Console.WriteLine($"CNPJ Inválido! {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CNPJ Inválido! {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

            /*
            Console.WriteLine("Informe o CPF");
            CPF cpf = new CPF(Console.ReadLine());
                             OU
            IDocumento documento = new CPF(Console.ReadLine());

            if(cpf.Validar())
                Console.WriteLine("CPF válido")
            else
                Console.WriteLine("CPF inválido")
             
             */
        }



    }
}



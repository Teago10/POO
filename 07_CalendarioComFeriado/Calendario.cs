using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalendarioComFeriado
{
    internal class Calendario
    {
        private int ano;
        private int mes;
        private DateTime primeiroDiaMes;
        private int[,] calendario;
        public Calendario(int ano, int mes) // construtor
        {
            this.ano = ano; // atribui o ano
            this.mes = mes; // atribui o mês
            primeiroDiaMes = new DateTime(ano, mes, 1); // Primeiro dia do mês
            calendario = new int[6, 7]; // 6 semanas, 7 dias por semana
            gerarCalendario(); // gera o calendário
        }
        private void gerarCalendario() // gera o calendário
        {
            int diasDoMes = DateTime.DaysInMonth(ano, mes); // número de dias do mês

            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek; // dia da semana do primeiro dia do mês (0=Dom, 1=Seg, ..., 6=Sáb)

            int dia = 1; // dia do mês

            for (int semana = 0; semana < 6; semana++) // para cada semana
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++) // para cada dia da semana
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio) // antes do primeiro dia do mês
                    {
                        calendario[semana, diaSemana] = 0; // vazio
                    }
                    else if (dia <= diasDoMes) // enquanto houver dias no mês
                    {
                        calendario[semana, diaSemana] = dia; // atribui o dia
                        dia++; // incrementa o dia
                    }
                }
            }
        }

        public void ImprimirCalendario()
        {
            Console.WriteLine($"\nCalendário de " +
                                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            //int[] diasFeriados = { };
            Feriado[] diasFeriados = RetornaFeriados(); // obtém os feriados do mês, chamando o método RetornaFeriados()

            bool ehFeriado;

            //impressão do calendário
            for (int semana = 0; semana < 6; semana++) // para cada semana
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++) // para cada dia da semana
                {
                    if (calendario[semana, diaSemana] != 0) // se houver dia, imprime o dia 
                    {
                        ehFeriado = false;
                        for (int posicaoFeriado = 0; posicaoFeriado < diasFeriados.Length; posicaoFeriado++) // verifica se o dia é feriado
                        {
                            if (diasFeriados[posicaoFeriado] != null && diasFeriados[posicaoFeriado].Dia == calendario[semana, diaSemana]) // se for feriado
                            {
                                ehFeriado = true;
                                break;
                            }
                        }

                        //if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0) // se for feriado ou domingo, muda a cor para vermelho
                        if (ehFeriado || diaSemana == 0) // se for feriado ou domingo, muda a cor para vermelho
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t"); // imprime o dia com dois dígitos

                        Console.ResetColor(); // reseta a cor
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            /*for (int i = 0; i < diasFeriados.Length; i++) // imprime os feriados
            {
                if (diasFeriados[i] > 0) // se for maior que zero, imprime o dia
                {
                    Console.Write($"{diasFeriados[i].ToString("D2")}\t"); // imprime o dia com dois dígitos
                }
            }*/
            foreach (Feriado diasFeriado in diasFeriados) // imprime os feriados
            {
                if (diasFeriado != null) // se não for nulo, imprime o dia e a descrição
                    Console.Write($"{diasFeriado.Dia:D2} - {diasFeriado.Descricao}\t"); // imprime o dia com dois dígitos e a descrição 
            }
        }

        private Feriado[] RetornaFeriados()
        {
            Feriado[] feriados = new Feriado[15]; // array para armazenar os feriados do mês

            int indice = 0; // índice para o array de feriados          
            if (mes == 1) feriados[indice++] = new Feriado(1, "Confraternização Universal"); // Confraternização Universal

            else if (mes == 4)
            {
                feriados[indice++] = new Feriado(4, "Aniversario da Cidade");
                feriados[indice++] = new Feriado(21, "Tiradentes");
            }
            else if (mes == 5) feriados[indice++] = new Feriado(1, "Dia do Trabalho");
            else if (mes == 7) feriados[indice++] = new Feriado(9, "Revolução Constitucionalista de SP");
            else if (mes == 9) feriados[indice++] = new Feriado(7, "Independência do Brasil");
            else if (mes == 10) feriados[indice++] = new Feriado(12, "Nossa Senhora Aparecida");
            else if (mes == 11)
            {
                feriados[indice++] = new Feriado(2, "Finados");
                feriados[indice++] = new Feriado(15, "Proclamação da Republica");
                feriados[indice++] = new Feriado(20, "Conciência Negra");
            }
            else if (mes == 12)
            {
                feriados[indice++] = new Feriado(8, "Padroeira da Cidade");
                feriados[indice++] = new Feriado(25, "Natal");
            }
            DateTime domingoDePascoa = DomingoDePascoa();

            DateTime carnaval = domingoDePascoa.AddDays(-47); // 47 dias antes da Páscoa
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2); // 2 dias antes da Páscoa
            DateTime CorpuChrist = domingoDePascoa.AddDays(60); // 60 dias depois da Páscoa

            if (domingoDePascoa.Month == mes)
                feriados[indice++] = new Feriado(domingoDePascoa.Day, "Páscoa"); // se a Páscoa for no mês, adiciona ao array

            if (carnaval.Month == mes)
                feriados[indice++] = new Feriado(carnaval.Day, "Carnaval"); // se o Carnaval for no mês, adiciona ao array

            if (sextaFeiraSanta.Month == mes)
                feriados[indice++] = new Feriado(sextaFeiraSanta.Day, "Sexta Feira Santa"); // se a Sexta-feira Santa for no mês, adiciona ao array

            if (CorpuChrist.Month == mes)
                feriados[indice++] = new Feriado(CorpuChrist.Day, "Corpus Christe"); // se o Corpus Christi for no mês, adiciona ao array

            // Array.Sort(feriados); // ordena o array de feriados

            return feriados;
        }

        private DateTime DomingoDePascoa()
        {
            DateTime domingoDePascoa; // variável para armazenar a data da Páscoa
            int X = 0, Y = 0, a, b, c, d, g, dia, mes;

            if (ano <= 1699)
            {
                X = 22;
                Y = 2;
            }
            else if (ano <= 1799)
            {
                X = 23;
                Y = 3;
            }
            else if (ano <= 1899)
            {
                X = 24;
                Y = 4;
            }
            else if (ano <= 2099)
            {
                X = 24;
                Y = 5;
            }
            else if (ano <= 2199)
            {
                X = 24;
                Y = 6;
            }
            else if (ano <= 2299)
            {
                X = 24;
                Y = 7;
            }

            a = ano % 19;
            b = ano % 4;
            c = ano % 7;
            d = (19 * a + X) % 30;
            g = (2 * b + 4 * c + 6 * d + Y) % 7;

            if ((d + g) > 9)
            {
                dia = (d + g - 9);
                mes = 4;
            }
            else
            {
                dia = (d + g + 22);
                mes = 3;
            }

            domingoDePascoa = new DateTime(ano, mes, dia); // cria a data da Páscoa

            return domingoDePascoa;
        }
    }
}
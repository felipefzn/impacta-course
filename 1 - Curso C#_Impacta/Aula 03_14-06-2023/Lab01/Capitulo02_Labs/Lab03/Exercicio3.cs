using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
    {
    class Exercicio3
        {
        static void Main(string[] args)
            {
            int max = 100;
            int min = 0;
            int tentativas = 0;
            int valorGerado = new Random().Next(min, max);

            while (true)
                {
                //toda interacao registra uma tentativa
                tentativas++;

                Console.Write($"Informar um valor entre {min} e { max}: ");
                int valor = int.Parse(Console.ReadLine());

                //validamos o valor informado
                if (valor < min || valor > max)
                    {
                    continue;
                    }

                // compara o valor informado com valor gerado
                if (valor < valorGerado)
                    {
                    min = valor + 1;
                    }
                else if (valor > valorGerado)
                    {
                    max = valor - 1;
                    }
                else
                    {
                    break;
                    }


                }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Você acertou em {tentativas} tentativas.");
            Console.ReadKey();
            }
        }
    }

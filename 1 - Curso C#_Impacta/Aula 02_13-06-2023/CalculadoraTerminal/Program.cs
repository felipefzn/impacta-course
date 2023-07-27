using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTerminal
    {
    class Program
        {
        static void Main(string[] args)
            {
            // CTRL + K + C - Comenta o código, ou clicando ali encima 
            // CTRL + K + U - Descomenta o código

            /*Outro tipo de comentario */


            // Declaração de variaveis
            int num1 = 0;
            int num2 = 0;

            //// mudar a cor do fundo
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Green;

            // Colocar um titulo para nossa Calculadora || o Write deixa o cursor piscando na linha que vc escreveu, e o WriteLine quebra a linha, e o cursor
            // Vem pra linha de baixo
            Console.WriteLine("CALCULADORA no C#");
            // \n faz uma quebra de linha
            Console.WriteLine("---------------------\n");

            //pergunta para o usuario digitar o primeiro numero
            Console.WriteLine("Digite um número e pressione [ENTER]");
            // vamos ler o que o usuario digitar
            // Esse Convert.ToInt32 = converte o valor da var string para int
            num1 = Convert.ToInt32(Console.ReadLine());

            // vamos ler o segundo numero digitado pelo usuario
            Console.WriteLine("Digite outro número e pressione [ENTER]");
            num2 = Convert.ToInt32(Console.ReadLine());

            // mostrar as opções da calculadora
            // \t ele faz uma tabulação
            Console.WriteLine("Escolha uma opção da Lista abaixo: ");
            Console.WriteLine("\n\ta - Adicionar");
            Console.WriteLine("\ts - Subtrair");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.Write("\n Opção selecionada: ");

            string opcao = Console.ReadLine();

            //ao colocar o $ na frente, ele faz a conversão automaticamente, ou seja converteu os numeros para string, interpolação de variaveis, ele vai interpolar essa variavel, vai pegar ela e concatenar com uma string
            switch (opcao)
                {
                case "a":
                    Console.WriteLine($"Seu resultado é: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Seu resultado é: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu resultado é: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":

                    while (num1 == 0)
                        {
                        Console.WriteLine("\nDigite o primeiro numero diferente de zero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        }

                    while (num2 == 0)
                        {
                        Console.WriteLine("\nDigite o segundo numero diferente de zero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        }
                    Console.WriteLine($"Seu resultado é: {num1} / {num2} = " + (num1 / num2));
                    break;
                }

            // mensagem final para o usuario
            Console.WriteLine("Pressione qualquer tecla para fechar a calculadora...");
            Console.ReadKey(); // faz o terminal não fechar, espera o usuario apertar uma tecla

            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo02_Labs
    {
    class Exercicio01
        {
        static void Main(string[] args)
            {

            bool continuar = true;

            while (continuar)
                {

                string strNome;
                int idade;
                double dblIngresso;
                string resposta;

                Console.WriteLine("SEJA BEM VINDO AO CLUBE!!!!");
                Console.WriteLine(new string('-', 15));


                Console.WriteLine("Escreva seu nome: ");
                strNome = Console.ReadLine();

                Console.WriteLine(new string('-', 15));

                Console.WriteLine("Escreva sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(new string('-', 30));

                if (idade <= 17)
                    {
                    dblIngresso = 30;
                    }
                else if (idade > 17 && idade <= 59)
                    {
                    dblIngresso = 40;
                    }
                else
                    {
                    dblIngresso = 20;
                    }

                resposta = $"O convidado {strNome} tem {idade} anos, e pagará {dblIngresso:c}";

                Console.WriteLine(resposta);
                Console.WriteLine(new string('-', 30));
                Console.WriteLine($"Deseja repetir o processo? [Digite 's' para continuar]");

                if (Console.ReadLine() != "s")
                    {
                    continuar = false;
                    Console.WriteLine("Obrigado, volte sempre!!!");

                    Console.WriteLine(new string('-', 5));

                    Console.WriteLine("[aperte qualquer tecla para fechar o programa]");
                    Console.ReadKey();
                    }
                }
            }
        }
    }

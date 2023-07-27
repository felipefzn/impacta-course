using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
    {
    class Program
        {
        static void Main(string[] args)
            {

            string strSenha;
            bool continuar = true;
            int digito;

            while (continuar)
                {

                Console.WriteLine("Informe a quantidade de dígitos da senha: ");
                digito = Convert.ToInt32(Console.ReadLine());

                if (digito < 4 || digito > 10 || digito % 2 != 0)
                    {
                    Console.WriteLine($"O valor {digito} é inválido de acordo com as regras, por favor digite um valor entre 4 e 10, e que seja par!");
                    Console.ReadKey();
                    continue;
                    }
                //se o valor digitado atender as regras, usamos o break para quebrar o LOOP
                break;
                }


            //variável a ser usada como senha
            strSenha = "";

            //objeto a partir do qual os valores aleatórios serão gerados
            var rnd = new Random();


            for (int i = 0; i < digito; i++)
                {
                //valor aleatório entre 0 e 9
                int numero = rnd.Next(0, 9);

                //acumulo do valor em senha
                strSenha += numero;
                }

            Console.WriteLine($"Senha gerada: {strSenha}");
            Console.ReadKey();

            }
        }
    }

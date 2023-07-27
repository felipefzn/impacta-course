using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpactaTerminal
{
    class Program
    {
        static void Main(string[] args)//esse método recebe um argumento
        {
            Console.WriteLine("Hello World!");

            int a = 42;
            int b = 119;
            int c = a + b;

            Console.WriteLine(c);

            bool resultado = a == b;//bool, variavel vai retornar true or false

            object teste = resultado;//estou atribuindo um valor booleano para a variavel teste, objeto consegue receber o valor de tudo

            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine(); //ReadLine = leia a lina, vai armazenar oq vc digitar na var nome;

            Console.WriteLine("Boa noite " + nome);

            Console.ReadKey();// faz uma pausa, fica esperando vc apertar uma tecla
        }
    }
}


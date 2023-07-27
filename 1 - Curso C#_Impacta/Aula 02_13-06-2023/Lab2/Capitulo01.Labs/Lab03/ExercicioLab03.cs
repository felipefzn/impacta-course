using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
    {
    class ExercicioLab03
        {
        static void Main(string[] args)
            {

            Console.WriteLine("Escreva o nome do funcionario: ");
            string strNome = Console.ReadLine();

            Console.WriteLine("Informe o salario do funcionario: ");
            double dblSalario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor gasto com transporte no mês: ");
            double dblValorTransporte = Convert.ToDouble(Console.ReadLine());

            //desconto de 6% no salario
            double vt = dblSalario * 6 / 100;
            //verificação do valor real do vale-transporte
            double vtReal = (dblValorTransporte > vt ? vt : dblValorTransporte);

            string resultado =
                $"Funcionario: {strNome} \n Salario: {dblSalario:c} \n" +
                $"Desconto VT: {vtReal:c}";

            Console.WriteLine(resultado);
            Console.ReadKey();

            }
        }
    }

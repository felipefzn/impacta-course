using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
    {
    class ExercicioLab02
        {
        static void Main(string[] args)
            {
            Console.Write("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            //calculo de 10% sobre o salario fornecido
            // esse c na var, é uma formatação para casas decimais
            double desconto = (salario * 10 / 100);
            double salarioLiquido = (salario - desconto);
            string resposta = $"Funcionario: {nome} \n Salario Bruto: {salario:c} \n + " +
                $"Desconto  {desconto:c} \n Salario liquido: {salarioLiquido:c}";

            Console.WriteLine(resposta);
            Console.ReadKey();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta_GerenciadorPagamentos
    {
    class Program
        {
        static void Main(string[] args)
            {
            //herança de interface, organizar meu codigo
            //herança de abstrata, 
            //aquilo que for comum entre as classes, é recomendavel ter uma classe abstrata. Crie uma com a implemetanção padrão entre elas

            // Uma classe pai (Pagamento) tem tudo oq uma classe filha tem. Por isso aceita o Pagemtno instanciando o pgto
            PagamentoPorBoleto pgtoBoleto = new PagamentoPorBoleto();
            PagamentoPorCartaoDeCredito pgtoCc = new PagamentoPorCartaoDeCredito();
            PagamentoPorPix pgtoPix = new PagamentoPorPix();

            pgtoBoleto.RealizarPagamento(20m);
            pgtoCc.RealizarPagamento(40m);
            pgtoPix.RealizarPagamento(100m);
            pgtoPix.RealizarEstorno(100m);

            Console.ReadKey();

            }
        }

    //interface sempre vai ser publica, é o contrario de classe

    //uma classe pode herda apenas de uma classe, e de interfaces quantas quiser
    //
    //interface não tem implementação, nunca vai ter implementação de método
    //public interface IPagamento
    //    {
    //    int Id { get; set; }
    //    decimal DataPagamento { get; set; }

    //    void RealizarPagamento(decimal valor);
    //    void RealizarEstorno(decimal valor);

    //    }

    //sinal de herança é o :
    public abstract class Pagamento
        {
        //var no escopo da classe, e fora dos métodos, pode ser usada por todos os métodos
        //var fora do método, e dentro do escopo da classe chama atributo | var dentro do método, chama var.


        public int Id { get; set; }
        public decimal DataPagamento { get; set; }

        public void RealizarEstorno(decimal valor)
            {
            Console.WriteLine("Estorno Realizado com Sucesso.");

            }

        public virtual void RealizarPagamento(decimal valor)
            {
            decimal valorComTaxa = AdicionarTaxaDaMaquina(valor);
            Console.WriteLine($"[PADRAO - Base] - Pagamento realizado no valor: { valor: c}");
            Console.ReadKey();

            }

        //tudo que não tem modificador de acesso, é privado
        // quando tem void no método, ele não precisa retornar valor, e quando não tem o void, precisa do return

        public virtual decimal AdicionarTaxaDaMaquina(decimal valor)//quando coloca o virtual, é uma implementação padrão. A assinatura é a mesma 
            {
            return valor * 1.05m;
            }
        }


    public class PagamentoPorBoleto : Pagamento
        {
        public override void RealizarPagamento(decimal valor)
            {
            Console.WriteLine($"[Boleto] - Pagamento realizado no valor: {valor:c}");
            Console.ReadKey();
            }
        }


    public class PagamentoPorCartaoDeCredito : Pagamento
        {

        public override void RealizarPagamento(decimal valor)
            {

            valor = AdicionarTaxaDaMaquina(valor);

            Console.WriteLine($"[Cartão de Crédito] - Pagamento realizado no valor: {valor:c}");
            Console.ReadKey();
            }


        }

    public class PagamentoPorPix : Pagamento
        {

        }

    } 


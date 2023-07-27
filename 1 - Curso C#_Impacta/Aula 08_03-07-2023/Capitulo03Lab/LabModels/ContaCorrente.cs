using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabModels
    {
    public class ContaCorrente : Conta
        {
        //public int NumeroBanco { get; set; }
        //public string NumeroAgencia { get; set; }
        //public string NumeroConta { get; set; }
        public double Saldo { get; protected set; }

        public ContaCorrente()
            {

            }

        public ContaCorrente(int banco, string agencia, string conta) : base(banco, agencia, conta)
        {
            this.NumeroBanco = banco;
            this.NumeroAgencia = agencia;
            this.NumeroConta = conta;
        }

        // vamos criar nosso relacionamento com cliente
        public Cliente ClienteInfo { get; set; }

        // como recebemos herença da classe base Conta, agora temos que fornecer os parametros pedidos pelo
        // construtor pedidos pelo construtor da classe base Conta
        // para isso usamos a palavra BASE

        public ContaCorrente(int Banco, string Agencia, string Conta,
        Cliente cliente)
        : this(Banco, Agencia, Conta)
        {
            this.ClienteInfo = cliente;
        }


        public override void EfetuarOperacao(double valor, Operacoes operacoes = Operacoes.Deposito)
         {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser positivo");
            }

            switch (operacoes)
                {
                case Operacoes.Deposito:
                    this.Saldo += valor;
                    break;
                case Operacoes.Saque:
                    this.Saldo -= valor;
                    break;
                default:
                    break;
                }

            // ignora a classe filha e chama a classe pai
            base.RegistrarMovimento(valor, operacoes);
         }

        public virtual string Exibir()
        {
            string cliente = this.ClienteInfo != null ?
            this.ClienteInfo.Exibir() + "\n" : "";
            return $"{cliente} Banco: {this.NumeroBanco}\n Agência: {this.NumeroAgencia}\n Conta: {this.NumeroConta}\n Saldo Atual: {this.Saldo}";

        }

        public override string MostrarExtrato()
        {
            //StringBuilder serve para fazer a concatenação de string
            StringBuilder builder = new StringBuilder();

            builder.Append($"Cliente: {ClienteInfo.Nome} \n")
                .Append($"Banco: {NumeroBanco} \n")
                .Append($"Agência: {NumeroAgencia} \n")
                .Append($"Conta: {NumeroConta} \n")
                .Append(new string('-', 35));

            if (this.Movimentos.Count() == 0)
            {
                builder.Append("Nenhum movimento registrado para esta conta.");
            }
            else
            {
                foreach (var item in this.Movimentos)
                {
                    builder.Append($"{item} \n");
                }
            }

            builder.Append(new string('-', 35) + '\n');
            builder.Append($"Saldo: {this.Saldo:c}");

            return builder.ToString();

        }
    }
}

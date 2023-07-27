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



        // vamos criar nosso relacionamento com cliente
        public Cliente ClienteInfo { get; set; }

        // como recebemos herança da classe base Conta, agora temos que fornecer
        // os parametros pedidos pelo construtor da classe base conta
        // para isso usamos palabra BASE

        //virtual ele pode ser sobrescrito sua logica em outras classes
        public virtual void EfetuarOperacao(double valor, Operacoes operacoes = Operacoes.Deposito)
            {
            switch (operacoes)
                {
                case Operacoes.Deposito:
                    this.Saldo += valor;
                    break;
                case Operacoes.Saque:
                    if (valor <= this.Saldo)
                        {
                        this.Saldo -= valor;
                        }
                    break;
                default:
                    break;
                }
            }

        // construtor vem depois das propriedades
        public ContaCorrente(int banco, string agencia, string conta) : base(banco, agencia, conta)
            {
            base.NumeroConta = NumeroConta;
            this.NumeroBanco = banco;
            this.NumeroAgencia = agencia;
            this.NumeroConta = conta;

            }
        public ContaCorrente(int Banco, string Agencia, string Conta, Cliente cliente)
        : this(Banco, Agencia, Conta)
            {
            this.ClienteInfo = cliente;
            }

        public virtual string Exibir()
            {
            string cliente = this.ClienteInfo != null ?
            this.ClienteInfo.Exibir() + "\n" : "";
            return $"{cliente} Banco: {this.NumeroBanco}\n Agência: {this.NumeroAgencia}\n Conta: {this.NumeroConta}\n Saldo Atual: {this.Saldo}";

            }

        public override string MostrarExtrato()
            {
            throw new NotImplementedException();
            }
        }
    }

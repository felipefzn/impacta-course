using LabModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
{
    public class ContaEspecial : ContaCorrente
    {
        public double Limite { get; set; }

        public ContaEspecial(int Banco, string Agencia, string Conta) :
            base(Banco, Agencia, Conta)
        {

        }

        public ContaEspecial(int Banco, string Agencia, string Conta, Cliente cliente)
        : this(Banco, Agencia, Conta)
        {
            this.ClienteInfo = cliente;
        }

        public ContaEspecial(int Banco, string Agencia, string Conta, Cliente cliente, double Limite) : this(Banco, Agencia, Conta)
        {
            this.ClienteInfo = cliente;
            this.Limite = Limite;
        }


        public override void EfetuarOperacao(double valor, Operacoes operacoes = Operacoes.Deposito)
        {
            /* 
            Altere o modificador de acesso da propriedade Saldo, na classe ContaCorrente,
            para protected, pois ela deverá ser acessada também na nova subclasse
            */
            switch (operacoes)
            {
                case Operacoes.Deposito:
                    this.Saldo += valor;
                    break;
                case Operacoes.Saque:
                    if (valor <= (this.Saldo + this.Limite))
                    {
                        this.Saldo -= valor;
                    }
                    break;
                default:
                    break;
            }

            base.RegistrarMovimetno(valor, operacoes);
        }

        public override string Exibir()
        {
            return $"{base.Exibir()}\n" +
                $"Limite: {this.Limite}\n" +
                $"Salto Disponível: {this.Saldo + this.Limite}";
        }

        public override string MostrarExtrato()
        {
            return new StringBuilder(base.MostrarExtrato())
                .Append($"\n Limite: {this.Limite:c}")
                .Append($"\n Saldo Disponivel: {this.Limite + this.Saldo:c}")
                .ToString();
        }

    }
}

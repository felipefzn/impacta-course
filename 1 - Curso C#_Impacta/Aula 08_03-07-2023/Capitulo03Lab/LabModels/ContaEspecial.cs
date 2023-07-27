using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels
{
    public class ContaEspecial : ContaCorrente

    {
        private double _limite;
        public double Limite
        {
            get => _limite;
            set => _limite = (value <= 0 ? value :
            throw new
            InvalidOperationException("O Limite deve ser positivo"));
        }

        public ContaEspecial()
            {

            }

        public ContaEspecial(int Banco, string Agencia, string Conta) : base(Banco, Agencia, Conta)
        {

        }
        public ContaEspecial(int Banco, string Agencia, string Conta, Cliente cliente) : this(Banco, Agencia, Conta)
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
            switch (operacoes)
            {
                // Altere o modificador de acesso da propriedade Saldo, na claase
                case Operacoes.Deposito:
                    this.Saldo += valor;
                    break;
                case Operacoes.Saque:
                    if (valor > (this.Saldo + this.Limite))
                    {
                        throw new InvalidOperationException("Saldo Insuficiente");
                        
                    }

                    this.Saldo -= valor;
                    break;
                default:
                    break;
            }

            base.RegistrarMovimento(valor, operacoes);
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
                .Append($"\n Saldo Disponível: {this.Limite + this.Saldo:c}")
                .ToString();
        }


    }
}

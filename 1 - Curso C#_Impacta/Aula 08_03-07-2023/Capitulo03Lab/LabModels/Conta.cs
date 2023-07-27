using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels
{
    public class Conta
    {
        public int Id { get; set; }
        public int NumeroBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }
        public List<Movimento> Movimentos { get; set; }
        public Cliente ClienteInfo { get; set; }
        public double Limite { get; set; }
        public string NumeroDocumento { get; set; }


        //Construtor padrão (Default)

        public Conta()
            {

            }

        public Conta(int banco, string agencia, string conta)
        {
            if (Movimentos == null)
            {
                Movimentos = new List<Movimento>();
            }

            NumeroBanco = banco;
            NumeroAgencia = agencia;
            NumeroConta = conta;
        }

        protected void RegistrarMovimento(double valor, Operacoes operacao)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser positivo");
            }

            this.Movimentos.Add(new Movimento() 
            {
                Data = DateTime.Now,
                Historico = operacao == Operacoes.Saque ? "SAQUE" : "DEPÓSITO",
                Operacao = operacao,
                Valor = valor
            });
        }
        // Metodo que as classes filhas serao obrigadas a fornecer a sua implementacao
        public virtual string MostrarExtrato()
            {
            throw new Exception("Esse método deve ser implementado na classe filha");
            }

        public virtual void EfetuarOperacao(double valor, Operacoes operacao = Operacoes.Deposito)
            {
            Operacoes operacoes = Operacoes.Deposito;
            }

        public override string ToString()
        {
            return this.NumeroAgencia + "/" + this.NumeroConta;
        }

    }
}

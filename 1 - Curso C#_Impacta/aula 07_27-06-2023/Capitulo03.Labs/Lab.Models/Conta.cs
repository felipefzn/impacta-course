using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
{
    public abstract class Conta
    {
        public int NumeroBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }
        public List<Movimento> Movimentos { get; set; }
        public Cliente ClienteInfo { get; set; }

        // construtor
        public Conta(int banco, string agencia, string conta)
        {

            //if (Movimentos == null)
            //    {
            //    Movimentos = new List<Movimento> movimentos;
            //    }


            NumeroBanco = banco;
            NumeroAgencia = agencia;
            NumeroConta = conta;
        }

        protected void RegistrarMovimetno(double valor, Operacoes operacoes)
            {
            this.Movimentos.Add(new Movimento()
                {
                Data = DateTime.Now,
                Historico = operacoes == Operacoes.Saque ? "SAQUE" : "DEPÓSITO",
                operacoes = operacoes,
                Valor = valor
                });
            }

        // Metodo que as classes filhas serão obrigadas a
        // fornecer a sua implementação
        public abstract string MostrarExtrato();

        public abstract void EfetuarOperacao(double valor, Operacoes operacao = Operacoes.Deposito);

        public override string ToString()
            {
            return this.NumeroAgencia + "/" + this.NumeroConta;
            }


        }
}

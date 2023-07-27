using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Models;
using LabModels;
using LabUtilitarios;


namespace LabModels
{
    public class Cliente
    {
        public string _cpf;
        public string Cpf
        {

            get => _cpf;
            set
            {
                _cpf = value.ValidarCPF() ? value : throw new Exception("Cpf Inválido");//teve que por esse if ternario pois o método validar cpf é bool
            }

        }
        public string Nome { get; set; }
        public virtual string NumeroDocumento { get; set; }
        private int _idade;
        public int Idade
        {
            get => _idade;
            set => _idade = (value >= 0 ? value : throw new InvalidOperationException(
                "A idade não pode ser negativa"));
        }
        public Sexo Sexo { get; set; }
        public Endereco EnderecoResidencial { get; set; }
        public List<Conta> Contas { get; set; }


        public ContaCorrente Conta { get; set; }
        /// <summary>
        /// Construtor Padrão (não tem implementação interna)
        /// </summary>
        public Cliente()
            {

            }

        // CTOR p/ criar o construtor
        /// <summary>
        /// Metodo construtor versao 1
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="nome"></param>
        /// <param name="sexo"></param>
        public Cliente(string nome, Sexo sexo)
        {
            if (this.Contas == null)
            {
                this.Contas = new List<Conta>();
            }

            this.Nome = nome;
            this.Sexo = sexo;

        }

        /// <summary>
        /// Metodo construtor versao 2
        /// </summary>
        /// <param name="cpf">cpf do cliente</param>
        /// <param name="nome">nome do cliente</param>
        /// <param name="sexo">sexo do cliente</param>
        /// <param name="endereco">endereco do cliente</param>

        public Cliente(string nome, Sexo sexo, Endereco endereco)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.EnderecoResidencial = endereco;

        }

        public Cliente(string Nome, Sexo Sexo, int idade) : this(Nome, Sexo)
        {
            this.Idade = idade;
        }

        // Metodo Destrutor

        ~Cliente()
        {
            if (this.Contas != null)
            {
                this.Contas = null;
            }
        }

        public virtual string Exibir()
        {
            return $"Cpf: {Cpf} \n Nome: {Nome} \n Idade: {Idade} \n Sexo: {Sexo} \n ENDEREÇO DO CLIENTE: {EnderecoResidencial.Exibir()}";
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }

}

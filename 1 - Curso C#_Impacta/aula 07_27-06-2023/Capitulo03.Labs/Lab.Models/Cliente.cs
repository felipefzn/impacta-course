using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Lab.Utilitarios;
using LabModels;

namespace Lab.Models
    {
    public abstract class Cliente
        {

        private string _cpf;
        private string cpf;

        public string Cpf
            {
            get => _cpf;
            set
                {
                _cpf = value.ValidarCPF() ? value : throw new Exception("Cpf Invalido");
                }
            }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco EnderecoResidencial { get; set; }
        public List<Conta> Contas { get; set; }

        public ContaCorrente Conta { get; set; }


        // CTOR p/ criar o construtor
        /// <summary>
        /// Metodo construtor versão 1
        /// </summary>
        /// <param name="cpf">cpf do cliente</param>
        /// <param name="nome">nome do cliente</param>
        /// <param name="sexo">sexo do cliente</param>
        public Cliente(string nome, Sexo sexo)
            {

            if (this.Contas == null)
                {
                this.Conta = new List<Conta>();
                }

            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = sexo;
            }

        /// <summary>
        /// Metodo Construtor versao 2
        /// </summary>
        /// <param name="cpf">cpf do cliente</param>
        /// <param name="nome">nome do cliente</param>
        /// <param name="sexo">sexo do cliente</param>
        /// <param name="endereco">endereço do cliente</param>
        public Cliente(string nome, Sexo sexo, Endereco endereco)
            {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = sexo;
            this.EnderecoResidencial = endereco;
            }

        /// <summary>
        /// Metodo Construtor Versao 3
        /// </summary>
        /// <param name="Cpf"></param>
        /// <param name="Nome"></param>
        /// <param name="Sexo"></param>
        /// <param name="idade"></param>
        public Cliente(string Nome, Sexo Sexo, int idade) : this(Cpf, Nome, Sexo)
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
            return $"Cpf: {Cpf} \n" +
                     $"Nome: {Nome} \n" +
                     $"Idade: {Idade} \n" +
                     $"Sexo: {Sexo} \n" +
                     $"ENDERÇO DO CLIENTE: {EnderecoResidencial.Exibir()} \n";
            }

        //public override string ToString()
        //    {
        //    return this.Nome();
        //    }

        }
    }

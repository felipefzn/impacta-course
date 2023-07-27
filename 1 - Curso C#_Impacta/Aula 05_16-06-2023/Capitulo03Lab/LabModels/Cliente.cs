using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco EnderecoResidencial { get; set; }
        public ContaCorrente Conta { get; set; }

        
        public Cliente(string cpf, string nome, Sexo sexo)
            {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = Sexo;
            }

        public Cliente(string cpf, string nome, Sexo sexo, Endereco endereco)
            {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = Sexo;
            this.EnderecoResidencial = endereco;
            }

        public Cliente(string Cpf, string Nome, Sexo Sexo, int idade) : this(Cpf, Nome, Sexo)
            {
            this.Idade = idade;
            }

        //metodo destrutor

        //~Cliente()
        //    {
        //    if (this.Conta = null)
        //        {
        //        GC.SuppressFinalize;
        //        this.Conta = null;
        //        }
        //    }

        public string Exibir()
            {
            return $"Cpf: {Cpf} \n Nome: {Nome} \n Idade: {Idade} \n Sexo: {Sexo} \n ENDEREÇO DO CLIENTE: {EnderecoResidencial.Exibir()}";
            }
        }
    }

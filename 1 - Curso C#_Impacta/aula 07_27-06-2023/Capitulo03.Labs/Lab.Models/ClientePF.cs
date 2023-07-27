using Lab.Models.Interfaces;
using Lab.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
    {
    public class ClientePF : Cliente, IDocumento
        {
        private string _cpf;      

        public string NumeroDocumento
            {
            get => _cpf;
            set
                {
                if (value.ValidarCPF())
                    {
                    _cpf = value;
                    }
                else
                    {
                    throw new Exception("CPF Inválido");
                    }
                }

            }

        public string MostrarDocumento()
            {
            return $"CPF do Cliente : {NumeroDocumento}";
            }

        public ClientePF(string cpf, string nome, Sexo sexo, int idade, Endereco endereco)
            :base(nome, sexo)
            {
            this.NumeroDocumento = cpf;
            base.EnderecoResidencial = endereco;
            }
        public ClientePF(string Cpf, string Nome, Sexo Sexo, int Idade)
            : base(Nome, Sexo, Idade)
            {
            this.NumeroDocumento = Cpf;
            }

        public override string Exibir()
            {
            return $"{MostrarDocumento()}\n {base.Exibir()}";
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Models;
using LabModels.Interfaces;
using LabUtilitarios;

namespace LabModels
{
    public class ClientePF : Cliente, iDocumento
    {
        public override string NumeroDocumento
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
            throw new NotImplementedException();
        }

        public ClientePF(string cpf, string nome, Sexo sexo, int idade, Endereco endereco)
            :base(nome, sexo)
        {
            this.NumeroDocumento = cpf;
            base.EnderecoResidencial = endereco;
        }

        public ClientePF(string Cpf, string Nome, Sexo Sexo, int Idade, object enedereco)
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

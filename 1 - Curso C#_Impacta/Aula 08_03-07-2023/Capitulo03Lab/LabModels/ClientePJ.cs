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
     public class ClientePJ : Cliente, iDocumento
    {
        private string _cnpj;

        public override string NumeroDocumento
        {
            get { return _cnpj; }
            set { _cnpj = (value.Length == 14 ? value : throw new Exception("CNPJ Inválido"));
            }
        }

        public string MostrarDocumento()
        {
            return $"CNPJ do cliente: {NumeroDocumento}";
        }

        //construtores
        public ClientePJ(string Cnpj, string Nome, Sexo Sexo)
        : base(Nome, Sexo)
        {
            this.NumeroDocumento = Cnpj;
        }

        public ClientePJ(string Cnpj, string Nome, Sexo Sexo,
        int Idade, Endereco endereco)
        : base(Nome, Sexo, Idade)
        {
            this.NumeroDocumento = Cnpj;
            base.EnderecoResidencial = endereco;
        }
        public override string Exibir()
        {
            return $"{MostrarDocumento()}\n" +
            $"{base.Exibir()}";
        }
    }
}

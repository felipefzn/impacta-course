using Lab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
    {
    public class ClientePJ : Cliente, IDocumento
        {
        private string myVar;
        private string _cnpj;

        public string MyProperty
            {
            get { return _cnpj; }
            set { _cnpj = (value.Length == 14 ? value : throw new Exception("CNPJ Inválido"));
                }
            }
        public string NumeroDocumento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

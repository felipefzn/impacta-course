using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabUtilitarios;

namespace LabModels
    {
    public struct Endereco
        {
        public string Logradouro { get; set; }//prop tab tab
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }


        //Metodo Construtor
        public Endereco(string logradouro, int numero, string cidade, string cep)
            {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cidade = cidade;
            this.Cep = cep;
            }


        public string Exibir()
            {
            return $"Logradouro: {this.Logradouro} \n Número: {this.Numero} \n Cidade: {this.Cidade} \n CEP: {this.Cep} ";

#warning parei aqui fazendo alteração do cliente
            }
        }
    }

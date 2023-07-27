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
        public int Id { get; set; }
        public string Logradouro { get; set; }//prop tab tab
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        /// <summary>
        /// Metodo Construtor recebe como parametros os atributos iniciais para as propriedades da classe
        /// </summary>
        /// <param name="logradouro">e nome da rua ou avenida</param>
        /// <param name="numero">e o numero da residencia</param>
        /// <param name="cidade">e uam cidade do seu estado</param>
        /// <param name="cep">e o cep referente ao estado e cidade</param>

        public Endereco(int id, string logradouro, int numero, string cidade, string cep)
        {
            this.Id = id;
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

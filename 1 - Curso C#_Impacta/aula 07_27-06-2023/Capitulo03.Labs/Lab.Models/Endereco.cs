using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Utilitarios;



namespace Lab.Models
{
    public struct Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        /// <summary>
        /// Metodo construtor: Recebe como parametros os atributos iniciais para 
        /// as propriedades da classe.
        /// </summary>
        /// <param name="logradouro">e nome da rua ou avenida</param>
        /// <param name="numero">é o numero da residencia</param>
        /// <param name="cidade">é uma cidade do seu estado</param>
        /// <param name="cep">é o cep referente ao estado e cidade</param>
        public Endereco(string logradouro, int numero, string cidade, string cep)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cidade = cidade;
            this.Cep = cep;
        }


        public string Exibir()
        {
            return $"Logradouro: {this.Logradouro} \n" +
                $"Número: {this.Numero} \n" +
                $"Cidade: {this.Cidade} \n" +
                $"CEP: { this.Cep}";
        }
    }

}

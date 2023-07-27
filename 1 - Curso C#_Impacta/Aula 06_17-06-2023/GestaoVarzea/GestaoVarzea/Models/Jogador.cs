using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVarzea.Models
    {
    //esta classe será derivada da classe base pessoa
    // então ela recebe a herança da classe pessoa
    public class Jogador : Pessoa, IJogador
        {
        public string Posicao { get; set; }
        public int Registro { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataTerminoContrato { get; set; }
        public decimal Salario { get; set; }
        public int MyProperty { get; set; }

        

        public int CadastrarProduto()
            {
            throw new NotImplementedException();
            }

        public bool ConsultarJogador(Jogador atleta)
            {
            throw new NotImplementedException();
            }

        public int EmitirNFe()
            {
            throw new NotImplementedException();
            }

        public int ExcluirProduto()
            {
            throw new NotImplementedException();
            }


        /// <summary>
        /// Salva no banco de dados o cadastro do jogador
        /// </summary>
        /// <param name="atleta">é um objeto do tipo classe jogador</param>
        /// <returns>Retorna Verdadeiro se foi inserido com sucesso, caso contrario false</returns>


        public bool SalvarJogador(Jogador atleta)
            {
            // adaptação paliativa == gambiarra
            if (atleta != null)
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        }
    }

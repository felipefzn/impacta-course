using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels
    {
    //abstract só serve pra passar herança, eu n posso trabalhar diretamente com ela
    public abstract class Conta
        {
        public int NumeroBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }

        //Contrutor
        public Conta(int banco, string agencia, string conta)
            {
            this.NumeroBanco = banco;
            this.NumeroAgencia = agencia;
            this.NumeroConta = conta;
            }

        // Metodo que as classes filhas serão obrigadas a forenecer a sua implementação
        public abstract string MostrarExtrato();
        }
    }
    



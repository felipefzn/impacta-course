using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVarzea.Models
    {
    // classe abstrata serve somente como modelo para
    // as demais classes que vão derivar dela
    public abstract class Pessoa        
        {
        // na classe na asbtrata colocamos dados como
        // propriedades e metodos comuns entre as classes

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        }
    }

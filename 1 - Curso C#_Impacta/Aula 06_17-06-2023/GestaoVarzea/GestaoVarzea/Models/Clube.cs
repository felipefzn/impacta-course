using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVarzea.Models
    {
   public class Clube
        {
        public int Id { get; set; }
        public string NomeClube { get; set; }
        public DateTime DataFundacao { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public string NomePresidente { get; set; }
        public int Telefone { get; set; }

        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Models;

namespace Lab.Dados
    {
    class ContasDao : Dao<Conta, string>
        {
        public override Conta Buscar(string chave)
            {
            throw new NotImplementedException();    
            }

        public override int IncluirT(Conta Item)
            {
            throw new NotImplementedException();
            }

        public override IEnumerable<Conta> Listar(string chave = null)
            {
            throw new NotImplementedException();
            }

        public override int Remover(Conta item)
            {
            throw new NotImplementedException();
            }
        }
    }

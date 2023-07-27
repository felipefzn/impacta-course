using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVarzea.Models
    {
    public interface IJogador
        {

        bool SalvarJogador(Jogador atleta);
        bool ConsultarJogador(Jogador atleta);
        int CadastrarProduto();
        int ExcluirProduto();
        int EmitirNFe();
        }
    }

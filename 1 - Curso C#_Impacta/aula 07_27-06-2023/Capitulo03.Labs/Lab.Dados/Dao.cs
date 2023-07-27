using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Dados
    {
    public abstract class Dao<T, K> where T : class
        {
        // o metodo marcado como abstract, ele não tem implementação padrão na classe base.
        // mas a classe derivada deve fornecer a sua propria implementação

        public abstract int IncluirT(T Item);
        public abstract T Buscar(K chave);

        /*
         Observe que o método Listar recebe um parâmetro opcional. Como o tipo desse
parâmetro é genérico, atribuímos o comando default(T) para que seja assumido o
valor default de acordo com o tipo do parâmetro de tipo K.
        */


        public abstract IEnumerable<T> Listar(K chave = default(K));
        public abstract int Remover(T item);
        }
    }

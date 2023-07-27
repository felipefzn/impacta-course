using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabModels;

namespace LabDados
{
    public abstract class Dao<T, K> where T: class
    {

        protected string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBAplicacaoBancaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected SqlConnection cn;

        public Dao()
            {
            cn = new SqlConnection(conexao);
            }

        // o metodo marcado como abstract class, ele não tem implementação padrão na classe base, mas a classe
        // derivada deve fornecer a sua própria implementação
        public abstract int Incluir(T item);
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

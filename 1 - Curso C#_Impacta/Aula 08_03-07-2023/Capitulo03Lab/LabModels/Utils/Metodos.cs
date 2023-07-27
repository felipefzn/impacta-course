using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels.Utils
{
    public class Metodos
    {
        private static HashSet<Cliente> clientes = new HashSet<Cliente>();
        private static HashSet<Conta> contas = new HashSet<Conta>();

        public static void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static IEnumerable<Cliente> ListarClientes()
        {
            return clientes;

        }

        public static IEnumerable<Conta> ListarContas()
        {
            return contas;

        }
    }
}

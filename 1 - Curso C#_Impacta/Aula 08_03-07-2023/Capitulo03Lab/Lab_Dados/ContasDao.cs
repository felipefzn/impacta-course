using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabModels;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace LabDados
    {
    public class ContasDao : Dao<Conta, string>
        {
        public override Conta Buscar(string chave)
            {
            Cliente cli = null;

            try
                {
                cli = cn.QueryFirst<Cliente>("SELECT NumeroDocumento, Nome, Idade, case Sexo where 'F' then 1 when 'M' then 0 end as Sexo from Clientes " +
                    "where NumeroDocumento = @NumeroDocumento", new { NumeroDocumento = numerodocumento });
                }
            catch (Exception)
                {

                throw;
                }
            }

        public override int Incluir(Conta item)
            {
            long registros = 0;
            double limite = 0;

            // vamos verificar o tipo de conta
            if (item is ContaEspecial)
                {
                limite = ((ContaEspecial)item).Limite;
                }

            try
                {
                registros = cn.Insert<ContaEspecial>(
                    new ContaEspecial
                        {
                        NumeroDocumento = item.NumeroDocumento,
                        NumeroBanco = item.NumeroBanco,
                        NumeroAgencia = item.NumeroAgencia,
                        NumeroConta = item.NumeroConta,
                        Limite = limite,
                        });
                }
            catch (Exception)
                {

                throw;
                }

            return (int)registros;
            }

        public override IEnumerable<Conta> Listar(string chave = null)
            {
            List<Conta> conta = new List<Conta>();

            try
                {
                /* com DAPPER puro seria assim:
                var lista = cn.Query<ContaEspecial>("SELECT * from TBContas");
                */
                var lista = cn.GetAll<ContaEspecial>();

                // vamos separar os clientes PF e PJ
                foreach (var item in lista)
                    {
                    if (item.Limite == 0) //conta comum se limite == 0
                        {
                        var cc = new ContaCorrente(item.NumeroBanco, item.NumeroAgencia, item.NumeroConta);

                        cc.Id = item.Id;
                        cc.NumeroDocumento = item.NumeroDocumento;

                        contas.Add(cc); 
                        }
                    else
                        {
                        contas.Add(item);
                        }
                    }
                }
            catch (Exception)
                {

                throw;
                }
            }

        public override int Remover(Conta item)
            {
            throw new NotImplementedException();
            }
        }
    }

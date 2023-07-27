using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabModels;
using Dapper;
using Lab.Models;

namespace LabDados
    {
    public class ClientesDao : Dao<Cliente, string>
        {
        public override Cliente Buscar(string chave)
            {


            Cliente cli = null;

            try
                {
                cli = cn.QueryFirst<Cliente>("SELECT NumeroDocumento, " +
                                    "Nome, Idade," +
                                    "case Sexo" +
                                    " when 'F' then 1" +
                                    " when 'M' then 0 " +
                                    "end as Sexo from Clientes WHERE " +
                                    "NumeroDocumento = @NumeroDocumento",
                                    new { NumeroDocumento = chave });
                }
            catch (Exception)
                {

                throw;
                }
            return cli;
            }

        public override int Incluir(Cliente item)
            {
            var registros = 0; // vai receber o número de registros incluidos

            try
                {
                string documento;
                if (item is ClientePF)
                    {
                    documento = ((ClientePF)item).NumeroDocumento;
                    }
                else
                    {
                    // é pessoa juridica
                    documento = ((ClientePJ)item).NumeroDocumento;
                    }

                registros = cn.Execute("INSERT INTO Cliente(" +
                    "NumeroDocumento, Nome, Idade, Sexo) " +
                    "VALUES (@NumeroDocumento, @Nome, @Idade, @Sexo)",
                    new
                        {
                        NumeroDocumento = documento,
                        item.Nome,
                        item.Idade,
                        Sexo = (item.Sexo == Sexo.Masculino ? "M" : "F")
                        }
                    );

                var endereco = cn.Execute("INSERT INTO TBEnderecos (" +
                "NumeroDocumento,Logradouro,Numero,Cidade,Cep) " +
                "VALUES (@NumeroDocumento,@Logradouro,@Numero,@Cidade, @Cep)",
                    new
                        {
                        NumeroDocumento = documento,
                        item.EnderecoResidencial.Logradouro,
                        item.EnderecoResidencial.Numero,
                        item.EnderecoResidencial.Cidade,
                        item.EnderecoResidencial.Cep
                        });
                }
            catch (Exception)
                {

                throw;
                }
            return registros;
            }

        public override IEnumerable<Cliente> Listar(string chave = null)
            {
            List<Cliente> clientes = new List<Cliente>();

            try
                {
                var lista = cn.Query<Cliente>(
                                "SELECT NumeroDocumento, " +
                                "Nome, Idade," +
                                "case Sexo" +
                                " when 'F' then 1" +
                                " when 'M' then 0 " +
                                "end as Sexo from Clientes");

                // vamos fazer um for para separar o cliente PF do PJ
                foreach (var item in lista)
                    {
                    var endereco = BuscarEndereco(item.NumeroDocumento);
                    if (item.NumeroDocumento.Length == 11)
                        {
                        clientes.Add(new ClientePF(item.NumeroDocumento, item.Nome, item.Sexo, item.Idade, endereco));
                        }
                    else if (item.NumeroDocumento.Length == 14)
                        {
                        clientes.Add(new ClientePJ(item.NumeroDocumento, item.Nome, item.Sexo, item.Idade, endereco));
                        }
                    }
                }
            catch (Exception)
                {

                throw;
                }
            }

        private object BuscarEndereco(string numeroDocumento)
            {
            Endereco endereco;
            try
                {
                endereco = cn.QueryFirst<Endereco>(
                    "Select * from TBEnderecos WHERE NumeroDocumento = @NumeroDocumento",
                    new { NumeroDocumento = numeroDocumento });
                }
            catch (Exception)
                {

                throw;
                }
            return endereco;
            }

        public override int Remover(Cliente item)
            {
            string documento;
            var registros = 0;

            if (item is ClientePF)
                {
                documento = ((ClientePF)item).NumeroDocumento;
                }
            else if (item is ClientePJ)
                {
                documento = ((ClientePJ)item).NumeroDocumento;
                }
            else
                {
                throw new Exception("Objeto Cliente não identificado");
                }
            try
                {
                registros = cn.Execute("DELETE FROM Clientes WHERE NumeroDocumento = @NumeroDocumento", new { NumeroDocumento = documento });
                }
            catch (Exception)
                {

                throw;
                }
            }
        }
    }

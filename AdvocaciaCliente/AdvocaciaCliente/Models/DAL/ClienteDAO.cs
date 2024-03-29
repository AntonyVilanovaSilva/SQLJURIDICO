﻿using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class ClienteDAO
    {
        private SqlConnection _conexao;

        public ClienteDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<Cliente> getTodosClientes()
        {
            string sql = "select * from Cliente";
            var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
            return dados;
        }
        public bool inserirCliente(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO [dbo].[Cliente]  ([CLINOME],[CLIENDERECO] ,[CLINUMEROENDERECO], " +
                    "[CIDADE]  ,[ESTADOSIGLA]     ,[CLICPF]  ,[CLICNPJ]) " +
                    "VALUES  (@CLINOME, @CLIENDERECO,  @CLINUMEROENDERECO , @CIDADE, @ESTADOSIGLA, @CLICPF, @CLICNPJ) ";
                int qtdInserida = _conexao.Execute(sql, cliente);
                if (qtdInserida > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                return false;
            }



        }
    }
}

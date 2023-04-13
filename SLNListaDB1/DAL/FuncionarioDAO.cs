using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class FuncionarioDAO
    {
        private SqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<FuncionarioDAO> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<FuncionarioDAO>)conexao.Query<FuncionarioDAO>(sql);
            return dados8;
        }
    }
}

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
        public List<Funcionario> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<Funcionario>)conexao.Query<Funcionario>(sql);
            return dados8;
        }
    }
}

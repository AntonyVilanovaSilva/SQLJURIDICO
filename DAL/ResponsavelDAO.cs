using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class ResponsavelDAO
    {
        private SqlConnection conexao;

        public ResponsavelDAO()
        {
            conexao = ConexaoBD.getConexao();
        }

        public List<Responsavel> getTodosResponsavel()
        {
            string sql = "select * from Responsavel";
            var dados = (List<Responsavel>)conexao.Query<Responsavel>(sql);
            return dados;
        }
        
  
        public List<FuncionarioDAO> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<FuncionarioDAO>)conexao.Query<FuncionarioDAO>(sql);
            return dados8;
        }
    }
}

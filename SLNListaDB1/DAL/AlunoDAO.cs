using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class AlunoDAO
    {

        private SqlConnection conexao;

        public AlunoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<Aluno> getTodosAlunos()
        {
            string sql = "select * from Aluno";
            var dados1 = (List<Aluno>)conexao.Query<Aluno>(sql);
            return dados1;
        }
    }
}

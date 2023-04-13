using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class RecursoDAO
    {
        private SqlConnection conexao;

        public RecursoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<RecursoDAO> getTodosRecursos()
        {
            string sql = "select * from Recurso";
            var dados5 = (List<RecursoDAO>)conexao.Query<RecursoDAO>(sql);
            return dados5;
        }
    }
}

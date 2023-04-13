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
        public List<Recurso> getTodosRecursos()
        {
            string sql = "select * from Recurso";
            var dados5 = (List<Recurso>)conexao.Query<Recurso>(sql);
            return dados5;
        }
    }
}

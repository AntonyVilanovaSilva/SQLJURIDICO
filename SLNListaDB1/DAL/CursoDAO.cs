using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class CursoDAO
    {
        private SqlConnection conexao;

        public CursoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<CursoDAO> getTodosCursos()
        {
            string sql = "select * from Curso";
            var dados2 = (List<CursoDAO>)conexao.Query<CursoDAO>(sql);
            return dados2;
        }
    }
}

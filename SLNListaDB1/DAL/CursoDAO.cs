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
        public List<Curso> getTodosCursos()
        {
            string sql = "select * from Curso";
            var dados2 = (List<Curso>)conexao.Query<Curso>(sql);
            return dados2;
        }
        public void insertCurso(Curso pcurso)
        {
            string query = "insert Curso(CUDESCRICAO,CUAREA) values (@CUDESCRICA, @CUAREA)";

            int qtdInserida = conexao.Execute(query, pcurso);

        }
        public void updateCurso(Curso pcurso)
        {
            string query = "update Curso set CUDESCRICAO=@CUDESCRICAO,CUAREA =@CUAREA where CUID=@CUID";

            int qtdAtualizada = conexao.Execute(query, pcurso);

        }
    }
}

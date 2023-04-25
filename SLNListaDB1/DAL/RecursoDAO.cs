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
        public void insertRecurso(Recurso precurso)
        {
            string query = "insert Recurso (RECDESCRICAO, RECQUANTIDADE, RECCODIGOCATEGORIA ) values (@RECDESCRICAO, @RECQUANTIDADE,@RECCODIGOCATEGORIA)";

            var qtdInserida = conexao.Execute(query, precurso);

        }
        public void updateRecurso(Recurso precurso)
        {
            string query = "update recurso set RECDESCRICAO=@RECDESCRICAO,RECQUANTIDADE=@RECQUANTIDADE, RECCODIGOCATEGORIA=@RECCODIGOCATEGORIA where RECID=@RECID";

            int qtdAtualizada = conexao.Execute(query, precurso);

        }
        public void apagarRecurso(Recurso precurso)
        {
            string query = "Delete sala where RECID=@RECID";

            int qtdAtualizada = conexao.Execute(query, precurso);

        }
    }
}

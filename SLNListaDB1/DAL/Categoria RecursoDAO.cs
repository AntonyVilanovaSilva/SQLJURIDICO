using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class Categoria_RecursoDAO
    {

        private SqlConnection conexao;

        public Categoria_RecursoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<CategoriaRecurso> getTodosCategorias()
        {
            string sql = "select * from CategoriaRecurso";
            var dados4 = (List<CategoriaRecurso>)conexao.Query<CategoriaRecurso>(sql);
            return dados4;
        }
        public void insertCategoriaRecurso(CategoriaRecurso pcategoriarecurso)
        {
            string query = "insert CategoriaRecurso(CATDESCRICAO ,CATNOME) values (@CATDESCRICAO , @CATNOME)";

            int qtdInserida = conexao.Execute(query, pcategoriarecurso);

        }
        public void updateCategoriaRecurso(CategoriaRecurso pcategoriarecurso)
        {
            string query = "update CategoriaRecurso set CATDESCRICAO=@CATDESCRICAO, CATNOME=@CATNOME where CATID =@CATID ";

            int qtdAtualizada = conexao.Execute(query, pcategoriarecurso);

        }
    }
}

using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class SalaDAO
    {
        private SqlConnection conexao;

        public SalaDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<Sala> getTodosSalas()
        {
            string sql = "select * from Sala";
            var dados = (List<Sala>)conexao.Query<Sala>(sql);
            return dados;
        }
        public void insertSala(Sala psala)
        {
            string query = "insert Sala (SALADESCRICAO, SALANUMERO) values (@SALADESCRICAO, @SALANUMERO)";

            int qtdInserida = conexao.Execute(query, psala);

        }
        public void updateSala(Sala psala)
        {
            string query = "update sala set SALADESCRICAO=@SALADESCRICAO, SALANUMERO=@SALANUMERO where SALID=@SALAID";

            int qtdAtualizada = conexao.Execute(query, psala);

        }
    }
}

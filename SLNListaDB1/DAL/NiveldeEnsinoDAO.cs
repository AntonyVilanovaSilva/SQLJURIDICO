using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class NiveldeEnsinoDAO
    {
        private SqlConnection conexao;

        public NiveldeEnsinoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<NiveldeEnsino> getTodosNiveldeEnsino()
        {
            string sql = "select * from NiveldeEnsino";
            var dados7 = (List<NiveldeEnsino>)conexao.Query<NiveldeEnsino>(sql);
            return dados7;
        }
        public void insertNiveldeEnsino(NiveldeEnsino pniveldeensino)
        {
            string query = "insert NiveldeEnsino (NIENOME,NIENDESCRICAO) values (@NIENOME, @NIENDESCRICAO)";

            var qtdInserida = conexao.Execute(query, pniveldeensino);

        }
        public void updateNiveldeEnsino(NiveldeEnsino pniveldeensino)
        {
            string query = "update niveldeEnsino set NIENOME=@NIENOME, NIENDESCRICAO=@NIENDESCRICAO where NIENID=@NIENID";

            int qtdAtualizada = conexao.Execute(query, pniveldeensino);

        }
    }
}

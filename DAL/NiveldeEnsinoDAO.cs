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
    }
}

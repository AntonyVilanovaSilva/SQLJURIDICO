using Dapper;
using GestaoSala.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoSala.DAL
{
    public class OCUPACAODAO
    {
        private SqlConnection _conexao;

        public OCUPACAODAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<OCUPACAO> getTodasAsOcupacoes()
        {
            string query = "select * from OCUPACAO";

            var lista = (List<OCUPACAO>)_conexao.Query<OCUPACAO>(query);
            return lista;
        }
    }
}

using Dapper;
using GestaoSala.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestaoSala.DAL
{
    public class SALADAO
    {
        private SqlConnection _conexao;

        public SALADAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<SALA> getTodasAsSalas()
        {
            string query = "select * from sala";
            _conexao.Open();

            var lista = (List<SALA>)_conexao.Query<SALA>(query);
            return lista;
        }
    }
}

using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class DepartamentoDAO
    {
        private SqlConnection conexao;

        public DepartamentoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<DepartamentoDAO> getTodosDepartamentos()
        {
            string sql = "select * from Departamento";
            var dados6 = (List<DepartamentoDAO>)conexao.Query<DepartamentoDAO>(sql);
            return dados6;
        }
    }
}

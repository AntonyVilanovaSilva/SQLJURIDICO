using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class ResponsavelDAO
    {
        private SqlConnection conexao;

        public ResponsavelDAO()
        {
            conexao = ConexaoBD.getConexao();
        }

        public List<Responsavel> getTodosResponsavel()
        {
            string sql = "select * from Responsavel";
            var dados = (List<Responsavel>)conexao.Query<Responsavel>(sql);
            return dados;
        }
        
  
        public List<Responsavel> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<Responsavel>)conexao.Query<Responsavel>(sql);
            return dados8;
        }
        public void insertResponsavel(Responsavel presponsavel)
        {
            string query = "insertResponsavel (RESNOME , RESIDADE,) values (@RESNOME, @RESIDADE)";

            var qtdInserida = conexao.Execute(query, presponsavel);

        }
        public void updateResponsavel(Responsavel presponsavel)
        {
            string query = "update serie set RESNOME=@RESNOME,RESIDADE=@RESIDADE where RESID=@RESID";

            int qtdAtualizada = conexao.Execute(query, presponsavel);

        }
        public void apagarResponsavel(Responsavel presponsavel)
        {
            string query = "Delete sala where RESID=@RESID";

            int qtdAtualizada = conexao.Execute(query, presponsavel);

        }
    }
}

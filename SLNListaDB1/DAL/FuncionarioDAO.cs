using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class FuncionarioDAO
    {
        private SqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<Funcionario> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<Funcionario>)conexao.Query<Funcionario>(sql);
            return dados8;
        }

        public void insertFuncionario(Funcionario pFuncionario)
        {
            string query = "insertFuncionario (FUNOME, FUNDATADEENTRADA, FUNCODIGODEPARTAMENTO) values (@FUNOME, @FUNDATADEENTRADA, @FUNCODIGODEPARTAMENTO)";

            var qtdInserida = conexao.Execute(query, pFuncionario);

        }
        public void updateFuncionario(Funcionario pFuncionario)
        {
            string query = "update Funcionario set FUNOME=@FUNOME, FUNDATADEENTRADA=@FUNDATADEENTRADA,FUNCODIGODEPARTAMENTO=@FUNCODIGODEPARTAMENTO where FUNID=@FUNID";

            int qtdAtualizada = conexao.Execute(query, pFuncionario);

        }

    }
}

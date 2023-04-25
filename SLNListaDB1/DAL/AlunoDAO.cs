using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class AlunoDAO
    {

        private SqlConnection conexao;

        public AlunoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<Aluno> getTodosAlunos()
        {
            string sql = "select * from Aluno";
            var dados1 = (List<Aluno>)conexao.Query<Aluno>(sql);
            return dados1;
        }
        public void insertAluno(Aluno pAluno)
        {
            string query = "insert Aluno(ALUNOME,ALUSOBRENOME) values (@ALUNOME, @ALUSOBRENOME)";

            int qtdInserida = conexao.Execute(query, pAluno);

        }
        public void updateAluno(Aluno pAluno)
        {
            string query = "update Aluno set ALUNOME=@ALUNOME, ALUSOBRENOME=@ALUSOBRENOME where ALUID=@ALUID";

            int qtdAtualizada = conexao.Execute(query, pAluno);

        }
        public void apagarAluno(Aluno paluno)
        {
            string query = "Delete sala where ALUID=@SALUID";

            int qtdAtualizada = conexao.Execute(query,paluno);

        }
    }
}

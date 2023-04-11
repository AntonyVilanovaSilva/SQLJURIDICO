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
            conexao = ResponsavelBD.getConexao();
        }

        public List<Responsavel> getTodosResponsavel()
        {
            string sql = "select * from Responsavel";
            var dados = (List<Responsavel>)conexao.Query<Responsavel>(sql);
            return dados;
        }
        public List<Aluno> getTodosAlunos()
        {
            string sql = "select * from Aluno";
            var dados1 = (List<Aluno>)conexao.Query<Aluno>(sql);
            return dados1;
        }
        public List<Curso> getTodosCursos()
        {
            string sql = "select * from Curso";
            var dados2 = (List<Curso>)conexao.Query<Curso>(sql);
            return dados2;
        }
        public List<Sala> getTodosSalas()
        {
            string sql = "select * from Sala";
            var dados3 = (List<Sala>)conexao.Query<Sala>(sql);
            return dados3;
        }
        public List<CategoriaRecurso> getTodosCategorias()
        {
            string sql = "select * from CategoriaRecurso";
            var dados4 = (List<CategoriaRecurso>)conexao.Query<CategoriaRecurso>(sql);
            return dados4;
        }
        public List<Recurso> getTodosRecursos()
        {
            string sql = "select * from Recurso";
            var dados5 = (List<Recurso>)conexao.Query<Recurso>(sql);
            return dados5;
        }
        public List<Departamento> getTodosDepartamentos()
        {
            string sql = "select * from Departamento";
            var dados6 = (List<Departamento>)conexao.Query<Departamento>(sql);
            return dados6;
        }
        public List<Serie> getTodosSerie()
        {
            string sql = "select * from Serie";
            var dados7 = (List<Serie>)conexao.Query<Serie>(sql);
            return dados7;
        }
        public List<NiveldeEnsino> getTodosNiveldeEnsino()
        {
            string sql = "select * from NiveldeEnsino";
            var dados7 = (List<NiveldeEnsino>)conexao.Query<NiveldeEnsino>(sql);
            return dados7;
        }
        public List<Funcionario> getTodosFuncionario()
        {
            string sql = "select * from Funcionario";
            var dados8 = (List<Funcionario>)conexao.Query<Funcionario>(sql);
            return dados8;
        }
    }
}

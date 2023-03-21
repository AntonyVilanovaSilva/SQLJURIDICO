using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class TipoPessoaDAO
    {
        private SqlConnection _conexao;
        public TipoPessoaDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<TipoPessoa> GetALlTipoPessoas()
        {
            string sql = "select * from TipoPessoa";

            var dados = (List<TipoPessoa>)_conexao.Query<TipoPessoa>(sql);
            return dados;
        }
        public TipoPessoa getTipoPessoa(string id)
        {
            string sql = "select * from TipoDePessoa where TIPID=" + id;
            var dados = (TipoPessoa)_conexao.QueryFirst<TipoPessoa>(sql);
            return dados;
        }

        
        public bool updateTipoPessoa(string id, TipoPessoa pTipoPessoa)
        {
            string sql = "Update TipoDePessoa set TIPDESCRICAO=@TIPDESCRICAO where TIPID=" + id;
            int qtd = _conexao.Execute(sql, pTipoPessoa);
            if (qtd >= 1)
            {
                return true;

            }
            return false;

        }
    }
}

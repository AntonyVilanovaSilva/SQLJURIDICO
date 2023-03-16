namespace AdvocaciaEstado.Models.DAL;
{
    public class EstadoDAO
    {
        private SqlConnection _conexao;

        public EstadoDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<Estado> getTodosEstados()
        {
            string sql = "select * from Estado";
            var dados = (List<Estado>)_conexao.Query<Estado>(sql);
            return dados;
        }
    }
}

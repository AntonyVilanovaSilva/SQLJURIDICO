namespace AdvocaciaCliente.Models
{
    public class TipoPessoa
    {
        public string TIPDESCRICAO { get; internal set; }
        public int TIPID { get; internal set; }

        public class TipoDePessoa
        {
            public int TIPID { get; set; }
            public string TIPDESCRICAO { get; set; }
        }
    }
}

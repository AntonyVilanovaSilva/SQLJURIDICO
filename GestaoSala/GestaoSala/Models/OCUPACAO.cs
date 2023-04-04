using System;

namespace GestaoSala.Models
{
    public class OCUPACAO
    {
       public int OCUID { get; set; }
        public int SALID { get; set; }
        public DateTime OCUDATA { get; set; }
        public DateTime OCUHORAINICIO { get; set; }
        public DateTime OCUHORAFIM { get; set; }

    }
}

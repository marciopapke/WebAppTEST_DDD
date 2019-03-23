using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_DDD.ApplicationCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {

        }

        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }
    }
}

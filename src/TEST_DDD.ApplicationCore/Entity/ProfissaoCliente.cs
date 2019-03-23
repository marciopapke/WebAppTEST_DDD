using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_DDD.ApplicationCore.Entity
{
    public class ProfissaoCliente
    {
        public ProfissaoCliente()
        {

        }
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }
    }
}

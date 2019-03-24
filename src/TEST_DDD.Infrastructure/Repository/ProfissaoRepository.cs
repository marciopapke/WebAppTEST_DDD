using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.ApplicationCore.Interfaces.Repository;
using TEST_DDD.Infrastructure.Data;

namespace TEST_DDD.Infrastructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
    {
        public ProfissaoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}

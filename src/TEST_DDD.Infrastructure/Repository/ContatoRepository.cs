using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.ApplicationCore.Interfaces.Repository;
using TEST_DDD.Infrastructure.Data;

namespace TEST_DDD.Infrastructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}

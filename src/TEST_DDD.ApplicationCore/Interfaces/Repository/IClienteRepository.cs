using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {

        Cliente ObterPorProfissao(int clienteId);

    }
}

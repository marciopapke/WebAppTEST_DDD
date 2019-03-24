using System.Linq;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.ApplicationCore.Interfaces.Repository;
using TEST_DDD.Infrastructure.Data;

namespace TEST_DDD.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public override Cliente Adicionar(Cliente entity)
        {
            //Implemento a regra específica sobreescrevendo o método com o poliformismo
            //Com a regra específica para 'Cliente'


            _dbContext.Set<Cliente>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteId)).FirstOrDefault();
        }
    }
}

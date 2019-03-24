using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.ApplicationCore.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterId(int Id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        void Remover(Cliente entity);
    }
}

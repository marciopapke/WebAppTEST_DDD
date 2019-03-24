using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.ApplicationCore.Interfaces.Services
{
    public interface IContatoService
    {
        Contato Adicionar(Contato entity);
        void Atualizar(Contato entity);
        IEnumerable<Contato> ObterTodos();
        Contato ObterId(int Id);
        IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado);
        void Remover(Contato entity);
    }
}

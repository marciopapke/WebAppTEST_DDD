using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.ApplicationCore.Interfaces.Repository;
using TEST_DDD.ApplicationCore.Interfaces.Services;

namespace TEST_DDD.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            //Adicionar regra de negócio ... se nao for atendida voce retorno null nao 
            //vai nem para _contatoRepository. a acao que voce precisa realizar. 

            return _contatoRepository.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Contato ObterId(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contato> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Contato entity)
        {
            throw new NotImplementedException();
        }
    }
}

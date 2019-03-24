using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.ApplicationCore.Interfaces.Repository;
using TEST_DDD.ApplicationCore.Interfaces.Services;

namespace TEST_DDD.ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            //Adicionar regra de negócio ... se nao for atendida voce retorno null nao 
            //vai nem para _clienteRepository. a acao que voce precisa realizar. 

            return _clienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            _clienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterId(int Id)
        {
            return _clienteRepository.ObterId(Id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}

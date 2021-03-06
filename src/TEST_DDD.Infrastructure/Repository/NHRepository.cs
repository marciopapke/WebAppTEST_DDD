﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TEST_DDD.ApplicationCore.Interfaces.Repository;

namespace TEST_DDD.Infrastructure.Repository
{
    public class NHRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Mostrando apenas o exemplo ... que independe da tecnologia ... EF ou Dapper ou NHibernate ... 
        //Basta apenas herdar de IRepository ... e implemntar os métodos da interface.

        public TEntity Adicionar(TEntity entity)
        {
            //Esse e os demais métodos você implementa com as caracteristicas do NHibernate 
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterId(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

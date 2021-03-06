﻿using Edux_API.Contexts;
using Edux_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Repositories
{
    public class BaseGeneric<T> : IBase<T> where T : class
    {
        public eduxContext _edux = new eduxContext();
        public virtual void Atualizar(T obj)
        {
           /* var objeto = BuscarPorId(id);
            objeto
            _edux.Entry(objeto).State = EntityState.Modified;
            
            _edux.SaveChanges();*/
        }

        public virtual T BuscarPorId(Guid id)
        {      
            return _edux.Set<T>().Find(id);
        }      
               
        public virtual List<T> BuscarTodos()
        {
            return _edux.Set<T>().AsNoTracking().ToList();
        }

        public virtual void Criar(T Objeto)
        {
            _edux.Set<T>().Add(Objeto);
            _edux.SaveChanges();
        }

        public virtual void Deletar(Guid id)
        {
            T objeto = BuscarPorId(id);
            _edux.Set<T>().Remove(objeto);
            _edux.SaveChanges();
        }
    }
}

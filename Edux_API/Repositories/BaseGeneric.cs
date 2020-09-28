using Edux_API.Contexts;
using Edux_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Repositories
{
    public class BaseGeneric<T> : IBase<T> where T : class
    {
        eduxContext _edux = new eduxContext();
        public void Atualizar(T objeto)
        {

            _edux.Set<T>().Update(objeto);
            _edux.SaveChanges();
        }

        public T BuscarPorId(Guid id)
        {
            return _edux.Set<T>().Find(id);
        }

        public List<T> BuscarTodos()
        {
            return _edux.Set<T>().ToList();
        }

        public void Criar(T Objeto)
        {
            _edux.Set<T>().Add(Objeto);
            _edux.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            T objeto = BuscarPorId(id);
            _edux.Set<T>().Remove(objeto);
            _edux.SaveChanges();
        }
    }
}

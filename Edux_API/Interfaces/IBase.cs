using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Interfaces
{
    interface IBase<T> where T: class
    {
        T BuscarPorId(Guid id);
        List<T> BuscarTodos();
    }
}

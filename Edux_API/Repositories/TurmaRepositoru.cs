using Edux_API.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Repositories
{
    public class TurmaRepositoru:BaseGeneric<Turma>
    {
        public override List<Turma> BuscarTodos()
        {
            return _edux.Turma.Include(e => e.IdCursoNavigation).ToList();
        }
    }
}

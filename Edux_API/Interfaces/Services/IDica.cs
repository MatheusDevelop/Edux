using Edux_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Interfaces.Services
{
    public interface IDica
    {
        List<Dica> LerDica();
        void AdicionarDica(Dica dica);
        void RemoverDica(Guid id);
        Dica SearchDicaForId(Guid id);
        void AtualizarDica(Dica dica);
    }
}

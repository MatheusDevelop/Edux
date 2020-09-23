using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class Curtida
    {
        public Guid? IdUsuario { get; set; }
        public Guid? IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

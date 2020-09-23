using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class Dica
    {
        public Guid IdDica { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        public Guid? IdUsuario { get; set; }


        public Dica()
        {
            IdDica = Guid.NewGuid();
        }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

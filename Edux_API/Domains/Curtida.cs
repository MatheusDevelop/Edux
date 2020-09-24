using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edux_API.Domains
{
    public partial class Curtida
    {
        public Guid? IdUsuario { get; set; }        
        public Guid? IdCurtida { get; set; }
        public Guid? IdDica { get; set; }

        public Curtida()
        {
            IdCurtida = Guid.NewGuid();
        }


        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

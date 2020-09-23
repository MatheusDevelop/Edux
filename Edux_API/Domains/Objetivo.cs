using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class Objetivo
    {
        public Objetivo()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
            IdObjetivo = Guid.NewGuid();
        }

        public Guid IdObjetivo { get; set; }
        public string Tipo { get; set; }
        public Guid? IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<ObjetivoAluno> ObjetivoAluno { get; set; }
    }
}

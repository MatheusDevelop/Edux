﻿using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class Curso
    {
        public Curso()
        {
            Turma = new HashSet<Turma>();
            IdCurso = Guid.NewGuid();
        }

        public Guid IdCurso { get; set; }
        public string Titulo { get; set; }
        public Guid? IdInstituicao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}

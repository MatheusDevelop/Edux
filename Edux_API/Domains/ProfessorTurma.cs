﻿using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class ProfessorTurma
    {
        public Guid IdProfessorTurma { get; set; }
        public string Descricao { get; set; }
        public Guid? IdUsuario { get; set; }
        public Guid? IdTurma { get; set; }
        public ProfessorTurma()
        {
            IdProfessorTurma = Guid.NewGuid();
        }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

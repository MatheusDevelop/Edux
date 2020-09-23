﻿using System;
using System.Collections.Generic;

namespace Edux_API.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            AlunoTurma = new HashSet<AlunoTurma>();
            Dica = new HashSet<Dica>();
            ProfessorTurma = new HashSet<ProfessorTurma>();
            IdUsuario = Guid.NewGuid();
        }

        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public Guid? IdPerfil { get; set; }

        public virtual Perfil IdPerfilNavigation { get; set; }
        public virtual ICollection<AlunoTurma> AlunoTurma { get; set; }
        public virtual ICollection<Dica> Dica { get; set; }
        public virtual ICollection<ProfessorTurma> ProfessorTurma { get; set; }
    }
}

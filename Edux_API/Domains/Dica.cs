using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Edux_API.Domains
{
    public partial class Dica
    {
        public Guid IdDica { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        public Guid? IdUsuario { get; set; }

        //TODO: Enviar uma imagem do front para testar
        [NotMapped]
        [JsonIgnore]
        public IFormFile ImageForUpload{ get; set; }


        public Dica()
        {
            IdDica = Guid.NewGuid();
        }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

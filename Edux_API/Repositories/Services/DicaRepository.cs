using Edux_API.Contexts;
using Edux_API.Domains;
using Edux_API.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Repositories.Services
{
    public class DicaRepository : IDica
    {
        eduxContext _edux = new eduxContext();

        public void AdicionarDica(Dica dica)
        {
            var image = dica.ImageForUpload;

            using var ms = new MemoryStream();
                image.CopyTo(ms);
                var imgBytes = ms.ToArray();


            dica.Imagem = Convert.ToBase64String(imgBytes);

            _edux.Dica.Add(dica);
            _edux.SaveChanges();




        }

        public void AtualizarDica(Dica dica)
        {
            if(dica.ImageForUpload != null)
            {
                var image = dica.ImageForUpload;

                using var ms = new MemoryStream();
                    image.CopyTo(ms);
                    var imgBytes = ms.ToArray();

                dica.Imagem = Convert.ToBase64String(imgBytes);
            }

            _edux.Dica.Update(dica);
            _edux.SaveChanges();
        }

        public List<Dica> LerDica()
        {
            return _edux.Dica.ToList();
        }

        public void RemoverDica(Guid id)
        {
            var obj = SearchDicaForId(id);
            _edux.Dica.Remove(obj);
            _edux.SaveChanges();
        }

        public Dica SearchDicaForId(Guid id)
        {
            return _edux.Dica.FirstOrDefault(e => e.IdDica == id);
        }
    }
}

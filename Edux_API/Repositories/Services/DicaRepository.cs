using Edux_API.Contexts;
using Edux_API.Domains;
using Edux_API.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Repositories.Services
{
    public class DicaRepository : BaseGeneric<Dica>
    {

        public override void Criar(Dica Objeto)
        {
            var imageFile = Objeto.ImageForUpload;

            Objeto.Imagem = convertFileToStringForDatabase(imageFile);

            _edux.Dica.Add(Objeto);




        }



        private string convertFileToStringForDatabase(IFormFile image)
        {
            byte[] arrayOfBytes = convertFileToArrayOfBytes(image);
            string imageConvertedForString = convertArrayOfBytesToString(arrayOfBytes);

            return imageConvertedForString;


        }

        private byte[] convertFileToArrayOfBytes(IFormFile file)
        {
            byte[] arr = null;

            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                arr = ms.ToArray();
                
            }


            return arr;

        }

        private string convertArrayOfBytesToString(byte[] array)
        {
            string str = Convert.ToBase64String(array);
            return str;
        }








    }
}

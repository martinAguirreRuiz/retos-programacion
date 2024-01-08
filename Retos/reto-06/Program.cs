using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
namespace reto_06
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
            * Crea un programa que se encargue de calcular el aspect ratio de una
            * imagen a partir de una url.
            * - Url de ejemplo:
            *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
            * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
            *   imagen de 1920*1080px.
            */

            string imageUrl = "https://raw.githubusercontent.com/mouredev/mouredev/master/mouredev_github_profile.png";

            using (var httpClient = new HttpClient())
            {
                byte[] imageBytes = await httpClient.GetByteArrayAsync(imageUrl);

                using (Image image = Image.Load(imageBytes))
                {

                }
            }



        }
    }
}

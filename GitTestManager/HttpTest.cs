using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace GitTestManager
{
    public class HttpTest
    {

        public static async void checkHttpRequest()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.Credentials = new NetworkCredential("latacita", "Hascom14&17");

            HttpClient client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://api.github.com");

            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters["name"] = "MyFirstAutomaticRepo";


            try {

                HttpContent content = new FormUrlEncodedContent(parameters);
                Console.Out.WriteLine("Ejecutando la petición");
                HttpResponseMessage response = await client.PostAsync("/user/repos", content);
                Console.Out.WriteLine("Petición realizada");
                Console.Out.WriteLine("Respuesta " + response.ToString());
            }
            catch (HttpRequestException exc)
            {
                Console.Out.WriteLine(exc.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PetAsService.Classes
{
    public class BuscaJson
    {
        public static string GetJson()
        {
            var request = WebRequest.Create("https://api.thecatapi.com/v1/breeds");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if(response.StatusCode == HttpStatusCode.OK)
            {
                using(var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json.ToString();
                }
            }
            return null;
        }
    }
}

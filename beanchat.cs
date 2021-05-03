using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class beanchat
    {


        public static void send(string sendString)
        {

            var url1 = "https://api.isaacthoman.me/api/App?message=" + sendString;

            var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest1.Method = "POST";
            httpRequest1.ContentType = "text/plain";
            httpRequest1.Headers["Content-Length"] = "0";
            var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();



            using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
            {
                var result = streamReader1.ReadToEnd();
                string myresult = result;
                return;
            }



        }

        public static string recieve()
        {

            var url = "https://api.isaacthoman.me/api/App";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();



            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result.Trim('"');
            }


        }

    }
}

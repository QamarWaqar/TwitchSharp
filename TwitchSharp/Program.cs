using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TwitchSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how I registered my App with the User //
            /*
            System.Net.WebClient wC = new WebClient();
            wC.Headers.Add("Accept: application/vnd.twitchtv.v2+json");
            string str = wC.DownloadString("https://api.twitch.tv/kraken/users/cloakers");
            Console.WriteLine(str);
             */

            // THIS IS ANOTHER WAY OF DOING STUFF //
            //string str = wC.UploadString("https://api.twitch.tv/kraken/oauth2/token", "POST", "client_id%3Dni4koap98lo2roja33mcpxyt2ovsmx6%20%26client_secret%3Di9kk9gw915txoyq8jispebsvnnsaf9b%20%26grant_type%3Dauthorization_code%20%26redirect_uri%3Dhttp%3A%2F%2Frockyb.ddns.net%2Ftesting.html%20%26code%3Dqai9v99krp8dggnvg1uk6zdksp7p1jx");

            System.Net.WebClient wC = new WebClient();
            wC.Headers.Add("Accept: application/vnd.twitchtv.v2+json");
            wC.Headers.Add("Authorization: OAuth 5jtfs23dfuc18sbjfwt720qqg25xhm7");
            string str = wC.DownloadString("https://api.twitch.tv/kraken/user");
            Console.WriteLine(str);
        }
    }
}

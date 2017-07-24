using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net.Http;

using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Xml;

namespace Ballgame
{
    internal class Sync
    {
        public Games SyncGames(DateTime date)
        {
            string xml = "";

                xml = GetXML(GetAPIString(date) + "miniscoreboard.xml");
            
                XmlSerializer serializer = new XmlSerializer(typeof(Games));

                return (Games)serializer.Deserialize(new StringReader(xml));
            
        }

        internal LinescoreGame GetLineScore(string gameDir)
        {
            string xml = "";

                xml = GetXML(GetAPIString() + gameDir + "/linescore.xml");



                XmlSerializer serializer = new XmlSerializer(typeof(LinescoreGame));
                return (LinescoreGame)serializer.Deserialize(new StringReader(xml));

        }

        public Boxscore SyncBoxscore(string gameDir)
        {
            string xml = "";

                xml = GetXML(GetAPIString() + gameDir + "/boxscore.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(Boxscore));
                return (Boxscore)serializer.Deserialize(new StringReader(xml));
            
        }

        public GameCenterGame SyncGameCenterGame(string gameDir)
        {
                string xml = "";

                xml = GetXML(GetAPIString() + gameDir + "/gamecenter.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(GameCenterGame));
                return (GameCenterGame)serializer.Deserialize(new StringReader(xml));
        }
/* 
        public GameEventLog SyncEventLog(string gameDir)
        {
            string xml = "";

                xml = GetXML(GetAPIString() + gameDir + "/eventLog.xml");


                XmlSerializer serializer = new XmlSerializer(typeof(GameEventLog));
                return (GameEventLog)serializer.Deserialize(new StringReader(xml));
            
        }
*/

        public string GetAPIString([Optional] DateTime date)
        {
            string root = @"http://gd2.mlb.com";
            string components = "/components/game/mlb";
            if (date==DateTime.MinValue) return root;
            root += components;

            string year = "year_" + date.Year;
            string month = "month_" + date.ToString("MM");
            string day = "day_" + date.ToString("dd");
     
            return root + "/" + year + "/" + month + "/" + day + "/";
        }

        private static string GetXML(string page)
        {
            try{                
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(page).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent responseContent = response.Content; 
                        string responseString = responseContent.ReadAsStringAsync().Result;

                        return responseString;
                    }
                }
                return "";
            }
            catch(Exception e){
                Console.WriteLine("Network Error: "+e.Message);
                return "";
            }

        }
    }
}

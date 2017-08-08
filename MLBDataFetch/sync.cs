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
            string xml = GetXML(GetAPIString(date) + "miniscoreboard.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Games));
            try{
                return (Games)serializer.Deserialize(new StringReader(xml));  
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return new Games();
            }
             
        }

        internal LinescoreGame SyncLineScore(string gameDir)
        {
            string xml = GetXML(GetAPIString() + gameDir + "/linescore.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(LinescoreGame)); 
            try{
                return (LinescoreGame)serializer.Deserialize(new StringReader(xml));
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return new LinescoreGame();
            }
        }

        public Boxscore SyncBoxscore(string gameDir)
        {
            string xml = GetXML(GetAPIString() + gameDir + "/boxscore.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Boxscore));
            try{
               return (Boxscore)serializer.Deserialize(new StringReader(xml)); 
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return new Boxscore();
            }
        }

        public GameCenterGame SyncGameCenterGame(string gameDir)
        {
                string xml = GetXML(GetAPIString() + gameDir + "/gamecenter.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(GameCenterGame));
                try{
                    return (GameCenterGame)serializer.Deserialize(new StringReader(xml));
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);
                    return new GameCenterGame();
                }
        }

        public GameEvents SyncGameEvents(string gameDir)
        {
                string xml = GetXML(GetAPIString() + gameDir + "/game_events.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(GameEvents));
                try{
                    return (GameEvents)serializer.Deserialize(new StringReader(xml));
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);
                    return new GameEvents();
                }
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
            string responseString="";
            try{                
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(page).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent responseContent = response.Content; 
                        responseString = responseContent.ReadAsStringAsync().Result;
                    }
                    return responseString;
                }
            }
            catch(Exception e){
                Console.WriteLine("Network Error: "+e.Message);
                return responseString;
            }
        }
    }
}

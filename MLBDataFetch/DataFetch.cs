using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ballgame
{
    public class DataFetch
    {
        private Sync sync = new Sync();

        public DataFetch()
        {
            
        }

        public List<Game> GetGames(DateTime date)
        {
            return sync.SyncGames(date).Game;
        }

        public Boxscore GetBoxscore(string gameDir)
        {
            return sync.SyncBoxscore(gameDir);
        }

        public LinescoreGame GetLinescore(string gameDir)
        {
            return sync.SyncLineScore(gameDir);
        }

        public GameCenterGame GetGameCenterGame(string gameDir)
        {
            return sync.SyncGameCenterGame(gameDir);
        }
        
        public GameEvents GetGameEvents(string gameDir)
        {
            return sync.SyncGameEvents(gameDir);
        }
        
        //public List<Event> GetEvents(string gameDir)
        //{
        //    eventLog = sync.SyncEventLog(gameDir);
        //    List<Event> events = new List<Event>();
        //    foreach(Team t in eventLog.Team)
        //    {
        //        foreach(Event e in t.Events)
        //        {
        //            events.Add(e);
        //        }
        //    }
        //    return events.OrderBy(o => Int32.Parse(o.Number)).ToList(); 
        //}
     }
}
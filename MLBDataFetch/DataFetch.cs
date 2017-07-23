using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ballgame
{
    public class DataFetch
    {
        private Games games = new Games();
        private Boxscore boxscore = new Boxscore();
        private LinescoreGame linescore = new LinescoreGame();
        //private GameEventLog eventLog = new GameEventLog();
        private Sync sync = new Sync();

        public DataFetch()
        {
            //games = sync.SyncGames();
        }

        public List<Game> GetGames(DateTime date)
        {
            games = sync.SyncGames(date);
            return games.Game;
        }

        public Boxscore GetBoxscore(string gameDir)
        {
            return sync.SyncBoxscore(gameDir);
        }

        public LinescoreGame GetLinescore(string gameDir)
        {
            return sync.GetLineScore(gameDir);
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
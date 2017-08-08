using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Timer;

namespace Ballgame
{
    public static class Display
    {
        private static int consoleWidth = 120;

        public static void DisplayGames(List<Game> games, DateTime date)
        {
            Console.Clear();
            if (date == DateTime.Today) { Console.WriteLine("Todays Games:"); }
            else { Console.WriteLine("Games of " + date.Date.ToString("MM/dd/yyyy")); }
            int count = 1;
            string str = "";
            int itemCount = 0;
            int columns = 0;
            int lineNo = 1;
            int lineMax = 0;
            foreach (Game g in games)
            {

                Console.SetCursorPosition(columns, lineNo);
                string status = g.Status;
                if (status == "In Progress") { status = (g.Top_inning=="Y" ? "Top":"Btm") + " " +g.Inning; }
                if (status == "Preview") { status = g.Home_time+g.Home_time_zone; }
                
                str = string.Format(@"[{0}]════════════════════╗", count.ToString().PadLeft(2));
                Console.SetCursorPosition(columns, lineNo);
                Console.Write(str);
                lineNo++;
                str = string.Format(@"  ║ {0}R | H | E  ║", (status).PadRight(9));
                Console.SetCursorPosition(columns, lineNo);
                Console.Write(str);
                lineNo++;
                str = string.Format(@"  ║ {0}:     {1}| {2}| {3} ║", g.Away_name_abbrev.PadRight(3), (g.Away_team_runs ?? " ").PadRight(2), (g.Away_team_hits ?? " ").PadRight(2), (g.Away_team_errors ?? " ").PadRight(2));
                Console.SetCursorPosition(columns, lineNo);
                Console.Write(str);
                lineNo++;
                str = string.Format(@"  ║ {0}:     {1}| {2}| {3} ║", g.Home_name_abbrev.PadRight(3), (g.Home_team_runs ?? " ").PadRight(2), (g.Home_team_hits ?? " ").PadRight(2), (g.Home_team_errors ?? " ").PadRight(2));
                Console.SetCursorPosition(columns, lineNo);
                Console.Write(str);
                lineNo++;
                str = @"  ╚═════════════════════╝";
                Console.SetCursorPosition(columns, lineNo);
                Console.Write(str);
                lineNo++;

                count++;
                itemCount++;
                lineNo++;
                if (itemCount == 4) { columns += 30; lineMax = lineNo; lineNo = 1; itemCount = 0; }
            }
            Console.SetCursorPosition(0, lineMax + 1);
            Console.Write("(p)rev (n)ext (#)>");
        }

        public static void DisplayGameData(Object stateInfo, Game game, LinescoreGame line_score, Boxscore boxscore, GameEvents events, GameCenterGame gcg)
        {
            string outStr = "";
            if (line_score.Status == "Final" || line_score.Status == "Game Over")
            {   
                Console.Clear();
                Display.DisplayFinal(game, boxscore, line_score, gcg);
            }
            else if (line_score.Status == "Pre-Game" || line_score.Status == "Preview")
            {
                DisplayLinescore(line_score);
                outStr = string.Format("Game Starts at {0}", line_score.Time + line_score.Time_zone);
                ConsoleLineFill(outStr, consoleWidth);
            }
            else
            {
                DisplayLinescore(line_score);
                outStr = line_score.Inning_state + " " + line_score.Inning;
                ConsoleLineFill(outStr, consoleWidth);
                DisplayStatus(line_score,events);
            }
            GC.Collect();
        }

        private static void DisplayLinescore(LinescoreGame line_score)
        {

            Console.SetCursorPosition(0, 0);

            LinescoreGame linescore = new LinescoreGame();
            linescore = line_score;
            DisplayHeader(linescore);
            ConsoleLineFill("", consoleWidth);


            string header = "   |";
            string awayLine = linescore.Away_name_abbrev.PadLeft(3) + "|";
            string homeLine = linescore.Home_name_abbrev.PadLeft(3) + "|";

            if (linescore.Linescore.Count < 9)
            {
                for (int i = linescore.Linescore.Count; i < 9; i++)
                {
                    linescore.Linescore.Add(new LinescoreInning() { Inning = (i + 1).ToString() });
                }
            }


            foreach (LinescoreInning i in linescore.Linescore)
            {
                header += " " + i.Inning.PadLeft(2) + "|";
                awayLine += " " + (i.Away_inning_runs ?? " ").PadLeft(2) + "|";
                homeLine += " " + (i.Home_inning_runs ?? " ").PadLeft(2) + "|";
            }
            header += "   R |  H | E ";
            awayLine += "   " + (linescore.Away_team_runs ?? " ").PadLeft(2) + "| " + (linescore.Away_team_hits ?? " ").PadLeft(2) + " |" + (linescore.Away_team_errors ?? " ").PadLeft(2);
            homeLine += "   " + (linescore.Home_team_runs ?? " ").PadLeft(2) + "| " + (linescore.Home_team_hits ?? " ").PadLeft(2) + " |" + (linescore.Home_team_errors ?? " ").PadLeft(2);
            ConsoleLineFill(header, consoleWidth);
            ConsoleLineFill(awayLine, consoleWidth);
            ConsoleLineFill(homeLine, consoleWidth);
            Console.WriteLine();
        }

        public static void DisplayFinal(Game game, Boxscore boxscore, LinescoreGame l, GameCenterGame gcg)
        {
            DisplayLinescore(l);
            string str= "";

            foreach(string s in Boxify(gcg.Recaps.Mlb.Headline,WordWrap(gcg.Recaps.Mlb.Blurb, 60),1,120,120)){Console.WriteLine(s);} 

            ConsoleLineFill("", consoleWidth);
            string[] info = {string.Format("{0} is now {1}-{2} and are {3} games back", l.Home_team_city, l.Home_win, l.Home_loss, l.Home_games_back),
                            string.Format("{0} is now {1}-{2} and are {3} games back", l.Away_team_city, l.Away_win, l.Away_loss, l.Away_games_back)};
            foreach(string s in Boxify("",info,1,120,120)){Console.WriteLine(s);};
            ConsoleLineFill(str, consoleWidth);

            //Batting
            foreach(var bTeam in boxscore.Batting)
            {
                str = string.Format("┌{0}────────────────────────────────────────────────┐",bTeam.Team_flag.ToUpper()+" Batting");
                Console.WriteLine(str);
                str = string.Format("│                    AB  H  R  RBI  BB  SO  .AVG  .OBP  .SLG │");
                Console.WriteLine(str);
                foreach(var b in bTeam.Batter){
                    str=string.Format("│ {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} │", b.Name_display_first_last.PadRight(18), 
                    b.Ab.PadLeft(2), 
                    b.H.PadLeft(2),
                    b.R.PadLeft(2),
                    b.Rbi.PadLeft(3),
                    b.Bb.PadLeft(3),
                    b.So.PadLeft(3),
                    b.Avg.PadLeft(6),
                    b.Obp.PadLeft(5),
                    b.Slg.PadLeft(5));
                    ConsoleLineFill(str,consoleWidth);
                }
                str = string.Format("│ {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} │","TOTALS".PadRight(18), 
                    bTeam.Ab.PadLeft(2), 
                    bTeam.H.PadLeft(2),
                    bTeam.R.PadLeft(2),
                    bTeam.Rbi.PadLeft(3),
                    bTeam.Bb.PadLeft(3),
                    bTeam.So.PadLeft(3),
                    bTeam.Avg.PadLeft(6),
                    bTeam.Obp.PadLeft(5),
                    bTeam.Slg.PadLeft(5)
                );
                Console.WriteLine(str);
                str = "└────────────────────────────────────────────────────────────┘";
                Console.WriteLine(str);
            }
            
            //Pitching
            foreach(var pTeam in boxscore.Pitching)
            {
                str=string.Format("┌{0}───────────────────────────────────────────────┐",pTeam.Team_flag.ToUpper() + " Pitching");
                Console.WriteLine(str);
                str = "│                             IP  H  R  ER  BB  SO  HR   ERA │";
                Console.WriteLine(str);
                foreach(var p in pTeam.Pitcher)
                {
                    str = string.Format("│ {0} {1} {2} {3} {4} {5} {6} {7} {8} │",
                    (p.Name_display_first_last+" "+p.Note).PadRight(26),
                    GetInnings(p.Out).PadLeft(3),
                    p.H.PadLeft(2),
                    p.R.PadLeft(2),
                    p.Er.PadLeft(3),
                    p.Bb.PadLeft(3),
                    p.So.PadLeft(3),
                    p.Hr.PadLeft(3),
                    p.Era.PadLeft(5)
                    );
                    Console.WriteLine(str);
                }
                str = string.Format("│ {0} {1} {2} {3} {4} {5} {6} {7} {8} │",
                                    "TOTALS".PadRight(26),
                    GetInnings(pTeam.Out).PadLeft(3),
                    pTeam.H.PadLeft(2),
                    pTeam.R.PadLeft(2),
                    pTeam.Er.PadLeft(3),
                    pTeam.Bb.PadLeft(3),
                    pTeam.So.PadLeft(3),
                    pTeam.Hr.PadLeft(3),
                    pTeam.Era.PadLeft(5)
                );
                Console.WriteLine(str);
                str= "└────────────────────────────────────────────────────────────┘";
                Console.WriteLine(str);
            } 

            
            Console.SetWindowPosition(0,0);
        }

        public static void DisplayStatus(LinescoreGame linescore,GameEvents events)
        {
            string outStr = "";
            string pitch,pitchSpeed,lastPlay ="";
            int eventInning = (events.Inning.Count == linescore.Inning.Count() ? linescore.Inning.Count()-1 : events.Inning.Count-1);
            if(linescore.Inning_state=="Top")
            {
                //try{
                pitch = events.Inning[eventInning]?.Top.Atbat.LastOrDefault()?.Pitch?.LastOrDefault()?.Pitch_type ?? "";
                pitchSpeed = events.Inning[eventInning]?.Top.Atbat.LastOrDefault()?.Pitch?.LastOrDefault()?.Start_speed ?? "";
                lastPlay = events.Inning[eventInning]?.Top.Atbat.LastOrDefault()?.Des ?? "";//}
                //catch{};
            }
            else{
                //try{
                pitch = events.Inning[eventInning]?.Bottom.Atbat.LastOrDefault()?.Pitch?.LastOrDefault()?.Pitch_type ?? "";
                pitchSpeed = events.Inning[eventInning]?.Bottom.Atbat.LastOrDefault()?.Pitch?.LastOrDefault()?.Start_speed ?? "";
                lastPlay = events.Inning[eventInning]?.Bottom.Atbat.LastOrDefault()?.Des ?? "";//}
                //catch{};
            }
            
            outStr = string.Format(@"            [{0}]           Batting: {1} ({2})", (linescore.Runner_on_2b ?? "").Length > 0 ? "*" : " ",
                     linescore.Current_batter.First_name + " " + linescore.Current_batter.Last_name, linescore.Current_batter.Avg);
            ConsoleLineFill(outStr, consoleWidth);
            outStr = string.Format(@"           /   \          Count: {0} - {1}", linescore.Balls, linescore.Strikes);
            ConsoleLineFill(outStr, consoleWidth);
            outStr = string.Format(@"        /         \       Outs: {0}", linescore.Outs);
            ConsoleLineFill(outStr, consoleWidth);
            outStr = string.Format(@"      [{0}]         [{1}]     On Deck: {2}", (linescore.Runner_on_3b ?? "").Length > 0 ? "*" : " ", (linescore.Runner_on_1b ?? "").Length > 0 ? "*" : " ",
                     linescore.Current_ondeck.First_name + " " + linescore.Current_ondeck.Last_name);
            ConsoleLineFill(outStr, consoleWidth);
            outStr = string.Format(@"        \         /");
            ConsoleLineFill(outStr, consoleWidth);
            outStr = string.Format(@"          \     /	  Pitching: {0} ({1} ERA)", linescore.Current_pitcher.First_name + " " + linescore.Current_pitcher.Last_name, linescore.Current_pitcher.Era);
            ConsoleLineFill(outStr, consoleWidth - 13);
            outStr = string.Format(@"            [ ]           Last Pitch: {0} {1}mph", pitch,pitchSpeed );
            ConsoleLineFill(outStr, consoleWidth);

            ConsoleLineFill("", consoleWidth);
            foreach(string s in Boxify("Last Play",WordWrap(lastPlay,60),1,100,100)){ConsoleLineFill(s,consoleWidth);}
            ConsoleLineFill("", consoleWidth);
            ConsoleLineFill("", consoleWidth);
            ConsoleLineFill("", consoleWidth);

            /* 
            ConsoleLineFill("", consoleWidth);
            outStr = "Last play:";
            ConsoleLineFill(outStr, consoleWidth);

            outStr = linescore.Pbp_last;
            ConsoleLineFill(outStr, consoleWidth);
            ConsoleLineFill("", consoleWidth);*/

            outStr = "Last Update: " + DateTime.Now.ToString();
            ConsoleLineFill(outStr, consoleWidth);
        }

        public static void DisplayPreview(LinescoreGame linescore, GameCenterGame gcg)
        {
            DisplayHeader(linescore);
            Console.WriteLine();
            foreach(string s in Boxify((gcg.Previews.Mlb.Headline ?? "".ToUpper()), WordWrap(gcg.Previews.Mlb.Blurb,100),1,120,100)){Console.WriteLine(s);}

            Console.WriteLine();
            foreach(string s in Boxify(linescore.Home_team_name,WordWrap(gcg.Probables.Home.Report,100),1,120,100)){Console.WriteLine(s);}

            Console.WriteLine();
            foreach(string s in Boxify(linescore.Away_team_name,WordWrap(gcg.Probables.Away.Report,100),1,120,100)){Console.WriteLine(s);}
        }
        public static void DisplayHeader(LinescoreGame linescore)
        {
            FigletFont font = FigletFont.Load(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "/fonts/CalvinS.flf");
            Figlet figlet = new Figlet(font);

            string header = "";

            header = string.Format("{0}  @  {1}", linescore.Away_team_name, linescore.Home_team_name);
            Console.WriteLine(figlet.ToAscii(header));
        
            Console.WriteLine(linescore.Venue+", "+linescore.Location+": "+linescore.Time+linescore.Time_zone);
            if(linescore.Status =="Final"){Console.WriteLine("FINAL");};

        }

        public static void DisplaySplash()
        {
            Console.Clear();
            string str = @"                    
                                         .-----------------.                
                                      .------------------------.            
                                  .-------------------------------.         
                                .-----------------------------------.       
                              .--------------------------------------.            
                            .-------------------------------------------.   
                           .----------------------------------------------. 
                          .-------------╔═════════════════════╗-------------.   
                          .-------------║                     ║-------------.    
                           `------------║      BALLGAME!      ║------------.       
                             `.---------║                     ║----------. 
                               `.-------║                     ║--------.     
                                 `.-----║     v0.1.072817     ║------.      Another fine bit of software by 
                                   `.---╚═════════════════════╝ ---.        Matt Smith, a competent C#
                                     `.---                    --.'          developer available for hire. 
                                       `.--                 --.'             
                                          .--             --.`              matt@mattsmithcodesmith.com 
                                           .-           -.`               
                                             .-.......-.`                  
                                              .:::::::.                     
                                              .:::::::.                     
                                               .-----.";
            Console.WriteLine(str);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

        }

        public static string[] Boxify(string title, string[] lines, int border, int maxWidth, int maxHeight)
        {

            string topLeft = (border==1) ? "┌":"╔";
            string topRight = (border==1) ? "┐":"╗";
            string horizontal = (border==1) ? "─":"═";
            string vertical = (border==1) ? "│":"║";
            string botLeft = (border==1) ? "└":"╚";
            string botRight = (border==1) ? "┘":"╝";
            
            var sorted = lines.OrderBy(n => n.Length);
            int longestLine = sorted.LastOrDefault().Length+2;
            if (longestLine+4 > maxWidth) longestLine = maxWidth-4;
            int numLines = lines.Count();
            if (numLines+2 > maxHeight) numLines = maxHeight-2;

            string[] str= new string[numLines+2];

            string tempStr="";
            
            tempStr = topLeft+title;
            for(int i =0;i<=longestLine-title.Length;i++){tempStr+=horizontal;}
            tempStr+=topRight;
            str[0]=tempStr;

            
            for(int j=0;j < numLines;j++)
            {   
                tempStr=vertical;
                lines[j] = lines[j].PadLeft(lines[j].Length+1);
                for(int i=0;i<lines[j].Length;i++){tempStr+=lines[j][i];}
                tempStr=tempStr.PadRight(longestLine+2);
                tempStr+=vertical;
                str[j+1]=tempStr;
            }
            
            tempStr = botLeft;
            for(int i =0;i<=longestLine;i++){tempStr+=horizontal;}
            tempStr+=botRight;
            int k = str.Count()-1;
            str[k]=tempStr;

            return str;

        }
        
        public static void ConsoleLineFill(string str, int windowWidth)
        {
            string emptySpace = "";
            str = str ?? "";
            for (int i = 0; i < (windowWidth - str.Length) - 2; i++)
            {
                emptySpace += " ";
            }
            str = str + emptySpace;
            int j = str.Length;
            Console.WriteLine(str);
        }

        public static string[] WordWrap(string line, int maxLength)
        {
            List<string> lines = new List<string>();
            Queue<string> words = new Queue<string>(line.Split(' '));
            
            string tempStr="";

            while(words.Count>0)
            {   
                if(tempStr.Length+words.Peek().Length < maxLength){
                    tempStr += words.Dequeue()+" ";
                }
                else{
                    lines.Add(tempStr);
                    tempStr="";
                }
                
            }
            lines.Add(tempStr);
            return lines.ToArray();
        }

        public static string GetInnings(string outs)
        {
            string str=Math.Round((double.Parse(outs)/3.0), 1).ToString(); 
            if(str.Last()=='7'){str=str.Remove(str.Length -1, 1) + "2";}
            if(str.Last()=='3'){str=str.Remove(str.Length -1, 1) + "1";}
            return str;
        }

    }
}

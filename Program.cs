using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace Ballgame
{
class Program
    {
        private static DataFetch df = new DataFetch();
        private static Timer timer;
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WindowWidth=120;
            Display.DisplaySplash();

            Game game = new Game();
            List<Game> games = new List<Game>();
            games=df.GetGames(DateTime.Today);

            Display.DisplayGames(games,DateTime.Today);

            DateTime selectedDate = DateTime.Today;
            string i = Console.ReadLine();
            while (i != "q")
            {
                
                switch (i)
                {
                    case "p":
                        {
                            selectedDate = selectedDate.AddDays(-1);
                            games = df.GetGames(selectedDate);
                            Display.DisplayGames(games, selectedDate);
                            i = Console.ReadLine();
                            break;
                        }
                    case "n":
                        {
                                selectedDate = selectedDate.AddDays(1);
                                games = df.GetGames(selectedDate);
                                Display.DisplayGames(games,selectedDate);
                                i = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            int selection;
                            if (Int32.TryParse(i,out selection)) {
                                game = df.GetGames(selectedDate)[selection - 1];
                                Console.Clear();
                                if (selectedDate==DateTime.Today && game.Status !="Final" && game.Status !="Preview")
                                {
                                    DisplayAudioMenu(game); 
                                    var autoEvent = new AutoResetEvent(false);
                                    timer = new Timer(x =>Display.DisplayGameData(x,game, df.GetLinescore(game.Game_data_directory),
                                                                                                df.GetBoxscore(game.Game_data_directory),
                                                                                                df.GetGameEvents(game.Game_data_directory),
                                                                                                df.GetGameCenterGame(game.Game_data_directory)),autoEvent,0,30000);
                                 GC.KeepAlive(timer);
                                }
                                else if (game.Status=="Final")
                                {
                                    Display.DisplayFinal(game, df.GetBoxscore(game.Game_data_directory), df.GetLinescore(game.Game_data_directory),df.GetGameCenterGame(game.Game_data_directory));
                                }
                                else if(game.Status=="Preview")
                                {
                                    Display.DisplayPreview(df.GetLinescore(game.Game_data_directory),df.GetGameCenterGame(game.Game_data_directory));
                                }
                                    

                                i = Console.ReadLine();
                            }
                            else {
                                games = df.GetGames(selectedDate);
                                Display.DisplayGames(games,selectedDate);
                                System.Console.WriteLine("Invalid Selection"+Environment.NewLine+">");
                                i = Console.ReadLine();
                            }
                            
                            break;
                        }
                }
            }
        }

        private static void DisplayAudioMenu(Game game)
        {
            string environment = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            if(environment.Contains("Microsoft")){
                environment="Windows";
            }
            else if(environment.Contains("Linux") || (environment.Contains("MacOS"))){
                environment="Unix";
            }
            else{return;}
            Console.WriteLine("Would you like to listen to home or away radio? (h/a/n)");
            Console.Write(">");
            string response = Console.ReadLine();
            if (response == "a")
            {
                PlayRadio(game.Away_team_name, environment);
            }
            else if (response == "h")
            {
                PlayRadio(game.Home_team_name, environment);

            }
            Console.Clear();
        }


        static public void PlayRadio(string teamName, string environment)
        {
            if(environment=="Windows"){
                if(System.IO.File.Exists(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Extras\Windows\ConsoleAudioStreamPlayer.exe")){
                    Process.Start(@"Extras\Windows\ConsoleAudioStreamPlayer.exe",teamName.Replace(" ","").ToLower());
                }
                else{Console.WriteLine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Extras\Windows\ConsoleAudioStreamPlayer.exe");}
                }
            if(environment=="Unix"){
                if(System.IO.File.Exists(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Extras\nix\mplayerstream.sh")){
                    Process.Start(@"sh mplayerstream.sh",teamName.Replace(" ","").ToLower());
                }
                else{Console.WriteLine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Extras\nix\mplayerstream.sh Not Found");}
                }
            }
        } 
    }


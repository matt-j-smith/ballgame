using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace Ballgame
{
class Program
    {
        private static DataFetch df = new DataFetch();
        

        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Display.DisplaySplash();

            Game game = new Game();
            List<Game> games = new List<Game>();
            games=df.GetGames(DateTime.Today);

            Display.DisplayGames(games,DateTime.Today);

            DateTime selectedDate = DateTime.Today;
            string o = Console.ReadLine();
            while (o != "q")
            {
                
                switch (o)
                {
                    case "p":
                        {
                            selectedDate = selectedDate.AddDays(-1);
                            games = df.GetGames(selectedDate);
                            Display.DisplayGames(games, selectedDate);
                            o = Console.ReadLine();
                            break;
                        }
                    case "n":
                        {
                            if (selectedDate < DateTime.Today) {
                                selectedDate = selectedDate.AddDays(1);
                                games = df.GetGames(selectedDate);
                                Display.DisplayGames(games,selectedDate);
                                o = Console.ReadLine();
                            }
                            else
                            {
                                games = df.GetGames(selectedDate);
                                Display.DisplayGames(games,selectedDate);
                                o = Console.ReadLine();
                            }
                            break;
                        }
                    default:
                        {
                            int selection;
                            if (Int32.TryParse(o,out selection)) {
                                game = df.GetGames(selectedDate)[selection - 1];
                                Console.Clear();
                                if (selectedDate==DateTime.Today && game.Status !="Final" && game.Status !="Preview")
                                {
                                    DisplayAudioMenu(game); 
                                    var autoEvent = new AutoResetEvent(false);
                                    Timer timer = new Timer(x =>Display.DisplayGameData(x,game, df.GetLinescore(game.Game_data_directory)),autoEvent,0,30000);
                                }
                                else if (game.Status=="Final")
                                {
                                    Display.DisplayFinal(game, df.GetBoxscore(game.Game_data_directory), df.GetLinescore(game.Game_data_directory));
                                }
                                    

                                o = Console.ReadLine();
                            }
                            else {
                                games = df.GetGames(selectedDate);
                                Display.DisplayGames(games,selectedDate);
                                System.Console.WriteLine("Invalid Selection"+Environment.NewLine+">");
                                o = Console.ReadLine();
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
                PlayRadio(game.Home_team_name,environment);

            }
            Console.Clear();
        }


        static public void PlayRadio(string teamName, string environment)
        {
            if(environment=="Windows"){
                if(System.IO.File.Exists(@"Extras\Windows\ConsoleAudioStreamPlayer.exe")){
                    Process.Start(@"Extras\Windows\ConsoleAudioStreamPlayer.exe",teamName.Replace(" ","").ToLower());
                }
                else{Console.WriteLine(@"Extras\Windows\ConsoleAudioStreamPlayer.exe not found");}
                }
            if(environment=="Unix"){
                if(System.IO.File.Exists(@"Extras\Nix\mplayerstream.sh")){
                    Process.Start(@"sh mplayerstream.sh",teamName.Replace(" ","").ToLower());
                }
                else{Console.WriteLine(@"Extras\Nix\mplayerstream.sh Not Found");}
                }
            }
        } 
    }


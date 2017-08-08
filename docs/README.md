# Ballgame
MLB boxscores and auto-updating game day data in your terminal

### Build Instructions
1. Open a console in the directory where you have unzipped the Ballgame code
2. **dotnet restore**
3. **dotnet run**
4. To build a executable:
   * Windows: **dotnet publish -c release -r win10-x64**
   * Linux: **dotnet publish -c release -r ubuntu.16.10-x64** (or whatever your environment is)
   * MacOS **dotnet publish -c release -r osx.10.11-x64**


![Game Selection](https://github.com/matt-j-smith/ballgame/blob/master/docs/Ballgame_gameselection.PNG)
![Game Status](https://github.com/matt-j-smith/ballgame/blob/master/docs/Ballgame_GameStatus.PNG)
![Game Boxscore](https://github.com/matt-j-smith/ballgame/blob/master/docs/Ballgame_Boxscore.PNG)
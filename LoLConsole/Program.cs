using System;

namespace LoLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu menuObject = new mainMenu();
            bool menuLoop = true;
            bool errorConnection = false;
            bool fileCreate = false;
            int menuItem = 0;
            string fileSettings = "Settings.ini";

            // Json objects from servers
            ChampionListDto liveChampionList = new ChampionListDto();
            GameObject pastGames = new GameObject();
            league_v2_3 summonerLeagueLadder = new league_v2_3();
            API_Call Operator = new API_Call();
            summonerProfile summonerStats = new summonerProfile();
            stats_v1_2_Ranked testStats = new stats_v1_2_Ranked();
            ChampionListDTO listOfChampions = new ChampionListDTO();


            // Operator makes call and grabs data from Riot.
            Operator.MakeCall(ref liveChampionList);

            Console.WriteLine("Calling pastGames");
            Operator.MakeCall(ref pastGames);

            Console.WriteLine("Calling summonerLeagueLadder");
            Operator.MakeCall(ref summonerLeagueLadder);
            Operator.MakeCall(ref testStats);
            Operator.MakeCall(ref listOfChampions);

            // Determines if user has run the program before.
            fileCreate = menuObject.checkFile(fileSettings);

            // Creates a file for user; mostly ini
            if (fileCreate)
            {

            }

            if (!errorConnection)
            {
                while (menuLoop)
                {
                    menuObject.displayMenu(ref menuItem);

                    switch (menuItem)
                    {
                        case 1:
                            // Display Active Roster
                            menuObject.displayActiveRoster(liveChampionList, listOfChampions);
                            break;
                        case 2:
                            //Display Free to Play Roster
                            // menuObject.displayFreeToPlay(liveChampionList);
                            break;
                        case 3:
                            // Change Current Region
                            // menuObject.displayBotChampions(liveChampionList);
                            break;
                        case 4:
                            // Displays last 10 games from user.
                            // menuObject.displayGamesPlayed(pastGames, liveChampionList);
                            break;
                        case 5:
                            // Display players in current league of player
                            menuObject.displayLeaderBoard(ref summonerLeagueLadder);
                            break;
                        case 6:
                            // Display Summary Stats
                            menuObject.displaySummaryStats(summonerStats);
                            break;
                        default:
                            menuLoop = false;
                            break;
                    }

                    // Exit program by user.
                    if (menuItem == 0)
                        menuLoop = false;
                }
            }
            else
            {
                Console.WriteLine("Closing program.");
            }

            Console.WriteLine("Hit any-key");
            Console.Read();
        }
    }
}

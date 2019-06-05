using System;
using System.Linq;

// Need for user defined operations
using System.Net;
using System.IO;
using Newtonsoft.Json;

// Riot Class Functions

namespace LoLConsole
{
    // Contains Second Level fucntions
      // ********************************
    partial class mainMenu
    {
        /*****************************************************************
        * Method Name: checkFile()
        * Arguements: fileName - Name of file currently being checked.
        * Purpose: Checks if a file exists, if it doesn't exist, it return
        *          false else true.
        *****************************************************************/
        public bool checkFile(string fileName)
        {
            bool settingsFile_Exist;

            if (File.Exists(fileName))
            {
                settingsFile_Exist = true;
                Console.WriteLine(fileName + ": Exists");
            }
            else
            {
                settingsFile_Exist = false;
                Console.WriteLine(fileName + ": Doesn't Exist - Creating File");
            }

            return settingsFile_Exist;
        }

        /*****************************************************************
        * Method Name: createFile
        * Arguements: fileName - Name of file currently being checked.
        * Purpose: Displays all current champions that are active in game.
        *****************************************************************/
        public void createFile(string fileName)
        {

            // Gets Summoner Name
            Console.WriteLine("Please Enter your Summoner Name");

            // Gets Summoner Region
            Console.WriteLine("Please type in the summoner region");

        }

        public void displayMenu(ref int userNumber)
        {
            bool testData = true;

            while (testData)
            {
                Console.WriteLine("-           Enter correponding number            -");
                Console.WriteLine("==================================================");
                Console.WriteLine(" 1) View Current Champion Roster                 -");
                Console.WriteLine(" 2) View Current Free Champions                  -");
                Console.WriteLine(" 3) View Current Bot Champions For Custom Games  -");
                Console.WriteLine(" 4) View Last Ten Games                          -");
                Console.WriteLine(" 5) View View current League Ladder              -");
                Console.WriteLine(" 0) Exit Program - ");

                try
                {
                    userNumber = Convert.ToInt32(Console.ReadLine());

                    switch (userNumber)
                    {
                        case 1:
                            testData = false;
                            break;
                        case 2:
                            testData = false;
                            break;
                        case 3:
                            testData = false;
                            break;
                        case 4:
                            testData = false;
                            break;
                        case 5:
                            testData = false;
                            break;
                        case 0:
                            testData = false;
                        break;
                        default:
                            Console.WriteLine("Please type in a valid number.");
                            testData = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please insert a valid entry.");
                }
            }
        }

        /*****************************************************************
         * Method Name: void displayActiveRoster(ChampionObject)
         * Arguements: displayName
         * Purpose: Displays all current champions that are active in game.
         *****************************************************************/
        public void displayActiveRoster(ChampionListDto championList, ChampionListDTO championListDTO)
        {
            // Determines if the list is empty.
            bool isEmpty = false;
            int code = 0;
            string whyItFailed = "";

            if ( championList == null )
                isEmpty = true;

            championList.getErrorCode(ref code, ref whyItFailed);

            if (championListDTO == null)
                isEmpty = true;

            if ((int)code == 200) // Success!
            {
                if (!isEmpty)
                {
                    foreach (var champion in championListDTO.data)
                    {
                        Console.WriteLine("Name: {0} - ID: {1} ", champion.Key, champion.Value.id);
                    }
                }
                else
                    Console.WriteLine("List is empty.");
            }
            else // Failed!
            {
                Console.WriteLine("-- Failed --");
                Console.WriteLine("Error Code: " + code);
                Console.WriteLine("Reason: " + whyItFailed);
            }

            return;
        }

        /**********************************************************************************************************
         * - Maybe have been deleted by RIOT.
         **********************************************************************************************************/
        /*
        public void displayFreeToPlay(ChampionListDto displayFreeToPlay)
        {
            int ndx = 0;
            int count = 0;
            string nameFormat;

            // Determines if the list is empty.
            bool isEmpty = false;

            if (displayFreeToPlay.champions.Count() == 0)
            {
                isEmpty = true;
            }

            if (!isEmpty)
            {
                Console.WriteLine("Displaying Free to Play Roster");

                for (ndx = 0; ndx < displayFreeToPlay.champions.Count(); ndx++)
                {
                    if (displayFreeToPlay.champions[ndx].freeToPlay)
                    {
                        nameFormat = String.Format("Name : {0,-10}", displayFreeToPlay.champions[ndx].name);

                        Console.WriteLine(nameFormat);
                        Console.WriteLine("Health: " + displayFreeToPlay.champions[ndx].defenseRank);
                        Console.WriteLine("Attack: " + displayFreeToPlay.champions[ndx].attackRank);
                        Console.WriteLine("Magic: " + displayFreeToPlay.champions[ndx].magicRank);
                        Console.WriteLine("Difficulty: " + displayFreeToPlay.champions[ndx].difficultyRank);

                        Console.WriteLine();
                    }
                }
            }
            else
                Console.WriteLine("List is Empty.");
        } */

        public void displayBotChampions(ChampionListDto displayBotChampions)
        {
            int ndx = 0;
            // Determines if the list is empty.
            bool isEmpty = false;

            if (displayBotChampions.champions == null)
            {
                isEmpty = true;
            }

            if (!isEmpty)
            {
                Console.WriteLine("Displaying Bot Roster enabled for Custom Games");

                for (ndx = 0; ndx < displayBotChampions.champions.Count(); ndx++)
                    if (displayBotChampions.champions[ndx].botEnabled)
                        Console.WriteLine(displayBotChampions.champions[ndx].id);
            }
            else
                Console.WriteLine("List is empty");
        }

        public void displayGamesPlayed(GameObject pastGames, champions champList)
        {
            int ndx = 0;
            int sizeOfList = 0;
            int statCounter = 0;

            // Sorts games by game time.
            pastGames.sortObject();
            
            sizeOfList = pastGames.games.Count;

            // Displays last games of current user.
            for (ndx = 0; ndx < sizeOfList; ndx++)
            {
                // Display info on games played
                Console.WriteLine(pastGames.games[ndx].championId);

                // Write Time and convert from epoch.
                Console.WriteLine("Time in epoch: " + pastGames.games[ndx].createDate);
                DateTime myTime = FromUnixTime(pastGames.games[ndx].createDate );
                string format = "hh:mm:ss tt yyyy";    // Use this format
                Console.WriteLine(myTime.ToString(format));

                Console.WriteLine("\n");
            }

            Console.WriteLine("Largest Stat: " + statCounter);            

        }

        public void displayLeaderBoard(ref league_v2_3 leaguePlayers)
        {
            int index = 0;
            int divisionLadder = 0;

            // Determines if the list is empty.
            bool isEmpty = false;

            if (leaguePlayers.leaderBoard == null)
            {
                isEmpty = true;
            }

            // Deterimines if is ranked or not
            if (!isEmpty)
            {
                if (leaguePlayers.leaderBoard != null)
                {
                    if (leaguePlayers.leaderBoard[index].queue == "RANKED_SOLO_5x5")
                    {
                        Console.WriteLine("RANKED_SOLO_5x5");

                        // Displays Tier One
                        for (divisionLadder = 0; divisionLadder < leaguePlayers.leaderBoard[index].entries.Count; divisionLadder++)
                        {
                            Console.WriteLine("Name: " + leaguePlayers.leaderBoard[index].entries[divisionLadder].playerOrTeamName);
                            Console.WriteLine("Tier: " + leaguePlayers.leaderBoard[index].entries[divisionLadder].tier );
                            Console.WriteLine("League Points: " + leaguePlayers.leaderBoard[index].entries[divisionLadder].leaguePoints);
                            Console.WriteLine("League Name: " + leaguePlayers.leaderBoard[index].entries[divisionLadder].leagueName);
                        }
                    }
                }
                else
                    Console.WriteLine("Not in any League.");
            }
            else
                Console.WriteLine("Leader board is empty.");

            Console.WriteLine("End leader board.");

        }

        public void getChampionsFromAPI(string API_URL, ref champions liveChampionList, ref bool errorConnection)
        {
            WebRequest request_champ_stream;

            try
            {
                // Open stream and generate URI request
                Console.Write("\n");
                Console.WriteLine("Opening URL");
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Get Response
                Console.WriteLine("\nThe Timeout time of the request before setting is : {0} milliseconds", request_champ_stream.Timeout);

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;
                Console.Write("Waiting on Web Response: ");

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server
                Console.WriteLine("Converting stream to string.");
                string responseFromServer = reader.ReadToEnd();


                // Parse Data from server
                Console.WriteLine("Parsing Data");
                liveChampionList = JsonConvert.DeserializeObject<champions>(responseFromServer);

                Console.WriteLine("Closing Stream");
                reader.Close();
                response.Close();
            }
            catch (WebException e)
            {
                errorConnection = true;
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                    Console.WriteLine(e.Message);
            }
        }



        public void getLeaguePlayersFromAPI( ref league_v2_3 leaguePlayers )
        {
            WebRequest request_Games;

            // redesign or get rid of this whole method
            string API_URL = "http://prod.api.pvp.net/api/lol/na/v2.2/league/by-summoner/23549704";
            // Open stream and generate URI request
            Console.Write("\n");
            Console.Write("Getting League Players from API");
            Console.WriteLine("Opening URL");

            try
            {
                request_Games = WebRequest.Create(API_URL);
                request_Games.Credentials = CredentialCache.DefaultCredentials;

                // Get Response
                // Setting 'Timeout' property in Milliseconds
                request_Games.Timeout = 30000;
                Console.WriteLine("\nThe Timeout time of the request before setting is : {0} milliseconds", request_Games.Timeout);
                Console.Write("Waiting on Web Response: ");

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_Games.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server
                Console.WriteLine("Converting stream to string.");
                string responseFromServer = reader.ReadToEnd();


                // Parse Data from server
                Console.WriteLine("Parsing Data");
                leaguePlayers = JsonConvert.DeserializeObject<league_v2_3>(responseFromServer);

                Console.WriteLine("Closing Stream");
                reader.Close();
                response.Close();
            }
            catch (WebException e)
            {
                // For error code to send back
                // errorConnection = true;
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DateTime FromUnixTime(long unixTime)
        {
            DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            d = d.AddMilliseconds(unixTime);
            return d.ToLocalTime();
        }


        public void displaySummaryStats(summonerProfile summonerStats)
        {

        }
    }
}

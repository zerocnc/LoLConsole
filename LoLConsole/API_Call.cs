
using System;
using System.Collections.Generic;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace LoLConsole
{

    using appAlias = Properties.Settings;
    public class API_Call
    {
        // Constructor
        public API_Call()
        {
            // Set to default
            user_region = "na";

            // Start summoner "Esteris"
            user_summonerid = "23655840";

            requestUrl_champions_v1_2 = "https://{region}.api.pvp.net/api/lol/{region}/v1.2/champion";
            requestUrl_current_game_v1_0 = "https://{region}.api.pvp.net/api/lol/observer-mode/rest/consumer/getSpectatorGameInfo/{platformId}/{summonerId}";
            requestUrl_game_v1_3 = "https://{region}.api.pvp.net/api/lol/{region}/v1.3/game/by-summoner/{summonerId}/recent";
            requestUrl_LeaderBoard_v2_3 = "https://{region}.api.pvp.net/api/lol/{region}/v2.3/league/by-summoner/{summonerId}";
            requestUrl_PlayerStatsSummary_v1_2 = "https://{region}.api.pvp.net/api/lol/{region}/v1.2/stats/by-summoner/{summonerId}/summary";
            requestUrl_PlayerStatsRanked_v1_2 = "https://{region}.api.pvp.net/api/lol/{region}/v1.2/stats/by-summoner/{summonerId}/ranked";
        }

        public void SetRegionAndName(string name, string region)
        {
            user_region = region;
            user_summoner_name = name;
        }

        private string user_summonerid;
        private string user_region;
        private string user_summoner_name;
        public static readonly string api_Key = appAlias.Default._APIKEY; // Your API Key from riot; located in setting file.;

        // Used to display error
        public string errorReason;
        public string errorHTTPStatusCode;
        public bool errorResponse;

        // URL used to make calls to server.
        private string requestUrl_champions_v1_2;
        private string requestUrl_game_v1_3;
        private string requestUrl_LeaderBoard_v2_3;
        private string requestUrl_PlayerStatsSummary_v1_2;
        private string requestUrl_PlayerStatsRanked_v1_2;
        private string requestUrl_current_game_v1_0;

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: ChampionObject myChamp.
        * Purpose: Calls Riot Servers to grab list of champions currently active in League of Legends.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data.
        *****************************************************************************************/
        public void MakeCall(ref ChampionListDto championList)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string temp = requestUrl_champions_v1_2 + api_Key;
            string API_URL = "";

            API_URL = temp.Replace("{region}", user_region);

            // Displays where at
            Console.WriteLine("Champion List Call");
            try
            {
                // Open stream and generate URI request
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 60000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                championList = JsonConvert.DeserializeObject<ChampionListDto>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                championList.setErrorCode( 200, "Success" );

                errorResponse = false;
                
            }

            // Determines if the call failed.
            catch (WebException e)
            {
                championList.setErrorCode((int)e.Status, e.Message);

                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: ChampionObject myChamp.
        * Purpose: Calls Riot Servers to grab list of champions currently active in League of Legends.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data.
        *****************************************************************************************/
        public void MakeCall(ref ChampionDto championList)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string temp = requestUrl_champions_v1_2 + api_Key;
            string API_URL = "";

            API_URL = temp.Replace("{region}", user_region);

            // Displays where at
            Console.WriteLine("Champion List Call");
            try
            {
                // Open stream and generate URI request
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 20000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                championList = JsonConvert.DeserializeObject<ChampionDto>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
                // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: GameObject pastGames.
        * Purpose: Calls Riot Servers to grab list of the last games played.  Will only collect and
        *          store up to a maximum of 10 games.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data.
        ******************************************************************************************/
        public void MakeCall(ref GameObject pastGames)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = requestUrl_game_v1_3 + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            API_URL = temp.Replace("{summonerId}", user_summonerid);

            // Displays where at
            Console.WriteLine("GameObject Object Call");
            try
            {
                // Open stream and generate URI request
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                pastGames = JsonConvert.DeserializeObject<GameObject>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
                // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: league_v2_3 summonerLeaderBoard.
        * Purpose: Calls Riot Servers to grab list of the current leader board the summoner is currently
        *          in.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data recieved from Data Set.
        ******************************************************************************************/
        public void MakeCall(ref league_v2_3 summonerLeaderBoard)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = requestUrl_LeaderBoard_v2_3 + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            API_URL = temp.Replace("{summonerId}", user_summonerid);


            // Displays where at
            Console.WriteLine("leaderBoard Object Call");
            try
            {
                // Open stream and generate URI request
                WebRequest.Create(API_URL);
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                summonerLeaderBoard.leaderBoard = JsonConvert.DeserializeObject<List<LeagueDto>>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
            // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: league_v2_3 summonerLeaderBoard.
        * Purpose: Calls Riot Servers to grab list of the current leader board the summoner is currently
        *          in.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data.
        ******************************************************************************************/
        public void MakeCall(ref summonerProfile summonersProfile)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = requestUrl_PlayerStatsSummary_v1_2 + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            API_URL = temp.Replace("{summonerId}", user_summonerid);

            // Displays where at
            Console.WriteLine("leaderBoard Object Call");
            try
            {
                // Open stream and generate URI request
                WebRequest.Create(API_URL);
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                summonersProfile = JsonConvert.DeserializeObject<summonerProfile>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
            // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************************************************************************************
        * Method Name: void MakeCall()
        * Arguements: RankedStatsDTO summonerRanked.
        * Purpose: Calls Riot Servers to grab list of the current leader board the summoner is currently
        *          in.
        * PreConditions: Assumes that API Key and Region have been set to desired location.
        * PostConditions: Fills current object with JSON parsed data.
        ******************************************************************************************/
        public void MakeCall(ref stats_v1_2_Ranked summonerRanked)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = requestUrl_PlayerStatsRanked_v1_2 + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            API_URL = temp.Replace("{summonerId}", user_summonerid);

            // Displays where at
            Console.WriteLine("stats_v1_2_Ranked Object Call");
            try
            {
                // Open stream and generate URI request
                WebRequest.Create(API_URL);
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                summonerRanked = JsonConvert.DeserializeObject<stats_v1_2_Ranked>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
            // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void MakeCall(ref Spectator_v3 summonerCurrentGame)
        {
            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = requestUrl_PlayerStatsRanked_v1_2 + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            API_URL = temp.Replace("{summonerId}", user_summonerid);

            // Displays where at
            Console.WriteLine("stats_v1_2_Ranked Object Call");
            try
            {
                // Open stream and generate URI request
                WebRequest.Create(API_URL);
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                summonerCurrentGame = JsonConvert.DeserializeObject<Spectator_v3>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
            // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }

        public void MakeCall(ref ChampionListDTO listOfChampions)
        {
            // https://{region}.api.pvp.net/api/lol/

            WebRequest request_champ_stream;
            string responseFromServer;
            string API_URL = "https://na.api.pvp.net/api/lol/static-data/na/v1.2/champion" + api_Key;
            string temp = API_URL;

            API_URL = temp.Replace("{region}", user_region);
            temp = API_URL;
            
            // Displays where at
            Console.WriteLine("listOfChampions Object Call");
            try
            {
                // Open stream and generate URI request
                WebRequest.Create(API_URL);
                request_champ_stream = WebRequest.Create(API_URL);
                request_champ_stream.Credentials = CredentialCache.DefaultCredentials;

                // Setting 'Timeout' property in Milliseconds
                request_champ_stream.Timeout = 30000;

                // This request will throw a WebException if it reaches the timeout limit before it is able to fetch the resource.
                WebResponse response = request_champ_stream.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream contaning content returned by the server.
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Reading content from server and converting it to string type.
                responseFromServer = reader.ReadToEnd();

                // Parse Data from server into object
                listOfChampions = JsonConvert.DeserializeObject<ChampionListDTO>(responseFromServer);

                // Closing Stream
                reader.Close();
                response.Close();

                errorResponse = false;
            }
            // Determines if the call failed.
            catch (WebException e)
            {
                Console.WriteLine("This program can't comminicate with the Web Server." +
                                  "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    errorHTTPStatusCode = "Status Code : {0}" + (((HttpWebResponse)e.Response).StatusCode).ToString();
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);

                    errorReason = "Status Description : {0}" + (((HttpWebResponse)e.Response).StatusDescription).ToString();
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }
    }
}

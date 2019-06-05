using System;
using LoLConsole;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// User Defined
using System.Data.SQLite;
using System.Net;
using System.IO;
using Newtonsoft;

namespace LoLConsole
{

    /**********************************************************************************************
     * Type: Response Classes
     * Return Value: ChampionListDto
     * URL: /api/lol/{region}/v1.2/champion
     * Descriptin: Get's the current League of Legends roster from the API.
     *             
     *      Path Parameters
     *      region - "na", "euw", "eune"
     *      
     * Returns Respone codes
     * - HTTP Status Code -----------  Reason --------
     *      400                     Bad request
     *      401                     Unauthorized
     *      500                     Internal server error
     *      404                     Summoner not found
     *      503                     Service unavailable
     *********************************************************************************************/
    public class ChampionListDto
    {
        public ChampionListDto()
        {

        }

        // The list of champion information data transfer object.
        [JsonProperty(PropertyName = "champions")]
        public List<Champion> champions { get; set; }

        /******************************************************************************************
         * Method Name: void getChampionName(int id)
         * Arguements: id - id of Champion
         * Purpose: Gets Champion name based on id.
         * PreConditions: Assumes the Champion list is filled
         * PostConditions: Returns string name to caller reguardless if champion was found
         *****************************************************************************************/
        public string GetChampionName(long id)
        {
            int ndx = 0;
            int listSize = 0;
            string championName = "";
            bool foundName = false;

            listSize = this.champions.Count();

            // Used to find the champion in the current list.
            while (ndx < listSize && !foundName)
            {
                if (id == this.champions[ndx].id)
                {
                    // championName = this.champions[ndx].name.ToString();
                    championName = this.champions[ndx].id.ToString();
                    ndx = listSize + 1;
                    foundName = true;
                }
                ndx++;
            }

            if (!foundName)
                championName = "Unknown Champion";

            return championName;
        }
    }

    public class Champion
    {
        // Indicates if the champion is active.
        [JsonProperty(PropertyName = "active")]
        public bool active { get; set; }

        // Bot enabled flag (for custom games).
        [JsonProperty(PropertyName = "botEnabled")]
        public bool botEnabled { get; set; }

        // Bot Match Made enabled flag (for Co-op vs. AI games).
        [JsonProperty(PropertyName = "botMmEnabled")]
        public bool botMmEnabled { get; set; }

        // Indicates if the champion is free to play. Free to play champions are rotated periodically.
        [JsonProperty(PropertyName = "freeToPlay")]
        public bool freeToPlay { get; set; }

        // Champion ID. For static information correlating to champion IDs, please refer to the LoL Static Data API.
        [JsonProperty(PropertyName = "id")]
        public long id { get; set; }

        // Ranked play enabled flag.
        [JsonProperty(PropertyName = "rankedPlayEnabled")]
        public bool rankedPlayEnabled { get; set; }
    }
}
using System;
using System.Collections.Generic;

// User Defined
using Newtonsoft.Json;

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
            // Class Constructor
            public ChampionListDto()
            {
                reason = String.Empty;
                httpStatusCode = 0;
            }

            // The list of champion information (DTO) data transfer object.
            [JsonProperty(PropertyName = "champions")]
            public List<ChampionDto> champions { get; set; }

            // -----------------------------------------------------------------
            // String Parameters.

            // Required to get information from region.
            private string region;

            // Optional: If true, gets list of free to play champions this week.
            private bool freeToPlay;

            // Response Error Codes - From server
            private int httpStatusCode;
            private string reason;

            // Allows client to ask why it failed with code.
            public void getErrorCode(ref int code, ref string whyItFailed)
            {
                code = this.httpStatusCode;
                whyItFailed = String.Copy(this.reason);
            }

            // Allows client to send in error code
            public void setErrorCode(int code, string whyItFailed)
            {
                httpStatusCode = code;
                reason = String.Copy(whyItFailed);
            }

        }

        public class ChampionDto
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
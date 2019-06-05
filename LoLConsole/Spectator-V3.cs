using System.Collections.Generic;

// User defined
using Newtonsoft.Json;

/// <summary>
/// Response Class(DTO) : Spectator_V3 -> CurrentGameInfo 
/// </summary>
public class Spectator_v3
{
    class CurrentGameInfo
    {
        /// <summary>
        /// The ID of the game.
        /// </summary>
        [JsonProperty(PropertyName = "gameId")]
        public long gameId;

        /// <summary>
        /// The game start time represented in epoch milliseconds 
        /// </summary>
        [JsonProperty(PropertyName = "gameStartTime")]
        public long gameStartTime { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played 
        /// </summary>
        [JsonProperty(PropertyName = "platformId")]
        public string platformId { get; set; }

        /// <summary>
        /// The Game Mode
        /// </summary>
        [JsonProperty(PropertyName = "gameMode")]
        public string gameMode { get; set; }

        /// <summary>
        /// The ID of the map.
        /// </summary>
        [JsonProperty(PropertyName = "mapId")]
        public long mapId { get; set; }

        /// <summary>
        /// The game type.
        /// </summary>
        [JsonProperty(PropertyName = "gameType")]
        public string gameType { get; set; }

        /// <summary>
        /// Banned champion Information (all)
        /// </summary>
        [JsonProperty(PropertyName = "bannedChampions")]
        public List<BannedChampion> bannedChampions { get; set; }

        /// <summary>
        /// The observer information.
        /// </summary>
        [JsonProperty(PropertyName = "observers")]
        public Observer observers { get; set; }

        /// <summary>
        /// The participant information
        /// </summary>
        [JsonProperty(PropertyName ="participants")]
        public List<CurrentGameParticipant> participants { get; set; }

        /// <summary>
        /// The amount of time in seconds that has passed since the game started.
        /// </summary>
        [JsonProperty(PropertyName ="gameLength")]
        public long gameLength { get; set; }

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants Page; Riot Values Const)
        /// </summary>
        [JsonProperty(PropertyName = "gameQueueConfigid")]
        public long gameQueueConfigId { get; set; }

        /// <summary>
        /// Information on banned champion; 
        /// </summary>
        public class BannedChampion
        {
            /// <summary>
            /// The turn during which the champion was banned?
            /// </summary>
            [JsonProperty(PropertyName = "pickTurn")]
            public int pickTurn;

            /// <summary>
            /// The ID of the banned champions
            /// </summary>
            [JsonProperty(PropertyName = "championId")]
            public long championId;

            /// <summary>
            /// The ID of the team that banned the champion
            /// </summary>
            [JsonProperty(PropertyName = "teamId")]
            public long teamId;
        }

        public class Observer
        {
            /// <summary>
            /// Key used to decrypt the specator grid game data playback.
            /// </summary>
            [JsonProperty(PropertyName = "encryptionKey")]
            public string encryptionKey;
        }

        public class CurrentGameParticipant
        {
            /// <summary>
            /// The ID of the profile icon used by the participant
            /// </summary>
            [JsonProperty(PropertyName = "profileIconId")]
            public long profileId;
        }
    }
}

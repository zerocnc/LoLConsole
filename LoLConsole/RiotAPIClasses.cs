// System
using System;
using System.Collections.Generic;

// User defined - Imported
using Newtonsoft.Json;

namespace LoLConsole
{
          #region game_v1_3
        public class RecentGamesDto
        {
            // List of recent games played (max 10).
            [JsonProperty(PropertyName = "games")]   
            public List<GameDto> games { get; set; }

            // Summoner Id.
            [JsonProperty(PropertyName = "summonerId")]
            public long summonerId { get; set; }
        }

        public class GameDto
        {
            [JsonProperty(PropertyName ="championId")]
            public int championId { get; set; }

            [JsonProperty(PropertyName ="createDate")]
            public long createDate { get; set; }

            [JsonProperty(PropertyName ="fellowPlayers")]
            public List<PlayerDto> fellowPlayers { get; set; }

            [JsonProperty(PropertyName ="gameId")]
            public long gameId { get; set; }

            [JsonProperty(PropertyName ="gameMode")]
            public string gameMode { get; set; }

            [JsonProperty(PropertyName = "gameType" )]
            public string gameType { get; set; }

            [JsonProperty(PropertyName = "invalid" )]
            public bool invalid { get; set; }

            [JsonProperty(PropertyName ="level")]
            int level { get; set; }

            [JsonProperty(PropertyName ="mapId")]
            int mapId { get; set; }

            [JsonProperty(PropertyName ="spell1")]
            int spell1 { get; set; }

            [JsonProperty(PropertyName ="spell2")]
            int spell2 { get; set; }

            [JsonProperty(PropertyName ="stats")]
            RawStatsDto stats { get; set; }

            [JsonProperty(PropertyName ="subType")]
            string subType { get; set; }

            [JsonProperty(PropertyName="teamId")]
            int teamId { get; set; }

        }

        public class PlayerDto
        {
            [JsonProperty(PropertyName="championId")]
            public int championId { get; set; }

            [JsonProperty(PropertyName="teamId")]
            public int teamId { get; set; }

            [JsonProperty(PropertyName="summonerId")]
            public int summonerId { get; set; }
        }

        public class RawStatsDto
        {
            // Flag specifying whether or not this game was won.
            [JsonProperty(PropertyName="win")]
            public bool win { get; set; }

            // Flag specifying if the summoner got the killing blow on the nexus.
            [JsonProperty(PropertyName = "nexusKilled")]
            public bool nexusKilled { get; set; }

            [JsonProperty(PropertyName="assists")]
            public int assists { get; set; }

            [JsonProperty(PropertyName = "barracksKilled")]
            public int barracksKilled { get; set; }

            [JsonProperty(PropertyName = "championsKilled")]
            public int championsKilled { get; set; }

            [JsonProperty(PropertyName = "combatPlayerScore")]
            public int combatPlayerScore { get; set; }

            [JsonProperty(PropertyName = "consumablesPurchased")]
            public int consumablesPurchased { get; set; }

            [JsonProperty(PropertyName = "damageDealtPlayer")]
            public int damageDealtPlayer { get; set; }

            [JsonProperty(PropertyName = "doubleKills")]
            public int doubleKills { get; set; }

            [JsonProperty(PropertyName = "firstBlood")]
            public int firstBlood { get; set; }

            [JsonProperty(PropertyName = "gold")]
            public int gold { get; set; }

            [JsonProperty(PropertyName = "goldEarned")]
            public int goldEarned { get; set; }

            [JsonProperty(PropertyName = "goldSpent")]
            public int goldSpent { get; set; }

            [JsonProperty(PropertyName = "item0")]
            public int item0 { get; set; }

            [JsonProperty(PropertyName = "item1")]
            public int item1 { get; set; }

            [JsonProperty(PropertyName = "item2")]
            public int item2 { get; set; }

            [JsonProperty(PropertyName = "item3")]
            public int item3 { get; set; }

            [JsonProperty(PropertyName = "item4")]
            public int item4 { get; set; }

            [JsonProperty(PropertyName = "item5")]
            public int item5 { get; set; }

            [JsonProperty(PropertyName = "item6")]
            public int item6 { get; set; }

            [JsonProperty(PropertyName = "itemsPurchased")]
            public int itemsPurchased { get; set; }

            [JsonProperty(PropertyName = "killingSprees")]
            public int killingSprees { get; set; }

            [JsonProperty(PropertyName = "largestCriticalStrike")]
            public int largestCriticalStrike { get; set; }

            [JsonProperty(PropertyName = "largestKillingSpree")]
            public int largestKillingSpree { get; set; }

            [JsonProperty(PropertyName = "largestMultiKill")]
            public int largestMultiKill { get; set; }

            // Number of Tier 3 items created.
            [JsonProperty(PropertyName = "legendaryItemsCreated")]
            public int legendaryItemsCreated { get; set; }

            [JsonProperty(PropertyName = "level")]
            public int level { get; set; }

            [JsonProperty(PropertyName = "magicDamageDealtPlayer")]
            public int magicDamageDealtPlayer { get; set; }

            [JsonProperty(PropertyName = "magicDamageDealtToChampions")]
            public int magicDamageDealtToChampions { get; set; }

            [JsonProperty(PropertyName = "magicDamageTaken")]
            public int magicDamageTaken { get; set; }

            [JsonProperty(PropertyName = "minionsDenied")]
            public int minionsDenied { get; set; }

            [JsonProperty(PropertyName = "minionsKilled")]
            public int minionsKilled { get; set; }

            [JsonProperty(PropertyName = "neutralMinionsKilledEnemyJungle")]
            public int neutralMinionsKilledEnemyJungle { get; set; }

            [JsonProperty(PropertyName = "neutralMinionsKilledYourJungle")]
            public int neutralMinionsKilledYourJungle { get; set; }

            [JsonProperty(PropertyName = "neutralMinionsKilled")]
            public int neutralMinionsKilled { get; set; }

            [JsonProperty(PropertyName = "nodeCapture")]
            public int nodeCapture { get; set; }

            [JsonProperty(PropertyName = "nodeCaptureAssist")]
            public int nodeCaptureAssist { get; set; }

            [JsonProperty(PropertyName = "nodeNeutralize")]
            public int nodeNeutralize { get; set; }

            [JsonProperty(PropertyName = "nodeNeutralizeAssist")]
            public int nodeNeutralizeAssist { get; set; }

            [JsonProperty(PropertyName = "numDeaths")]
            public int numDeaths { get; set; }

            [JsonProperty(PropertyName = "numItemsBought")]
            public int numItemsBought { get; set; }

            [JsonProperty(PropertyName = "objectivePlayerScore")]
            public int objectivePlayerScore { get; set; }

            [JsonProperty(PropertyName = "pentaKills")]
            public int pentaKills { get; set; }

            [JsonProperty(PropertyName = "physicalDamageDealtPlayer")]
            public int physicalDamageDealtPlayer { get; set; }

            [JsonProperty(PropertyName = "physicalDamageDealtToChampions")]
            public int physicalDamageDealtToChampions { get; set; }

            [JsonProperty(PropertyName = "physicalDamageTaken")]
            public int physicalDamageTaken { get; set; }

            [JsonProperty(PropertyName = "quadraKills")]
            public int quadraKills { get; set; }

            [JsonProperty(PropertyName = "sightWardsBought")]
            public int sightWardsBought { get; set; }

            // int	Number of times first champion spell was cast.
            [JsonProperty(PropertyName = "spell1Cast")]
            public int spell1Cast { get; set; }

            // int	Number of times second champion spell was cast.
            [JsonProperty(PropertyName = "spell2Cast")]
            public int spell2Cast { get; set; }

            // int	Number of times third champion spell was cast.
            [JsonProperty(PropertyName = "spell3Cast")]
            public int spell3Cast { get; set; }

            // int	Number of times forth champion spell was cast.
            [JsonProperty(PropertyName = "spell4Cast")]
            public int spell4Cast { get; set; }

            [JsonProperty(PropertyName = "summonSpell1Cast")]
            public int summonSpell1Cast { get; set; }

            [JsonProperty(PropertyName = "summonSpell2Cast")]
            public int summonSpell2Cast { get; set; }

            [JsonProperty(PropertyName = "superMonsterKilled")]
            public int superMonsterKilled { get; set; }

            [JsonProperty(PropertyName = "team")]
            public int team { get; set; }

            [JsonProperty(PropertyName = "teamObjective")]
            public int teamObjective { get; set; }

            [JsonProperty(PropertyName = "timePlayed")]
            public int timePlayed { get; set; }

            [JsonProperty(PropertyName = "totalDamageDealtToChampions")]
            public int totalDamageDealtToChampions { get; set; }

            [JsonProperty(PropertyName = "totalDamageDealt")]
            public int totalDamageDealt { get; set; }

            [JsonProperty(PropertyName = "totalDamageTaken")]
            public int totalDamageTaken { get; set; }

            [JsonProperty(PropertyName = "totalHeal")]
            public int totalHeal { get; set; }

            [JsonProperty(PropertyName = "totalPlayerScore")]
            public int totalPlayerScore { get; set; }

            [JsonProperty(PropertyName = "totalScoreRank")]
            public int totalScoreRank { get; set; }

            [JsonProperty(PropertyName = "totalTimeCrowdControlDealt")]
            public int totalTimeCrowdControlDealt { get; set; }

            [JsonProperty(PropertyName = "totalUnitsHealed")]
            public int totalUnitsHealed { get; set; }

            [JsonProperty(PropertyName = "tripleKills")]
            public int tripleKills { get; set; }

            [JsonProperty(PropertyName = "trueDamageDealtPlayer")]
            public int trueDamageDealtPlayer { get; set; }

            [JsonProperty(PropertyName = "trueDamageDealtToChampions")]
            public int trueDamageDealtToChampions { get; set; }

            [JsonProperty(PropertyName = "trueDamageTaken")]
            public int trueDamageTaken { get; set; }

            [JsonProperty(PropertyName = "turretsKilled")]
            public int turretsKilled { get; set; }

            [JsonProperty(PropertyName = "unrealKills")]
            public int unrealKills { get; set; }

            [JsonProperty(PropertyName = "victoryPointTotal")]
            public int victoryPointTotal { get; set; }

            [JsonProperty(PropertyName = "visionWardsBought")]
            public int visionWardsBought { get; set; }

            [JsonProperty(PropertyName = "wardKilled")]
            public int wardKilled { get; set; }

            [JsonProperty(PropertyName = "wardPlaced")]
            public int wardPlaced { get; set; }
        }

        public class GameDTO
        {
            // Game type. (legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
            [JsonProperty(PropertyName="gameType")]
            public string gameType { get; set; }

            // Other players associated with the game.
            [JsonProperty(PropertyName = "fellowPlayers")]
            public List<PlayerDto> fellowPlayers { get; set; }

            // Statistics associated with the game for this summoner.
            [JsonProperty(PropertyName="stats")]
            public RawStatsDto stats { get; set; }

            // Game ID.
            [JsonProperty(PropertyName="gameId")]
            public long gameId { get; set; }

            [JsonProperty(PropertyName="createDateAsDate")]
            public string createDateAsDate { get; set; }

            [JsonProperty(PropertyName="teamId")]
            public int teamId { get; set; }

            // ID of first summoner spell.
            [JsonProperty(PropertyName="spell1")]
            public int spell1 { get; set; }

            // ID of second summoner spell.
            [JsonProperty(PropertyName="spell2")]
            public int spell2 { get; set; }

            // Game mode. (legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, FIRSTBLOOD)
            [JsonProperty(PropertyName="gameMode")]
            public string gameMode { get; set; }

            // Map ID.
            [JsonProperty(PropertyName="mapId")]
            public int mapId { get; set; }

            // Level.
            [JsonProperty(PropertyName="level")]
            public int level { get; set; }

            // Invalid flag.
            [JsonProperty(PropertyName="invalid")]
            public bool invalid { get; set; }

            [JsonProperty(PropertyName="subType")]
            public string subType { get; set; }

            // Champion ID associated with game.
            [JsonProperty(PropertyName="")]
            public int championId { get; set; }

            // Date that end game data was recorded, specified as epoch milliseconds.
            [JsonProperty(PropertyName="createDate")]
            public long createDate { get; set; }
        }

        public class GameObject
        {

            // List of recent games played (max 10).
            [JsonProperty(PropertyName="games")]
            public List<GameDTO> games { get; set; }

            // Summoner ID.
            [JsonProperty(PropertyName="summonerId")]
            public long summonerId { get; set; }

            /****************************************************************
            * Function: sortObject()
            * Arguments: None
            * Description: Sorts the list games by dated created, ascending.
            * Preconditions:  Assumes that the currentObject is filled with
            *                 games.
            ****************************************************************/
            public void sortObject()
            {
                GameDTO temp = new GameDTO();

                int sizeOfHistory = this.games.Count;

                if (sizeOfHistory != 0)
                {
                    for (int index = 0; index <( sizeOfHistory - 1); index++)
                    {
                        if (this.games[index].createDate < this.games[index+1].createDate )
                        {
                            temp = this.games[index];
                            this.games[index] = this.games[index + 1];
                            this.games[index + 1] = temp;
                        }
                    }
                }
            }

        }
    #endregion

    #region League

        public class league_v2_3
        {
            [JsonProperty(PropertyName="leaderBoard")]
            public List<LeagueDto> leaderBoard;
        }

        public class LeagueDto
        {
            [JsonProperty(PropertyName="queue")]
            public string queue { get; set; }

            [JsonProperty(PropertyName="name")]
            public string name { get; set; }

            [JsonProperty(PropertyName = "participantId")]
            public string participantId { get; set; }

            [JsonProperty(PropertyName="entries")]
            public List<LeagueEntryDto> entries { get; set; }

            [JsonProperty(PropertyName="tier")]
            public string tier { get; set; }
        }

        public class LeagueEntryDto
        {
            [JsonProperty(PropertyName="isHotStreak")]
            public bool isHotStreak { get; set; }

            [JsonProperty(PropertyName="isFreshBlood")]
            public bool isFreshBlood { get; set; }

            [JsonProperty(PropertyName="leagueName")]
            public string leagueName { get; set; }

            [JsonProperty(PropertyName="isVeteran")]
            public bool isVeteran { get; set; }

            [JsonProperty(PropertyName="tier")]
            public string tier { get; set; }

            [JsonProperty(PropertyName="lastPlayed")]
            public long lastPlayed { get; set; }

            [JsonProperty(PropertyName="playerOrTeamId")]
            public string playerOrTeamId { get; set; }

            [JsonProperty(PropertyName="leaguePoints")]
            public int leaguePoints { get; set; }

            [JsonProperty(PropertyName="rank")]
            public string rank { get; set; }

            [JsonProperty(PropertyName="isInactive")]
            public bool isInactive { get; set; }

            [JsonProperty(PropertyName="queueType")]
            public string queueType { get; set; }

            [JsonProperty(PropertyName="playerOrTeamName")]
            public string playerOrTeamName { get; set; }

            [JsonProperty(PropertyName="wins")]
            public int wins { get; set; }

            [JsonProperty(PropertyName="miniSeries")]
            public MiniSeries miniSeries { get; set; }
        }

        public class MiniSeries
        {
            [JsonProperty(PropertyName="progress")]
            public string progress { get; set; }

            [JsonProperty(PropertyName="target")]
            public int target { get; set; }

            [JsonProperty(PropertyName="losses")]
            public int losses { get; set; }

            [JsonProperty(PropertyName = "timeLeftToPlayMillis")]
            public int timeLeftToPlayMillis { get; set; }

            [JsonProperty(PropertyName="wins")]
            public int wins { get; set; }
        }

    #endregion

    #region lol-static-data-v1
        /**********************************************************************************************
         * Type: Response Classes
         * Return Value: ChampionListDTO
         * URL: /api/lol/static-data/{region}/v1/champion
         * Descriptin: Retrieves champion list.
         * Notes: Requests to this API will not be counted in your Rate Limit.
         *             
         *      Path Parameters
         *          region - BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR
         *      Query Parameters
         *          Name           Type          Value
         *          locale         string        en_US
         *          version        string        v1   
         *          champData      string        all, image, skins, lore, blurp, allytips, enemytips, tags, partype,
         *                                       info, stats, spells, passive, recommend
         *          
         *          
         *      Example:
         *      Without Paramters
         *          https://prod.api.pvp.net/api/lol/static-data/br/v1/champion?champData=all&api_key=b729e826-32bd-4f0a-82b3-c31cd3ece046
         *          https://prod.api.pvp.net/api/lol/static-data/{region}/{version}/champion?champData={champData}&{api_Key}
         *      
         * Returns Respone codes
         * - HTTP Status Code -----------  Reason --------
         *      400                     Bad request
         *      401                     Unauthorized
         *      500                     Internal server error
         *      404                     Summoner not found
         *      503                     Service unavailable
         *********************************************************************************************/
        #region ChampionListDTO
        public class ChampionListDTO
        {
            public Dictionary<string, ChampionDTO> data;

            [JsonProperty(PropertyName="format")]
            public string format { get; set; }

            public Dictionary<string, string> keys { get; set; }

            [JsonProperty(PropertyName="type")]
            public string type { get; set; }

            [JsonProperty(PropertyName="version")]
            public string version { get; set; }
        }

        public class ChampionDTO
        {
            public List<string> allytips { get; set; }
            public string blurp { get; set; }
            public List<string> enemytips { get; set; }
            public string id { get; set; }
            public ImageDTO image { get; set;}
            public InfoDTO info { get; set; }
            public string key { get; set; }
            public string lore { get; set; }
            public string name { get; set; }
            public string partype { get; set; }
            public PassiveDTO passive { get; set; }
            public List<RecommendedDTO> recommended { get; set; }
            public List<SkinDTO> skins { get; set; }
            public List<SpellDTO> spells { get; set;}
            public StatsDTO stats { get; set; }
            public List<string> tags { get; set; }
            public string title { get; set; }
        }

        public class ImageDTO
        {
            public string full { get; set; }
            public string group { get; set; }
            public int h { get; set; }
            public string sprite { get; set; }
            public int w { get; set; }
            public int x { get; set; }
            public int y { get; set; }
        }

        public class InfoDTO
        {
            public int attack { get; set; }
            public int defense { get; set; }
            public int difficulty { get; set; }
            public int magic { get; set; }
        }

        public class PassiveDTO
        {
            public string description { get; set; }
            public ImageDTO image { get; set; }
            public string name { get; set; }
        }

        public class RecommendedDTO
        {
            public List<BlockDTO> blocks { get; set; }
            public string champion { get; set; }
            public string map { get; set; }
            public string mode { get; set; }
            public bool priority { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }

        public class SkinDTO
        {
            public string id { get; set; }
            public string name { get; set; }
            public int num { get; set; }
        }

        public class SpellDTO
        {
            public List<int> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int> cost { get; set; }
            public string costBurn { get; set; }
            public string costType { get; set; }
            public string description { get; set; }
            public List<object> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public string id { get; set; }
            public ImageDTO image { get; set; }
            public LevelTipDTO leveltip { get; set; }
            public int maxrank { get; set; }
            public string name { get; set; }
            public object range { get; set; }
            public string rangeBurn { get; set; }
            public string resource { get; set; }
            public string tooltip { get; set; }
            public List<object> vars { get; set; }
        }

        public class StatsDTO
        {
            public double armor { get; set; }
            public double armorperlevel { get; set; }
            public double attackdamage { get; set; }
            public double attackdamageperlevel { get; set; }
            public double attackrange { get; set; }
            public double attackspeedoffset { get; set; }
            public double attackspeedperlevel { get; set; }
            public double crit { get; set; }
            public double critperlevel { get; set; }
            public double hp { get; set; }
            public double hpperlevel { get; set; }
            public double hpregen { get; set; }
            public double hpregenperlevel { get; set; }
            public double movespeed { get; set; }
            public double mp { get; set; }
            public double mpperlevel { get; set; }
            public double mpregen { get; set; }
            public double mpregenperlevel { get; set; }
            public double spellblock { get; set; }
            public double spellblockperlevel { get; set; }
        }

        public class BlockDTO
        {
            public List<BlockItemDTO> items { get; set; }
            public string type { get; set; }
        }

        public class LevelTipDTO
        {
            public List<string> effect;
            public List<string> label;
        }

        public class BlockItemDTO
        {
            public int count { get; set; }
            public string id { get; set; }
        }
        #endregion

        #region ChampionDto
        /**********************************************************************************************
         * Type: Response Classes
         * Return Value: ChampionDTO
         * URL: /api/lol/static-data/{region}/v1/champion/{id}
         * Descriptin: Retrieves a single champion object.
         * Notes: Requests to this API will not be counted in your Rate Limit.
         *             
         *      Path Parameters
         *          region - BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR
         *      Query Parameters
         *          Name           Type          Value
         *          locale         string        en_US
         *          version        string        v1   
         *          champData      string        all, image, skins, lore, blurp, allytips, enemytips, tags, partype,
         *                                       info, stats, spells, passive, recommend
         *          
         *          
         *      Example:
         *      Without Paramters
         *          https://prod.api.pvp.net/api/lol/static-data/{regoin}/v1/champion/1?api_key={api_Key}
         *      
         * Returns Respone codes
         * - HTTP Status Code -----------  Reason --------
         *      400                     Bad request
         *      401                     Unauthorized
         *      500                     Internal server error
         *      404                     Summoner not found
         *      503                     Service unavailable
         *********************************************************************************************/
        public class ChampionDtoAsset
        {
            public List<string> allyTips { get; set; }
            public string blurb { get; set; }
            public List<string> enemyTips { get; set; }
            public string id { get; set; }
            public ImageDTO image { get; set; }
            public InfoDTO info { get; set; }
            public string key { get; set; }
            public string lore { get; set; }
            public string name { get; set; }
            public string partype { get; set; }
            public PassiveDTO passive { get; set; }
            public List<RecommendedDTO> recommend { get; set; }
            public List<SkinDTO> skins { get; set; }
            public List<SpellDTO> spells { get; set; }
            public StatsDTO stats { get; set; }
            public List<string> tags { get; set; }
            public string title { get; set; }
        }

    /*
        public class BlockDTO
        {
            public List<BlockItemDTO> items { get; set; }
            public string type { get; set; }
        }

        public class LevelTipDTO
        {
            public List<string> effect { get; set; }
            public List<string> label { get; set; }
        }        */

        #endregion ChapionDTO

        #region ItemDTO
        public class ItemDTO
        {
            public string collq { get; set; }
            public string description { get; set; }
            public GoldDTO gold { get; set; }
            public string group { get; set; }
            public ImageDTO image { get; set; }
            public List<string> info { get; set; }
            public string name { get; set; }
            public string plaintext { get; set; }
            public Dictionary<string, object> stats { get; set; }
            public List<string> tags { get; set; }
        }

        public class GoldDTO
        {
            [JsonProperty(PropertyName = "base")]
            public int Base { get; set; }
            public bool purchasable { get; set; }
            public int sell { get; set; }
            public int total { get; set; }
        }
        #endregion ItemDTO

        #region ItemListDTO
        public class ItemListDTO
        {
            public BasicDataDTO basic { get; set; }
            public Dictionary<string, ItemDTO> data { get; set; }
            public List<GroupDTO> groups { get; set; }
            public List<ItemTreeDTO> tree { get; set; }
            public string type { get; set; }
            public string version { get; set; }
        }

        public class BasicDataDTO
        {
            public string colloq { get; set; }
            public bool consumeOnFull { get; set; }
            public bool consumed { get; set; }
            public int depth { get; set; }
            public string description { get; set; }
            public List<string> from { get; set; }
            public GoldDTO gold { get; set; }
            public string group { get; set; }
            public bool hideFromAll { get; set; }
            public bool inStore { get; set; }
            public List<string> into { get; set; }
            public Dictionary<string, bool> maps { get; set; }
            public string name { get; set; }
            public string plaintext { get; set; }
            public string requiredChampion { get; set; }
            public ItemRuneDTO rune { get; set; }
            public int specialRecipe { get; set; }
            public int stacks { get; set; }
            public ItemStatsDTO stats { get; set; }
            public List<string> tags { get; set; }
        }

        public class GroupDTO
        {
            public string MaxGroupOwnable { get; set; }
            public string id { get; set; }
        }
    /*
        public class ItemDTO
        {
            public string colloq { get; set; }
            public string description { get; set; }
            public GoldDTO gold { get; set; }
            public string group { get; set; }
            public ImageDTO image { get; set; }
            public List<string> into { get; set; }
            public string name { get; set; }
            public string plaintext { get; set; }
            public Dictionary<string, object> stats { get; set; }
            public List<string> stats { get; set; }
        }*/

        public class ItemTreeDTO
        {
            public string header { get; set; }
            public List<string> tags { get; set; }
        }

        public class ItemRuneDTO
        {
            public bool isRune { get; set; }
            public int tier { get; set; }
            public string type { get; set; }
        }

        public class ItemStatsDTO
        {
            public int FlatArmorMod { get; set; }
            public int FlatAttackSpeedMod { get; set; }
            public int FlatBlockMod { get; set; }
            public int FlatCritChanceMod { get; set; }
            public int FlatCritDamageMod { get; set; }
            public int FlatEXPBonus { get; set; }
            public int FlatHPPoolMod { get; set; }
            public int FlatHPRegenMod { get; set; }
            public int FlatMPPoolMod { get; set; }
            public int FlatMPRegenMod { get; set; }
            public int FlatMagicDamageMod { get; set; }
            public int FlatMovementSpeedMod { get; set; }
            public int FlatPhysicalDamageMod { get; set; }
            public int FlatSpellBlockMod { get; set; }
            public int PercentArmorMod { get; set; }
            public int PercentAttackSpeedMod { get; set; }
            public int PercentBlockMod { get; set; }
            public int PercentCritChanceMod  { get; set; }
            public int PercentCritDamageMod { get; set; }
            public int PercentDodgeMod { get; set; }
            public int PercentEXPBonus { get; set; }
            public int PercentHPPoolMod { get; set; }
            public int PercentHPRegenMod { get; set; }
            public int PercentMPPoolMod { get; set; }
            public int PercentMPRegenMod { get; set; }
            public int PercentMagicDamageMod { get; set; }
            public int PercentMovementSpeedMod { get; set; }
            public int PercentPhysicalDamageMod { get; set; }
            public int PercentSpellBlockMod { get; set; }
            public int rFlatArmorModPerLevel { get; set; }
            public int rFlatArmorPenetrationMod { get; set; }
            public int rFlatArmorPenetrationModPerLevel { get; set; }
            public int rFlatCritChanceModPerLevel { get; set; }
            public int rFlatCritDamageModPerLevel { get; set; }
            public int rFlatDodgeMod { get; set; }
            public int rFlatDodgeModPerLevel { get; set; }
            public int rFlatGoldPer10Mod { get; set; }
            public int rFlatHPModPerLevel { get; set; }
            public int rFlatHPRegenModPerLevel { get; set; }
            public int rFlatMPModPerLevel { get; set; }
            public int rFlatMPRegenModPerLevel { get; set; }
            public int rFlatMagicDamageModPerLevel { get; set; }
            public int rFlatMagicPenetrationMod { get; set; }
            public int rFlatMagicPenetrationModPerLevel { get; set; }
            public int rFlatMovementSpeedModPerLevel { get; set; }
            public int rFlatPhysicalDamageModPerLevel { get; set; }
            public int rFlatSpellBlockModPerLevel { get; set; }
            public int rFlatTimeDeadMod { get; set; }
            public int rFlatTimeDeadModPerLevel { get; set; }
            public int rPercentArmorPenetrationMod { get; set; }
            public int rPercentArmorPenetrationModPerLevel { get; set; }
            public int rPercentAttackSpeedModPerLevel { get; set; }
            public int rPercentCooldownMod { get; set; }
            public int rPercentCooldownModPerLevel { get; set; }
            public int rPercentMagicPenetrationMod { get; set; }
            public int rPercentMagicPenetrationModPerLevel { get; set; }
            public int rPercentMovementSpeedModPerLevel { get; set; }
            public int rPercentTimeDeadMod { get; set; }
            public int rPercentTimeDeadModPerLevel { get; set; }
        }
        
        

        #endregion ItemListDTO

        #region MasteryDTO
        /*************************************************************************************
         * /api/lol/static-data/{region}/v1/mastery/{id}
        *************************************************************************************/
        public class MasteryDTO
        {
            public List<string> description { get; set; }
            public int id { get; set; }
            public ImageDTO image { get; set; }
            public string name { get; set; }
            public string prereq { get; set; }
            public int ranks { get; set; }
        }

        #endregion MasteryDTO

        #region MasteryListDTO
        /*
         * Usage: Retrieves mastery list.
         */
        public class MasteryListDTO
        {
            public Dictionary<string, MasteryDTO> data { get; set; }
            public MasteryTreeDTO tree { get; set; }
            public string type { get; set; }
            public string version { get; set; }
        }

        public class MasteryTreeDTO
        {
            public List<object> Defense { get; set; }
            public List<object> Offense { get; set; }
            public List<object> Utility { get; set; }
        }

        #endregion MasteryListDTO

        #region RealmDTO
        /*
         * Used
         * URL: /api/lol/static-data/{region}/v1/realm
         * */
        public class RealmDTO
        {
            // The base CDN url.
            [JsonProperty(PropertyName = "cdn")]
            public string cdn { get; set; }

            // Latest changed version of Dragon Magic's css file.
            [JsonProperty(PropertyName = "css")]
            public string css { get; set; }

            // Latest changed version of Dragon Magic.
            [JsonProperty(PropertyName = "dd")]
            public string dd { get; set; }

            // Default language for this realm.
            [JsonProperty(PropertyName = "l")]
            public string l { get; set; }

            // Legacy script mode for IE6 or older.
            [JsonProperty(PropertyName = "lg")]
            public string lg { get; set; }

            // Latest changed version for each data type listed.
            [JsonProperty(PropertyName = "n")]
            public Dictionary<string, string> n { get; set; }

            // Special behavior number identifying the largest profileicon id that can be used under 500. 
            // Any profileicon that is requested between this number and 500 should be mapped to 0.
            [JsonProperty(PropertyName = "proflieiconmax")]
            public int profileiconmax { get; set; }

            // Additional api data drawn from other sources that may be related to data dragon functionality.
            [JsonProperty(PropertyName = "store")]
            public string store { get; set; }

            // Current version of this file for this realm.
            [JsonProperty(PropertyName = "v")]
            public string v { get; set; }
        }

        #endregion RealmDTO

        #region RuneDTO
        /*************************************************************************************
         * Usage: Retrieves rune by its unique id.
         * From: /api/lol/static-data/{region}/v1/rune/{id}
         *************************************************************************************/
        public class RuneDTO
        {
            [JsonProperty(PropertyName = "colloq")]
            public string colloq { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string description { get; set; }

            [JsonProperty(PropertyName = "image")]
            public ImageDTO image { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string name { get; set; }

            [JsonProperty(PropertyName = "plaintext")]
            public string plaintext { get; set; }

            [JsonProperty(PropertyName = "rune")]
            public RuneTypeDTO rune { get; set; }

            [JsonProperty(PropertyName = "stats")]
            public RuneStatsDTO stats { get; set; }

            [JsonProperty(PropertyName = "tags")]
            public List<string> tags { get; set; }
        }

        public class RuneStatsDTO
        {
            [JsonProperty(PropertyName="FlatArmorMod")]
            double	FlatArmorMod { get; set; }

            [JsonProperty(PropertyName="FlatAttackSpeedMod")]
            double	FlatAttackSpeedMod { get; set; }

            [JsonProperty(PropertyName="FlatBlockMod")]
            double	FlatBlockMod { get; set; }

            [JsonProperty(PropertyName="FlatCritChanceMod")]
            double	FlatCritChanceMod { get; set; }

            [JsonProperty(PropertyName="FlatCritDamageMod")]
            double	FlatCritDamageMod { get; set; }

            [JsonProperty(PropertyName="FlatEXPBonus")]
            double	FlatEXPBonus { get; set; }

            [JsonProperty(PropertyName="FlatEnergyPoolMod")]
            double	FlatEnergyPoolMod { get; set; }

            [JsonProperty(PropertyName="FlatEnergyRegenMod")]
            double	FlatEnergyRegenMod { get; set; }

            [JsonProperty(PropertyName="FlatHPPoolMod")]
            double	FlatHPPoolMod { get; set; }

            [JsonProperty(PropertyName="FlatHPRegenMod")]
            double	FlatHPRegenMod { get; set; }

            [JsonProperty(PropertyName="FlatMPPoolMod")]
            double	FlatMPPoolMod { get; set; }

            [JsonProperty(PropertyName="FlatMPRegenMod")]
            double	FlatMPRegenMod { get; set; }

            [JsonProperty(PropertyName="FlatMagicDamageMod")]
            double	FlatMagicDamageMod { get; set; }

            [JsonProperty(PropertyName="FlatMovementSpeedMod")]
            double	FlatMovementSpeedMod { get; set; }

            [JsonProperty(PropertyName="FlatPhysicalDamageMod")]
            double	FlatPhysicalDamageMod { get; set; }

            [JsonProperty(PropertyName="FlatSpellBlockMod")]
            double	FlatSpellBlockMod { get; set; }

            [JsonProperty(PropertyName="PercentArmorMod")]
            double	PercentArmorMod { get; set; }

            [JsonProperty(PropertyName="PercentAttackSpeedMod")]
            double	PercentAttackSpeedMod { get; set; }

            [JsonProperty(PropertyName="PercentBlockMod")]
            double	PercentBlockMod { get; set; }

            [JsonProperty(PropertyName="PercentCritChanceMod")]
            double	PercentCritChanceMod { get; set; }

            [JsonProperty(PropertyName="PercentCritDamageMod")]
            double	PercentCritDamageMod { get; set; }

            [JsonProperty(PropertyName="PercentDodgeMod")]
            double	PercentDodgeMod { get; set; }

            [JsonProperty(PropertyName="PercentEXPBonus")]
            double	PercentEXPBonus { get; set; }

            [JsonProperty(PropertyName="PercentHPPoolMod")]
            double	PercentHPPoolMod { get; set; }

            [JsonProperty(PropertyName="PercentHPRegenMod")]
            double	PercentHPRegenMod { get; set; }

            [JsonProperty(PropertyName="PercentLifeStealMod")]
            double	PercentLifeStealMod { get; set; }

            [JsonProperty(PropertyName="PercentMPPoolMod")]
            double	PercentMPPoolMod { get; set; }

            [JsonProperty(PropertyName="PercentMPRegenMod")]
            double	PercentMPRegenMod { get; set; }

            [JsonProperty(PropertyName="PercentMagicDamageMod")]
            double	PercentMagicDamageMod { get; set; }

            [JsonProperty(PropertyName="PercentMovementSpeedMod")]
            double	PercentMovementSpeedMod { get; set; }

            [JsonProperty(PropertyName="PercentPhysicalDamageMod")]
            double	PercentPhysicalDamageMod { get; set; }

            [JsonProperty(PropertyName="PercentSpellBlockMod")]
            double	PercentSpellBlockMod { get; set; }

            [JsonProperty(PropertyName="PercentSpellVampMod")]
            double	PercentSpellVampMod { get; set; }

            [JsonProperty(PropertyName="rFlatArmorModPerLevel")]
            double	rFlatArmorModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatArmorPenetrationMod")]
            double	rFlatArmorPenetrationMod { get; set; }

            [JsonProperty(PropertyName="rFlatArmorPenetrationModPerLevel")]
            double	rFlatArmorPenetrationModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatCritChanceModPerLevel")]
            double	rFlatCritChanceModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatCritDamageModPerLevel")]
            double	rFlatCritDamageModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatDodgeMod")]
            double	rFlatDodgeMod { get; set; }

            [JsonProperty(PropertyName="rFlatDodgeModPerLevel")]
            double	rFlatDodgeModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatEnergyModPerLevel")]
            double	rFlatEnergyModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatEnergyRegenModPerLevel")]
            double	rFlatEnergyRegenModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatGoldPer10Mod")]
            double	rFlatGoldPer10Mod { get; set; }

            [JsonProperty(PropertyName="rFlatHPModPerLevel")]
            double	rFlatHPModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatHPRegenModPerLevel")]
            double	rFlatHPRegenModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatMPModPerLevel")]
            double	rFlatMPModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatMPRegenModPerLevel")]
            double	rFlatMPRegenModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatMagicDamageModPerLevel")]
            double	rFlatMagicDamageModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatMagicPenetrationMod")]
            double	rFlatMagicPenetrationMod { get; set; }

            [JsonProperty(PropertyName="rFlatMovementSpeedModPerLevel")]
            double	rFlatMovementSpeedModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatPhysicalDamageModPerLevel")]
            double	rFlatPhysicalDamageModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatSpellBlockModPerLevel")]
            double	rFlatSpellBlockModPerLevel { get; set; }

            [JsonProperty(PropertyName="rFlatTimeDeadMod")]
            double	rFlatTimeDeadMod { get; set; }

            [JsonProperty(PropertyName="rFlatTimeDeadModPerLevel")]
            double	rFlatTimeDeadModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentArmorPenetrationMod")]
            double	rPercentArmorPenetrationMod { get; set; }

            [JsonProperty(PropertyName="rPercentArmorPenetrationModPerLevel")]
            double	rPercentArmorPenetrationModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentAttackSpeedModPerLevel")]
            double	rPercentAttackSpeedModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentCooldownMod")]
            double	rPercentCooldownMod { get; set; }

            [JsonProperty(PropertyName="rPercentCooldownModPerLevel")]
            double	rPercentCooldownModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentMagicPenetrationMod")]
            double	rPercentMagicPenetrationMod { get; set; }

            [JsonProperty(PropertyName="rPercentMagicPenetrationModPerLevel")]
            double	rPercentMagicPenetrationModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentMovementSpeedModPerLevel")]
            double	rPercentMovementSpeedModPerLevel { get; set; }

            [JsonProperty(PropertyName="rPercentTimeDeadMod")]
            double	rPercentTimeDeadMod { get; set; }

            [JsonProperty(PropertyName="rPercentTimeDeadModPerLevel")]
            double rPercentTimeDeadModPerLevel { get; set; }

        }

        public class RuneTypeDTO
        {
            [JsonProperty(PropertyName = "isrune")]
            public bool isrune { get; set; }

            [JsonProperty(PropertyName = "tier")]
            public string tier { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string type { get; set; }
        }

        #endregion RuneDTO

        #region RuneListDto
        /***************************************************************************************************
         * For: /api/lol/static-data/{region}/v1/rune
         * Used: Retieves Rune List, data base of runes if you will.
         **************************************************************************************************/
        public class RuneListDTO
        {
            [JsonProperty(PropertyName = "basic")]
            public BasicRuneDataDTO basic { get; set; }

            [JsonProperty(PropertyName = "data")]
            public Dictionary<string, RuneDTO> data { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string type { get; set; }

            [JsonProperty(PropertyName = "version")]
            public string version { get; set; }
        }

        public class BasicRuneDataDTO
        {
            // Left empty - Why riot?
        }

        #endregion RuneListDto

        #region SummonerSpellDto
        /*
         * Used: Retrieves summoner spell by its unique id.
         * URL: /api/lol/static-data/{region}/v1/summoner-spell/{id}
         * 
         **/
        public class SummonerSpellDto
        {
            [JsonProperty(PropertyName = "cooldown")]
            public List<int> cooldown { get; set; }

            [JsonProperty(PropertyName = "cooldownBurn")]
            public string cooldownBurn { get; set; }

            [JsonProperty(PropertyName = "cost")]
            public List<int> cost { get; set; }

            [JsonProperty(PropertyName = "costBurn")]
            public string costBurn { get; set; }

            [JsonProperty(PropertyName = "costType")]
            public string costType { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string description { get; set; }

            [JsonProperty(PropertyName = "effect")]
            public List<object> effect { get; set; }

            [JsonProperty(PropertyName = "effectBurn")]
            public List<string> effectBurn { get; set; }

            [JsonProperty(PropertyName = "id")]
            public string id { get; set; }

            [JsonProperty(PropertyName = "image")]
            public ImageDTO image { get; set; }

            [JsonProperty(PropertyName = "key")]
            public string key { get; set; }

            [JsonProperty(PropertyName = "maxrank")]
            public int maxrank { get; set; }

            [JsonProperty(PropertyName = "modes")]
            public List<string> modes { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string name { get; set; }

            [JsonProperty(PropertyName = "range")]
            public object range { get; set; }

            [JsonProperty(PropertyName = "rangeBurn")]
            public string rangeBurn { get; set; }

            [JsonProperty(PropertyName = "resource")]
            public string resource { get; set; }

            [JsonProperty(PropertyName = "summonerLevel")]
            public int summonerLevel { get; set; }

            [JsonProperty(PropertyName = "tooltip")]
            public string tooltip { get; set; }

            [JsonProperty(PropertyName = "vars")]
            public List<SummonerSpellVarsDto> vars { get; set; }

        }

        public class SummonerSpellVarsDto
        {
            [JsonProperty(PropertyName = "coeff")]
            public object coeff { get; set; }

            [JsonProperty(PropertyName = "key")]
            public string key { get; set; }

            [JsonProperty(PropertyName = "link")]
            public string link { get; set; }
        }

        #endregion SummonerSpellDto

        #region SummonerSpellListDto
        /*************************************************************************************************
         * URL: /api/lol/static-data/{region}/v1/summoner-spell
         * For: Retrieves summoner spell list.
         *************************************************************************************************/

        public class SummonerSpellListDto
        {
            [JsonProperty(PropertyName = "data")]
            public Dictionary<string, SummonerSpellDto> data { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string type { get; set; }

            [JsonProperty(PropertyName = "version")]
            public string version { get; set; }
        }

        #endregion SummonerSpellListDto

    #endregion lol-static-data-v1

    #region stats
        /***********************************************************************************************
        * Type: Response Classes
        * Return Value: PlayerStatsSummaryListDto
        * URL: /api/lol/{region}/v1.2/stats/by-summoner/{summonerId}/summary
        * Description:  Get player stats summaries by summoner ID. One summary is returned per queue type. 
        *             
        *      Path Parameters
        *      region - "na", "euw", "eune"
        *      summonerIdseason - long type
        *      
        * Returns Respone codes
        * - HTTP Status Code -----------  Reason --------
        *      400                     Bad request
        *      401                     Unauthorized
        *      500                     Internal server error
        *      404                     Summoner not found
        *      503                     Service unavailable
        ***********************************************************************************************/
        class stats_v1_2_Summary
        {

            public class PlayerStatsSummaryListDto
            {
                // List of player stats summaries associated with the summoner.
                List<PlayerStatsSummaryDto> playerStatSummaries { get; set; }

                // Summoner ID
                long summonerId { get; set; }
            }

            public class PlayerStatsSummaryDto
            {
                // Aggregated stats.
                AggregatedStatDTO aggregatedStats { get; set; }

                // Number of losses for this queue type. Returned for ranked queue types only.
                int losses { get; set; }

                // Date stats were last modified specified as epoch milliseconds.
                long modifyDate { get; set; }

                // Player stats summary type. (legal values: AramUnranked5x5, CoopVsAI, CoopVsAI3x3, OdinUnranked, 
                // RankedPremade3x3, RankedPremade5x5, RankedSolo5x5, RankedTeam3x3, RankedTeam5x5, Unranked, Unranked3x3, 
                // OneForAll5x5, FirstBlood1x1, FirstBlood2x2)
                string playerStatSummaryType { get; set; }

                // Number of wins for this queue type.
                int wins { get; set; }
            }

            public class AggregatedStatDTO
            {
                // Dominion only
                int averageAssists { get; set; }

                // Dominion only
                int averageChampionsKilled { get; set; }

                // Dominion only
                int averageCombatPlayerScore { get; set; }

                // Dominion only.
                int averageNodeCapture { get; set; }

                // Dominion only.
                int averageNodeCaptureAssist { get; set; }

                // Dominion only.
                int averageNodeNeutralize { get; set; }

                // Dominion only.
                int averageNumDeaths { get; set; }

                // Dominion only.
                int averageObjectivePlayerScore { get; set; }

                // Dominion only.
                int averageTeamObjective { get; set; }

                // Dominion only.
                int averageTotalPlayerScore { get; set; }

                // Dominion and Normal
                int botGamesPlayed { get; set; }

                // Dominion and Normal
                int killingSpree { get; set; }

                // Dominion Only
                int maxAssists { get; set; }

                // Dominion and Normal
                int maxChampionsKilled { get; set; }

                // Dominion only.
                int maxCombatPlayerScore { get; set; }

                // Dominion and Normal
                int maxLargestCriticalStrike { get; set; }

                // Dominion and Normal
                int maxLargestKillingSpree { get; set; }

                // Dominion only.
                int maxNodeCapture { get; set; }

                // Dominion only.
                int maxNodeCaptureAssist { get; set; }

                // Dominion only.
                int maxNodeNeutralize { get; set; }

                // Dominion only.
                int maxNodeNeutralizeAssist { get; set; }

                // Only returned for ranked statistics.
                int maxNumDeaths { get; set; }

                // Dominion Only
                int maxObjectivePlayerScore { get; set; }

                // Dominion only.
                int maxTeamObjective { get; set; }

                // Dominion and Normal
                int maxTimePlayed { get; set; }

                // Dominion and Normal
                int maxTimeSpentLiving { get; set; }

                // Dominion only
                int maxTotalPlayerScore { get; set; }

                // Dominion and Normal
                int mostChampionKillsPerSession { get; set; }

                // Dominion and Normal
                int mostSpellsCast { get; set; }

                // Dominion and Normal
                int normalGamesPlayed { get; set; }

                // Dominion and Normal
                int rankedPremadeGamesPlayed { get; set; }

                // Dominion and Normal
                int rankedSoloGamesPlayed { get; set; }

                // Dominion and Normal
                int totalAssists { get; set; }

                // Dominion and Normal
                int totalChampionKills { get; set; }

                // Dominion and Normal
                int totalDamageDealt { get; set; }

                // Dominion and normal.
                int totalDamageTaken { get; set; }

                // Only returned for ranked statistics.
                int totalDeathsPerSession { get; set; }

                // Dominion and normal
                int totalDoubleKills { get; set; }

                // Dominion and normal.
                int totalFirstBlood { get; set; }

                // Dominion and normal
                int totalGoldEarned { get; set; }

                // Dominion and normal
                int totalHeal { get; set; }

                // Dominion and normal
                int totalMagicDamageDealt { get; set; }

                // Dominion and normal
                int totalMinionKills { get; set; }

                // Dominion and normal
                int totalNeutralMinionsKilled { get; set; }

                // Dominion only.
                int totalNodeCapture { get; set; }

                // Dominoin only.
                int totalNodeNeutralize { get; set; }

                // Dominion and normal
                int totalPentaKills { get; set; }

                // Dominion and normal
                int totalPhysicalDamageDealt { get; set; }

                // Dominion and normal
                int totalQuadraKills { get; set; }

                // Dominion and normal
                int totalSessionsLost { get; set; }

                // Dominion and normal
                int totalSessionsPlayed { get; set; }

                // Dominion and normal
                int totalSessionsWon { get; set; }

                // Dominion and normal
                int totalTripleKills { get; set; }

                // Dominion and normal
                int totalTurretsKilled { get; set; }

                // Dominion and normal
                int totalUnrealKills { get; set; }
            }
        }

        /***********************************************************************************************
         * Type: Response Classes
         * Return Value: RankedStatsDto
         * URL: /api/lol/{region}/v1.2/stats/by-summoner/{summonerId}/ranked?season={season}&api_key={key}
         * Descriptin: Get ranked stats by summoner ID. Includes statistics for Twisted Treeline and 
         *             Summoner's Rift.
         *             
         *      Path Parameters
         *      region - "na", "euw", "eune"
         *      summonerIdseason - long type
         *      season - "SEASON3", "SEASON4"
         *      
         * Returns Respone codes
         * - HTTP Status Code -----------  Reason --------
         *      400                     Bad request
         *      401                     Unauthorized
         *      500                     Internal server error
         *      404                     Summoner not found
         *      503                     Service unavailable
         **********************************************************************************************/
        public class stats_v1_2_Ranked
        {
            public class RankedStatsDto
            {
                // List of aggregated stats summarized by champion.
                public List<ChampionStatsDto> champions { get; set; }

                // Date stats were last modified specified as epoch milliseconds.
                public long modifyDate { get; set; }

                // Summoner ID.
                public long summonerId { get; set; }
            }

            public class ChampionStatsDto
            {
                // Champion id.
                public int id { get; set; }

                // Champion name.
                public string name { get; set; }

                // Aggregated stats associated with the champion.
                public AggregatedStatsDto stats { get; set; }
            }

            public class AggregatedStatsDto
            {
                int averageAssists { get; set; } 	// Dominion only.
                int averageChampionsKilled { get; set; }	//	Dominion only.
                int averageCombatPlayerScore { get; set; }	// Dominion only.
                int averageNodeCapture { get; set; }	// 	Dominion only.
                int averageNodeCaptureAssist { get; set; }	// 	Dominion only.
                int averageNodeNeutralize { get; set; }	// 	Dominion only.
                int averageNodeNeutralizeAssist { get; set; }	// 	Dominion only.
                int averageNumDeaths { get; set; }	// 	Dominion only.
                int averageObjectivePlayerScore { get; set; }	// 	Dominion only.
                int averageTeamObjective { get; set; }	// 	Dominion only.
                int averageTotalPlayerScore { get; set; }	// 	Dominion only.
                int botGamesPlayed { get; set; }	// 	
                int killingSpree { get; set; }	// 	
                int maxAssists { get; set; }	// 	Dominion only.
                int maxChampionsKilled { get; set; }	// 	
                int maxCombatPlayerScore { get; set; }	// 	Dominion only.
                int maxLargestCriticalStrike { get; set; }	// 	
                int maxLargestKillingSpree { get; set; }	// 	
                int maxNodeCapture { get; set; }	// 	Dominion only.
                int maxNodeCaptureAssist { get; set; }	// 	Dominion only.
                int maxNodeNeutralize { get; set; }	// 	Dominion only.
                int maxNodeNeutralizeAssist { get; set; }	// 	Dominion only.
                int maxNumDeaths { get; set; }	// 	Only returned for ranked statistics.
                int maxObjectivePlayerScore { get; set; }	// 	Dominion only.
                int maxTeamObjective { get; set; }	// 	Dominion only.
                int maxTimePlayed { get; set; }	// 	
                int maxTimeSpentLiving { get; set; }	// 	
                int maxTotalPlayerScore { get; set; }	// 	Dominion only.
                int mostChampionKillsPerSession { get; set; }	// 	
                int mostSpellsCast { get; set; }	// 	
                int normalGamesPlayed { get; set; }	// 	
                int rankedPremadeGamesPlayed { get; set; }	// 	
                int rankedSoloGamesPlayed { get; set; }	// 	
                int totalAssists { get; set; }	// 	
                int totalChampionKills { get; set; }	// 	
                int totalDamageDealt { get; set; }	// 	
                int totalDamageTaken { get; set; }	// 	
                int totalDeathsPerSession { get; set; }	// 	Only returned for ranked statistics.
                int totalDoubleKills { get; set; }	// 	
                int totalFirstBlood { get; set; }	// 	
                int totalGoldEarned { get; set; }	// 	
                int totalHeal { get; set; }	// 	
                int totalMagicDamageDealt { get; set; }	// 	
                int totalMinionKills { get; set; }	// 	
                int totalNeutralMinionsKilled { get; set; }	// 	
                int totalNodeCapture { get; set; }	// 	Dominion only.
                int totalNodeNeutralize { get; set; }	// 	Dominion only.
                int totalPentaKills { get; set; }	// 	
                int totalPhysicalDamageDealt { get; set; }	// 	
                int totalQuadraKills { get; set; }	// 	
                int totalSessionsLost { get; set; }	// 	
                int totalSessionsPlayed { get; set; }	// 	
                int totalSessionsWon { get; set; }	// 	
                int totalTripleKills { get; set; }	// 	
                int totalTurretsKilled { get; set; }	// 	
                int totalUnrealKills { get; set; }	// 
            }
        }

    #endregion

    #region summonerProfile
     /***********************************************************************************************
     * Type: Response Classes
     * Return Value: Map[string, MasteryPagesDto]
     * URL: /api/lol/{region}/v1.3/summoner/{summonerIds}/masteries
     * Descriptin: Get's summoner's rune page from server.
     *             
     *      Path Parameters
     *      region - "na", "euw", "eune"
     *      summonerIdseason - long
     *      
     * Returns Respone codes
     * - HTTP Status Code -----------  Reason --------
     *      400                     Bad request
     *      401                     Unauthorized
     *      500                     Internal server error
     *      404                     Summoner not found
     *      503                     Service unavailable
     **********************************************************************************************/
        public class summonerProfile
        {
            #region Masteries
            // Holds the name & dictionary of all Mastery pages for a summoner.
            public Dictionary<string, MasteryPages> summonerMasteryBook { get; set; }

            public class MasteryPages
            {
                // List of mastery pages associated with the summoner.
                public List<MasteryPage> pages { get; set; }

                // Summoner Id.
                public long summonerId { get; set; }
            }

            public class MasteryPage
            {
                // Indicates if the mastery page is the current mastery page.
                bool current { get; set; }

                // Mastery page ID.
                long id { get; set; }

                // Mastery page name.
                string name { get; set; }

                // List of mastery page talents associated with the mastery page.
                List<Talent> talents { get; set; }
            }

            public class Talent
            {
                // Talent id.
                int id { get; set; }

                // Talent name.
                string name { get; set; }

                // Talent rank.
                int rank { get; set; }
            }

            #endregion

            #region SummonerRuneBook
            public Dictionary<string, summonerRunePages> summonerRuneBook { get; set; }

            public class summonerRunePages
            {
                // Set of rune pages associated with the summoner.
                public List<Page> pages { get; set; }

                // Summoner ID.
                public int summonerId { get; set; }
            }

            public class Page
            {
                // Rune page ID.
                public long id { get; set; }

                // List of rune slots associated with the rune page.
                public List<RuneSlot> slots { get; set; }

                // Rune page name.
                public string name { get; set; }

                // Indicates if the page is the current page.
                public bool current { get; set; }
            }

            public class RuneSlot
            {
                // Rune slot ID.
                public int runeSlotId { get; set; }

                // Rune associated with the rune slot.
                public Rune rune { get; set; }
            }

            public class Rune
            {
                // Rune ID.
                public int id { get; set; }

                // Rune description.
                public string description { get; set; }

                // Rune name.
                public string name { get; set; }

                // Rune tier.
                public int tier { get; set; }
            }

            #endregion

            #region SummonerNames
            /************************************************************************************************
             * Riot Notes: The response object contains the summoner objects mapped by the standardized 
             * summoner name, which is the summoner name in all lower case and with spaces removed. Use 
             * this version of the name when checking if the returned object contains the data for a 
             * given summoner.
             ***********************************************************************************************/
            public Dictionary<string, SummonerNames> mapSummonerNames { get; set; }

            public class SummonerNames
            {
                // Summoner Id
                public long id;

                // Summoner Name
                public string name;

                // ID of the summoner icon associated with the summoner.
                public int profileIconId;

                // Date summoner was last modified specified as epoch milliseconds.
                public long revsionDate;

                // Summoner level associated with the summoner.
                public long summonerLevel;
            }
            #endregion

            /**************************************************************************************
             * /api/lol/{region}/v1.3/summoner/{summonerIds}/name
             * Get summoner names mapped by summoner ID for a given list of summoner IDs.
             *************************************************************************************/
            public Dictionary<long, string> dictionarySummonerIdToName;

            /**************************************************************************************
             * /api/lol/{region}/v1.3/summoner/{summonerIds}
             * Get summoner objects mapped by summoner ID for a given list of summoner IDs.
             *************************************************************************************/
            public Dictionary<string, Summoner> listSummoners;

            public class Summoner
            {
                // Summoner ID.
                public long Id;
                // Summoner name.
                public string name;
                // ID of the summoner icon associated with the summoner.
                public int profileIconId;
                // Date summoner was last modified specified as epoch milliseconds.
                public long revisionDate;
                // Summoner level associated with the summoner.
                public long summonerLevel;
            }
        }
    #endregion

    #region Team v2.2

        public class SummonerTeam
        {
            List<Team> teams { get; set; }
        }
        public class Team
        {
            // Note: Object are of type Date

            public object createDate;
            public string fullId;
            public object lastGameDate;
            public object lastJoinDate;
            public object lastJoinedRankedTeamQueueDate;
            public List<MatchHistorySummary> matchHistory;
            public MessageOfDay messageOfDay;
            public object modifyDate;
            public string name;
            public Roster roster;
            public string status;
            public string tag;
            public TeamStatSummary teamStatSummary;
            public object thirdLastJoinDate;
        }

        public class MatchHistorySummary
        {
            public int assists;
            public int deaths;
            public long gameId;
            public string gameMode;
            public bool invalid;
            public int kills;
            public int mapId;
            public int opposingTeamKills;
            public string opposingTeamName;
            public bool win;
        }

        public class MessageOfDay
        {
            public long createDate;
            public string message;
            public int version;
        }

        public class Roster
        {
            public List<TeamMemberInfo> memberList;
            public long ownerId;
        }

        public class TeamStatSummary
        {
            public string fullId;
            public List<TeamStatDetail> teamStatDetail;
        }

        public class TeamMemberInfo
        {
            public object inviteDate;
            public object joinDate;
            public long playerId;
            public string status;
        }

        public class TeamStatDetail
        {
            public int averageGamesPlayed;
            public string fullId;
            public int losses;
            public string teamStatType;
            public int wins;
        }

    #endregion
}



using Newtonsoft.Json;

/// <summary>
/// Get'
/// </summary>
public class ChampionMasteryDTO
{
    /// <summary>
    /// Is chest granted for this champion or not in current season.
    /// </summary>
    [JsonProperty(PropertyName = "chestGranted")]
    public bool chestGranted { get; set; }

    /// <summary>
    /// Champion level for the specified player and champion combination.
    /// </summary>
    [JsonProperty(PropertyName = "championLevel")]
    public int championLevel { get; set; }

    /// <summary>
    /// Total number of champion points for this player and champion combination - they are used to determine championLevel.
    /// </summary>
    [JsonProperty(PropertyName = "championPoints")]
    public int championPoints { get; set; }

    /// <summary>
    /// Champion ID for this entry
    /// </summary>
    [JsonProperty(PropertyName = "championId")]
    public long championId { get; set; }

    /// <summary>
    /// Player ID for this entry.
    /// </summary>
    [JsonProperty(PropertyName = "playerId")]
    public long playerId { get; set; }

    /// <summary>
    /// Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.
    /// </summary>
    [JsonProperty(PropertyName = "championPointsUntilNextLevel")]
    public long championPointsUntilNextLevel { get; set; }

    /// <summary>
    /// Number of points earned since current level has been achieved. Zero if player reached maximum champion level for this champion. 
    /// </summary>
    [JsonProperty(PropertyName = "championPointsSinceLastLevel")]
    public long championPointsSinceLastLevel { get; set; }

    /// <summary>
    /// Last time this champion was played by this player - in Unix milliseconds time format. 
    /// </summary>
    [JsonProperty(PropertyName = "lastPlayTime")]
    public long lastPlayTime { get; set; }

}


namespace OsuSharp.Objects;

/// <summary>
/// Hello
/// </summary>
public class Beatmap
{
    /// <summary>
    /// Status of the Beatmap
    /// 4 = Loved, 3 = qualified, 2 = approved, 1 = ranked, 0 = pending, -1 = WIP, -2 = graveyard
    /// </summary>
    public BeatmapApprovedStatus ApprovedStatus { get; set; }
    /// <summary>
    /// The Date and time a Beatmap was submited, in UTC 
    /// </summary>
    public DateTime Submited { get; set; }
    /// <summary>
    /// The Date and time a Beatmap was ranked, in UTC
    /// </summary>
    public DateTime Approved { get; set; }
    /// <summary>
    /// The Date the Beatmap was last updated.
    /// </summary>
    public DateTime LastUpdated { get; set; }
    /// <summary>
    /// The Artist of the song used in the Beatmap
    /// </summary>
    public string Artist { get; set; }
    /// <summary>
    /// The Id of the current Beatmap (Id is per difficulty)
    /// </summary>
    public int BeatmapId { get; set; }
    /// <summary>
    /// THe Id of a Betamap difficulty group
    /// </summary>
    public int BeatmapsetID { get; set; }
    /// <summary>
    /// The number of beats in a minute for the Beatmap
    /// </summary>
    public int Bpm { get; set; }
    public string Creator { get; set; }
    public int CreatorId { get; set; }
    public float DifficultyRating { get; set; }
    public Difficulty Difficulty { get; set; }
}

public enum BeatmapApprovedStatus 
{
    loved = 4,
    qualified = 3,
    approved = 2,
    ranked = 1,
    pending = 0,
    WIP = -1,
    graveyard = -2
}

public struct Difficulty
{
    public float Rating { get; set; }
    public float Aim { get; set; }
    public float Speed { get; set; }
    public int CircleSize { get; set; }
    public int OverallDifficulty { get; set; }
}
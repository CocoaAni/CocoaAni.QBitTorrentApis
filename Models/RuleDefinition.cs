namespace CocoaAni.QBitTorrentApis.Models;

public class RuleDefinition
{
    public RuleDefinition(bool enabled, string mustContain, string mustNotContain, bool useRegex, string episodeFilter, bool smartFilter, List<string> previouslyMatchedEpisodes, List<string> affectedFeeds, int ignoreDays, string lastMatch, bool addPaused, string assignedCategory, string savePath)
    {
        Enabled = enabled;
        MustContain = mustContain;
        MustNotContain = mustNotContain;
        UseRegex = useRegex;
        EpisodeFilter = episodeFilter;
        SmartFilter = smartFilter;
        PreviouslyMatchedEpisodes = previouslyMatchedEpisodes;
        AffectedFeeds = affectedFeeds;
        IgnoreDays = ignoreDays;
        LastMatch = lastMatch;
        AddPaused = addPaused;
        AssignedCategory = assignedCategory;
        SavePath = savePath;
    }

    public RuleDefinition()
    {
        Enabled = default!;
        MustContain = default!;
        MustNotContain = default!;
        UseRegex = default!;
        EpisodeFilter = default!;
        SmartFilter = default!;
        PreviouslyMatchedEpisodes = default!;
        AffectedFeeds = default!;
        IgnoreDays = default!;
        LastMatch = default!;
        AddPaused = default!;
        AssignedCategory = default!;
        SavePath = default!;
    }

    /// <summary>
    /// Whether the rule is enabled
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// The substring that the torrent name must contain
    /// </summary>
    public string MustContain { get; set; }

    /// <summary>
    /// The substring that the torrent name must not contain
    /// </summary>
    public string MustNotContain { get; set; }

    /// <summary>
    /// Enable regex mode in "mustContain" and "mustNotContain"
    /// </summary>
    public bool UseRegex { get; set; }

    /// <summary>
    /// Episode filter definition
    /// </summary>
    public string EpisodeFilter { get; set; }

    /// <summary>
    /// Enable smart episode filter
    /// </summary>
    public bool SmartFilter { get; set; }

    /// <summary>
    /// The list of episode IDs already matched by smart filter
    /// </summary>
    public List<string> PreviouslyMatchedEpisodes { get; set; }

    /// <summary>
    /// The feed URLs the rule applied to
    /// </summary>
    public List<string> AffectedFeeds { get; set; }

    /// <summary>
    /// Ignore sunsequent rule matches
    /// </summary>
    public int IgnoreDays { get; set; }

    /// <summary>
    /// The rule last match time
    /// </summary>
    public string LastMatch { get; set; }

    /// <summary>
    /// Add matched torrent in paused mode
    /// </summary>
    public bool AddPaused { get; set; }

    /// <summary>
    /// Assign category to the torrent
    /// </summary>
    public string AssignedCategory { get; set; }

    /// <summary>
    /// Save torrent to the given directory
    /// </summary>
    public string SavePath { get; set; }
}
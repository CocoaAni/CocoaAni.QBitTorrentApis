namespace CocoaAni.QBitTorrentApis.Models;

public class Torrent
{
    public Torrent(int addedOn, int amountLeft, bool autoTmm, float availability, string category, int completed, int completionOn, string contentPath, int dlLimit, int dlspeed, int downloaded, int downloadedSession, int eta, bool flPiecePrio, bool forceStart, string hash, int lastActivity, string magnetUri, float maxRatio, int maxSeedingTime, string name, int numComplete, int numIncomplete, int numLeechs, int numSeeds, int priority, float progress, float ratio, float ratioLimit, string savePath, int seedingTime, int seedingTimeLimit, int seenComplete, bool seqDl, int size, string state, bool superSeeding, string tags, int timeActive, int totalSize, string tracker, int upLimit, int uploaded, int uploadedSession, int upspeed)
    {
        AddedOn = addedOn;
        AmountLeft = amountLeft;
        AutoTmm = autoTmm;
        Availability = availability;
        Category = category;
        Completed = completed;
        CompletionOn = completionOn;
        ContentPath = contentPath;
        DlLimit = dlLimit;
        Dlspeed = dlspeed;
        Downloaded = downloaded;
        DownloadedSession = downloadedSession;
        Eta = eta;
        FLPiecePrio = flPiecePrio;
        ForceStart = forceStart;
        Hash = hash;
        LastActivity = lastActivity;
        MagnetUri = magnetUri;
        MaxRatio = maxRatio;
        MaxSeedingTime = maxSeedingTime;
        Name = name;
        NumComplete = numComplete;
        NumIncomplete = numIncomplete;
        NumLeechs = numLeechs;
        NumSeeds = numSeeds;
        Priority = priority;
        Progress = progress;
        Ratio = ratio;
        RatioLimit = ratioLimit;
        SavePath = savePath;
        SeedingTime = seedingTime;
        SeedingTimeLimit = seedingTimeLimit;
        SeenComplete = seenComplete;
        SeqDl = seqDl;
        Size = size;
        State = state;
        SuperSeeding = superSeeding;
        Tags = tags;
        TimeActive = timeActive;
        TotalSize = totalSize;
        Tracker = tracker;
        UpLimit = upLimit;
        Uploaded = uploaded;
        UploadedSession = uploadedSession;
        Upspeed = upspeed;
    }

    public Torrent()
    {
        AddedOn = default!;
        AmountLeft = default!;
        AutoTmm = default!;
        Availability = default!;
        Category = default!;
        Completed = default!;
        CompletionOn = default!;
        ContentPath = default!;
        DlLimit = default!;
        Dlspeed = default!;
        Downloaded = default!;
        DownloadedSession = default!;
        Eta = default!;
        FLPiecePrio = default!;
        ForceStart = default!;
        Hash = default!;
        LastActivity = default!;
        MagnetUri = default!;
        MaxRatio = default!;
        MaxSeedingTime = default!;
        Name = default!;
        NumComplete = default!;
        NumIncomplete = default!;
        NumLeechs = default!;
        NumSeeds = default!;
        Priority = default!;
        Progress = default!;
        Ratio = default!;
        RatioLimit = default!;
        SavePath = default!;
        SeedingTime = default!;
        SeedingTimeLimit = default!;
        SeenComplete = default!;
        SeqDl = default!;
        Size = default!;
        State = default!;
        SuperSeeding = default!;
        Tags = default!;
        TimeActive = default!;
        TotalSize = default!;
        Tracker = default!;
        UpLimit = default!;
        Uploaded = default!;
        UploadedSession = default!;
        Upspeed = default!;
    }

    /// <summary>
    /// Time (Unix Epoch) when the torrent was added to the client
    /// </summary>
    public int AddedOn { get; set; }

    /// <summary>
    /// Amount of data left to download (bytes)
    /// </summary>
    public int AmountLeft { get; set; }

    /// <summary>
    /// Whether this torrent is managed by Automatic Torrent Management
    /// </summary>
    public bool AutoTmm { get; set; }

    /// <summary>
    /// Percentage of file pieces currently available
    /// </summary>
    public float Availability { get; set; }

    /// <summary>
    /// Category of the torrent
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    /// Amount of transfer data completed (bytes)
    /// </summary>
    public int Completed { get; set; }

    /// <summary>
    /// Time (Unix Epoch) when the torrent completed
    /// </summary>
    public int CompletionOn { get; set; }

    /// <summary>
    /// Absolute path of torrent content (root path for multifile torrents, absolute file path for singlefile torrents)
    /// </summary>
    public string ContentPath { get; set; }

    /// <summary>
    /// Torrent download speed limit (bytes/s). -1 if ulimited.
    /// </summary>
    public int DlLimit { get; set; }

    /// <summary>
    /// Torrent download speed (bytes/s)
    /// </summary>
    public int Dlspeed { get; set; }

    /// <summary>
    /// Amount of data downloaded
    /// </summary>
    public int Downloaded { get; set; }

    /// <summary>
    /// Amount of data downloaded this session
    /// </summary>
    public int DownloadedSession { get; set; }

    /// <summary>
    /// Torrent ETA (seconds)
    /// </summary>
    public int Eta { get; set; }

    /// <summary>
    /// True if first last piece are prioritized
    /// </summary>
    public bool FLPiecePrio { get; set; }

    /// <summary>
    /// True if force start is enabled for this torrent
    /// </summary>
    public bool ForceStart { get; set; }

    /// <summary>
    /// Torrent hash
    /// </summary>
    public string Hash { get; set; }

    /// <summary>
    /// Last time (Unix Epoch) when a chunk was downloaded/uploaded
    /// </summary>
    public int LastActivity { get; set; }

    /// <summary>
    /// Magnet URI corresponding to this torrent
    /// </summary>
    public string MagnetUri { get; set; }

    /// <summary>
    /// Maximum share ratio until torrent is stopped from seeding/uploading
    /// </summary>
    public float MaxRatio { get; set; }

    /// <summary>
    /// Maximum seeding time (seconds) until torrent is stopped from seeding
    /// </summary>
    public int MaxSeedingTime { get; set; }

    /// <summary>
    /// Torrent name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Number of seeds in the swarm
    /// </summary>
    public int NumComplete { get; set; }

    /// <summary>
    /// Number of leechers in the swarm
    /// </summary>
    public int NumIncomplete { get; set; }

    /// <summary>
    /// Number of leechers connected to
    /// </summary>
    public int NumLeechs { get; set; }

    /// <summary>
    /// Number of seeds connected to
    /// </summary>
    public int NumSeeds { get; set; }

    /// <summary>
    /// Torrent priority. Returns -1 if queuing is disabled or torrent is in seed mode
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Torrent progress (percentage/100)
    /// </summary>
    public float Progress { get; set; }

    /// <summary>
    /// Torrent share ratio. Max ratio value: 9999.
    /// </summary>
    public float Ratio { get; set; }

    /// <summary>
    /// TODO (what is different from max_ratio?)
    /// </summary>
    public float RatioLimit { get; set; }

    /// <summary>
    /// Path where this torrent's data is stored
    /// </summary>
    public string SavePath { get; set; }

    /// <summary>
    /// Torrent elapsed time while complete (seconds)
    /// </summary>
    public int SeedingTime { get; set; }

    /// <summary>
    /// TODO (what is different from max_seeding_time?) seeding_time_limit is a per torrent setting, when Automatic Torrent Management is disabled, furthermore then max_seeding_time is set to seeding_time_limit for this torrent. If Automatic Torrent Management is enabled, the value is -2. And if max_seeding_time is unset it have a default value -1.
    /// </summary>
    public int SeedingTimeLimit { get; set; }

    /// <summary>
    /// Time (Unix Epoch) when this torrent was last seen complete
    /// </summary>
    public int SeenComplete { get; set; }

    /// <summary>
    /// True if sequential download is enabled
    /// </summary>
    public bool SeqDl { get; set; }

    /// <summary>
    /// Total size (bytes) of files selected for download
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Torrent state. See table here below for the possible values
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// True if super seeding is enabled
    /// </summary>
    public bool SuperSeeding { get; set; }

    /// <summary>
    /// Comma-concatenated tag list of the torrent
    /// </summary>
    public string Tags { get; set; }

    /// <summary>
    /// Total active time (seconds)
    /// </summary>
    public int TimeActive { get; set; }

    /// <summary>
    /// Total size (bytes) of all file in this torrent (including unselected ones)
    /// </summary>
    public int TotalSize { get; set; }

    /// <summary>
    /// The first tracker with working status. Returns empty string if no tracker is working.
    /// </summary>
    public string Tracker { get; set; }

    /// <summary>
    /// Torrent upload speed limit (bytes/s). -1 if ulimited.
    /// </summary>
    public int UpLimit { get; set; }

    /// <summary>
    /// Amount of data uploaded
    /// </summary>
    public int Uploaded { get; set; }

    /// <summary>
    /// Amount of data uploaded this session
    /// </summary>
    public int UploadedSession { get; set; }

    /// <summary>
    /// Torrent upload speed (bytes/s)
    /// </summary>
    public int Upspeed { get; set; }
}
using CocoaAni.QBitTorrentApis.Enums;

namespace CocoaAni.QBitTorrentApis.Models;


public class Tracker
{

    public Tracker(string url, TrackerStatus status, int tier, int numPeers, int numSeeds, int numLeeches, int numDownloaded, string msg)
    {
        Url = url;
        Status = status;
        Tier = tier;
        NumPeers = numPeers;
        NumSeeds = numSeeds;
        NumLeeches = numLeeches;
        NumDownloaded = numDownloaded;
        Msg = msg;
    }

    public Tracker()
    {
        Url = default!;
        Status = default!;
        Tier = default!;
        NumPeers = default!;
        NumSeeds = default!;
        NumLeeches = default!;
        NumDownloaded = default!;
        Msg = default!;
    }

    /// <summary>
    /// Tracker url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Tracker status. See the table below for possible values
    /// </summary>
    public TrackerStatus Status { get; set; }

    /// <summary>
    /// Tracker priority tier. Lower tier trackers are tried before higher tiers. Tier numbers are valid when >= 0, Less than 0 is used as placeholder when tier does not exist for special entries (such as DHT).
    /// </summary>
    public int Tier { get; set; }

    /// <summary>
    /// Number of peers for current torrent, as reported by the tracker
    /// </summary>
    public int NumPeers { get; set; }

    /// <summary>
    /// Number of seeds for current torrent, asreported by the tracker
    /// </summary>
    public int NumSeeds { get; set; }

    /// <summary>
    /// Number of leeches for current torrent, as reported by the tracker
    /// </summary>
    public int NumLeeches { get; set; }

    /// <summary>
    /// Number of completed downlods for current torrent, as reported by the tracker
    /// </summary>
    public int NumDownloaded { get; set; }

    /// <summary>
    /// Tracker message (there is no way of knowing what this message is - it's up to tracker admins)
    /// </summary>
    public string Msg { get; set; }
}
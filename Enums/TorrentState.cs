namespace CocoaAni.QBitTorrentApis.Enums;

public class TorrentState
{
    /// <summary>
    /// Some error occurred, applies to paused torrents
    /// </summary>
    public static string Error { get; } = "error";

    /// <summary>
    /// Torrent data files is missing
    /// </summary>
    public static string MissingFiles { get; } = "missingFiles";

    /// <summary>
    /// Torrent is being seeded and data is being transferred
    /// </summary>
    public static string Uploading { get; } = "uploading";

    /// <summary>
    ///  Torrent is paused and has finished downloading
    /// </summary>
    public static string PausedUp { get; } = "pausedUP";

    /// <summary>
    /// Queuing is enabled and torrent is queued for upload
    /// </summary>
    public static string QueuedUp { get; } = "queuedUP";

    /// <summary>
    /// Torrent is being seeded, but no connection were made
    /// </summary>
    public static string StalledUp { get; } = "stalledUP";

    /// <summary>
    ///  Torrent has finished downloading and is being checked
    /// </summary>
    public static string CheckingUp { get; } = "checkingUP";

    /// <summary>
    ///   Torrent is forced to uploading and ignore queue limit
    /// </summary>
    public static string ForcedUp { get; } = "forcedUP";

    /// <summary>
    ///    Torrent is allocating disk space for download
    /// </summary>
    public static string Allocating { get; } = "allocating";

    /// <summary>
    /// Torrent is being downloaded and data is being transferred
    /// </summary>
    public static string Downloading { get; } = "downloading";

    /// <summary>
    /// Torrent has just started downloading and is fetching metadata
    /// </summary>
    public static string MetaDl { get; } = "metaDL";

    /// <summary>
    /// Torrent is paused and has NOT finished downloading
    /// </summary>
    public static string PausedDl { get; } = "pausedDL";

    /// <summary>
    /// Queuing is enabled and torrent is queued for download
    /// </summary>
    public static string QueuedDl { get; } = "queuedDL";

    /// <summary>
    /// Torrent is being downloaded, but no connection were made
    /// </summary>
    public static string StalledDl { get; } = "stalledDL";

    /// <summary>
    /// Same as checkingUP, but torrent has NOT finished downloading
    /// </summary>
    public static string CheckingDl { get; } = "checkingDL";

    /// <summary>
    /// Torrent is forced to downloading to ignore queue limit
    /// </summary>
    public static string ForcedDl { get; } = "forcedDL";

    /// <summary>
    /// Checking resume data on qBt startup
    /// </summary>
    public static string CheckingResumeData { get; } = "checkingResumeData";

    /// <summary>
    ///  Torrent is moving to another location
    /// </summary>
    public static string Moving { get; } = "moving";

    /// <summary>
    /// unknown Unknown status
    /// </summary>
    public static string Unknown { get; } = "unknown";
}
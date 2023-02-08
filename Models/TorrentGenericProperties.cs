namespace CocoaAni.QBitTorrentApis.Models;

public class TorrentGenericProperties
{
    public TorrentGenericProperties(string savePath, int creationDate, int pieceSize, string comment, int totalWasted, int totalUploaded, int totalUploadedSession, int totalDownloaded, int totalDownloadedSession, int upLimit, int dlLimit, int timeElapsed, int seedingTime, int nbConnections, int nbConnectionsLimit, float shareRatio, int additionDate, int completionDate, string createdBy, int dlSpeedAvg, int dlSpeed, int eta, int lastSeen, int peers, int peersTotal, int piecesHave, int piecesNum, int reannounce, int seeds, int seedsTotal, int totalSize, int upSpeedAvg, int upSpeed)
    {
        SavePath = savePath;
        CreationDate = creationDate;
        PieceSize = pieceSize;
        Comment = comment;
        TotalWasted = totalWasted;
        TotalUploaded = totalUploaded;
        TotalUploadedSession = totalUploadedSession;
        TotalDownloaded = totalDownloaded;
        TotalDownloadedSession = totalDownloadedSession;
        UpLimit = upLimit;
        DlLimit = dlLimit;
        TimeElapsed = timeElapsed;
        SeedingTime = seedingTime;
        NbConnections = nbConnections;
        NbConnectionsLimit = nbConnectionsLimit;
        ShareRatio = shareRatio;
        AdditionDate = additionDate;
        CompletionDate = completionDate;
        CreatedBy = createdBy;
        DlSpeedAvg = dlSpeedAvg;
        DlSpeed = dlSpeed;
        Eta = eta;
        LastSeen = lastSeen;
        Peers = peers;
        PeersTotal = peersTotal;
        PiecesHave = piecesHave;
        PiecesNum = piecesNum;
        Reannounce = reannounce;
        Seeds = seeds;
        SeedsTotal = seedsTotal;
        TotalSize = totalSize;
        UpSpeedAvg = upSpeedAvg;
        UpSpeed = upSpeed;
    }

    public TorrentGenericProperties()
    {
        SavePath = default!;
        CreationDate = default!;
        PieceSize = default!;
        Comment = default!;
        TotalWasted = default!;
        TotalUploaded = default!;
        TotalUploadedSession = default!;
        TotalDownloaded = default!;
        TotalDownloadedSession = default!;
        UpLimit = default!;
        DlLimit = default!;
        TimeElapsed = default!;
        SeedingTime = default!;
        NbConnections = default!;
        NbConnectionsLimit = default!;
        ShareRatio = default!;
        AdditionDate = default!;
        CompletionDate = default!;
        CreatedBy = default!;
        DlSpeedAvg = default!;
        DlSpeed = default!;
        Eta = default!;
        LastSeen = default!;
        Peers = default!;
        PeersTotal = default!;
        PiecesHave = default!;
        PiecesNum = default!;
        Reannounce = default!;
        Seeds = default!;
        SeedsTotal = default!;
        TotalSize = default!;
        UpSpeedAvg = default!;
        UpSpeed = default!;
    }

    /// <summary>
    /// Torrent save path
    /// </summary>
    public string SavePath { get; set; }

    /// <summary>
    /// Torrent creation date (Unix timestamp)
    /// </summary>
    public int CreationDate { get; set; }

    /// <summary>
    /// Torrent piece size (bytes)
    /// </summary>
    public int PieceSize { get; set; }

    /// <summary>
    /// Torrent comment
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Total data wasted for torrent (bytes)
    /// </summary>
    public int TotalWasted { get; set; }

    /// <summary>
    /// Total data uploaded for torrent (bytes)
    /// </summary>
    public int TotalUploaded { get; set; }

    /// <summary>
    /// Total data uploaded this session (bytes)
    /// </summary>
    public int TotalUploadedSession { get; set; }

    /// <summary>
    /// Total data downloaded for torrent (bytes)
    /// </summary>
    public int TotalDownloaded { get; set; }

    /// <summary>
    /// Total data downloaded this session (bytes)
    /// </summary>
    public int TotalDownloadedSession { get; set; }

    /// <summary>
    /// Torrent upload limit (bytes/s)
    /// </summary>
    public int UpLimit { get; set; }

    /// <summary>
    /// Torrent download limit (bytes/s)
    /// </summary>
    public int DlLimit { get; set; }

    /// <summary>
    /// Torrent elapsed time (seconds)
    /// </summary>
    public int TimeElapsed { get; set; }

    /// <summary>
    /// Torrent elapsed time while complete (seconds)
    /// </summary>
    public int SeedingTime { get; set; }

    /// <summary>
    /// Torrent connection count
    /// </summary>
    public int NbConnections { get; set; }

    /// <summary>
    /// Torrent connection count limit
    /// </summary>
    public int NbConnectionsLimit { get; set; }

    /// <summary>
    /// Torrent share ratio
    /// </summary>
    public float ShareRatio { get; set; }

    /// <summary>
    /// When this torrent was added (unix timestamp)
    /// </summary>
    public int AdditionDate { get; set; }

    /// <summary>
    /// Torrent completion date (unix timestamp)
    /// </summary>
    public int CompletionDate { get; set; }

    /// <summary>
    /// Torrent creator
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Torrent average download speed (bytes/second)
    /// </summary>
    public int DlSpeedAvg { get; set; }

    /// <summary>
    /// Torrent download speed (bytes/second)
    /// </summary>
    public int DlSpeed { get; set; }

    /// <summary>
    /// Torrent ETA (seconds)
    /// </summary>
    public int Eta { get; set; }

    /// <summary>
    /// Last seen complete date (unix timestamp)
    /// </summary>
    public int LastSeen { get; set; }

    /// <summary>
    /// Number of peers connected to
    /// </summary>
    public int Peers { get; set; }

    /// <summary>
    /// Number of peers in the swarm
    /// </summary>
    public int PeersTotal { get; set; }

    /// <summary>
    /// Number of pieces owned
    /// </summary>
    public int PiecesHave { get; set; }

    /// <summary>
    /// Number of pieces of the torrent
    /// </summary>
    public int PiecesNum { get; set; }

    /// <summary>
    /// Number of seconds until the next announce
    /// </summary>
    public int Reannounce { get; set; }

    /// <summary>
    /// Number of seeds connected to
    /// </summary>
    public int Seeds { get; set; }

    /// <summary>
    /// Number of seeds in the swarm
    /// </summary>
    public int SeedsTotal { get; set; }

    /// <summary>
    /// Torrent total size (bytes)
    /// </summary>
    public int TotalSize { get; set; }

    /// <summary>
    /// Torrent average upload speed (bytes/second)
    /// </summary>
    public int UpSpeedAvg { get; set; }

    /// <summary>
    /// Torrent upload speed (bytes/second)
    /// </summary>
    public int UpSpeed { get; set; }
}
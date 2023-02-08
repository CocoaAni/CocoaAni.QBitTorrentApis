namespace CocoaAni.QBitTorrentApis.Models;

public class GlobalTransferInfo
{
    public GlobalTransferInfo()
    {
        DlInfoSpeed = default!;
        DlInfoData = default!;
        UpInfoSpeed = default!;
        UpInfoData = default!;
        DlRateLimit = default!;
        UpRateLimit = default!;
        DhtNodes = default!;
        ConnectionStatus = default!;
        Queueing = default!;
        UseAltSpeedLimits = default!;
        RefreshInterval = default!;
    }

    public GlobalTransferInfo(int dlInfoSpeed, int dlInfoData, int upInfoSpeed, int upInfoData, int dlRateLimit, int upRateLimit, int dhtNodes, string connectionStatus, bool queueing, bool useAltSpeedLimits, int refreshInterval)
    {
        DlInfoSpeed = dlInfoSpeed;
        DlInfoData = dlInfoData;
        UpInfoSpeed = upInfoSpeed;
        UpInfoData = upInfoData;
        DlRateLimit = dlRateLimit;
        UpRateLimit = upRateLimit;
        DhtNodes = dhtNodes;
        ConnectionStatus = connectionStatus;
        Queueing = queueing;
        UseAltSpeedLimits = useAltSpeedLimits;
        RefreshInterval = refreshInterval;
    }

    /// <summary>
    /// Global download rate (bytes/s)
    /// </summary>
    public int DlInfoSpeed { get; set; }

    /// <summary>
    /// Data downloaded this session (bytes)
    /// </summary>
    public int DlInfoData { get; set; }

    /// <summary>
    /// Global upload rate (bytes/s)
    /// </summary>
    public int UpInfoSpeed { get; set; }

    /// <summary>
    /// Data uploaded this session (bytes)
    /// </summary>
    public int UpInfoData { get; set; }

    /// <summary>
    /// Download rate limit (bytes/s)
    /// </summary>
    public int DlRateLimit { get; set; }

    /// <summary>
    /// Upload rate limit (bytes/s)
    /// </summary>
    public int UpRateLimit { get; set; }

    /// <summary>
    /// DHT nodes connected to
    /// </summary>
    public int DhtNodes { get; set; }

    /// <summary>
    /// Connection status. See possible values here below
    /// </summary>
    public string ConnectionStatus { get; set; }

    /// <summary>
    /// True if torrent queueing is enabled
    /// </summary>
    public bool Queueing { get; set; }

    /// <summary>
    /// True if alternative speed limits are enabled
    /// </summary>
    public bool UseAltSpeedLimits { get; set; }

    /// <summary>
    /// Transfer list refresh interval (milliseconds)
    /// </summary>
    public int RefreshInterval { get; set; }
}
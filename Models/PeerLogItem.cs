namespace CocoaAni.QBitTorrentApis.Models;

public class PeerLogItem
{
    public PeerLogItem(int id, string ip, int timestamp, bool blocked, string reason)
    {
        Id = id;
        Ip = ip;
        Timestamp = timestamp;
        Blocked = blocked;
        Reason = reason;
    }

    public PeerLogItem()
    {
        Id = default!;
        Ip = default!;
        Timestamp = default!;
        Blocked = default!;
        Reason = default!;
    }

    /// <summary>
    /// ID of the peer
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// IP of the peer
    /// </summary>
    public string Ip { get; set; }

    /// <summary>
    /// Milliseconds since epoch
    /// </summary>
    public int Timestamp { get; set; }

    /// <summary>
    /// Whether or not the peer was blocked
    /// </summary>
    public bool Blocked { get; set; }

    /// <summary>
    /// Reason of the block
    /// </summary>
    public string Reason { get; set; }
}
namespace CocoaAni.QBitTorrentApis.Models;

public class LogItem
{
    public LogItem(int id, string message, int timestamp, int type)
    {
        Id = id;
        Message = message;
        Timestamp = timestamp;
        Type = type;
    }

    public LogItem()
    {
        Id = default!;
        Message = default!;
        Timestamp = default!;
        Type = default!;
    }

    /// <summary>
    /// ID of the message
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Text of the message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Milliseconds since epoch
    /// </summary>
    public int Timestamp { get; set; }

    /// <summary>
    /// Type of the message: Log::NORMAL: 1, Log::INFO: 2, Log::WARNING: 4, Log::CRITICAL: 8
    /// </summary>
    public int Type { get; set; }
}
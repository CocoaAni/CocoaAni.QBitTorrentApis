namespace CocoaAni.QBitTorrentApis.Models;

public class SearchItemStatus
{
    public SearchItemStatus(int id, string status, int total)
    {
        Id = id;
        Status = status;
        Total = total;
    }

    public SearchItemStatus()
    {
        Id = default!;
        Status = default!;
        Total = default!;
    }

    /// <summary>
    /// ID of the search job
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Current status of the search job (either Running or Stopped)
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Total number of results. If the status is Running this number may contineu to increase
    /// </summary>
    public int Total { get; set; }
}
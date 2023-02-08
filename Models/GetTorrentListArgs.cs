namespace CocoaAni.QBitTorrentApis.Models;

public class GetTorrentListArgs
{
    /// <summary>
    /// Filter torrent list by state. Allowed state filters: all, downloading, seeding, completed, paused, active, inactive, resumed, stalled, stalled_uploading, stalled_downloading, errored
    /// </summary>
    public string? Filter { get; set; }

    /// <summary>
    /// Get torrents with the given category (empty string means "without category"; no "category" parameter means "any category"  broken until #11748 is resolved). Remember to URL-encode the category name. For example, My category becomes My%20category
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Get torrents with the given tag (empty string means "without tag"; no "tag" parameter means "any tag". Remember to URL-encode the category name. For example, My tag becomes My%20tag
    /// </summary>
    public string? Tag { get; set; }

    /// <summary>
    /// Sort torrents by given key. They can be sorted using any field of the response's JSON array (which are documented below) as the sort key.
    /// </summary>
    public string? Sort { get; set; }

    /// <summary>
    /// Enable reverse sorting. Defaults to false
    /// </summary>
    public bool? Reverse { get; set; }

    /// <summary>
    /// Limit the number of torrents returned
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Set offset (if less than 0, offset from end)
    /// </summary>
    public int? Offset { get; set; }

    /// <summary>
    /// Filter by hashes. Can contain multiple hashes separated by |
    /// </summary>
    public string? Hashes { get; set; }
}
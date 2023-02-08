namespace CocoaAni.QBitTorrentApis.Models;

public class MainData
{
    /// <summary>
    /// Response ID
    /// </summary>
    public int Rid { get; set; }

    /// <summary>
    /// Whether the response contains all the data or partial data
    /// </summary>
    public bool FullUpdate { get; set; }

    /// <summary>
    /// Property: torrent hash, value: same as torrent list
    /// </summary>
    public List<Torrent> Torrents { get; set; } = default!;

    /// <summary>
    /// List of hashes of torrents removed since last request
    /// </summary>
    public List<Torrent> TorrentsRemoved { get; set; } = default!;

    /// <summary>
    /// Info for categories added since last request
    /// </summary>
    public List<Category> Categories { get; set; } = default!;

    /// <summary>
    /// List of categories removed since last request
    /// </summary>
    public List<Category> CategoriesRemoved { get; set; } = default!;

    /// <summary>
    /// List of tags added since last request
    /// </summary>
    public List<string> Tags { get; set; } = default!;

    /// <summary>
    /// List of tags removed since last request
    /// </summary>
    public List<string> TagsRemoved { get; set; } = default!;

    /// <summary>
    /// Global transfer info
    /// </summary>
    public GlobalTransferInfo ServerState { get; set; } = default!;
}
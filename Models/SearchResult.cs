namespace CocoaAni.QBitTorrentApis.Models;

public class SearchResult
{
    public SearchResult(string descrLink, string fileName, int fileSize, string fileUrl, int nbLeechers, int nbSeeders, string siteUrl)
    {
        DescrLink = descrLink;
        FileName = fileName;
        FileSize = fileSize;
        FileUrl = fileUrl;
        NbLeechers = nbLeechers;
        NbSeeders = nbSeeders;
        SiteUrl = siteUrl;
    }

    public SearchResult()
    {
        DescrLink = default!;
        FileName = default!;
        FileSize = default!;
        FileUrl = default!;
        NbLeechers = default!;
        NbSeeders = default!;
        SiteUrl = default!;
    }

    /// <summary>
    /// URL of the torrent's description page
    /// </summary>
    public string DescrLink { get; set; }

    /// <summary>
    /// Name of the file
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Size of the file in Bytes
    /// </summary>
    public int FileSize { get; set; }

    /// <summary>
    /// Torrent download link (usually either .torrent file or magnet link)
    /// </summary>
    public string FileUrl { get; set; }

    /// <summary>
    /// Number of leechers
    /// </summary>
    public int NbLeechers { get; set; }

    /// <summary>
    /// Number of seeders
    /// </summary>
    public int NbSeeders { get; set; }

    /// <summary>
    /// URL of the torrent site
    /// </summary>
    public string SiteUrl { get; set; }
}
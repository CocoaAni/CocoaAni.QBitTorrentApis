namespace CocoaAni.QBitTorrentApis.Models;

public class BuildInfo
{
    public BuildInfo(string qt, string libtorrent, string boost, string openssl, int bitness)
    {
        Qt = qt;
        Libtorrent = libtorrent;
        this.Boost = boost;
        Openssl = openssl;
        Bitness = bitness;
    }

    public BuildInfo()
    {
        Qt = default!;
        Libtorrent = default!;
        Boost = default!;
        Openssl = default!;
        Bitness = default!;
    }

    /// <summary>
    /// QT version
    /// </summary>
    public string Qt { get; set; }

    /// <summary>
    /// libtorrent version
    /// </summary>
    public string Libtorrent { get; set; }

    /// <summary>
    ///  Boost version
    /// </summary>
    public string Boost { get; set; }

    /// <summary>
    /// OpenSSL version
    /// </summary>
    public string Openssl { get; set; }

    /// <summary>
    /// Application bitness(e.g. 64-bit)
    /// </summary>
    public int Bitness { get; set; }
}
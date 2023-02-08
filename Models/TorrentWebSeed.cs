namespace CocoaAni.QBitTorrentApis.Models;

public class TorrentWebSeed
{
    public TorrentWebSeed(string url)
    {
        Url = url;
    }

    public TorrentWebSeed()
    {
        Url = default!;
    }

    public string Url { get; set; }
}
using System.Text.Json.Serialization;

namespace CocoaAni.QBitTorrentApis.Models;

public class ThePirateBay
{
    public ThePirateBay(string audio, string video)
    {
        Audio = audio;
        Video = video;
    }

    public ThePirateBay()
    {
        Audio = default!;
        Video = default!;
    }

    public string Audio { get; set; }
    public string Video { get; set; }
}

public class RssItem
{
    public RssItem(string hdTorrentsOrg, string powerfulJre, ThePirateBay thePirateBay)
    {
        HdTorrentsOrg = hdTorrentsOrg;
        PowerfulJre = powerfulJre;
        ThePirateBay = thePirateBay;
    }

    public RssItem()
    {
        HdTorrentsOrg = default!;
        PowerfulJre = default!;
        ThePirateBay = default!;
    }

    [JsonPropertyName("HD-Torrents.org")]
    public string HdTorrentsOrg { get; set; }

    public string PowerfulJre { get; set; }

    [JsonPropertyName("The Pirate Bay")]
    public ThePirateBay ThePirateBay { get; set; }
}
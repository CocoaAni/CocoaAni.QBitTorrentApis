using CocoaAni.Net.WebApi;
using System.Globalization;

namespace CocoaAni.QBitTorrentApis.Models;

public class AddTorrentArgs
{
    public AddTorrentArgs(string? savepath, string? cookie, string? category, string? tags, bool? skipChecking, bool? paused, bool? rootFolder, string? rename, int? upLimit, int? dlLimit, float? ratioLimit, int? seedingTimeLimit, bool? autoTmm, bool? sequentialDownload, bool? firstLastPiecePrio)
    {
        Savepath = savepath;
        Cookie = cookie;
        Category = category;
        Tags = tags;
        SkipChecking = skipChecking;
        Paused = paused;
        RootFolder = rootFolder;
        Rename = rename;
        UpLimit = upLimit;
        DlLimit = dlLimit;
        RatioLimit = ratioLimit;
        SeedingTimeLimit = seedingTimeLimit;
        AutoTmm = autoTmm;
        SequentialDownload = sequentialDownload;
        FirstLastPiecePrio = firstLastPiecePrio;
    }

    public AddTorrentArgs()
    {
    }

    /// <summary>
    /// Download folder
    /// </summary>
    public string? Savepath { get; set; }

    /// <summary>
    /// Cookie sent to download the .torrent file
    /// </summary>
    public string? Cookie { get; set; }

    /// <summary>
    /// Category for the torrent
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Tags for the torrent, split by ','
    /// </summary>
    public string? Tags { get; set; }

    /// <summary>
    /// Skip hash checking. Possible values are true, false (default)
    /// </summary>
    public bool? SkipChecking { get; set; }

    /// <summary>
    /// Add torrents in the paused state. Possible values are true, false (default)
    /// </summary>
    public bool? Paused { get; set; }

    /// <summary>
    /// Create the root folder. Possible values are true, false, unset (default)
    /// </summary>
    public bool? RootFolder { get; set; }

    /// <summary>
    /// Rename torrent
    /// </summary>
    public string? Rename { get; set; }

    /// <summary>
    /// Set torrent upload speed limit. Unit in bytes/second
    /// </summary>
    public int? UpLimit { get; set; }

    /// <summary>
    /// Set torrent download speed limit. Unit in bytes/second
    /// </summary>
    public int? DlLimit { get; set; }

    /// <summary>
    /// Set torrent share ratio limit
    /// </summary>
    public float? RatioLimit { get; set; }

    /// <summary>
    /// Set torrent seeding time limit. Unit in minutes
    /// </summary>
    public int? SeedingTimeLimit { get; set; }

    /// <summary>
    /// Whether Automatic Torrent Management should be used
    /// </summary>
    public bool? AutoTmm { get; set; }

    /// <summary>
    /// Enable sequential download. Possible values are true, false (default)
    /// </summary>
    public bool? SequentialDownload { get; set; }

    /// <summary>
    /// Prioritize download first last piece. Possible values are true, false (default)
    /// </summary>
    public bool? FirstLastPiecePrio { get; set; }

    public void OutputFormDataItems(List<FormDataItem> items)
    {
        if (Savepath != null)
            items.Add(new FormDataItem("savepath", Savepath));
        if (Cookie != null)
            items.Add(new FormDataItem("cookie", Cookie));
        if (Category != null)
            items.Add(new FormDataItem("category ", Category));
        if (Tags != null)
            items.Add(new FormDataItem("cookie", Tags));
        if (SkipChecking != null)
            items.Add(new FormDataItem("skip_checking ", SkipChecking.Value.ToString()));
        if (Paused != null)
            items.Add(new FormDataItem("paused", Paused.Value.ToString()));
        if (RootFolder != null)
            items.Add(new FormDataItem("root_folder", RootFolder.Value.ToString()));
        if (Rename != null)
            items.Add(new FormDataItem("rename", Rename));
        if (UpLimit != null)
            items.Add(new FormDataItem("upLimit", UpLimit.Value.ToString()));
        if (DlLimit != null)
            items.Add(new FormDataItem("dlLimit", DlLimit.Value.ToString()));
        if (RatioLimit != null)
            items.Add(new FormDataItem("ratioLimit", RatioLimit.Value.ToString(CultureInfo.InvariantCulture)));
        if (SeedingTimeLimit != null)
            items.Add(new FormDataItem("seedingTimeLimit", SeedingTimeLimit.Value.ToString()));
        if (AutoTmm != null)
            items.Add(new FormDataItem("autoTMM", AutoTmm.Value.ToString()));
        if (SequentialDownload != null)
            items.Add(new FormDataItem("sequentialDownload   ", SequentialDownload));
        if (FirstLastPiecePrio != null)
            items.Add(new FormDataItem("firstLastPiecePrio ", FirstLastPiecePrio));
    }
}
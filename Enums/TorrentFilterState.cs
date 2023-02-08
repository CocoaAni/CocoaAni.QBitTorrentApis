namespace CocoaAni.QBitTorrentApis.Enums;

public class TorrentFilterState
{
    public static string All { get; } = "all";
    public static string Downloading { get; } = "downloading";
    public static string Seeding { get; } = "seeding";
    public static string Completed { get; } = "completed";
    public static string Paused { get; } = "paused";
    public static string Active { get; } = "active";
    public static string Inactive { get; } = "inactive";
    public static string Resumed { get; } = "resumed";
    public static string Stalled { get; } = "stalled";
    public static string StalledUploading { get; } = "stalled_uploading";
    public static string Errored { get; } = "errored";
}
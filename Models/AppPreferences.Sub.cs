namespace CocoaAni.QBitTorrentApis.Models;

public partial class AppPreferences
{
    /// <summary>
    /// Download to the monitored folder
    /// </summary>
    public static int ScanDirsIsMonitoredFolder { get; } = 0;

    /// <summary>
    /// Download to the default save path
    /// </summary>
    public static int ScanDirsIsDefaultSavePath { get; } = 1;

    /// <summary>
    /// Download to the monitored folder
    /// </summary>
    public bool IsScanDirsIsMonitoredFolder => ScanDirs.Equals(ScanDirsIsMonitoredFolder);

    /// <summary>
    /// Is Download to the default save path
    /// </summary>
    public bool IsScanDirsIsDefaultSavePath => ScanDirs.Equals(ScanDirsIsDefaultSavePath);
}
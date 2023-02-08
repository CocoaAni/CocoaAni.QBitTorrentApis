namespace CocoaAni.QBitTorrentApis.Models;

public class SearchPlugin
{
    public SearchPlugin(bool enabled, string fullName, string name, string[] supportedCategories, string url, string version)
    {
        Enabled = enabled;
        FullName = fullName;
        Name = name;
        SupportedCategories = supportedCategories;
        Url = url;
        Version = version;
    }

    public SearchPlugin()
    {
        Enabled = default!;
        FullName = default!;
        Name = default!;
        SupportedCategories = default!;
        Url = default!;
        Version = default!;
    }

    /// <summary>
    /// Whether the plugin is enabled
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Full name of the plugin
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Short name of the plugin
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// List of category objects
    /// </summary>
    public string[] SupportedCategories { get; set; }

    /// <summary>
    /// URL of the torrent site
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Installed version of the plugin
    /// </summary>
    public string Version { get; set; }
}
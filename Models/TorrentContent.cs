using CocoaAni.QBitTorrentApis.Enums;

namespace CocoaAni.QBitTorrentApis.Models;

public class TorrentContent
{
    /// <summary>
    /// 2.8.2   integer File index
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// File name (including relative path)
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// File size (bytes)
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// File progress (percentage/100)
    /// </summary>
    public float Progress { get; set; }

    /// <summary>
    /// File priority. See possible values here below
    /// </summary>
    public FilePriority Priority { get; set; }

    /// <summary>
    /// True if file is seeding/complete
    /// </summary>
    public bool IsSeed { get; set; }

    /// <summary>
    /// The first number is the starting piece index and the second number is the ending piece index (inclusive)
    /// </summary>
    public int[] PieceRange { get; set; } = default!;

    /// <summary>
    /// Percentage of file pieces currently available (percentage/100)
    /// </summary>
    public float Availability { get; set; }
}
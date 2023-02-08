namespace CocoaAni.QBitTorrentApis.Enums;

[Flags]
public enum LogLevel
{
    Normal = 1,
    Info = 2,
    Warning = 4,
    Critical = 8,

    All = Normal | Info | Warning | Critical
}
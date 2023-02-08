using CocoaAni.QBitTorrentApis.Enums;
using System.Text.Json.Serialization;

namespace CocoaAni.QBitTorrentApis.Models;

public class GetLogsArgs
{
    public GetLogsArgs(LogLevel levels, int lastKnownId = -1)
    {
        LogLevel = levels;
        LastKnownId = lastKnownId;
    }

    public GetLogsArgs()
    {
        LogLevel = LogLevel.All;
    }

    [JsonIgnore]
    public LogLevel LogLevel { get; set; }

    /// <summary>
    /// LogLevel.Normal / 日志等级.常规
    /// </summary>
    public bool Normal
    {
        get => ((int)LogLevel & (int)LogLevel.Normal) == (int)LogLevel.Normal;
        set
        {
            if (value)
                LogLevel |= LogLevel.Normal;
            else LogLevel &= ~LogLevel.Normal;
        }
    }

    /// <summary>
    /// LogLevel.Info / 日志等级.信息
    /// </summary>
    public bool Info
    {
        get => ((int)LogLevel & (int)LogLevel.Info) == (int)LogLevel.Info;
        set
        {
            if (value)
                LogLevel |= LogLevel.Info;
            else LogLevel &= ~LogLevel.Info;
        }
    }

    /// <summary>
    /// LogLevel.Warning / 日志等级.警告
    /// </summary>
    public bool Warning
    {
        get => ((int)LogLevel & (int)LogLevel.Warning) == (int)LogLevel.Warning;
        set
        {
            if (value)
                LogLevel |= LogLevel.Warning;
            else LogLevel &= ~LogLevel.Warning;
        }
    }

    /// <summary>
    /// LogLevel.Critical / 日志等级.重要
    /// </summary>
    public bool Critical
    {
        get => ((int)LogLevel & (int)LogLevel.Critical) == (int)LogLevel.Critical;
        set
        {
            if (value)
                LogLevel |= LogLevel.Critical;
            else LogLevel &= ~LogLevel.Critical;
        }
    }

    // ReSharper disable InvalidXmlDocComment
    /// <summary>
    /// Exclude LogId Less than or equal to LastKnownId / 排除LastKnownId前的日志
    /// </summary>
    public int LastKnownId { get; set; } = -1;
}
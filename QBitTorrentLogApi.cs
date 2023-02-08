using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Enums;
using CocoaAni.QBitTorrentApis.Models;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentLogApi : WebApiComponent
{
    public QBitTorrentLogApi(Uri original, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = original.OriginalString + "/api/v2";
    }

    public QBitTorrentLogApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    /// <summary>
    /// Get log / 获取日志
    /// </summary>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Task<Result<List<LogItem>>> GetLogAsync(GetLogsArgs args, CancellationToken ctk = default)
        => DoGetAsync<Result<List<LogItem>>>("/log/main", args, ctk);

    /// <summary>
    /// Get log / 获取日志
    /// </summary>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Result<List<LogItem>> GetLog(GetLogsArgs args, CancellationToken ctk = default)
        => GetLogAsync(args, ctk).Result;

    /// <summary>
    /// Get log / 获取日志
    /// </summary>
    /// <param name="levels">Log Levels / 日志等级</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Task<Result<List<LogItem>>> GetLogAsync(LogLevel levels, CancellationToken ctk = default) =>
        GetLogAsync(new GetLogsArgs(levels), ctk);

    // ReSharper disable InvalidXmlDocComment
    /// <summary>
    /// Get Log / 获取日志
    /// </summary>
    /// <param name="levels">Log Levels / 日志等级</param>
    /// <param name="lastKnownId">Exclude LogIdLess than or equal to LastKnownId / 排除LastKnownId前的日志</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Task<Result<List<LogItem>>> GetLogAsync(LogLevel levels, int lastKnownId, CancellationToken ctk = default) =>
        GetLogAsync(new GetLogsArgs(levels, lastKnownId), ctk);

    /// <summary>
    /// Get Log / 获取日志
    /// </summary>
    /// <param name="levels">Log Levels / 日志等级</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Result<List<LogItem>> GetLog(LogLevel levels, CancellationToken ctk = default) =>
        GetLogAsync(new GetLogsArgs(levels), ctk).Result;

    /// <summary>
    /// Get log / 获取日志
    /// </summary>
    /// <param name="levels">Log Levels / 日志等级</param>
    /// <param name="lastKnownId">Exclude PeerLogId Less than or equal to LastKnownId / 排除lastKnownId前的对等日志</param>
    /// <param name="ctk"></param>
    /// <returns>Log / 日志</returns>
    public Result<List<LogItem>> GetLog(LogLevel levels, int lastKnownId, CancellationToken ctk = default) =>
        GetLogAsync(new GetLogsArgs(levels, lastKnownId), ctk).Result;

    /// <summary>
    /// Get Peer Log / 获取对等日志
    /// </summary>
    /// <param name="lastKnownId">Exclude PeerLogId Less than or equal to LastKnownId / 排除lastKnownId前的对等日志</param>
    /// <param name="ctk"></param>
    /// <returns>PeerLog / 对等日志</returns>
    public Task<Result<List<PeerLogItem>>> GetPeerLogAsync(int lastKnownId, CancellationToken ctk = default)
        => DoGetAsync<Result<List<PeerLogItem>>>($"/log/peers?last_known_id={lastKnownId}", null, ctk);

    /// <summary>
    /// Get Peer Log / 获取对等日志
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>PeerLog / 对等日志</returns>
    public Task<Result<List<PeerLogItem>>> GetPeerLogAsync(CancellationToken ctk = default)
        => GetPeerLogAsync(-1, ctk);

    /// <summary>
    /// Get Peer Log / 获取对等日志
    /// </summary>
    /// <param name="lastKnownId">Exclude PeerLogId Less than or equal to LastKnownId / 排除lastKnownId前的对等日志</param>
    /// <param name="ctk"></param>
    /// <returns>PeerLog / 对等日志</returns>
    public Result<List<PeerLogItem>> GetPeerLog(int lastKnownId, CancellationToken ctk = default)
        => GetPeerLogAsync(lastKnownId, ctk).Result;

    /// <summary>
    /// Get Peer Log / 获取对等日志
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>PeerLog / 对等日志</returns>
    public Result<List<PeerLogItem>> GetPeerLog(CancellationToken ctk = default)
        => GetPeerLogAsync(-1, ctk).Result;
}
using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Models;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentTransferInfoApi : WebApiComponent
{
    public QBitTorrentTransferInfoApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentTransferInfoApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Get Global Transfer Info / 获取全局传输信息
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>全局传输信息</returns>
    public Task<Result<GlobalTransferInfo>> GetGlobalTransferInfoAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<GlobalTransferInfo>>("/transfer/info", null, ctk);

    /// <summary>
    /// Get Global Transfer Info / 获取全局传输信息
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>全局传输信息</returns>
    public Result<GlobalTransferInfo> GetGlobalTransferInfo(CancellationToken ctk = default)
        => GetGlobalTransferInfoAsync(ctk).Result;

    /// <summary>
    /// Get Alternative Speed Limits State / 获取备选速度限制状态
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>响应是是否启用了替代速度限制，否则。1/0</returns>
    public Task<Result<string>> GetAlternativeSpeedLimitsStateAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<string>>("/transfer/speedLimitsMode", null, ctk);

    /// <summary>
    /// Get Alternative Speed Limits State / 获取备选速度限制状态
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>响应是是否启用了替代速度限制，否则。1/0</returns>
    public Result<string> GetAlternativeSpeedLimitsState(CancellationToken ctk = default)
        => GetAlternativeSpeedLimitsStateAsync(ctk).Result;

    /// <summary>
    /// Toggle Alternative Speed Limits / 反转备选速度限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Task<Result> ToggleAlternativeSpeedLimitsAsync(CancellationToken ctk = default)
        => DoGetAsync<Result>("/transfer/toggleSpeedLimitsMode", null, ctk);

    /// <summary>
    /// Toggle Alternative Speed Limits / 反转备选速度限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Result ToggleAlternativeSpeedLimits(CancellationToken ctk = default)
        => ToggleAlternativeSpeedLimitsAsync(ctk).Result;

    /// <summary>
    /// Get Global Download Limit / 获取全局下载限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Task<Result<int>> GetGlobalDownloadLimitAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<int>>("/transfer/toggleSpeedLimitsMode", null, ctk);

    /// <summary>
    /// Get Global Download Limit / 获取全局下载限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Result<int> GetGlobalDownloadLimit(CancellationToken ctk = default)
        => GetGlobalDownloadLimitAsync(ctk).Result;

    /// <summary>
    /// Set Global Download Limit / 设置全局下载限制
    /// </summary>
    /// <param name="limit">The global download speed limit to set in bytes/second / 要设置的全局下载速度限制（字节/秒）</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Task<Result> SetGlobalDownloadLimitAsync(int limit, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/transfer/setDownloadLimit?limit={limit}", null, ctk);

    /// <summary>
    /// Set Global Download Limit / 设置全局下载限制
    /// </summary>
    /// <param name="limit">The global download speed limit to set in bytes/second / 要设置的全局下载速度限制（字节/秒）</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Result SetGlobalDownloadLimit(int limit, CancellationToken ctk = default)
        => SetGlobalDownloadLimitAsync(limit, ctk).Result;

    /// <summary>
    /// Get Global Upload Limit / 获取全局上载限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global upload speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局上传速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Task<Result<int>> GetGlobalUploadLimitAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<int>>("/transfer/uploadLimit", null, ctk);

    /// <summary>
    /// Get Global Upload Limit / 获取全局上载限制
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global upload speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局上传速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Result<int> GetGlobalUploadLimit(CancellationToken ctk = default)
        => GetGlobalUploadLimitAsync(ctk).Result;

    /// <summary>
    /// Set Global Upload Limit / 设置全局上载限制
    /// </summary>
    /// <param name="limit">The global upload speed limit to set in bytes/second / 要设置的全局上载速度限制（字节/秒）</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Task<Result> SetGlobalUploadLimitAsync(int limit, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/transfer/setUploadLimit?limit={limit}", null, ctk);

    /// <summary>
    /// Set Global Upload Limit / 设置全局上载限制
    /// </summary>
    /// <param name="limit">The global upload speed limit to set in bytes/second / 要设置的全局上载速度限制（字节/秒）</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Result SetGlobalUploadLimit(int limit, CancellationToken ctk = default)
        => SetGlobalUploadLimitAsync(limit, ctk).Result;

    /// <summary>
    /// Ban peers / 禁止Peers通行
    /// </summary>
    /// <param name="peers">The peer to ban, or multiple peers separated by a pipe |. Each peer is a colon-separated host:port / 要禁止的对等体，或由管道|分隔的多个对等体。每个对等端都是一个冒号分隔的主机：端口</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Task<Result> BanPeersAsync(string peers, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/transfer/banPeers?peers={peers}", null, ctk);

    /// <summary>
    /// Ban peers / 禁止Peers通行
    /// </summary>
    /// <param name="peers">The peer to ban, or multiple peers separated by a pipe |. Each peer is a colon-separated host:port / 要禁止的对等体，或由管道|分隔的多个对等体。每个对等端都是一个冒号分隔的主机：端口</param>
    /// <param name="ctk"></param>
    /// <returns>The response is the value of current global download speed limit in bytes/second; this value will be zero if no limit is applied. / 响应是当前全局下载速度限制的值，单位为字节/秒；如果没有应用限制，该值将为零。</returns>
    public Result BanPeers(string peers, CancellationToken ctk = default)
        => BanPeersAsync(peers, ctk).Result;
}
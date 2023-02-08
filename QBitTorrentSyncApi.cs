using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Models;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentSyncApi : WebApiComponent
{
    public QBitTorrentSyncApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentSyncApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Get Main Data / 获取主要数据
    /// </summary>
    /// <param name="rid">Response ID. If not provided, rid=0 will be assumed. If the given rid is different from the one of last server reply, full_update will be true / 响应ID。如果未提供，则假定rid=0。如果给定的rid与上次服务器回复的rid不同，则full_update将为true</param>
    /// <param name="ctk"></param>
    /// <returns>获取主要数据</returns>
    public Task<Result<MainData>> GetMainDataAsync(int rid, CancellationToken ctk = default)
        => DoGetAsync<Result<MainData>>($"/sync/maindata?rid={rid}", null, ctk);

    /// <summary>
    /// Get Main Data / 获取主要数据
    /// </summary>
    /// <param name="rid">Response ID. If not provided, rid=0 will be assumed. If the given rid is different from the one of last server reply, full_update will be true / 响应ID。如果未提供，则假定rid=0。如果给定的rid与上次服务器回复的rid不同，则full_update将为true</param>
    /// <param name="ctk"></param>
    /// <returns>获取主要数据</returns>
    public Result<MainData> GetMainData(int rid, CancellationToken ctk = default)
        => GetMainDataAsync(rid, ctk).Result;

    /// <summary>
    /// Get Torrent Peers Data / 获取Torrent Peers数据
    /// </summary>
    /// <param name="hash">Torrent hash / 种子哈希</param>
    /// <param name="rid">Response ID. If not provided, rid=0 will be assumed. If the given rid is different from the one of last server reply, full_update will be true / 响应ID。如果未提供，则假定rid=0。如果给定的rid与上次服务器回复的rid不同，则full_update将为true</param>
    /// <param name="ctk"></param>
    /// <returns>待办任务</returns>
    public Task<Result<string>> GetTorrentPeersDataAsync(string hash, int rid, CancellationToken ctk = default)
        => DoGetAsync<Result<string>>($"/sync/maindata?rid={rid}&hash={hash}", null, ctk);

    /// <summary>
    ///  Get Torrent Peers Data / 获取Torrent Peers数据
    /// </summary>
    /// <param name="hash">Torrent hash / 种子哈希</param>
    /// <param name="rid">Response ID. If not provided, rid=0 will be assumed. If the given rid is different from the one of last server reply, full_update will be true / 响应ID。如果未提供，则假定rid=0。如果给定的rid与上次服务器回复的rid不同，则full_update将为true</param>
    /// <param name="ctk"></param>
    /// <returns>待办任务</returns>
    public Result<string> GetTorrentPeersData(string hash, int rid, CancellationToken ctk = default)
        => GetTorrentPeersDataAsync(hash, rid, ctk).Result;
}
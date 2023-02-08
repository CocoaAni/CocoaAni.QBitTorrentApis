using CocoaAni.Net.WebApi;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentAuthenticationApi : WebApiComponent
{
    public QBitTorrentAuthenticationApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentAuthenticationApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Login in to qBittorrent
    /// 登录qBittorrent
    /// </summary>
    /// <param name="username">Username/用户名</param>
    /// <param name="password">Password/密码</param>
    /// <param name="ctk"></param>
    /// <returns>True if successful, false if wrong username/password, null if unreachable.</returns>
    public Task<Result> LoginAsync(string username, string password, CancellationToken ctk = default)
        => DoPostAsync<Result>("/auth/login", $"username={username}&password={password}", ctk);

    /// <summary>
    /// Logs out of qBittorrent.
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Task<Result> LogoutAsync(CancellationToken ctk = default)
        => DoPostAsync<Result>("/auth/logout", null, ctk);

    /// <summary>
    /// Login in to qBittorrent
    /// 登录qBittorrent
    /// </summary>
    /// <param name="username">Username/用户名</param>
    /// <param name="password">Password/密码</param>
    /// <param name="ctk"></param>
    /// <returns>True if successful, false if wrong username/password, null if unreachable.</returns>
    public Result Login(string username, string password, CancellationToken ctk = default) =>
        LoginAsync(username, password, ctk).Result;

    /// <summary>
    /// Logs out of qBittorrent.
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Result Logout(CancellationToken ctk = default) => LogoutAsync(ctk).Result;
}
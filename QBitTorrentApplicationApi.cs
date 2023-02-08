using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Models;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentApplicationApi : WebApiComponent
{
    public QBitTorrentApplicationApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentApplicationApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Get Application Version / 获取应用程序版本
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Application Version</returns>
    public Task<Result<string>> GetApplicationVersionAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<string>>("/app/version", null, ctk);

    /// <summary>
    /// Get Application Version / 获取应用程序版本
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Application Version</returns>
    public Result<string> GetApplicationVersion(CancellationToken ctk = default)
        => GetApplicationVersionAsync(ctk).Result;

    /// <summary>
    /// Gets API version.
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>API version.</returns>
    public Task<Result<int>> GetApiVersionAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<int>>("/app/webapiVersion", null, ctk);

    /// <summary>
    /// Gets API version.
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>API version.</returns>
    public Result<int> GetApiVersion(CancellationToken ctk = default)
        => GetApiVersionAsync(ctk).Result;

    /// <summary>
    /// Get build info / 获取应用构建信息
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>BuildInfo</returns>
    public Task<Result<BuildInfo>> GetBuildInfoAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<BuildInfo>>("/app/buildInfo", null, ctk);

    /// <summary>
    /// Get build info / 获取应用构建信息
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>BuildInfo</returns>
    public Result<BuildInfo> GetBuildInfo(CancellationToken ctk = default)
        => GetBuildInfoAsync(ctk).Result;

    /// <summary>
    /// Shutdown application / 关闭应用程序
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result</returns>
    public Task<Result> ShutdownApplicationAsync(CancellationToken ctk = default)
        => DoGetAsync<Result>("/app/shutdown", null, ctk);

    /// <summary>
    /// Shutdown application / 关闭应用程序
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result</returns>
    public Result ShutdownApplication(CancellationToken ctk = default)
        => ShutdownApplicationAsync(ctk).Result;

    /// <summary>
    /// Get Application Preferences / 获取应用首选项
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result</returns>
    public Task<Result<AppPreferences>> GetApplicationPreferencesAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<AppPreferences>>("/app/preferences", null, ctk);

    /// <summary>
    /// Get Application Preferences / 获取应用首选项
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result</returns>
    public Result<AppPreferences> GetApplicationPreferences(CancellationToken ctk = default)
        => GetApplicationPreferencesAsync(ctk).Result;

    /// <summary>
    /// Set application preferences / 设置应用首选项
    /// </summary>
    /// <param name="args">Preferences Args</param>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Task<Result> SetApplicationPreferencesAsync(SetAppPreferencesArgs args, CancellationToken ctk = default)
        => DoPostAsync<Result>("/app/setPreferences", args, ctk);

    /// <summary>
    /// Set application preferences / 设置应用首选项
    /// </summary>
    /// <param name="args">Preferences Args</param>
    /// <param name="ctk"></param>
    /// <returns></returns>
    public Result SetApplicationPreferences(SetAppPreferencesArgs args, CancellationToken ctk = default)
        => SetApplicationPreferencesAsync(args, ctk).Result;

    /// <summary>
    /// Get default save path / 获取默认保存路径
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Default Save Path / 默认保存路径</returns>
    public Task<Result<string>> GetDefaultSavePathAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<string>>("/app/defaultSavePath", null, ctk);

    /// <summary>
    /// Get default save path / 获取默认保存路径
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Default Save Path / 默认保存路径</returns>
    public Result<string> GetDefaultSavePath(CancellationToken ctk = default)
        => GetDefaultSavePathAsync(ctk).Result;
}
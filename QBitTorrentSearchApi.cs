using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Models;
using CocoaAni.ToolKit.String;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentSearchApi : WebApiComponent
{
    public QBitTorrentSearchApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentSearchApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Start search / 开始搜索
    /// </summary>
    /// <param name="pattern">
    ///     Pattern to search for (e.g. "Ubuntu 18.04") [END]
    ///     要搜索的模式（例如“Ubuntu 18.04”）
    /// </param>
    /// <param name="plugins">
    ///     Plugins to use for searching (e.g. "legittorrents"). Supports multiple plugins separated by |. Also supports all and enabled [END]
    ///     用于搜索的插件（例如“合法种子”）。支持以|分隔的多个插件。还支持所有和已启用
    /// </param>
    /// <param name="category">
    ///     Categories to limit your search to (e.g. "legittorrents"). Available categories depend on the specified plugins. Also supports all [END]
    ///     限制搜索的类别（例如“合法种子”）。可用类别取决于指定的插件。还支持所有
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: User has reached the limit of max Running searches(currently set to 5) |
    ///     200: All other scenarios- see JSON below |
    /// </returns>
    public Task<Result<StartSearchResponse>> StartSearchAsync(string pattern, string plugins, string category, CancellationToken ctk = default)
        => DoPostAsync<Result<StartSearchResponse>>("/search/start",
            $"pattern={UrlEncode(pattern)}&plugins={UrlEncode(plugins)}&category={UrlEncode(category)}", ctk);

    /// <summary>
    /// Start search / 开始搜索
    /// </summary>
    /// <param name="pattern">
    ///     Pattern to search for (e.g. "Ubuntu 18.04") [END]
    ///     要搜索的模式（例如“Ubuntu 18.04”）
    /// </param>
    /// <param name="plugins">
    ///     Plugins to use for searching (e.g. "legittorrents"). Supports multiple plugins separated by |. Also supports all and enabled [END]
    ///     用于搜索的插件（例如“合法种子”）。支持以|分隔的多个插件。还支持所有和已启用
    /// </param>
    /// <param name="category">
    ///     Categories to limit your search to (e.g. "legittorrents"). Available categories depend on the specified plugins. Also supports all [END]
    ///     限制搜索的类别（例如“合法种子”）。可用类别取决于指定的插件。还支持所有
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: User has reached the limit of max Running searches(currently set to 5) |
    ///     200: All other scenarios- see JSON below |
    /// </returns>
    public Result<StartSearchResponse> StartSearch(string pattern, string plugins, string category, CancellationToken ctk = default)
        => StartSearchAsync(pattern, plugins, category, ctk).Result;

    /// <summary>
    /// Stop Search / 停止搜索
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> StopSearchAsync(int id, CancellationToken ctk = default)
        => DoPostAsync<Result>("/search/stop",
            $"id={id}", ctk);

    /// <summary>
    /// Stop Search / 停止搜索
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result StopSearch(int id, CancellationToken ctk = default)
        => StopSearchAsync(id, ctk).Result;

    /// <summary>
    /// Get Search Status / 获取搜索状态
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result<SearchItemStatus[]>> GetSearchStatusAsync(int? id = null, CancellationToken ctk = default)
    {
        var idArg = id == null ? string.Empty : $"?id={id}";
        return DoGetAsync<Result<SearchItemStatus[]>>($"/search/status{idArg}", null, ctk);
    }

    /// <summary>
    /// Stop Search / 停止搜索
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result<SearchItemStatus[]> GetSearchStatus(int? id = null, CancellationToken ctk = default)
        => GetSearchStatusAsync(id, ctk).Result;

    /// <summary>
    /// Get Search Results / 获取搜索结果
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="limit">
    ///     max number of results to return. 0 or negative means no limit [END]
    ///     要返回的最大结果数。0或负数表示无限制
    /// </param>
    /// <param name="offset">
    ///     result to start at. A negative number means count backwards (e.g. -2 returns the 2 most recent results) [END]
    ///     开始的结果。负数表示向后计数（例如，-2返回2个最新结果）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     409: Offset is too large, or too small(e.g.absolute value of negative number is greater than # results) |
    ///     200: All other scenarios- see JSON below |
    /// </returns>
    public Task<Result<SearchResults>> GetSearchResultsAsync(int? id = null, int? limit = null, int? offset = null, CancellationToken ctk = default)
    {
        var limitArg = limit == null ? string.Empty : $"&limit={limit}";
        var offsetArg = id == null ? string.Empty : $"&id={id}";
        return DoGetAsync<Result<SearchResults>>($"/search/results?id={id}{limitArg}{offsetArg}", null, ctk);
    }

    /// <summary>
    /// Get Search Results / 获取搜索结果
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="limit">
    ///     max number of results to return. 0 or negative means no limit [END]
    ///     要返回的最大结果数。0或负数表示无限制
    /// </param>
    /// <param name="offset">
    ///     result to start at. A negative number means count backwards (e.g. -2 returns the 2 most recent results) [END]
    ///     开始的结果。负数表示向后计数（例如，-2返回2个最新结果）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     409: Offset is too large, or too small(e.g.absolute value of negative number is greater than # results) |
    ///     200: All other scenarios- see JSON below |
    /// </returns>
    public Result<SearchResults> GetSearchResults(int? id = null, int? limit = null, int? offset = null, CancellationToken ctk = default)
        => GetSearchResultsAsync(id, limit, offset, ctk).Result;

    /// <summary>
    /// Delete Search / 删除搜索
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> DeleteSearchAsync(int id, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/search/delete?id={id}", null, ctk);

    /// <summary>
    /// Stop Search / 停止搜索
    /// </summary>
    /// <param name="id">ID of the search job / 搜索任务的ID</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Search job was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result DeleteSearch(int id, CancellationToken ctk = default)
        => DeleteSearchAsync(id, ctk).Result;

    /// <summary>
    /// Get Search Plugins / 获取搜索插件
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Search Plugins / 搜索插件</returns>
    public Task<Result<SearchPlugin[]>> GetSearchPluginsAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<SearchPlugin[]>>("/search/plugins", null, ctk);

    /// <summary>
    /// Get Search Plugins / 获取搜索插件
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Search Plugins / 搜索插件</returns>
    public Result<SearchPlugin[]> GetSearchPlugins(CancellationToken ctk = default)
        => GetSearchPluginsAsync(ctk).Result;

    /// <summary>
    /// Install Search Plugin / 安装搜索插件
    /// </summary>
    /// <param name="sources">I
    ///     Url or file path of the plugin to install (e.g. "https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py"). Supports multiple sources separated by | [END]
    ///     要安装的插件的Url或文件路径（例如“https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py“）.支持由分隔的多个源|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> InstallSearchPluginAsync(string sources, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/search/installPlugin?sources={UrlEncode(sources)}", null, ctk);

    /// <summary>
    /// Install Search Plugin / 安装搜索插件
    /// </summary>
    /// <param name="sources">I
    ///     Url or file path of the plugin to install (e.g. "https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py"). Supports multiple sources separated by | [END]
    ///     要安装的插件的Url或文件路径（例如“https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py“）.支持由分隔的多个源|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result InstallSearchPlugin(string sources, CancellationToken ctk = default)
        => InstallSearchPluginAsync(sources, ctk).Result;

    /// <summary>
    /// Install Search Plugin / 安装搜索插件
    /// </summary>
    /// <param name="sources">I
    ///     Url or file path of the plugin to install (e.g. "https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py"). Supports multiple sources separated by | [END]
    ///     要安装的插件的Url或文件路径（例如“https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py“）.支持由分隔的多个源|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> InstallSearchPluginAsync(IEnumerable<string> sources, CancellationToken ctk = default)
        => InstallSearchPluginAsync(sources.Merger("|"), ctk);

    /// <summary>
    /// Install Search Plugin / 安装搜索插件
    /// </summary>
    /// <param name="sources">I
    ///     Url or file path of the plugin to install (e.g. "https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py"). Supports multiple sources separated by | [END]
    ///     要安装的插件的Url或文件路径（例如“https://raw.githubusercontent.com/qbittorrent/search-plugins/master/nova3/engines/legittorrents.py“）.支持由分隔的多个源|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result InstallSearchPlugin(IEnumerable<string> sources, CancellationToken ctk = default)
        => InstallSearchPluginAsync(sources.Merger("|"), ctk).Result;

    /// <summary>
    /// Uninstall Search Plugin / 卸载搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to uninstall (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要卸载的插件的名称（例如“合法种子”）。支持由分隔的多个名称|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> UninstallSearchPluginAsync(string names, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/search/uninstallPlugin?names={UrlEncode(names)}", null, ctk);

    /// <summary>
    /// Uninstall Search Plugin / 卸载搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to uninstall (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要卸载的插件的名称（例如“合法种子”）。支持由分隔的多个名称|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result UninstallSearchPlugin(string names, CancellationToken ctk = default)
        => UninstallSearchPluginAsync(names, ctk).Result;

    /// <summary>
    /// Uninstall Search Plugin / 卸载搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to uninstall (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要卸载的插件的名称（例如“合法种子”）。支持由分隔的多个名称|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> UninstallSearchPluginAsync(IEnumerable<string> names, CancellationToken ctk = default)
        => UninstallSearchPluginAsync(names.Merger("|"), ctk);

    /// <summary>
    /// Uninstall Search Plugin / 卸载搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to uninstall (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要卸载的插件的名称（例如“合法种子”）。支持由分隔的多个名称|
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result UninstallSearchPlugin(IEnumerable<string> names, CancellationToken ctk = default)
        => UninstallSearchPluginAsync(names.Merger("|"), ctk).Result;

    /// <summary>
    /// Enable Search Plugin /  启用搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to enable/disable (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要启用/禁用的插件的名称（例如“合法种子”）。支持用 |
    /// </param>
    /// <param name="enable">
    ///     Whether the plugins should be enabled [END]
    ///     是否应启用插件
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> EnableSearchPluginAsync(string names, bool enable, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/search/enablePlugin?names={UrlEncode(names)}&enable={enable}", null, ctk);

    /// <summary>
    /// Enable Search Plugin /  启用搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to enable/disable (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要启用/禁用的插件的名称（例如“合法种子”）。支持用 |
    /// </param>
    /// <param name="enable">
    ///     Whether the plugins should be enabled [END]
    ///     是否应启用插件
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result EnableSearchPlugin(string names, bool enable, CancellationToken ctk = default)
        => EnableSearchPluginAsync(names, enable, ctk).Result;

    /// <summary>
    /// Enable Search Plugin /  启用搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to enable/disable (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要启用/禁用的插件的名称（例如“合法种子”）。支持用 |
    /// </param>
    /// <param name="enable">
    ///     Whether the plugins should be enabled [END]
    ///     是否应启用插件
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> EnableSearchPluginAsync(IEnumerable<string> names, bool enable, CancellationToken ctk = default)
        => EnableSearchPluginAsync(names.Merger("|"), enable, ctk);

    /// <summary>
    /// Enable Search Plugin /  启用搜索插件
    /// </summary>
    /// <param name="names">I
    ///     Name of the plugin to enable/disable (e.g. "legittorrents"). Supports multiple names separated by | [END]
    ///     要启用/禁用的插件的名称（例如“合法种子”）。支持用 |
    /// </param>
    /// <param name="enable">
    ///     Whether the plugins should be enabled [END]
    ///     是否应启用插件
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result EnableSearchPlugin(IEnumerable<string> names, bool enable, CancellationToken ctk = default)
        => EnableSearchPluginAsync(names.Merger("|"), enable, ctk).Result;

    /// <summary>
    /// Update Search Plugins / 更新搜索插件
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> UpdateSearchPluginsAsync(CancellationToken ctk = default)
        => DoGetAsync<Result>("/search/updatePlugins", null, ctk);

    /// <summary>
    /// Update Search Plugins / 更新搜索插件
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result UpdateSearchPlugins(CancellationToken ctk = default)
        => UpdateSearchPluginsAsync(ctk).Result;
}
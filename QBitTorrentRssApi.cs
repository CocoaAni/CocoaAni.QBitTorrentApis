using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Models;
using CocoaAni.ToolKit.Json;
using System.Web;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentRssApi : WebApiComponent
{
    public QBitTorrentRssApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentRssApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Add Folder / 添加文件夹
    /// </summary>
    /// <param name="path">
    ///     Full path of added folder (e.g. "The Pirate Bay\Top100") [END]
    ///     添加文件夹的完整路径（例如“海盗湾\Top100”）/param>
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to add folder |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddFolderAsync(string path, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/addFolder", $"path={HttpUtility.UrlEncode(path)}", ctk);

    /// <summary>
    /// Add Folder / 添加文件夹
    /// </summary>
    /// <param name="path">
    ///     Full path of added folder (e.g. "The Pirate Bay\Top100") [END]
    ///     添加文件夹的完整路径（例如“海盗湾\Top100”）/param>
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to add folder |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddFolder(string path, CancellationToken ctk = default)
        => AddFolderAsync(path, ctk).Result;

    /// <summary>
    /// Add Feed / 添加提要
    /// </summary>
    /// <param name="url">
    ///     URL of RSS feed (e.g. "http://thepiratebay.org/rss//top100/200") [END]
    ///     RSS源的URL（例如“http://thepiratebay.org/rss//top100/200“）
    /// </param>
    /// <param name="path">
    ///     optional: Full path of added folder (e.g. "The Pirate Bay\Top100\Video") [END]
    ///     可选的：添加文件夹的完整路径（例如“海盗湾\Top100\Video”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to add feed |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddFeedAsync(string url, string? path = null, CancellationToken ctk = default)
    {
        path = path == null ? string.Empty : $"&path={HttpUtility.UrlEncode(path)}";
        return DoPostAsync<Result>("/rss/addFeed", $"url={url}{path}", ctk);
    }

    /// <summary>
    /// Add Feed / 添加提要
    /// </summary>
    /// <param name="url">
    ///     URL of RSS feed (e.g. "http://thepiratebay.org/rss//top100/200") [END]
    ///     RSS源的URL（例如“http://thepiratebay.org/rss//top100/200“）
    /// </param>
    /// <param name="path">
    ///     optional: Full path of added folder (e.g. "The Pirate Bay\Top100\Video") [END]
    ///     可选的：添加文件夹的完整路径（例如“海盗湾\Top100\Video”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to add feed |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddFeed(string url, string path, CancellationToken ctk = default)
        => AddFeedAsync(url, path, ctk).Result;

    /// <summary>
    /// Removes folder or feed. / 删除文件夹或源
    /// </summary>
    /// <param name="path">
    ///     Full path of removed item (e.g. "The Pirate Bay\Top100") [END]
    ///     移除物品的完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to remove item |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> RemoveItemAsync(string path, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/removeItem", $"path={HttpUtility.UrlEncode(path)}", ctk);

    /// <summary>
    /// Removes folder or feed. / 删除文件夹或源
    /// </summary>
    /// <param name="path">
    ///     Full path of removed item (e.g. "The Pirate Bay\Top100") [END]
    ///     移除物品的完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to remove item |
    ///     200: All other scenarios |
    /// </returns>
    public Result RemoveItem(string path, CancellationToken ctk = default)
        => RemoveItemAsync(path, ctk).Result;

    /// <summary>
    /// Moves/renames folder or feed. / 移动/重命名文件夹或源。
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="descPath">
    ///     New full path of item (e.g. "The Pirate Bay") [END]
    ///     项目的新完整路径（例如“海盗湾”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to move item |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> MoveItemAsync(string itemPath, string descPath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/moveItem", $"itemPath={HttpUtility.UrlEncode(itemPath)}&descPath={HttpUtility.UrlEncode(descPath)}", ctk);

    /// <summary>
    /// Moves/renames folder or feed. / 移动/重命名文件夹或源。
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="descPath">
    ///     New full path of item (e.g. "The Pirate Bay") [END]
    ///     项目的新完整路径（例如“海盗湾”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Failure to move item |
    ///     200: All other scenarios |
    /// </returns>
    public Result MoveItem(string itemPath, string descPath, CancellationToken ctk = default)
        => MoveItemAsync(itemPath, descPath, ctk).Result;

    /// <summary>
    /// Get All Items / 获取所有项目
    /// </summary>
    /// <param name="withData">
    ///     True if you need current feed articles [END]
    ///     如果需要当前提要文章，则为True
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result<RssItem[]>> GetAllItemsAsync(bool? withData = null, CancellationToken ctk = default)
    {
        var wd = withData == null ? string.Empty : $"withData={withData.Value}";
        return DoGetAsync<Result<RssItem[]>>($"/rss/items?{wd}", null, ctk);
    }

    /// <summary>
    /// Get All Items / 获取所有项目
    /// </summary>
    /// <param name="withData">
    ///     True if you need current feed articles [END]
    ///     如果需要当前提要文章，则为True
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result<RssItem[]> GetAllItems(bool? withData = null, CancellationToken ctk = default)
        => GetAllItemsAsync(withData, ctk).Result;

    /// <summary>
    /// Mark As Read / 标记为已读
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="articleId">
    ///     optional: If articleId is provided only the article is marked as read otherwise the whole feed is going to be marked as read. [END]
    ///     可选的: 如果提供articleId，则只将文章标记为已读，否则整个提要将标记为已阅读。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> MarkAsReadAsync(string itemPath, string? articleId = null, CancellationToken ctk = default)
    {
        articleId = articleId == null ? string.Empty : $"&articleId={articleId}";
        return DoPostAsync<Result>("/rss/markAsRead", $"itemPath={HttpUtility.UrlEncode(itemPath)}{articleId}", ctk);
    }

    /// <summary>
    /// Mark As Read / 标记为已读
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="articleId">
    ///     optional: If articleId is provided only the article is marked as read otherwise the whole feed is going to be marked as read. [END]
    ///     可选的: 如果提供articleId，则只将文章标记为已读，否则整个提要将标记为已阅读。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result MarkAsRead(string itemPath, string? articleId, CancellationToken ctk = default)
        => MarkAsReadAsync(itemPath, articleId, ctk).Result;

    /// <summary>
    /// Refreshes Folder Or Feed / 刷新文件夹或源
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RefreshItemAsync(string itemPath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/refreshItem", $"itemPath={HttpUtility.UrlEncode(itemPath)}", ctk);

    /// <summary>
    /// Mark As Read / 标记为已读
    /// </summary>
    /// <param name="itemPath">
    ///     Current full path of item (e.g. "The Pirate Bay\Top100") [END]
    ///     物品的当前完整路径（例如“海盗湾\Top100”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RefreshItem(string itemPath, CancellationToken ctk = default)
        => RefreshItemAsync(itemPath, ctk).Result;

    /// <summary>
    /// Set Auto Downloading Rule / 设置自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ruleDef">RuleDefinition / 规则定义信息</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetAutoDownloadingRuleAsync(string ruleName, RuleDefinition ruleDef, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/setRule",
            $"ruleName={HttpUtility.UrlEncode(ruleName)}&ruleDef={HttpUtility.UrlEncode(ruleDef.ToJsonString())}", ctk);

    /// <summary>
    /// Set Auto Downloading Rule / 设置自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ruleDef">RuleDefinition / 规则定义信息</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetAutoDownloadingRule(string ruleName, RuleDefinition ruleDef, CancellationToken ctk = default)
        => SetAutoDownloadingRuleAsync(ruleName, ruleDef, ctk).Result;

    /// <summary>
    /// Rename Auto Downloading Rule / 重命名自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="newRuleName">
    ///     New rule name (e.g. "The Punisher") [END]
    ///     新规则名称（例如“惩罚者”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RenameAutoDownloadingRuleAsync(string ruleName, string newRuleName, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/setRule",
            $"ruleName={HttpUtility.UrlEncode(ruleName)}&newRuleName={HttpUtility.UrlEncode(newRuleName.ToJsonString())}", ctk);

    /// <summary>
    /// Rename Auto Downloading Rule / 重命名自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="newRuleName">
    ///     New rule name (e.g. "The Punisher") [END]
    ///     新规则名称（例如“惩罚者”）
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RenameAutoDownloadingRule(string ruleName, string newRuleName, CancellationToken ctk = default)
        => RenameAutoDownloadingRuleAsync(ruleName, newRuleName, ctk).Result;

    /// <summary>
    /// Remove Auto Downloading Rule / 删除自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RemoveAutoDownloadingRuleAsync(string ruleName, CancellationToken ctk = default)
        => DoPostAsync<Result>("/rss/removeRule",
            $"ruleName={HttpUtility.UrlEncode(ruleName)}", ctk);

    /// <summary>
    /// Remove Auto Downloading Rule / 删除自动下载规则
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RemoveAutoDownloadingRule(string ruleName, CancellationToken ctk = default)
        => RemoveAutoDownloadingRuleAsync(ruleName, ctk).Result;

    /// <summary>
    /// Get All Articles Matching A Rule / 获取所有与规则匹配的 Articles
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Returns all articles that match a rule by feed name [END]
    ///     按源名称返回与规则匹配的所有项目
    /// </returns>
    public Task<Result<Dictionary<string, string[]>>> GetAllArticlesMatchingARuleAsync(string ruleName, CancellationToken ctk = default)
        => DoPostAsync<Result<Dictionary<string, string[]>>>("/rss/matchingArticles",
            $"ruleName={HttpUtility.UrlEncode(ruleName)}", ctk);

    /// <summary>
    /// Get All Articles Matching A Rule / 获取所有与规则匹配的 Articles
    /// </summary>
    /// <param name="ruleName">Rule Name / 规则名称</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Returns all articles that match a rule by feed name [END]
    ///     按源名称返回与规则匹配的所有项目
    /// </returns>
    public Result<Dictionary<string, string[]>> GetAllArticlesMatchingARule(string ruleName, CancellationToken ctk = default)
        => GetAllArticlesMatchingARuleAsync(ruleName, ctk).Result;
}
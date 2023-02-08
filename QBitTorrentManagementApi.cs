using CocoaAni.Net.WebApi;
using CocoaAni.QBitTorrentApis.Enums;
using CocoaAni.QBitTorrentApis.Models;
using CocoaAni.ToolKit.String;
using System.Text;
using System.Web;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentManagementApi : WebApiComponent
{
    public QBitTorrentManagementApi(WebApiComponent otherComponent) : base(otherComponent)
    {
    }

    public QBitTorrentManagementApi(Uri host, WebApiConfig? requestConfig = null, HttpClient? httpClient = null) : base(requestConfig, httpClient)
    {
        BaseUri = host.ToString() + "/api/v2";
    }

    /// <summary>
    /// Get Torrent List / 获取种子列表
    /// </summary>
    /// <param name="args">args / 参数</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent List / 种子列表</returns>
    public Task<Result<List<Torrent>>> GetTorrentListAsync(GetTorrentListArgs args, CancellationToken ctk = default)
        => DoGetAsync<Result<List<Torrent>>>("/torrents/info", args, ctk);

    /// <summary>
    /// Get Torrent List / 获取种子列表
    /// </summary>
    /// <param name="args">args / 参数</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent List / 种子列表</returns>
    public Result<List<Torrent>> GetTorrentList(GetTorrentListArgs args, CancellationToken ctk = default)
        => GetTorrentListAsync(args, ctk).Result;

    /// <summary>
    /// Get torrent generic properties / 获取种子通用属性
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Generic Properties / 种子通用属性</returns>
    public Task<Result<TorrentGenericProperties>> GetTorrentGenericPropertiesAsync(string hash,
        CancellationToken ctk = default)
        => DoGetAsync<Result<TorrentGenericProperties>>($"/torrents/properties?hash={hash}", null, ctk);

    /// <summary>
    /// Get torrent generic properties / 获取种子通用属性
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Generic Properties / 种子通用属性</returns>
    public Result<TorrentGenericProperties> GetTorrentGenericProperties(string hash, CancellationToken ctk = default)
        => GetTorrentGenericPropertiesAsync(hash, ctk).Result;

    /// <summary>
    /// Get Torrent Trackers / 获取种子跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Trackers / 种子跟踪器</returns>
    public Task<Result<List<Tracker>>> GetTorrentTrackersAsync(string hash, CancellationToken ctk = default)
        => DoGetAsync<Result<List<Tracker>>>($"/torrents/trackers?hash={hash}", null, ctk);

    /// <summary>
    /// Get Torrent Trackers / 获取种子跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Trackers / 种子跟踪器</returns>
    public Result<List<Tracker>> GetTorrentTrackers(string hash, CancellationToken ctk = default)
        => GetTorrentTrackersAsync(hash, ctk).Result;

    /// <summary>
    /// Get Torrent Web Seeds / 获取种子网络发送
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Web Seeds / 种子网络发送</returns>
    public Task<Result<List<TorrentWebSeed>>> GetTorrentWebSeedsAsync(string hash, CancellationToken ctk = default)
        => DoGetAsync<Result<List<TorrentWebSeed>>>($"/torrents/webseeds?hash={hash}", null, ctk);

    /// <summary>
    /// Get Torrent Web Seeds / 获取种子网络发送
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Web Seeds / 种子网络发送</returns>
    public Result<List<TorrentWebSeed>> GetTorrentWebSeeds(string hash, CancellationToken ctk = default)
        => GetTorrentWebSeedsAsync(hash, ctk).Result;

    /// <summary>
    /// Get Torrent Contents / 获取种子内容
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="indexes">The indexes of the files you want to retrieve. indexes can contain multiple values separated by |. / 要检索的文件的索引。索引可以包含由|分隔的多个值。</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Contents / 获取种子内容</returns>
    public Task<Result<List<TorrentContent>>> GetTorrentContentsAsync(string hash, string indexes,
        CancellationToken ctk = default)
        => DoGetAsync<Result<List<TorrentContent>>>($"/torrents/files?hash={hash}&indexes={indexes}", null, ctk);

    /// <summary>
    /// Get Torrent Contents / 获取种子内容
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="indexes">The indexes of the files you want to retrieve. indexes can contain multiple values separated by |. / 要检索的文件的索引。索引可以包含由|分隔的多个值。</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Contents / 获取种子内容</returns>
    public Result<List<TorrentContent>> GetTorrentContents(string hash, string indexes, CancellationToken ctk = default)
        => GetTorrentContentsAsync(hash, indexes, ctk).Result;

    /// <summary>
    /// Get Torrent Pieces' States / 获取种子片段的状态
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>torrent pieces' states / 种子片段的状态</returns>
    public Task<Result<List<TorrentPiecesStates>>> GetTorrentPiecesStatesAsync(string hash,
        CancellationToken ctk = default)
        => DoGetAsync<Result<List<TorrentPiecesStates>>>($"/torrents/pieceStates?hash={hash}", null, ctk);

    /// <summary>
    /// Get torrent pieces' states / 获取种子片段的状态
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>torrent pieces' states / 种子片段的状态</returns>
    public Result<List<TorrentPiecesStates>> GetTorrentPiecesState(string hash, CancellationToken ctk = default)
        => GetTorrentPiecesStatesAsync(hash, ctk).Result;

    /// <summary>
    /// Get Torrent Pieces' Hashes / 获取种子片段的哈希
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Pieces' Hashes / 种子片段的哈希</returns>
    public Task<Result<List<string>>> GetTorrentPiecesHashesAsync(string hash, CancellationToken ctk = default)
        => DoGetAsync<Result<List<string>>>($"/torrents/pieceHashes?hash={hash}", null, ctk);

    /// <summary>
    /// Get torrent pieces' hashes / 获取种子片段的哈希
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>Torrent Pieces' Hashes / 种子片段的哈希</returns>
    public Result<List<string>> GetTorrentPiecesHashes(string hash, CancellationToken ctk = default)
        => GetTorrentPiecesHashesAsync(hash, ctk).Result;

    /// <summary>
    /// Pause torrents / 暂停种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to pause. hashes can contain multiple hashes separated by |, to pause multiple torrents, or set to all, to pause all torrents. / 要暂停的种子的哈希值。哈希可以包含以|分隔的多个哈希，以暂停多个种子，或设置为all，以暂停所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> PauseTorrentsAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/pause?hashes={hashes}", null, ctk);

    /// <summary>
    /// Pause torrents / 暂停种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to pause. hashes can contain multiple hashes separated by |, to pause multiple torrents, or set to all, to pause all torrents. / 要暂停的种子的哈希值。哈希可以包含以|分隔的多个哈希，以暂停多个种子，或设置为all，以暂停所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result PauseTorrents(string hashes, CancellationToken ctk = default)
        => PauseTorrentsAsync(hashes, ctk).Result;

    /// <summary>
    /// Resume torrents / 恢复种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to resume. hashes can contain multiple hashes separated by |, to resume multiple torrents, or set to all, to resume all torrents. / 要恢复的种子的哈希值。哈希可以包含以|分隔的多个哈希，以恢复多个种子，或设置为all，以恢复所有种子</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> ResumeTorrentsAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/resume?hashes={hashes}", null, ctk);

    /// <summary>
    /// Resume torrents / 恢复种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to resume. hashes can contain multiple hashes separated by |, to resume multiple torrents, or set to all, to resume all torrents. / 要恢复的种子的哈希值。哈希可以包含以|分隔的多个哈希，以恢复多个种子，或设置为all，以恢复所有种子</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result ResumeTorrents(string hashes, CancellationToken ctk = default)
        => ResumeTorrentsAsync(hashes, ctk).Result;

    /// <summary>
    /// Delete torrents / 删除种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to delete. hashes can contain multiple hashes separated by |, to delete multiple torrents, or set to all, to delete all torrents. / 要删除的种子的哈希值。哈希可以包含多个以|分隔的哈希，以删除多个种子，或设置为all，以删除所有种子。</param>
    /// <param name="deleteFiles">If set to true, the downloaded data will also be deleted, otherwise has no effect. / 如果设置为true，下载的数据也将被删除，否则无效。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> DeleteTorrentsAsync(string hashes, bool deleteFiles, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/delete?hashes={hashes}&deleteFiles={deleteFiles}", null, ctk);

    /// <summary>
    /// Delete torrents / 删除种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to delete. hashes can contain multiple hashes separated by |, to delete multiple torrents, or set to all, to delete all torrents. / 要删除的种子的哈希值。哈希可以包含多个以|分隔的哈希，以删除多个种子，或设置为all，以删除所有种子。</param>
    /// <param name="deleteFiles">If set to true, the downloaded data will also be deleted, otherwise has no effect. / 如果设置为true，下载的数据也将被删除，否则无效。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result DeleteTorrents(string hashes, bool deleteFiles, CancellationToken ctk = default)
        => DeleteTorrentsAsync(hashes, deleteFiles, ctk).Result;

    /// <summary>
    /// Recheck torrents / 重新检查种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to recheck. hashes can contain multiple hashes separated by |, to recheck multiple torrents, or set to all, to recheck all torrents. / 要重新检查的种子的哈希值。哈希可以包含以|分隔的多个哈希，以重新检查多个种子，或设置为all以重新检查所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RecheckTorrentsAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/recheck?hashes={hashes}", null, ctk);

    /// <summary>
    /// Recheck torrents / 重新检查种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to recheck. hashes can contain multiple hashes separated by |, to recheck multiple torrents, or set to all, to recheck all torrents. / 要重新检查的种子的哈希值。哈希可以包含以|分隔的多个哈希，以重新检查多个种子，或设置为all以重新检查所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RecheckTorrents(string hashes, CancellationToken ctk = default)
        => RecheckTorrentsAsync(hashes, ctk).Result;

    /// <summary>
    /// Reannounce torrents / 重新发布种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to reannounce. hashes can contain multiple hashes separated by |, to reannounce multiple torrents, or set to all, to reannounce all torrents. / 你想要复活的激流的哈希。哈希可以包含以|分隔的多个哈希，以重新生成多个种子，或设置为all以重新生成所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> ReannounceTorrentsAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/reannounce?hashes={hashes}", null, ctk);

    /// <summary>
    /// Reannounce torrents / 重新发布种子
    /// </summary>
    /// <param name="hashes">The hashes of the torrents you want to reannounce. hashes can contain multiple hashes separated by |, to reannounce multiple torrents, or set to all, to reannounce all torrents. / 你想要复活的激流的哈希。哈希可以包含以|分隔的多个哈希，以重新生成多个种子，或设置为all以重新生成所有种子。</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result ReannounceTorrents(string hashes, CancellationToken ctk = default)
        => ReannounceTorrentsAsync(hashes, ctk).Result;

    /// <summary>
    /// Add New Torrent From Urls / 从Urls添加新种子
    /// </summary>
    /// <param name="urls">Urls</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Task<Result> AddNewTorrentFromUrlsAsync(IEnumerable<string> urls, AddTorrentArgs args,
        CancellationToken ctk = default)
    {
        var mFormData = new MultipartFormData();
        args.OutputFormDataItems(mFormData);
        var sb = new StringBuilder();
        foreach (var url in urls)
        {
            sb.AppendLine(url);
        }

        mFormData.Add(new FormDataItem("paths", sb.ToString()));
        return DoPostAsync<Result>($"/torrents/add", mFormData, ctk);
    }

    /// <summary>
    /// Add New Torrent From Urls / 从Urls添加新种子
    /// </summary>
    /// <param name="urls">Urls</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Result AddNewTorrentFromUrls(IEnumerable<string> urls, AddTorrentArgs args, CancellationToken ctk = default)
        => AddNewTorrentFromUrlsAsync(urls, args, ctk).Result;

    /// <summary>
    /// Add New Torrent From Url / 从Url添加新种子
    /// </summary>
    /// <param name="url">Url</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Task<Result> AddNewTorrentFromUrlAsync(string url, AddTorrentArgs args, CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(new[] { url }, args, ctk);

    /// <summary>
    /// Add New Torrent From Url / 从Url添加新种子
    /// </summary>
    /// <param name="url">Url</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Result AddNewTorrentFromUrl(string url, AddTorrentArgs args, CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(new[] { url }, args, ctk).Result;

    /// <summary>
    /// Add New Torrent From Local File Paths / 从本地文件路径添加新种子
    /// </summary>
    /// <param name="paths">Local File Paths / 本地文件路径</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Task<Result> AddNewTorrentFromFilesAsync(IEnumerable<string> paths, AddTorrentArgs args,
        CancellationToken ctk = default)
    {
        try
        {
            var mFormData = new MultipartFormData();
            args.OutputFormDataItems(mFormData);
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var url in paths)
            {
                var info = new FileInfo(url);
                var data = File.ReadAllBytes(url);
                mFormData.Add(new FormDataItem("torrents", data, null, info.Name));
            }

            return DoPostAsync<Result>($"/torrents/add", mFormData, ctk);
        }
        catch (Exception e)
        {
            return Task.FromResult(new Result(e));
        }
    }

    /// <summary>
    /// Add New Torrent From Local File Paths / 从本地文件路径添加新种子
    /// </summary>
    /// <param name="paths">Local File Paths / 本地文件路径</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Result AddNewTorrentFromFiles(IEnumerable<string> paths, AddTorrentArgs args,
        CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(paths, args, ctk).Result;

    /// <summary>
    /// Add New Torrent From Files / 从本地文件路径添加新种子
    /// </summary>
    /// <param name="fileInfos">Local File Info / 本地文件信息</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> AddNewTorrentFromFilesAsync(IEnumerable<FileInfo> fileInfos, AddTorrentArgs args,
        CancellationToken ctk = default)
    {
        try
        {
            var mFormData = new MultipartFormData();
            args.OutputFormDataItems(mFormData);
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var fileInfo in fileInfos)
            {
                mFormData.Add(new FormDataItem("torrents", fileInfo, null, fileInfo.Name));
            }

            return DoPostAsync<Result>($"/torrents/add", mFormData, ctk);
        }
        catch (Exception e)
        {
            return Task.FromResult(new Result(e));
        }
    }

    /// <summary>
    /// Add New Torrent From Files / 从本地文件路径添加新种子
    /// </summary>
    /// <param name="fileInfos">Local File Info / 本地文件信息</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Result AddNewTorrentFromFiles(IEnumerable<FileInfo> fileInfos, AddTorrentArgs args,
        CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(fileInfos, args, ctk).Result;

    public Task<Result> AddNewTorrentFromFileAsync(FileInfo fileInfo, AddTorrentArgs args,
        CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(new[] { fileInfo }, args, ctk);

    /// <summary>
    /// Add New Torrent From File / 从本地文件路径添加新种子
    /// </summary>
    /// <param name="fileInfo">FileInfo / 本地文件信息</param>
    /// <param name="args">参数</param>
    /// <param name="ctk"></param>
    /// <returns>
    /// HTTP Status Code |
    /// 415: Torrent file is not valid |
    /// 200: All other scenarios |
    /// </returns>
    public Result AddNewTorrentFromFile(FileInfo fileInfo, AddTorrentArgs args, CancellationToken ctk = default)
        => AddNewTorrentFromFilesAsync(new[] { fileInfo }, args, ctk).Result;

    /// <summary>
    /// Add Trackers To Torrent / 向种子添加跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">Note %0A (aka LF newline) between trackers. Ampersand in tracker urls MUST be escaped. / 注意跟踪器之间的%0A（又名LF换行符）。跟踪器URL中的安培数必须转义。</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddTrackersToTorrentAsync(string hash, string urls, CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/addTrackers", $"hash={hash}&urls={urls}", ctk);

    /// <summary>
    /// Add Trackers To Torrent / 向种子添加跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">Note %0A (aka LF newline) between trackers. Ampersand in tracker urls MUST be escaped. / 注意跟踪器之间的%0A（又名LF换行符）。跟踪器URL中的安培数必须转义。</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddTrackersToTorrent(string hash, string urls, CancellationToken ctk = default)
        => AddTrackersToTorrentAsync(hash, urls, ctk).Result;

    /// <summary>
    /// Add Trackers To Torrent / 向种子添加跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">urls / URL 连接</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddTrackersToTorrentAsync(string hash, IEnumerable<string> urls,
        CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/addTrackers", $"hash={hash}&urls={urls.Merger("%0")}", ctk);

    /// <summary>
    /// Add Trackers To Torrent / 向种子添加跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">urls / URL 连接</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddTrackersToTorrent(string hash, IEnumerable<string> urls, CancellationToken ctk = default)
        => AddTrackersToTorrentAsync(hash, urls, ctk).Result;

    /// <summary>
    /// Edit trackers / 编辑跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="origUrl">The tracker URL you want to edit / 要编辑的跟踪器URL</param>
    /// <param name="newUrl">The new URL to replace the origUrl / 替换origUrl的新URL</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: newUrl is not a valid URL |
    ///     404: Torrent hash was not found |
    ///     409: newUrl already exists for the torrent |
    ///     409: origUrl was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddTrackersToTorrentAsync(string hash, string origUrl, string newUrl,
        CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/editTracker", $"hash={hash}&origUrl={origUrl}&newUrl={newUrl}", ctk);

    /// <summary>
    /// Edit trackers / 编辑跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="origUrl">The tracker URL you want to edit / 要编辑的跟踪器URL</param>
    /// <param name="newUrl">The new URL to replace the origUrl / 替换origUrl的新URL</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: newUrl is not a valid URL |
    ///     404: Torrent hash was not found |
    ///     409: newUrl already exists for the torrent |
    ///     409: origUrl was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddTrackersToTorrent(string hash, string origUrl, string newUrl, CancellationToken ctk = default)
        => AddTrackersToTorrentAsync(hash, origUrl, newUrl, ctk).Result;

    /// <summary>
    /// Remove Trackers / 删除跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">URLs to remove, separated by | 要删除的URL，以分隔|</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> RemoveTrackersAsync(string hash, string urls, CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/removeTrackers", $"hash={hash}&urls={urls}", ctk);

    /// <summary>
    /// Remove Trackers / 删除跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">URLs to remove, separated by | 要删除的URL，以分隔|</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result RemoveTrackers(string hash, string urls, CancellationToken ctk = default)
        => RemoveTrackersAsync(hash, urls, ctk).Result;

    /// <summary>
    /// Remove Trackers / 删除跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">URLs to remove / 要删除的URL</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> RemoveTrackersAsync(string hash, IEnumerable<string> urls, CancellationToken ctk = default)
        => RemoveTrackersAsync(hash, urls.Merger("|"), ctk);

    /// <summary>
    /// Remove Trackers / 删除跟踪器
    /// </summary>
    /// <param name="hash">Torrent Hash / 种子哈希值</param>
    /// <param name="urls">URLs to remove / 要删除的URL</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result RemoveTrackers(string hash, IEnumerable<string> urls, CancellationToken ctk = default)
        => RemoveTrackersAsync(hash, urls, ctk).Result;

    /// <summary>
    /// Add Peers / 添加对等方
    /// </summary>
    /// <param name="hashes">
    ///     The hash of the torrent, or multiple hashes separated by a pipe |
    ///     种子的哈希，或由管道分隔的多个哈希|
    /// </param>
    /// <param name="peers">
    ///     The peer to add, or multiple peers separated by a pipe |. Each peer is a colon-separated host:port
    ///     要添加的对等体，或由管道|分隔的多个对等体。每个对等端都是一个冒号分隔的主机：端口
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddPeersAsync(string hashes, string peers, CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/addPeers", $"hashes={hashes}&peers={peers}", ctk);

    /// <summary>
    /// Add Peers / 添加对等方
    /// </summary>
    /// <param name="hashes">
    ///     The hash of the torrent, or multiple hashes separated by a pipe |
    ///     种子的哈希，或由管道分隔的多个哈希|
    /// </param>
    /// <param name="peers">
    ///     The peer to add, or multiple peers separated by a pipe |. Each peer is a colon-separated host:port
    ///     要添加的对等体，或由管道|分隔的多个对等体。每个对等端都是一个冒号分隔的主机：端口
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash was not found |
    ///     409: All urls were not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddPeers(string hashes, string peers, CancellationToken ctk = default)
        => AddPeersAsync(hashes, peers, ctk).Result;

    /// <summary>
    /// Add Peers / 添加对等方
    /// </summary>
    /// <param name="hashes">
    ///     The hash of the torrent, or multiple hashes
    ///     种子的哈希
    /// </param>
    /// <param name="peers">
    ///     The peer to add, or multiple peers Each peer is a colon-separated host:port
    ///     要添加的对等体。每个对等端都是一个冒号分隔的主机：端口
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: None of the supplied peers are valid |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddPeersAsync(IEnumerable<string> hashes, IEnumerable<string> peers,
        CancellationToken ctk = default)
        => AddPeersAsync(hashes.Merger("|"), peers.Merger("|"), ctk);

    /// <summary>
    /// Add Peers / 添加对等方
    /// </summary>
    /// <param name="hashes">
    ///     The hash of the torrent, or multiple hashes
    ///     种子的哈希
    /// </param>
    /// <param name="peers">
    ///     The peer to add, or multiple peers Each peer is a colon-separated host:port
    ///     要添加的对等体。每个对等端都是一个冒号分隔的主机：端口
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: None of the supplied peers are valid |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddPeers(IEnumerable<string> hashes, IEnumerable<string> peers, CancellationToken ctk = default)
        => AddPeersAsync(hashes.Merger("|"), peers.Merger("|"), ctk).Result;

    /// <summary>
    /// Increase Torrent Priority / 提高种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to increase the priority of. hashes can contain multiple hashes separated by |, to increase the priority of multiple torrents, or set to all, to increase the priority of all torrents. /
    ///    要提高优先级的种子的哈希值。哈希可以包含多个以|分隔的哈希，以提高多个种子的优先级，或者设置为all，以提高所有种子的优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> IncreaseTorrentPriorityAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/increasePrio?hashes={hashes}", null, ctk);

    /// <summary>
    /// Increase Torrent Priority / 提高种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to increase the priority of. hashes can contain multiple hashes separated by |, to increase the priority of multiple torrents, or set to all, to increase the priority of all torrents. /
    ///    要提高优先级的种子的哈希值。哈希可以包含多个以|分隔的哈希，以提高多个种子的优先级，或者设置为all，以提高所有种子的优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result IncreaseTorrentPriority(string hashes, CancellationToken ctk = default)
        => IncreaseTorrentPriorityAsync(hashes, ctk).Result;

    /// <summary>
    /// Increase Torrent Priority / 提高种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to increase the priority of. hashes can contain multiple hashes , to increase the priority of multiple torrents, or set to all, to increase the priority of all torrents. /
    ///    要提高优先级的种子的哈希值，提高多个种子的优先级，或者设置为all，以提高所有种子的优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> IncreaseTorrentPriorityAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => IncreaseTorrentPriorityAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Increase Torrent Priority / 提高种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to increase the priority of. hashes can contain multiple hashes , to increase the priority of multiple torrents, or set to all, to increase the priority of all torrents. /
    ///    要提高优先级的种子的哈希值，提高多个种子的优先级，或者设置为all，以提高所有种子的优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result IncreaseTorrentPriority(IEnumerable<string> hashes, CancellationToken ctk = default)
        => IncreaseTorrentPriorityAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Decrease torrent priority / 降低种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to decrease the priority of. hashes can contain multiple hashes separated by |, to decrease the priority of multiple torrents, or set to all, to decrease the priority of all torrents. /
    ///    要降低优先级的种子的哈希值。哈希可以包含以|分隔的多个哈希，以降低多个种子的优先级，或设置为all，以降低所有种子的优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> DecreaseTorrentPriorityAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/decreasePrio?hashes={hashes}", null, ctk);

    /// <summary>
    /// Decrease torrent priority / 降低种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to decrease the priority of. hashes can contain multiple hashes separated by |, to decrease the priority of multiple torrents, or set to all, to decrease the priority of all torrents. /
    ///    要降低优先级的种子的哈希值。哈希可以包含以|分隔的多个哈希，以降低多个种子的优先级，或设置为all，以降低所有种子的优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result DecreaseTorrentPriority(string hashes, CancellationToken ctk = default)
        => DecreaseTorrentPriorityAsync(hashes, ctk).Result;

    /// <summary>
    /// Decrease torrent priority / 降低种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to decrease the priority of. hashes can contain multiple hashes, to decrease the priority of multiple torrents, or set to all, to decrease the priority of all torrents. /
    ///    要降低优先级的种子的哈希值,或设置为all，以降低所有种子的优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> DecreaseTorrentPriorityAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => DecreaseTorrentPriorityAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Decrease torrent priority / 降低种子优先级
    /// </summary>
    /// <param name="hashes">
    ///    The hashes of the torrents you want to decrease the priority of. hashes can contain multiple hashes, to decrease the priority of multiple torrents, or set to all, to decrease the priority of all torrents. /
    ///    要降低优先级的种子的哈希值,或设置为all，以降低所有种子的优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result DecreaseTorrentPriority(IEnumerable<string> hashes, CancellationToken ctk = default)
        => DecreaseTorrentPriorityAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Maximal Torrent Priority / 种子最大优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the maximum priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the maximum priority, or set to all, to set all torrents to the maximum priority.
    ///   要设置为最大优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最大优先级，或设置为all，以将所有种子设置为最高优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> MaximalTorrentPriorityAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/topPrio?hashes={hashes}", null, ctk);

    /// <summary>
    /// Maximal Torrent Priority / 种子最大优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the maximum priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the maximum priority, or set to all, to set all torrents to the maximum priority.
    ///   要设置为最大优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最大优先级，或设置为all，以将所有种子设置为最高优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result MaximalTorrentPriority(string hashes, CancellationToken ctk = default)
        => MaximalTorrentPriorityAsync(hashes, ctk).Result;

    /// <summary>
    /// Maximal Torrent Priority / 种子最大优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the maximum priority. hashes can contain multiple hashes, to set multiple torrents to the maximum priority, or set to all, to set all torrents to the maximum priority.
    ///   要设置为最大优先级的种子哈希，以将多个种子设置为最大优先级，或设置为all，以将所有种子设置为最高优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> MaximalTorrentPriorityAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => MaximalTorrentPriorityAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Maximal Torrent Priority / 种子最大优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the maximum priority. hashes can contain multiple hashes, to set multiple torrents to the maximum priority, or set to all, to set all torrents to the maximum priority.
    ///   要设置为最大优先级的种子哈希，以将多个种子设置为最大优先级，或设置为all，以将所有种子设置为最高优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result MaximalTorrentPriority(IEnumerable<string> hashes, CancellationToken ctk = default)
        => MaximalTorrentPriorityAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Minimal Torrent Priority / 种子最低优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the minimal priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the minimal priority, or set to all, to set all torrents to the minimum priority.
    ///   要设置为最低优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最低优先级，或设置为all，以将所有种子设置为最低优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> MinimalTorrentPriorityAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/bottomPrio?hashes={hashes}", null, ctk);

    /// <summary>
    /// Minimal Torrent Priority / 种子最低优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the minimal priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the minimal priority, or set to all, to set all torrents to the minimum priority.
    ///   要设置为最低优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最低优先级，或设置为all，以将所有种子设置为最低优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result MinimalTorrentPriority(string hashes, CancellationToken ctk = default)
        => MinimalTorrentPriorityAsync(hashes, ctk).Result;

    /// <summary>
    /// Minimal Torrent Priority / 种子最低优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the minimal priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the minimal priority, or set to all, to set all torrents to the minimum priority.
    ///   要设置为最低优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最低优先级，或设置为all，以将所有种子设置为最低优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> MinimalTorrentPriorityAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => MinimalTorrentPriorityAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Minimal Torrent Priority / 种子最低优先级
    /// </summary>
    /// <param name="hashes">
    ///   The hashes of the torrents you want to set to the minimal priority. hashes can contain multiple hashes separated by |, to set multiple torrents to the minimal priority, or set to all, to set all torrents to the minimum priority.
    ///   要设置为最低优先级的种子哈希。哈希可以包含以|分隔的多个哈希，以将多个种子设置为最低优先级，或设置为all，以将所有种子设置为最低优先级。
    ///</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Torrent queueing is not enabled |
    ///     200: All other scenarios |
    /// </returns>
    public Result MinimalTorrentPriority(IEnumerable<string> hashes, CancellationToken ctk = default)
        => MinimalTorrentPriorityAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Set File Priority / 设置文件优先级
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子哈希值</param>
    /// <param name="id">
    ///     File ids, separated by |
    ///     文件ID，以分隔|
    /// </param>
    /// <param name="priority"></param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Priority is invalid |
    ///     400: At least one file id is not a valid integer |
    ///     404: Torrent hash was not found |
    ///     409: Torrent metadata hasn't downloaded yet |
    ///     409: At least one file id was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetFilePriorityAsync(string hash, string id, int priority, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/filePrio?hash={hash}&id={id}&priority={priority}", null, ctk);

    /// <summary>
    /// Set File Priority / 设置文件优先级
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子哈希值</param>
    /// <param name="id">
    ///     File ids, separated by |
    ///     文件ID，以分隔|
    /// </param>
    /// <param name="priority"></param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Priority is invalid |
    ///     400: At least one file id is not a valid integer |
    ///     404: Torrent hash was not found |
    ///     409: Torrent metadata hasn't downloaded yet |
    ///     409: At least one file id was not found |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetFilePriority(string hash, string id, int priority, CancellationToken ctk = default)
        => SetFilePriorityAsync(hash, id, priority, ctk).Result;

    /// <summary>
    /// Get Torrent Download Limit / 获取种子下载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Torrent Download Limit. This value will be zero if no limit is applied.  /
    ///     种子下载限 如果没有应用限制，该值将为零。
    /// </returns>
    public Task<Result<TorrentsLimit>> GetTorrentDownloadLimitAsync(string hashes, CancellationToken ctk = default)
        => DoPostAsync<Result<TorrentsLimit>>("/torrents/downloadLimit", $"hashes={hashes}", ctk);

    /// <summary>
    /// Get Torrent Download Limit / 获取种子下载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Torrent Download Limit. This value will be zero if no limit is applied.  /
    ///     种子下载限 如果没有应用限制，该值将为零。
    /// </returns>
    public Result<TorrentsLimit> GetTorrentDownloadLimit(string hashes, CancellationToken ctk = default)
        => GetTorrentDownloadLimitAsync(hashes, ctk).Result;

    /// <summary>
    /// Get Torrent Download Limit / 获取种子下载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Torrent Download Limit. This value will be zero if no limit is applied.  /
    ///     种子下载限 如果没有应用限制，该值将为零。
    /// </returns>
    public Task<Result<TorrentsLimit>> GetTorrentDownloadLimitAsync(IEnumerable<string> hashes,
        CancellationToken ctk = default)
        => GetTorrentDownloadLimitAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Get Torrent Download Limit / 获取种子下载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     Torrent Download Limit. This value will be zero if no limit is applied.  /
    ///     种子下载限 如果没有应用限制，该值将为零。
    /// </returns>
    public Result<TorrentsLimit> GetTorrentDownloadLimit(IEnumerable<string> hashes, CancellationToken ctk = default)
        => GetTorrentDownloadLimitAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Set Torrent Download Limit / 设置种子下载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="limit">
    ///     limit is the download speed limit in bytes per second you want to set. /
    ///     limit是要设置的下载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentDownloadLimitAsync(string hashes, int limit, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setDownloadLimit", $"hashes={hashes}&limit={limit}", ctk);

    /// <summary>
    /// Set Torrent Download Limit / 设置种子下载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="limit">
    ///     limit is the download speed limit in bytes per second you want to set. /
    ///     limit是要设置的下载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentDownloadLimit(string hashes, int limit, CancellationToken ctk = default)
        => SetTorrentDownloadLimitAsync(hashes, limit, ctk).Result;

    /// <summary>
    /// Set Torrent Download Limit / 设置种子下载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="limit">Limit / 下载限制</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentDownloadLimitAsync(IEnumerable<string> hashes, int limit,
        CancellationToken ctk = default)
        => SetTorrentDownloadLimitAsync(hashes.Merger("|"), limit, ctk);

    /// <summary>
    /// Set Torrent Download Limit / 设置种子下载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="limit">Limit / 下载限制</param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentDownloadLimit(IEnumerable<string> hashes, int limit, CancellationToken ctk = default)
        => SetTorrentDownloadLimitAsync(hashes.Merger("|"), limit, ctk).Result;

    /// <summary>
    /// Set Torrent Share Limit / 设置种子共享限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ratioLimit">
    ///     ratioLimit is the max ratio the torrent should be seeded until. -2 means the global limit should be used, -1 means no limit.  /
    ///     ratioLimit是种子种子应播种到的最大比率-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="seedingTimeLimit">
    ///     seedingTimeLimit is the max amount of time (minutes) the torrent should be seeded. -2 means the global limit should be used, -1 means no limit. /
    ///     seedingTimeLimit是种子种子应播种的最长时间（分钟）-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentShareLimitAsync(string hashes, float ratioLimit, int seedingTimeLimit,
        CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setShareLimits",
            $"hashes={hashes}&ratioLimit={ratioLimit}&seedingTimeLimit={seedingTimeLimit}", ctk);

    /// <summary>
    /// Set Torrent Share Limit / 设置种子共享限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ratioLimit">
    ///     ratioLimit is the max ratio the torrent should be seeded until. -2 means the global limit should be used, -1 means no limit.  /
    ///     ratioLimit是种子种子应播种到的最大比率-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="seedingTimeLimit">
    ///     seedingTimeLimit is the max amount of time (minutes) the torrent should be seeded. -2 means the global limit should be used, -1 means no limit. /
    ///     seedingTimeLimit是种子种子应播种的最长时间（分钟）-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentShareLimit(string hashes, float ratioLimit, int seedingTimeLimit,
        CancellationToken ctk = default)
        => SetTorrentShareLimitAsync(hashes, ratioLimit, seedingTimeLimit, ctk).Result;

    /// <summary>
    /// Set Torrent Share Limit / 设置种子共享限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes/
    ///     哈希可以包多个哈希
    /// </param>
    /// <param name="ratioLimit">
    ///     ratioLimit is the max ratio the torrent should be seeded until. -2 means the global limit should be used, -1 means no limit.  /
    ///     ratioLimit是种子种子应播种到的最大比率-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="seedingTimeLimit">
    ///     seedingTimeLimit is the max amount of time (minutes) the torrent should be seeded. -2 means the global limit should be used, -1 means no limit. /
    ///     seedingTimeLimit是种子种子应播种的最长时间（分钟）-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentShareLimitAsync(IEnumerable<string> hashes, float ratioLimit, int seedingTimeLimit,
        CancellationToken ctk = default)
        => SetTorrentShareLimitAsync(hashes.Merger("|"), ratioLimit, seedingTimeLimit, ctk);

    /// <summary>
    /// Set Torrent Share Limit / 设置种子共享限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes/
    ///     哈希可以包多个哈希
    /// </param>
    /// <param name="ratioLimit">
    ///     ratioLimit is the max ratio the torrent should be seeded until. -2 means the global limit should be used, -1 means no limit.  /
    ///     ratioLimit是种子种子应播种到的最大比率-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="seedingTimeLimit">
    ///     seedingTimeLimit is the max amount of time (minutes) the torrent should be seeded. -2 means the global limit should be used, -1 means no limit. /
    ///     seedingTimeLimit是种子种子应播种的最长时间（分钟）-2表示应使用全局限制，-1表示无限制。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentShareLimit(IEnumerable<string> hashes, float ratioLimit, int seedingTimeLimit,
        CancellationToken ctk = default)
        => SetTorrentShareLimitAsync(hashes.Merger("|"), ratioLimit, seedingTimeLimit, ctk).Result;

    /// <summary>
    /// Get Torrent Upload Limit / 获取种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result<TorrentsLimit>> GetTorrentUploadLimitAsync(string hashes, CancellationToken ctk = default)
        => DoPostAsync<Result<TorrentsLimit>>("/torrents/uploadLimit", $"hashes={hashes}", ctk);

    /// <summary>
    /// Get Torrent Upload Limit / 获取种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result<TorrentsLimit> GetTorrentUploadLimit(string hashes, CancellationToken ctk = default)
        => GetTorrentUploadLimitAsync(hashes, ctk).Result;

    /// <summary>
    /// Get Torrent Upload Limit / 获取种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes
    ///     多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result<TorrentsLimit>> GetTorrentUploadLimitAsync(IEnumerable<string> hashes,
        CancellationToken ctk = default)
        => GetTorrentUploadLimitAsync(hashes.Merger("|"), ctk);

    /// <summary>
    ///
    /// Get Torrent Upload Limit / 获取种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes
    ///     多个哈希
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result<TorrentsLimit> GetTorrentUploadLimit(IEnumerable<string> hashes, CancellationToken ctk = default)
        => GetTorrentUploadLimitAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Set Torrent Upload Limit / 设置种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="limit">
    ///     limit is the upload speed limit in bytes per second you want to set. /
    ///     limit是要设置的上载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentUploadLimitAsync(string hashes, int limit, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setUploadLimit", $"hashes={hashes}&limit={limit}", ctk);

    /// <summary>
    /// Set Torrent Upload Limit / 设置种子上载限制
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="limit">
    ///     limit is the upload speed limit in bytes per second you want to set. /
    ///     limit是要设置的上载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentUploadLimit(string hashes, int limit, CancellationToken ctk = default)
        => SetTorrentUploadLimitAsync(hashes, limit, ctk).Result;

    /// <summary>
    /// Set Torrent Upload Limit / 设置种子上载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="limit">
    ///     limit is the upload speed limit in bytes per second you want to set. /
    ///     limit是要设置的上载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetTorrentUploadLimitAsync(IEnumerable<string> hashes, int limit,
        CancellationToken ctk = default)
        => SetTorrentUploadLimitAsync(hashes.Merger("|"), limit, ctk);

    /// <summary>
    /// Set Torrent Upload Limit / 设置种子上载限制
    /// </summary>
    /// <param name="hashes">Torrent Hashes / 种子哈希值</param>
    /// <param name="limit">
    ///     limit is the upload speed limit in bytes per second you want to set. /
    ///     limit是要设置的上载速度限制（以字节/秒为单位）。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetTorrentUploadLimit(IEnumerable<string> hashes, int limit, CancellationToken ctk = default)
        => SetTorrentUploadLimitAsync(hashes.Merger("|"), limit, ctk).Result;

    /// <summary>
    /// Set Torrent Location / 设置种子位置
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="location">
    ///     if location doesn't exist, the torrent's location is unchanged. /
    ///     如果位置不存在，torrent的位置不变。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Save path is empty |
    ///     403: User does not have write access to directory |
    ///     409: Unable to create save path directory |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetTorrentLocationAsync(string hashes, string location, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setLocation", $"hashes={hashes}&location={HttpUtility.UrlEncode(location)}",
            ctk);

    /// <summary>
    /// Set Torrent Location / 设置种子位置
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="location">
    ///     if location doesn't exist, the torrent's location is unchanged. /
    ///     如果位置不存在，torrent的位置不变。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Save path is empty |
    ///     403: User does not have write access to directory |
    ///     409: Unable to create save path directory |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetTorrentLocation(string hashes, string location, CancellationToken ctk = default)
        => SetTorrentLocationAsync(hashes, location, ctk).Result;

    /// <summary>
    /// Set Torrent Location / 设置种子位置
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="location">
    ///     if location doesn't exist, the torrent's location is unchanged. /
    ///     如果位置不存在，torrent的位置不变。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Save path is empty |
    ///     403: User does not have write access to directory |
    ///     409: Unable to create save path directory |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetTorrentLocationAsync(IEnumerable<string> hashes, string location,
        CancellationToken ctk = default)
        => SetTorrentLocationAsync(hashes.Merger("|"), location, ctk);

    /// <summary>
    /// Set Torrent Location / 设置种子位置
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="location">
    ///     if location doesn't exist, the torrent's location is unchanged. /
    ///     如果位置不存在，torrent的位置不变。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Save path is empty |
    ///     403: User does not have write access to directory |
    ///     409: Unable to create save path directory |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetTorrentLocation(IEnumerable<string> hashes, string location, CancellationToken ctk = default)
        => SetTorrentLocationAsync(hashes.Merger("|"), location, ctk).Result;

    /// <summary>
    /// Set Torrent Name / 设置种子名称
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子哈希值</param>
    /// <param name="name">NewName / 新的名字</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash is invalid |
    ///     409: Torrent name is empty |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetTorrentNameAsync(string hash, string name, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/rename", $"hash={hash}&name={HttpUtility.UrlEncode(name)}", ctk);

    /// <summary>
    /// Set Torrent Name / 设置种子名称
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子哈希值</param>
    /// <param name="name">NewName / 新的名字</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     404: Torrent hash is invalid |
    ///     409: Torrent name is empty |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetTorrentName(string hash, string name, CancellationToken ctk = default)
        => SetTorrentNameAsync(hash, name, ctk).Result;

    /// <summary>
    /// Set Torrent Category / 设置种子类别
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="category">
    ///     The torrent category you want to set. /
    ///     要设置的种子类别。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Category name does not exist |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetTorrentCategoryAsync(string hashes, string category, CancellationToken ctk = default)
        => DoPostAsync<Result>($"/torrents/setCategory", $"hashes={hashes}&category={HttpUtility.UrlEncode(category)}",
            ctk);

    /// <summary>
    /// Set Torrent Category / 设置种子类别
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="category">
    ///     The torrent category you want to set. /
    ///     要设置的种子类别。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Category name does not exist |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetTorrentCategory(string hashes, string category, CancellationToken ctk = default)
        => SetTorrentCategoryAsync(hashes, category, ctk).Result;

    /// <summary>
    /// Set Torrent Category / 设置种子类别
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes
    ///     哈希可以包含多个
    /// </param>
    /// <param name="category">
    ///     The torrent category you want to set. /
    ///     要设置的种子类别。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Category name does not exist |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> SetTorrentCategoryAsync(IEnumerable<string> hashes, string category,
        CancellationToken ctk = default)
        => SetTorrentCategoryAsync(hashes.Merger("|"), category, ctk);

    /// <summary>
    /// Set Torrent Category / 设置种子类别
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes
    ///     哈希可以包含多个
    /// </param>
    /// <param name="category">
    ///     The torrent category you want to set. /
    ///     要设置的种子类别。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     409: Category name does not exist |
    ///     200: All other scenarios |
    /// </returns>
    public Result SetTorrentCategory(IEnumerable<string> hashes, string category, CancellationToken ctk = default)
        => SetTorrentCategoryAsync(hashes.Merger("|"), category, ctk).Result;

    /// <summary>
    /// Get All Categories / 获取所有类别
    /// </summary>
    /// <returns>All Categories / 所有类别</returns>
    public Task<Result<Dictionary<string, Category>>> GetAllCategoriesAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<Dictionary<string, Category>>>("/torrents/categories", null, ctk);

    /// <summary>
    /// Get All Categories / 获取所有类别
    /// </summary>
    /// <returns>All Categories / 所有类别</returns>
    public Result<Dictionary<string, Category>> GetAllCategories(CancellationToken ctk = default)
        => GetAllCategoriesAsync(ctk).Result;

    /// <summary>
    /// Add New Category / 添加新类别
    /// </summary>
    /// <param name="category">
    ///     category is the category you want to create. /
    ///     category是要创建的类别。
    /// </param>
    /// <param name="savePath">Save Path / 保存路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Category name is empty |
    ///     409: Category name is invalid |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> AddNewCategoryAsync(string category, string savePath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/editCategory ",
            $"category={HttpUtility.UrlEncode(category)}&savePath={HttpUtility.UrlEncode(savePath)}", ctk);

    /// <summary>
    /// Add New Category / 添加新类别
    /// </summary>
    /// <param name="category">
    ///     category is the category you want to create. /
    ///     category是要创建的类别。
    /// </param>
    /// <param name="savePath">Save Path / 保存路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Category name is empty |
    ///     409: Category name is invalid |
    ///     200: All other scenarios |
    /// </returns>
    public Result AddNewCategory(string category, string savePath, CancellationToken ctk = default)
        => AddNewCategoryAsync(category, savePath, ctk).Result;

    /// <summary>
    /// Edit Category / 编辑类别
    /// </summary>
    /// <param name="category">
    ///     category is the category you want to edit. /
    ///     category是要编辑的类别。
    /// </param>
    /// <param name="savePath">Save Path / 保存路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Category name is empty |
    ///     409: Category editing failed |
    ///     200: All other scenarios |
    /// </returns>
    public Task<Result> EditCategoryAsync(string category, string savePath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/editCategory ",
            $"category={HttpUtility.UrlEncode(category)}&savePath={HttpUtility.UrlEncode(savePath)}", ctk);

    /// <summary>
    /// Edit Category / 编辑类别
    /// </summary>
    /// <param name="category">
    ///     category is the category you want to edit. /
    ///     category是要编辑的类别。
    /// </param>
    /// <param name="savePath">Save Path / 保存路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code |
    ///     400: Category name is empty |
    ///     409: Category editing failed |
    ///     200: All other scenarios |
    /// </returns>
    public Result EditCategory(string category, string savePath, CancellationToken ctk = default)
        => EditCategoryAsync(category, savePath, ctk).Result;

    /// <summary>
    /// Remove Categories / 删除类别
    /// </summary>
    /// <param name="categories">
    ///     categories can contain multiple categories separated by \n (%0A urlencoded) /
    ///     类别可以包含多个类别，以\n（%0A URL编码）分隔
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RemoveCategoriesAsync(string categories, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/removeCategories",
            $"categories={categories}", ctk);

    /// <summary>
    /// Remove Categories / 删除类别
    /// </summary>
    /// <param name="categories">
    ///     categories can contain multiple categories separated by \n (%0A urlencoded) /
    ///     类别可以包含多个类别，以\n（%0A URL编码）分隔
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RemoveCategories(string categories, CancellationToken ctk = default)
        => RemoveCategoriesAsync(categories, ctk).Result;

    /// <summary>
    /// Remove Categories / 删除类别
    /// </summary>
    /// <param name="categories">
    ///     categories can contain multiple categories separated  /
    ///     类别可以包含多个类别
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RemoveCategoriesAsync(IEnumerable<string> categories, CancellationToken ctk = default)
        => RemoveCategoriesAsync(categories.Merger("%0A"), ctk);

    /// <summary>
    /// Remove Categories / 删除类别
    /// </summary>
    /// <param name="categories">
    ///     categories can contain multiple categories separated  /
    ///     类别可以包含多个类别
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RemoveCategories(IEnumerable<string> categories, CancellationToken ctk = default)
        => RemoveCategoriesAsync(categories.Select(HttpUtility.UrlEncode)!.Merger("%0A"), ctk).Result;

    /// <summary>
    /// Add Torrent Tags / 添加种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to add to passed torrents. /
    ///     tags是要添加到传递的种子的标记列表
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> AddTorrentTagsAsync(string hashes, string tags, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/addTags", $"hashes={hashes}&tags={tags}", ctk);

    /// <summary>
    /// Add Torrent Tags / 添加种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to add to passed torrents. /
    ///     tags是要添加到传递的种子的标记列表
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result AddTorrentTags(string hashes, string tags, CancellationToken ctk = default)
        => AddTorrentTagsAsync(hashes, tags, ctk).Result;

    /// <summary>
    /// Add Torrent Tags / 添加种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to add to passed torrents. /
    ///     tags是要添加到传递的种子的标记列表
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> AddTorrentTagsAsync(IEnumerable<string> hashes, IEnumerable<string> tags,
        CancellationToken ctk = default)
        => AddTorrentTagsAsync(hashes.Merger("|"),
            tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk);

    /// <summary>
    /// Add Torrent Tags / 添加种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to add to passed torrents. /
    ///     tags是要添加到传递的种子的标记列表
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result AddTorrentTags(IEnumerable<string> hashes, IEnumerable<string> tags, CancellationToken ctk = default)
        => AddTorrentTagsAsync(hashes.Merger("|"),
            tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk).Result;

    /// <summary>
    /// Remove Torrent Tags / 删除种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to remove from passed torrents. Empty list removes all tags from relevant torrents. /
    ///     tags是要从传递的种子中删除的标记列表。空列表将删除相关种子中的所有标记。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RemoveTorrentTagsAsync(string hashes, string tags, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/removeTags", $"hashes={hashes}&tags={tags}", ctk);

    /// <summary>
    /// Remove Torrent Tags / 删除种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to remove from passed torrents. Empty list removes all tags from relevant torrents. /
    ///     tags是要从传递的种子中删除的标记列表。空列表将删除相关种子中的所有标记。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RemoveTorrentTags(string hashes, string tags, CancellationToken ctk = default)
        => RemoveTorrentTagsAsync(hashes, tags, ctk).Result;

    /// <summary>
    /// Remove Torrent Tags / 删除种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to remove from passed torrents. Empty list removes all tags from relevant torrents. /
    ///     tags是要从传递的种子中删除的标记列表。空列表将删除相关种子中的所有标记。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> RemoveTorrentTagsAsync(IEnumerable<string> hashes, IEnumerable<string> tags,
        CancellationToken ctk = default)
        => RemoveTorrentTagsAsync(hashes.Merger("|"), tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk);

    /// <summary>
    /// Remove Torrent Tags / 删除种子标记
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all /
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="tags">
    ///     tags is the list of tags you want to remove from passed torrents. Empty list removes all tags from relevant torrents. /
    ///     tags是要从传递的种子中删除的标记列表。空列表将删除相关种子中的所有标记。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result RemoveTorrentTags(IEnumerable<string> hashes, IEnumerable<string> tags,
        CancellationToken ctk = default)
        => RemoveTorrentTagsAsync(hashes.Merger("|"), tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk).Result;

    /// <summary>
    /// Get All Tags / 获取所有标签
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result<string[]>> GetAllTagsAsync(CancellationToken ctk = default)
        => DoGetAsync<Result<string[]>>("/torrents/tags", null, ctk);

    /// <summary>
    /// Get All Tags / 获取所有标签
    /// </summary>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result<string[]> GetAllTags(CancellationToken ctk = default)
        => GetAllTagsAsync(ctk).Result;

    /// <summary>
    /// Create Tags / 创建标记
    /// </summary>
    /// <param name="tags">
    ///     tags is a list of tags you want to create. Can contain multiple tags separated by ,. [END]
    ///     标记是要创建的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> CreateTagsAsync(string tags, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/createTags", $"tags={tags}", ctk);

    /// <summary>
    /// Create Tags / 创建标记
    /// </summary>
    /// <param name="tags">
    ///     tags is a list of tags you want to create. Can contain multiple tags separated by ,. [END]
    ///     标记是要创建的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result CreateTags(string tags, CancellationToken ctk = default)
        => CreateTagsAsync(tags, ctk).Result;

    /// <summary>
    /// Create Tags / 创建标记
    /// </summary>
    /// <param name="tags">
    ///     tags is a list of tags you want to create. Can contain multiple tags separated by ,. [END]
    ///     标记是要创建的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> CreateTagsAsync(IEnumerable<string> tags, CancellationToken ctk = default)
        => CreateTagsAsync(tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk);

    /// <summary>
    /// Create Tags / 创建标记
    /// </summary>
    /// <param name="tags">
    ///     tags is a list of tags you want to create. Can contain multiple tags separated by ,. [END]
    ///     标记是要创建的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result CreateTags(IEnumerable<string> tags, CancellationToken ctk = default)
        => CreateTagsAsync(tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk).Result;

    /// <summary>
    /// Delete Tags / 删除标记
    /// </summary>
    /// <param name="tags">
    ///    tags is a list of tags you want to delete. Can contain multiple tags separated by ,. [END]
    ///    tags是要删除的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> DeleteTagsAsync(string tags, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/deleteTags", $"tags={tags}", ctk);

    /// <summary>
    /// Delete Tags / 删除标记
    /// </summary>
    /// <param name="tags">
    ///    tags is a list of tags you want to delete. Can contain multiple tags separated by ,. [END]
    ///    tags是要删除的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result DeleteTags(string tags, CancellationToken ctk = default)
        => DeleteTagsAsync(tags, ctk).Result;

    /// <summary>
    /// Delete Tags / 删除标记
    /// </summary>
    /// <param name="tags">
    ///    tags is a list of tags you want to delete. Can contain multiple tags separated by ,. [END]
    ///    tags是要删除的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> DeleteTagsAsync(IEnumerable<string> tags, CancellationToken ctk = default)
        => DeleteTagsAsync(tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk);

    /// <summary>
    /// Delete Tags / 删除标记
    /// </summary>
    /// <param name="tags">
    ///    tags is a list of tags you want to delete. Can contain multiple tags separated by ,. [END]
    ///    tags是要删除的标记列表。可以包含由、分隔的多个标记，。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result DeleteTags(IEnumerable<string> tags, CancellationToken ctk = default)
        => DeleteTagsAsync(tags.Select(HttpUtility.UrlEncode)!.Merger(","), ctk).Result;

    /// <summary>
    /// Set Automatic Torrent Management / 设置种子自动管理
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="enable">
    ///     enable is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     enable是一个布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetAutomaticTorrentManagementAsync(string hashes, bool enable, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setAutoManagement", $"hashes={hashes}&enable={enable}", ctk);

    /// <summary>
    /// Set Automatic Torrent Management / 设置种子自动管理
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="enable">
    ///     enable is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     enable是一个布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetAutomaticTorrentManagement(string hashes, bool enable, CancellationToken ctk = default)
        => SetAutomaticTorrentManagementAsync(hashes, enable, ctk).Result;

    /// <summary>
    /// Set Automatic Torrent Management / 设置种子自动管理
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="enable">
    ///     enable is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     enable是一个布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetAutomaticTorrentManagementAsync(IEnumerable<string> hashes, bool enable, CancellationToken ctk = default)
        => SetAutomaticTorrentManagementAsync(hashes.Merger("|"), enable, ctk);

    /// <summary>
    /// Set Automatic Torrent Management / 设置种子自动管理
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="enable">
    ///     enable is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     enable是一个布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetAutomaticTorrentManagement(IEnumerable<string> hashes, bool enable, CancellationToken ctk = default)
        => SetAutomaticTorrentManagementAsync(hashes.Merger("|"), enable, ctk).Result;

    /// <summary>
    /// Toggle Sequential Download / 切换顺序下载
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle sequential download for. hashes can contain multiple hashes separated by |, to toggle sequential download for multiple torrents, or set to all, to toggle sequential download for all torrents. [END]
    ///     要切换顺序下载的种子的哈希值。哈希可以包含多个以|分隔的哈希，以切换多个种子的顺序下载，或设置为all，以切换所有种子的顺序加载。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> ToggleSequentialDownloadAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/toggleSequentialDownload?hashes={hashes}", null, ctk);

    /// <summary>
    /// Toggle Sequential Download / 切换顺序下载
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle sequential download for. hashes can contain multiple hashes separated by |, to toggle sequential download for multiple torrents, or set to all, to toggle sequential download for all torrents. [END]
    ///     要切换顺序下载的种子的哈希值。哈希可以包含多个以|分隔的哈希，以切换多个种子的顺序下载，或设置为all，以切换所有种子的顺序加载。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result ToggleSequentialDownload(string hashes, CancellationToken ctk = default)
        => ToggleSequentialDownloadAsync(hashes, ctk).Result;

    /// <summary>
    /// Toggle Sequential Download / 切换顺序下载
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle sequential download for. hashes can contain multiple hashes separated by |, to toggle sequential download for multiple torrents, or set to all, to toggle sequential download for all torrents. [END]
    ///     要切换顺序下载的种子的哈希值。哈希可以包含多个以|分隔的哈希，以切换多个种子的顺序下载，或设置为all，以切换所有种子的顺序加载。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> ToggleSequentialDownloadAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => ToggleSequentialDownloadAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Toggle Sequential Download / 切换顺序下载
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle sequential download for. hashes can contain multiple hashes separated by |, to toggle sequential download for multiple torrents, or set to all, to toggle sequential download for all torrents. [END]
    ///     要切换顺序下载的种子的哈希值。哈希可以包含多个以|分隔的哈希，以切换多个种子的顺序下载，或设置为all，以切换所有种子的顺序加载。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result ToggleSequentialDownload(IEnumerable<string> hashes, CancellationToken ctk = default)
        => ToggleSequentialDownloadAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Set First Last Piece Priority / 设置首个最后一个分片优先级
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle the first/last piece priority for. hashes can contain multiple hashes separated by |, to toggle the first/last piece priority for multiple torrents, or set to all, to toggle the first/last piece priority for all torrents. [END]
    ///     要切换第一个/最后一个片段优先级的种子的哈希。哈希可以包含多个以|分隔的哈希，以切换多个种子的第一/最后一个片段优先级，或设置为all，以切换所有种子的第一个/最后一段优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetFirstLastPiecePriorityAsync(string hashes, CancellationToken ctk = default)
        => DoGetAsync<Result>($"/torrents/toggleFirstLastPiecePrio?hashes={hashes}", null, ctk);

    /// <summary>
    /// Set First Last Piece Priority / 设置首个最后一个分片优先级
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle the first/last piece priority for. hashes can contain multiple hashes separated by |, to toggle the first/last piece priority for multiple torrents, or set to all, to toggle the first/last piece priority for all torrents. [END]
    ///     要切换第一个/最后一个片段优先级的种子的哈希。哈希可以包含多个以|分隔的哈希，以切换多个种子的第一/最后一个片段优先级，或设置为all，以切换所有种子的第一个/最后一段优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetFirstLastPiecePriority(string hashes, CancellationToken ctk = default)
        => SetFirstLastPiecePriorityAsync(hashes, ctk).Result;

    /// <summary>
    /// Set First Last Piece Priority / 设置首个最后一个分片优先级
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle the first/last piece priority for. hashes can contain multiple hashes separated by |, to toggle the first/last piece priority for multiple torrents, or set to all, to toggle the first/last piece priority for all torrents. [END]
    ///     要切换第一个/最后一个片段优先级的种子的哈希。哈希可以包含多个以|分隔的哈希，以切换多个种子的第一/最后一个片段优先级，或设置为all，以切换所有种子的第一个/最后一段优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetFirstLastPiecePriorityAsync(IEnumerable<string> hashes, CancellationToken ctk = default)
        => SetFirstLastPiecePriorityAsync(hashes.Merger("|"), ctk);

    /// <summary>
    /// Set First Last Piece Priority / 设置首个最后一个分片优先级
    /// </summary>
    /// <param name="hashes">
    ///     The hashes of the torrents you want to toggle the first/last piece priority for. hashes can contain multiple hashes separated by |, to toggle the first/last piece priority for multiple torrents, or set to all, to toggle the first/last piece priority for all torrents. [END]
    ///     要切换第一个/最后一个片段优先级的种子的哈希。哈希可以包含多个以|分隔的哈希，以切换多个种子的第一/最后一个片段优先级，或设置为all，以切换所有种子的第一个/最后一段优先级。
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetFirstLastPiecePriority(IEnumerable<string> hashes, CancellationToken ctk = default)
        => SetFirstLastPiecePriorityAsync(hashes.Merger("|"), ctk).Result;

    /// <summary>
    /// Set Force Start / 设置强制启动
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔的多个哈希或设置为all
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetForceStartAsync(string hashes, bool value, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setForceStart", $"hashes={hashes}&value={value}", ctk);

    /// <summary>
    /// Set Force Start / 设置强制启动
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔的多个哈希或设置为all
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetForceStart(string hashes, bool value, CancellationToken ctk = default)
        => SetForceStartAsync(hashes, value, ctk).Result;

    /// <summary>
    /// Set Force Start / 设置强制启动
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔的多个哈希或设置为all
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetForceStartAsync(IEnumerable<string> hashes, bool value, CancellationToken ctk = default)
        => SetForceStartAsync(hashes.Merger("|"), value, ctk);

    /// <summary>
    /// Set Force Start / 设置强制启动
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔的多个哈希或设置为all
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetForceStart(IEnumerable<string> hashes, bool value, CancellationToken ctk = default)
        => SetForceStartAsync(hashes.Merger("|"), value, ctk).Result;

    /// <summary>
    /// Set Super Seeding / 设置超级种子
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetSuperSeedingAsync(string hashes, bool value, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/setSuperSeeding", $"hashes={hashes}&value={value}", ctk);

    /// <summary>
    /// Set Super Seeding / 设置超级种子
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetSuperSeeding(string hashes, bool value, CancellationToken ctk = default)
        => SetSuperSeedingAsync(hashes, value, ctk).Result;

    /// <summary>
    /// Set Super Seeding / 设置超级种子
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Task<Result> SetSuperSeedingAsync(IEnumerable<string> hashes, bool value, CancellationToken ctk = default)
        => SetSuperSeedingAsync(hashes.Merger("|"), value, ctk);

    /// <summary>
    /// Set Super Seeding / 设置超级种子
    /// </summary>
    /// <param name="hashes">
    ///     hashes can contain multiple hashes separated by | or set to all [END]
    ///     哈希可以包含由|分隔或设置为all的多个哈希
    /// </param>
    /// <param name="value">
    ///     value is a boolean, affects the torrents listed in hashes, default is false [END]
    ///     值为布尔值，影响哈希中列出的种子，默认值为false
    /// </param>
    /// <param name="ctk"></param>
    /// <returns>Result / 结果</returns>
    public Result SetSuperSeeding(IEnumerable<string> hashes, bool value, CancellationToken ctk = default)
        => SetSuperSeedingAsync(hashes.Merger("|"), value, ctk).Result;

    /// <summary>
    /// Rename File / 重命名文件
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子的哈希值</param>
    /// <param name="oldPath">The old path of the torrent / 旧的种子路径</param>
    /// <param name="newPath">The new path to use for the file / 用于文件的新路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code
    ///     400: Missing newPath parameter
    ///     409: Invalid newPath or oldPath, or newPath already in use
    ///     200: All other scenarios
    /// </returns>
    public Task<Result> RenameFileAsync(string hash, string oldPath, string newPath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/renameFile", $"hash={hash}&oldPath={HttpUtility.UrlEncode(oldPath)}&newPath={HttpUtility.UrlEncode(newPath)}", ctk);

    /// <summary>
    /// Rename File / 重命名文件
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子的哈希值</param>
    /// <param name="oldPath">The old path of the torrent / 旧的种子路径</param>
    /// <param name="newPath">The new path to use for the file / 用于文件的新路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code
    ///     400: Missing newPath parameter
    ///     409: Invalid newPath or oldPath, or newPath already in use
    ///     200: All other scenarios
    /// </returns>
    public Result RenameFile(string hash, string oldPath, string newPath, CancellationToken ctk = default)
        => RenameFileAsync(hash, oldPath, newPath, ctk).Result;

    /// <summary>
    /// Rename Folder / 重命名文件夹
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子的哈希值</param>
    /// <param name="oldPath">The old path of the torrent / 旧的种子路径</param>
    /// <param name="newPath">The new path to use for the file / 用于文件的新路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code
    ///     400: Missing newPath parameter
    ///     409: Invalid newPath or oldPath, or newPath already in use
    ///     200: All other scenarios
    /// </returns>
    public Task<Result> RenameFolderAsync(string hash, string oldPath, string newPath, CancellationToken ctk = default)
        => DoPostAsync<Result>("/torrents/renameFile", $"hash={hash}&oldPath={HttpUtility.UrlEncode(oldPath)}&newPath={HttpUtility.UrlEncode(newPath)}", ctk);

    /// <summary>
    /// Rename File / 重命名文件
    /// </summary>
    /// <param name="hash">The hash of the torrent / 种子的哈希值</param>
    /// <param name="oldPath">The old path of the torrent / 旧的种子路径</param>
    /// <param name="newPath">The new path to use for the file / 用于文件的新路径</param>
    /// <param name="ctk"></param>
    /// <returns>
    ///     HTTP Status Code
    ///     400: Missing newPath parameter
    ///     409: Invalid newPath or oldPath, or newPath already in use
    ///     200: All other scenarios
    /// </returns>
    public Result RenameFolder(string hash, string oldPath, string newPath, CancellationToken ctk = default)
        => RenameFolderAsync(hash, oldPath, newPath, ctk).Result;
}
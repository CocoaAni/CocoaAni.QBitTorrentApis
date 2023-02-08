using CocoaAni.Net.WebApi;
using CocoaAni.Net.WebApi.Enums;
using CocoaAni.ToolKit.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CocoaAni.QBitTorrentApis;

public class QBitTorrentApis : WebApiComponent
{
    public QBitTorrentApis(string host = "127.0.0.1", int post = 8080) : this(new Uri($"http://{host}:{post}"))
    {
    }

    public QBitTorrentApis(Uri original)
    {
        BaseUri = original.OriginalString + "/api/v2";
        WebApiConfig.ArgsFormat = DataFormat.Form;
        WebApiConfig.IsEnableCookie = true;
        WebApiConfig.JsonSerializerOptions ??= new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = JsonTool.Encoders.UnicodeEncoder
        };
        Log = new QBitTorrentLogApi(this);
        TransferInfo = new QBitTorrentTransferInfoApi(this);
        Management = new QBitTorrentManagementApi(this);
        Rss = new QBitTorrentRssApi(this);
        Sync = new QBitTorrentSyncApi(this);
        Authentication = new QBitTorrentAuthenticationApi(this);
        Application = new QBitTorrentApplicationApi(this);
        Search = new QBitTorrentSearchApi(this);
    }

    public QBitTorrentLogApi Log { get; protected set; }
    public QBitTorrentTransferInfoApi TransferInfo { get; protected set; }
    public QBitTorrentManagementApi Management { get; protected set; }
    public QBitTorrentRssApi Rss { get; protected set; }
    public QBitTorrentSyncApi Sync { get; protected set; }
    public QBitTorrentAuthenticationApi Authentication { get; protected set; }
    public QBitTorrentApplicationApi Application { get; protected set; }
    public QBitTorrentSearchApi Search { get; protected set; }
}
using CocoaAni.QBitTorrentApis.Enums;

namespace CocoaAni.QBitTorrentApis.Models;

public class SetAppPreferencesArgs
{
    /// <summary>
    /// Currently selected language (e.g. en_GB for English)
    /// </summary>
    public string? Locale { get; set; }

    /// <summary>
    /// True if a subfolder should be created when adding a torrent
    /// </summary>
    public bool? CreateSubfolderEnabled { get; set; }

    /// <summary>
    /// True if torrents should be added in a Paused state
    /// </summary>
    public bool? StartPausedEnabled { get; set; }

    /// <summary>
    /// TODO
    /// </summary>
    public int? AutoDeleteMode { get; set; }

    /// <summary>
    /// True if disk space should be pre-allocated for all files
    /// </summary>
    public bool? PreallocateAll { get; set; }

    /// <summary>
    /// True if ".!qB" should be appended to incomplete files
    /// </summary>
    public bool? IncompleteFilesExt { get; set; }

    /// <summary>
    /// True if Automatic Torrent Management is enabled by default
    /// </summary>
    public bool? AutoTmmEnabled { get; set; }

    /// <summary>
    /// True if torrent should be relocated when its Category changes
    /// </summary>
    public bool? TorrentChangedTmmEnabled { get; set; }

    /// <summary>
    /// True if torrent should be relocated when the default save path changes
    /// </summary>
    public bool? SavePathChangedTmmEnabled { get; set; }

    /// <summary>
    /// True if torrent should be relocated when its Category's save path changes
    /// </summary>
    public bool? CategoryChangedTmmEnabled { get; set; }

    /// <summary>
    /// Default save path for torrents, separated by slashes
    /// </summary>
    public string? SavePath { get; set; }

    /// <summary>
    /// True if folder for incomplete torrents is enabled
    /// </summary>
    public bool? TempPathEnabled { get; set; }

    /// <summary>
    /// Path for incomplete torrents, separated by slashes
    /// </summary>
    public string? TempPath { get; set; }

    /// <summary>
    /// Property: directory to watch for torrent files, value: where torrents loaded from this directory should be downloaded to (see list of possible values below). Slashes are used as path separators; multiple key/value pairs can be specified
    /// </summary>
    public object? ScanDirs { get; set; }

    /// <summary>
    /// Path to directory to copy .torrent files to. Slashes are used as path separators
    /// </summary>
    public string? ExportDir { get; set; }

    /// <summary>
    /// Path to directory to copy .torrent files of completed downloads to. Slashes are used as path separators
    /// </summary>
    public string? ExportDirFin { get; set; }

    /// <summary>
    /// True if e-mail notification should be enabled
    /// </summary>
    public bool? MailNotificationEnabled { get; set; }

    /// <summary>
    /// e-mail where notifications should originate from
    /// </summary>
    public string? MailNotificationSender { get; set; }

    /// <summary>
    /// e-mail to send notifications to
    /// </summary>
    public string? MailNotificationEmail { get; set; }

    /// <summary>
    /// smtp server for e-mail notifications
    /// </summary>
    public string? MailNotificationSmtp { get; set; }

    /// <summary>
    /// True if smtp server requires SSL connection
    /// </summary>
    public bool? MailNotificationSslEnabled { get; set; }

    /// <summary>
    /// True if smtp server requires authentication
    /// </summary>
    public bool? MailNotificationAuthEnabled { get; set; }

    /// <summary>
    /// Username for smtp authentication
    /// </summary>
    public string? MailNotificationUsername { get; set; }

    /// <summary>
    /// Password for smtp authentication
    /// </summary>
    public string? MailNotificationPassword { get; set; }

    /// <summary>
    /// True if external program should be run after torrent has finished downloading
    /// </summary>
    public bool? AutorunEnabled { get; set; }

    /// <summary>
    /// Program path/name/arguments to run if autorun_enabled is enabled; path is separated by slashes; you can use %f and %n arguments, which will be expanded by qBittorent as path_to_torrent_file and torrent_name (from the GUI; not the .torrent file name) respectively
    /// </summary>
    public string? AutorunProgram { get; set; }

    /// <summary>
    /// True if torrent queuing is enabled
    /// </summary>
    public bool? QueueingEnabled { get; set; }

    /// <summary>
    /// Maximum number of active simultaneous downloads
    /// </summary>
    public int? MaxActiveDownloads { get; set; }

    /// <summary>
    /// Maximum number of active simultaneous downloads and uploads
    /// </summary>
    public int? MaxActiveTorrents { get; set; }

    /// <summary>
    /// Maximum number of active simultaneous uploads
    /// </summary>
    public int? MaxActiveUploads { get; set; }

    /// <summary>
    /// If true torrents w/o any activity (stalled ones) will not be counted towards max_active_* limits; see dont_count_slow_torrents for more information
    /// </summary>
    public bool? DontCountSlowTorrents { get; set; }

    /// <summary>
    /// Download rate in KiB/s for a torrent to be considered "slow"
    /// </summary>
    public int? SlowTorrentDlRateThreshold { get; set; }

    /// <summary>
    /// Upload rate in KiB/s for a torrent to be considered "slow"
    /// </summary>
    public int? SlowTorrentUlRateThreshold { get; set; }

    /// <summary>
    /// Seconds a torrent should be inactive before considered "slow"
    /// </summary>
    public int? SlowTorrentInactiveTimer { get; set; }

    /// <summary>
    /// True if share ratio limit is enabled
    /// </summary>
    public bool? MaxRatioEnabled { get; set; }

    /// <summary>
    /// Get the global share ratio limit
    /// </summary>
    public float? MaxRatio { get; set; }

    /// <summary>
    /// Action performed when a torrent reaches the maximum share ratio. See list of possible values here below.
    /// </summary>
    public MaxRatioAct? MaxRatioAct { get; set; }

    /// <summary>
    /// Port for incoming connections
    /// </summary>
    public int? ListenPort { get; set; }

    /// <summary>
    /// True if UPnP/NAT-PMP is enabled
    /// </summary>
    public bool? Upnp { get; set; }

    /// <summary>
    /// True if the port is randomly selected
    /// </summary>
    public bool? RandomPort { get; set; }

    /// <summary>
    /// Global download speed limit in KiB/s; -1 means no limit is applied
    /// </summary>
    public int? DlLimit { get; set; }

    /// <summary>
    /// Global upload speed limit in KiB/s; -1 means no limit is applied
    /// </summary>
    public int? UpLimit { get; set; }

    /// <summary>
    /// Maximum global number of simultaneous connections
    /// </summary>
    public int? MaxConnec { get; set; }

    /// <summary>
    /// Maximum number of simultaneous connections per torrent
    /// </summary>
    public int? MaxConnecPerTorrent { get; set; }

    /// <summary>
    /// Maximum number of upload slots
    /// </summary>
    public int? MaxUploads { get; set; }

    /// <summary>
    /// Maximum number of upload slots per torrent
    /// </summary>
    public int? MaxUploadsPerTorrent { get; set; }

    /// <summary>
    /// Timeout in seconds for a stopped announce request to trackers
    /// </summary>
    public int? StopTrackerTimeout { get; set; }

    /// <summary>
    /// True if the advanced libtorrent option piece_extent_affinity is enabled
    /// </summary>
    public bool? EnablePieceExtentAffinity { get; set; }

    /// <summary>
    /// Bittorrent Protocol to use (see list of possible values below)
    /// </summary>
    public BitTorrentProtocol? BittorrentProtocol { get; set; }

    /// <summary>
    /// True if [du]l_limit should be applied to uTP connections; this option is only available in qBittorent built against libtorrent version 0.16.X and higher
    /// </summary>
    public bool? LimitUtpRate { get; set; }

    /// <summary>
    /// True if [du]l_limit should be applied to estimated TCP overhead (service data: e.g. packet headers)
    /// </summary>
    public bool? LimitTcpOverhead { get; set; }

    /// <summary>
    /// True if [du]l_limit should be applied to peers on the LAN
    /// </summary>
    public bool? LimitLanPeers { get; set; }

    /// <summary>
    /// Alternative global download speed limit in KiB/s
    /// </summary>
    public int? AltDlLimit { get; set; }

    /// <summary>
    /// Alternative global upload speed limit in KiB/s
    /// </summary>
    public int? AltUpLimit { get; set; }

    /// <summary>
    /// True if alternative limits should be applied according to schedule
    /// </summary>
    public bool? SchedulerEnabled { get; set; }

    /// <summary>
    /// Scheduler starting hour
    /// </summary>
    public int? ScheduleFromHour { get; set; }

    /// <summary>
    /// Scheduler starting minute
    /// </summary>
    public int? ScheduleFromMin { get; set; }

    /// <summary>
    /// Scheduler ending hour
    /// </summary>
    public int? ScheduleToHour { get; set; }

    /// <summary>
    /// Scheduler ending minute
    /// </summary>
    public int? ScheduleToMin { get; set; }

    /// <summary>
    /// Scheduler days. See possible values here below
    /// </summary>
    public ProxyType? SchedulerDays { get; set; }

    /// <summary>
    /// True if DHT is enabled
    /// </summary>
    public bool? Dht { get; set; }

    /// <summary>
    /// True if PeX is enabled
    /// </summary>
    public bool? Pex { get; set; }

    /// <summary>
    /// True if LSD is enabled
    /// </summary>
    public bool? Lsd { get; set; }

    /// <summary>
    /// See list of possible values here below
    /// </summary>
    public int? Encryption { get; set; }

    /// <summary>
    /// If true anonymous mode will be enabled; read more here; this option is only available in qBittorent built against libtorrent version 0.16.X and higher
    /// </summary>
    public bool? AnonymousMode { get; set; }

    /// <summary>
    /// See list of possible values here below
    /// </summary>
    public ProxyType? ProxyType { get; set; }

    /// <summary>
    /// Proxy IP address or domain name
    /// </summary>
    public string? ProxyIp { get; set; }

    /// <summary>
    /// Proxy port
    /// </summary>
    public int? ProxyPort { get; set; }

    /// <summary>
    /// True if peer and web seed connections should be proxified; this option will have any effect only in qBittorent built against libtorrent version 0.16.X and higher
    /// </summary>
    public bool? ProxyPeerConnections { get; set; }

    /// <summary>
    /// True proxy requires authentication; doesn't apply to SOCKS4 proxies
    /// </summary>
    public bool? ProxyAuthEnabled { get; set; }

    /// <summary>
    /// Username for proxy authentication
    /// </summary>
    public string? ProxyUsername { get; set; }

    /// <summary>
    /// Password for proxy authentication
    /// </summary>
    public string? ProxyPassword { get; set; }

    /// <summary>
    /// True if proxy is only used for torrents
    /// </summary>
    public bool? ProxyTorrentsOnly { get; set; }

    /// <summary>
    /// True if external IP filter should be enabled
    /// </summary>
    public bool? IpFilterEnabled { get; set; }

    /// <summary>
    /// Path to IP filter file (.dat, .p2p, .p2b files are supported); path is separated by slashes
    /// </summary>
    public string? IpFilterPath { get; set; }

    /// <summary>
    /// True if IP filters are applied to trackers
    /// </summary>
    public bool? IpFilterTrackers { get; set; }

    /// <summary>
    /// Comma-separated list of domains to accept when performing Host header validation
    /// </summary>
    public string? WebUiDomainList { get; set; }

    /// <summary>
    /// IP address to use for the WebUI
    /// </summary>
    public string? WebUiAddress { get; set; }

    /// <summary>
    /// WebUI port
    /// </summary>
    public int? WebUiPort { get; set; }

    /// <summary>
    /// True if UPnP is used for the WebUI port
    /// </summary>
    public bool? WebUiUpnp { get; set; }

    /// <summary>
    /// WebUI username
    /// </summary>
    public string? WebUiUsername { get; set; }

    /// <summary>
    /// For API ≥ v2.3.0: Plaintext WebUI password, not readable, write-only. For API max= v2.3.0: MD5 hash of WebUI password, hash is generated from the following string: username:Web UI Access:plain_text_web_ui_password
    /// </summary>
    public string? WebUiPassword { get; set; }

    /// <summary>
    /// True if WebUI CSRF protection is enabled
    /// </summary>
    public bool? WebUiCsrfProtectionEnabled { get; set; }

    /// <summary>
    /// True if WebUI clickjacking protection is enabled
    /// </summary>
    public bool? WebUiClickjackingProtectionEnabled { get; set; }

    /// <summary>
    /// True if WebUI cookie Secure flag is enabled
    /// </summary>
    public bool? WebUiSecureCookieEnabled { get; set; }

    /// <summary>
    /// Maximum number of authentication failures before WebUI access ban
    /// </summary>
    public int? WebUiMaxAuthFailCount { get; set; }

    /// <summary>
    /// WebUI access ban duration in seconds
    /// </summary>
    public int? WebUiBanDuration { get; set; }

    /// <summary>
    /// Seconds until WebUI is automatically signed off
    /// </summary>
    public int? WebUiSessionTimeout { get; set; }

    /// <summary>
    /// True if WebUI host header validation is enabled
    /// </summary>
    public bool? WebUiHostHeaderValidationEnabled { get; set; }

    /// <summary>
    /// True if authentication challenge for loopback address (127.0.0.1) should be disabled
    /// </summary>
    public bool? BypassLocalAuth { get; set; }

    /// <summary>
    /// True if webui authentication should be bypassed for clients whose ip resides within (at least) one of the subnets on the whitelist
    /// </summary>
    public bool? BypassAuthSubnetWhitelistEnabled { get; set; }

    /// <summary>
    /// (White)list of ipv4/ipv6 subnets for which webui authentication should be bypassed; list entries are separated by commas
    /// </summary>
    public string? BypassAuthSubnetWhitelist { get; set; }

    /// <summary>
    /// True if an alternative WebUI should be used
    /// </summary>
    public bool? AlternativeWebuiEnabled { get; set; }

    /// <summary>
    /// File path to the alternative WebUI
    /// </summary>
    public string? AlternativeWebuiPath { get; set; }

    /// <summary>
    /// True if WebUI HTTPS access is enabled
    /// </summary>
    public bool? UseHttps { get; set; }

    /// <summary>
    /// For API max= v2.0.0: SSL keyfile contents (this is a not a path)
    /// </summary>
    public string? SslKey { get; set; }

    /// <summary>
    /// For API max= v2.0.0: SSL certificate contents (this is a not a path)
    /// </summary>
    public string? SslCert { get; set; }

    /// <summary>
    /// For API ≥ v2.0.1: Path to SSL keyfile
    /// </summary>
    public string? WebUiHttpsKeyPath { get; set; }

    /// <summary>
    /// For API ≥ v2.0.1: Path to SSL certificate
    /// </summary>
    public string? WebUiHttpsCertPath { get; set; }

    /// <summary>
    /// True if server DNS should be updated dynamically
    /// </summary>
    public bool? DyndnsEnabled { get; set; }

    /// <summary>
    /// See list of possible values here below
    /// </summary>
    public DyndnsService? DyndnsService { get; set; }

    /// <summary>
    /// Username for DDNS service
    /// </summary>
    public string? DyndnsUsername { get; set; }

    /// <summary>
    /// Password for DDNS service
    /// </summary>
    public string? DyndnsPassword { get; set; }

    /// <summary>
    /// Your DDNS domain name
    /// </summary>
    public string? DyndnsDomain { get; set; }

    /// <summary>
    /// RSS refresh interval
    /// </summary>
    public int? RssRefreshInterval { get; set; }

    /// <summary>
    /// Max stored articles per RSS feed
    /// </summary>
    public int? RssMaxArticlesPerFeed { get; set; }

    /// <summary>
    /// Enable processing of RSS feeds
    /// </summary>
    public bool? RssProcessingEnabled { get; set; }

    /// <summary>
    /// Enable auto-downloading of torrents from the RSS feeds
    /// </summary>
    public bool? RssAutoDownloadingEnabled { get; set; }

    /// <summary>
    /// For API ≥ v2.5.1: Enable downloading of repack/proper Episodes
    /// </summary>
    public bool? RssDownloadRepackProperEpisodes { get; set; }

    /// <summary>
    /// For API ≥ v2.5.1: List of RSS Smart Episode Filters
    /// </summary>
    public string? RssSmartEpisodeFilters { get; set; }

    /// <summary>
    /// Enable automatic adding of trackers to new torrents
    /// </summary>
    public bool? AddTrackersEnabled { get; set; }

    /// <summary>
    /// List of trackers to add to new torrent
    /// </summary>
    public string? AddTrackers { get; set; }

    /// <summary>
    /// For API ≥ v2.5.1: Enable custom http headers
    /// </summary>
    public bool? WebUiUseCustomHttpHeadersEnabled { get; set; }

    /// <summary>
    /// For API ≥ v2.5.1: List of custom http headers
    /// </summary>
    public string? WebUiCustomHttpHeaders { get; set; }

    /// <summary>
    /// True enables max seeding time
    /// </summary>
    public bool? MaxSeedingTimeEnabled { get; set; }

    /// <summary>
    /// Number of minutes to seed a torrent
    /// </summary>
    public int? MaxSeedingTime { get; set; }

    /// <summary>
    /// TODO
    /// </summary>
    public string? AnnounceIp { get; set; }

    /// <summary>
    /// True always announce to all tiers
    /// </summary>
    public bool? AnnounceToAllTiers { get; set; }

    /// <summary>
    /// True always announce to all trackers in a tier
    /// </summary>
    public bool? AnnounceToAllTrackers { get; set; }

    /// <summary>
    /// Number of asynchronous I/O threads
    /// </summary>
    public int? AsyncIoThreads { get; set; }

    /// <summary>
    /// List of banned IPs
    /// </summary>
    public string? BannedIPs { get; set; }

    /// <summary>
    /// Outstanding memory when checking torrents in MiB
    /// </summary>
    public int? CheckingMemoryUse { get; set; }

    /// <summary>
    /// IP Address to bind to. Empty String means All addresses
    /// </summary>
    public string? CurrentInterfaceAddress { get; set; }

    /// <summary>
    /// Network Interface used
    /// </summary>
    public string? CurrentNetworkInterface { get; set; }

    /// <summary>
    /// Disk cache used in MiB
    /// </summary>
    public int? DiskCache { get; set; }

    /// <summary>
    /// Disk cache expiry interval in seconds
    /// </summary>
    public int? DiskCacheTtl { get; set; }

    /// <summary>
    /// Port used for embedded tracker
    /// </summary>
    public int? EmbeddedTrackerPort { get; set; }

    /// <summary>
    /// True enables coalesce reads and writes
    /// </summary>
    public bool? EnableCoalesceReadWrite { get; set; }

    /// <summary>
    /// True enables embedded tracker
    /// </summary>
    public bool? EnableEmbeddedTracker { get; set; }

    /// <summary>
    /// True allows multiple connections from the same IP address
    /// </summary>
    public bool? EnableMultiConnectionsFromSameIp { get; set; }

    /// <summary>
    /// True enables os cache
    /// </summary>
    public bool? EnableOsCache { get; set; }

    /// <summary>
    /// True enables sending of upload piece suggestions
    /// </summary>
    public bool? EnableUploadSuggestions { get; set; }

    /// <summary>
    /// File pool size
    /// </summary>
    public int? FilePoolSize { get; set; }

    /// <summary>
    /// Maximal outgoing port (0: Disabled)
    /// </summary>
    public int? OutgoingPortsMax { get; set; }

    /// <summary>
    /// Minimal outgoing port (0: Disabled)
    /// </summary>
    public int? OutgoingPortsMin { get; set; }

    /// <summary>
    /// True rechecks torrents on completion
    /// </summary>
    public bool? RecheckCompletedTorrents { get; set; }

    /// <summary>
    /// True resolves peer countries
    /// </summary>
    public bool? ResolvePeerCountries { get; set; }

    /// <summary>
    /// Save resume data interval in min
    /// </summary>
    public int? SaveResumeDataInterval { get; set; }

    /// <summary>
    /// Send buffer low watermark in KiB
    /// </summary>
    public int? SendBufferLowWatermark { get; set; }

    /// <summary>
    /// Send buffer watermark in KiB
    /// </summary>
    public int? SendBufferWatermark { get; set; }

    /// <summary>
    /// Send buffer watermark factor in percent
    /// </summary>
    public int? SendBufferWatermarkFactor { get; set; }

    /// <summary>
    /// Socket backlog size
    /// </summary>
    public int? SocketBacklogSize { get; set; }

    /// <summary>
    /// Upload choking algorithm used (see list of possible values below)
    /// </summary>
    public UploadChokingAlgorithm? UploadChokingAlgorithm { get; set; }

    /// <summary>
    /// Upload slots behavior used (see list of possible values below)
    /// </summary>
    public UploadSlotsBehavior? UploadSlotsBehavior { get; set; }

    /// <summary>
    /// UPnP lease duration (0: Permanent lease)
    /// </summary>
    public int? UpnpLeaseDuration { get; set; }

    /// <summary>
    /// μTP-TCP mixed mode algorithm (see list of possible values below)
    /// </summary>
    public UtpTcpMixedMode? UtpTcpMixedMode { get; set; }
}
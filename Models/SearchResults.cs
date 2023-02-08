namespace CocoaAni.QBitTorrentApis.Models;

public class SearchResults
{
    public SearchResults(SearchResults[] results, string status, int total)
    {
        Results = results;
        Status = status;
        Total = total;
    }

    public SearchResults()
    {
        Results = default!;
        Status = default!;
        Total = default!;
    }

    public SearchResults[] Results { get; set; }
    public string Status { get; set; }
    public int Total { get; set; }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CocoaAni.QBitTorrentApis.Enums;

//namespace CocoaAni.QBitTorrentApis;

//public class GetTorrentArgs
//{
//    public GetTorrentArgs(Status filter, string? category, Key sort, bool reverse, int? limit, int? offset)
//    {
//        Filter = filter;
//        Category = category;
//        Sort = sort;
//        Reverse = reverse;
//        Limit = limit;
//        Offset = offset;
//    }

//    public Status Filter { get; set; } = Status.All;

//    public string? Category { get; set; } = null;
//    public Key Sort { get; set; } = Key.Name;
//    public bool Reverse { get; set; } = false;

//    public int? Limit { get; set; } = null;
//    public int? Offset { get; set; } = null;
//}
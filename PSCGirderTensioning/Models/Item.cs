using SQLite;
using System;
using System.Collections.Generic;

namespace PSCGirderTensioning.Models
{
    [Serializable]
    public class Item
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string BridgeName { get; set; }
        public string PackageNo { get; set; }
        public string District { get; set; }
        public string Upazilla { get; set; }
        public int SpanNos { get; set; }
        //public List<SpanInfoDataModel> SpanList { get; set; } = new List<SpanInfoDataModel>();
    }
}
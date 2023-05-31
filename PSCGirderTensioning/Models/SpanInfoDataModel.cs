using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSCGirderTensioning.Models
{
    [Serializable]
    public class SpanInfoDataModel
    {
        [PrimaryKey]
        public string spanId { get; set; }
        public string bridgeId { get; set; }
        public int SpanNo { get; set; }
        //public List<GirderInfo> GirderList { get; set; } = new List<GirderInfo>();
        public string SpanNoText { get; set; } = "Span No: 0";


        public int TotalGirderNos { get; set; } = 2;
        public double SpanLength { get; set; } = 0.0; 
        public string SpanLengthUnit { get; set; } = "meter";

        public string TotalGirderNosText { get; set; } = "Total Girder Nos:";
        public string SpanLengthText { get; set; } = "Span Length:";

    }
}

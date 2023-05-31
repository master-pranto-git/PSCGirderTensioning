using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSCGirderTensioning.Models
{
    [Serializable]
    public class GirderInfo
    {
        [PrimaryKey] 
        public string girderId { get; set; }
        public string bridgeId { get; set; }
        public string spanId { get; set; }

        public int girderNo { get; set; }
        public DateTime girderCastingDate { get; set; }
        public int totalCableNos { get; set; }
        //public List<CableInfo> cablesList { get; set; } = new List<CableInfo>();

        public double girderLength { get; set; } = 0.0;
        public string girderLengthUnit { get; set; } = "meter";
        public string girderNoText { get; set; } = "Girder No: 0";
        public string totalCableNosText { get; set; } = "Total Cable Nos: 0";
        public string girderLengthText { get; set; } = "Girder Length: 0";

    }
}

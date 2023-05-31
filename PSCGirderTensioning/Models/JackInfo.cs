using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSCGirderTensioning.Models
{
    [Serializable]
    public class JackInfo
    {
        [PrimaryKey]
        public string jackId { get; set; }
        public string jackingEndRef { get; set; }
        public string jackEquation { get; set; } = "y = mx + c";
        public string y_text { get; set; }
        public string y_unit { get; set; }
        public string x_text { get; set; }
        public string x_unit { get; set; }
        public double x_coefficient { get; set; }
        public double c_coefficient { get; set; }
    }
}

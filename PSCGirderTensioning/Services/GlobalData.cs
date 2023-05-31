using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PSCGirderTensioning.Services
{
    public class GlobalData
    {
        public string dbPath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GirderTension.db3");

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESquare.XrmToolBox.AuditExplorer
{
    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        public int NumberOfRecordsPerRequest { get; set; } = 5000;
        public int NumberOfRequestsPerBulkRequest { get; set; } = 300;
        public int MaxNumberOfParallelRequests { get; set; } = 4;
        public int NumberOfRowsPerExcelFile { get; set; } = 100000;
        public List<Boolean> Columns { get; set; } = new List<bool>();
    }
   
}
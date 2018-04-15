using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESquare.XrmToolBox.AuditExplorer.Entities
{
    public class AuditRecord
    {
        public DateTime CreatedOn { get; set; }
        public String AuthorName { get; set; }
        public String OperationValue { get; set; }
        public String OperationFormated { get; set; }
        public String ActionValue { get; set; }
        public String ActionFormated { get; set; }
        public String EntityLogicalName { get; set; }
        public String EntityDisplayName { get; set; }
        public String ObjectLogicalName { get; set; }
        public String ObjectDisplayName { get; set; }
        public String RecordName { get; set; }
        public String OldValue { get; set; }
        public String OldValueFormated { get; set; }
        public String NewValue { get; set; }
        public String NewValueFormated { get; set; }
    }
}

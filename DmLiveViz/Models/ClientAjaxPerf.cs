using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class ClientAjaxPerf
    {
        public System.Guid KeyId { get; set; }
        public System.Guid RequestId { get; set; }
        public System.Guid ImpressionId { get; set; }
        public System.Guid SessionId { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int ContentLength { get; set; }
        public long StartTime { get; set; }
        public Nullable<long> SuccessTime { get; set; }
        public long CompleteTime { get; set; }
        public string Url { get; set; }
        public int SuccessLatency { get; set; }
        public int CompleteLatency { get; set; }
    }
}

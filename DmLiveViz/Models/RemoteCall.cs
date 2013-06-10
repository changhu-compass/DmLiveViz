using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class RemoteCall
    {
        public int Id { get; set; }
        public System.Guid RequestId { get; set; }
        public int Order { get; set; }
        public long LatencyInMs { get; set; }
        public System.DateTime StartedTime { get; set; }
        public string Action { get; set; }
        public string Category { get; set; }
        public string Result { get; set; }
        public Nullable<int> ContentLength { get; set; }
        public virtual Request Request { get; set; }
    }
}

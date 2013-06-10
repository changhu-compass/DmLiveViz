using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class GPing
    {
        public System.Guid KeyId { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public System.Guid ImpressionId { get; set; }
        public System.Guid SessionId { get; set; }
        public string Page { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
    }
}

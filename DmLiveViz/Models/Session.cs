using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class Session
    {
        public System.Guid SessionId { get; set; }
        public string UserId { get; set; }
        public System.DateTimeOffset SessionStart { get; set; }
        public System.TimeSpan SessionLength { get; set; }
        public string UserAgent { get; set; }
        public string Browser { get; set; }
    }
}

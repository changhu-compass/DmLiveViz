using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class Impression
    {
        public System.Guid ImpressionId { get; set; }
        public System.Guid SessionId { get; set; }
        public string UrlReferrer { get; set; }
    }
}

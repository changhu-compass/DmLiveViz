using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class Request
    {
        public Request()
        {
            this.RemoteCalls = new List<RemoteCall>();
        }

        public System.Guid RequestId { get; set; }
        public System.Guid ImpressionId { get; set; }
        public System.Guid SessionId { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public string RequestType { get; set; }
        public string UrlAbsolutePath { get; set; }
        public string UrlReferrer { get; set; }
        public bool HasSessionStart { get; set; }
        public string Service { get; set; }
        public int ServiceVersion { get; set; }
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string InputStreamString { get; set; }
        public string UserId { get; set; }
        public long ServerLatencyInMs { get; set; }
        public string Exception { get; set; }
        public string UserAgent { get; set; }
        public string Browser { get; set; }
        public virtual ICollection<RemoteCall> RemoteCalls { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DmLiveViz.Models
{
    public partial class ClientImpressionInfo
    {
        public System.Guid KeyId { get; set; }
        public System.Guid ImpressionId { get; set; }
        public System.Guid SessionId { get; set; }
        public string Status { get; set; }
        public long NavigationStart { get; set; }
        public long UnloadEventStart { get; set; }
        public long UnloadEventEnd { get; set; }
        public long RedirectStart { get; set; }
        public long RedirectEnd { get; set; }
        public long FetchStart { get; set; }
        public long DomainLookupStart { get; set; }
        public long DomainLookupEnd { get; set; }
        public long ConnectStart { get; set; }
        public long ConnectEnd { get; set; }
        public long RequestStart { get; set; }
        public long ResponseStart { get; set; }
        public long ResponseEnd { get; set; }
        public long DomLoading { get; set; }
        public long DomInteractive { get; set; }
        public long DomContentLoadedEventStart { get; set; }
        public long DomContentLoadedEventEnd { get; set; }
        public long DomComplete { get; set; }
        public long LoadEventStart { get; set; }
        public long LoadEventEnd { get; set; }
        public Nullable<long> MsFirstPaint { get; set; }
        public long RedirectCount { get; set; }
        public long NavigationType { get; set; }
        public Nullable<long> PageLoadAfterResponse { get; set; }
        public Nullable<long> PageLoad { get; set; }
        public Nullable<long> NetworkLatency { get; set; }
        public Nullable<int> AvailHeight { get; set; }
        public Nullable<int> AvailWidth { get; set; }
    }
}

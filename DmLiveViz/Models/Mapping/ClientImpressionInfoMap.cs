using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class ClientImpressionInfoMap : EntityTypeConfiguration<ClientImpressionInfo>
    {
        public ClientImpressionInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientImpressionInfos");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.ImpressionId).HasColumnName("ImpressionId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NavigationStart).HasColumnName("NavigationStart");
            this.Property(t => t.UnloadEventStart).HasColumnName("UnloadEventStart");
            this.Property(t => t.UnloadEventEnd).HasColumnName("UnloadEventEnd");
            this.Property(t => t.RedirectStart).HasColumnName("RedirectStart");
            this.Property(t => t.RedirectEnd).HasColumnName("RedirectEnd");
            this.Property(t => t.FetchStart).HasColumnName("FetchStart");
            this.Property(t => t.DomainLookupStart).HasColumnName("DomainLookupStart");
            this.Property(t => t.DomainLookupEnd).HasColumnName("DomainLookupEnd");
            this.Property(t => t.ConnectStart).HasColumnName("ConnectStart");
            this.Property(t => t.ConnectEnd).HasColumnName("ConnectEnd");
            this.Property(t => t.RequestStart).HasColumnName("RequestStart");
            this.Property(t => t.ResponseStart).HasColumnName("ResponseStart");
            this.Property(t => t.ResponseEnd).HasColumnName("ResponseEnd");
            this.Property(t => t.DomLoading).HasColumnName("DomLoading");
            this.Property(t => t.DomInteractive).HasColumnName("DomInteractive");
            this.Property(t => t.DomContentLoadedEventStart).HasColumnName("DomContentLoadedEventStart");
            this.Property(t => t.DomContentLoadedEventEnd).HasColumnName("DomContentLoadedEventEnd");
            this.Property(t => t.DomComplete).HasColumnName("DomComplete");
            this.Property(t => t.LoadEventStart).HasColumnName("LoadEventStart");
            this.Property(t => t.LoadEventEnd).HasColumnName("LoadEventEnd");
            this.Property(t => t.MsFirstPaint).HasColumnName("MsFirstPaint");
            this.Property(t => t.RedirectCount).HasColumnName("RedirectCount");
            this.Property(t => t.NavigationType).HasColumnName("NavigationType");
            this.Property(t => t.PageLoadAfterResponse).HasColumnName("PageLoadAfterResponse");
            this.Property(t => t.PageLoad).HasColumnName("PageLoad");
            this.Property(t => t.NetworkLatency).HasColumnName("NetworkLatency");
            this.Property(t => t.AvailHeight).HasColumnName("AvailHeight");
            this.Property(t => t.AvailWidth).HasColumnName("AvailWidth");
        }
    }
}

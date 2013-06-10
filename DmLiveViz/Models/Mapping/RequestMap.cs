using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class RequestMap : EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Requests");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.ImpressionId).HasColumnName("ImpressionId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.UrlAbsolutePath).HasColumnName("UrlAbsolutePath");
            this.Property(t => t.UrlReferrer).HasColumnName("UrlReferrer");
            this.Property(t => t.HasSessionStart).HasColumnName("HasSessionStart");
            this.Property(t => t.Service).HasColumnName("Service");
            this.Property(t => t.ServiceVersion).HasColumnName("ServiceVersion");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.HttpMethod).HasColumnName("HttpMethod");
            this.Property(t => t.InputStreamString).HasColumnName("InputStreamString");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ServerLatencyInMs).HasColumnName("ServerLatencyInMs");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.UserAgent).HasColumnName("UserAgent");
            this.Property(t => t.Browser).HasColumnName("Browser");
        }
    }
}

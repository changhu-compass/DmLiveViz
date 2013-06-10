using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class ClientAjaxPerfMap : EntityTypeConfiguration<ClientAjaxPerf>
    {
        public ClientAjaxPerfMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientAjaxPerfs");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.ImpressionId).HasColumnName("ImpressionId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.ContentLength).HasColumnName("ContentLength");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.SuccessTime).HasColumnName("SuccessTime");
            this.Property(t => t.CompleteTime).HasColumnName("CompleteTime");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.SuccessLatency).HasColumnName("SuccessLatency");
            this.Property(t => t.CompleteLatency).HasColumnName("CompleteLatency");
        }
    }
}

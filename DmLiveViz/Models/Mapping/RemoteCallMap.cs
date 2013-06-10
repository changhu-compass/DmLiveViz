using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class RemoteCallMap : EntityTypeConfiguration<RemoteCall>
    {
        public RemoteCallMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("RemoteCalls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.Order).HasColumnName("Order");
            this.Property(t => t.LatencyInMs).HasColumnName("LatencyInMs");
            this.Property(t => t.StartedTime).HasColumnName("StartedTime");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.ContentLength).HasColumnName("ContentLength");

            // Relationships
            this.HasRequired(t => t.Request)
                .WithMany(t => t.RemoteCalls)
                .HasForeignKey(d => d.RequestId);

        }
    }
}

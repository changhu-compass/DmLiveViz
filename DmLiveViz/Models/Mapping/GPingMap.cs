using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class GPingMap : EntityTypeConfiguration<GPing>
    {
        public GPingMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GPings");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.ImpressionId).HasColumnName("ImpressionId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.Page).HasColumnName("Page");
            this.Property(t => t.Href).HasColumnName("Href");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}

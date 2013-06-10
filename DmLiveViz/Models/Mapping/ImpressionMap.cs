using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class ImpressionMap : EntityTypeConfiguration<Impression>
    {
        public ImpressionMap()
        {
            // Primary Key
            this.HasKey(t => t.ImpressionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Impressions");
            this.Property(t => t.ImpressionId).HasColumnName("ImpressionId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.UrlReferrer).HasColumnName("UrlReferrer");
        }
    }
}

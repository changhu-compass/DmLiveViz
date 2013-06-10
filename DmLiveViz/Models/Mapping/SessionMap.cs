using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DmLiveViz.Models.Mapping
{
    public class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            // Primary Key
            this.HasKey(t => t.SessionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sessions");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SessionStart).HasColumnName("SessionStart");
            this.Property(t => t.SessionLength).HasColumnName("SessionLength");
            this.Property(t => t.UserAgent).HasColumnName("UserAgent");
            this.Property(t => t.Browser).HasColumnName("Browser");
        }
    }
}

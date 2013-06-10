using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DmLiveViz.Models.Mapping;

namespace DmLiveViz.Models
{
    public partial class DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context : DbContext
    {
        static DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context()
        {
            Database.SetInitializer<DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context>(null);
        }

        public DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context()
            : base("Name=DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context")
        {
        }

        public DbSet<ClientAjaxPerf> ClientAjaxPerfs { get; set; }
        public DbSet<ClientImpressionInfo> ClientImpressionInfos { get; set; }
        public DbSet<GPing> GPings { get; set; }
        public DbSet<Impression> Impressions { get; set; }
        public DbSet<RemoteCall> RemoteCalls { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientAjaxPerfMap());
            modelBuilder.Configurations.Add(new ClientImpressionInfoMap());
            modelBuilder.Configurations.Add(new GPingMap());
            modelBuilder.Configurations.Add(new ImpressionMap());
            modelBuilder.Configurations.Add(new RemoteCallMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new SessionMap());
        }
    }
}

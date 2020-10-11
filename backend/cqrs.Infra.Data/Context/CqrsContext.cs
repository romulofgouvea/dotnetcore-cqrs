
using cqrs.Domain.Entities;
using cqrs.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace cqrs.Infra.Data.Context
{
    public class CqrsContext : DbContext
    {
        public CqrsContext(DbContextOptions<CqrsContext> options) : base(options)
        {
        }
        public DbSet<Candidate> Candidate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidateMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
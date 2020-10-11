
using cqrs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace cqrs.Infra.Data.Context
{
    public class CqrsContext : DbContext
    {
        public CqrsContext(DbContextOptions<CqrsContext> options) : base(options)
        {
        }
        public DbSet<Candidate> Candidate { get; set; }
    }
}
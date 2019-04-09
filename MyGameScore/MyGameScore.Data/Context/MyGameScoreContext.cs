using Microsoft.EntityFrameworkCore;
using MyGameScore.Data.EntityTipeConfiguration;
using MyGameScore.Domain.Entities;

namespace MyGameScore.Data.Context
{
    public class MyGameScoreContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }

        public MyGameScoreContext(DbContextOptions<MyGameScoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new MatchTypeConfiguration());

            modelBuilder
                .Entity<Match>()
                .Ignore(e => e.ValidationResult);
        }
    }
}

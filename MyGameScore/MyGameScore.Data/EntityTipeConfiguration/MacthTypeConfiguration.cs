using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameScore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameScore.Data.EntityTipeConfiguration
{
    public class MatchTypeConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            ConfigureTableName(builder);
            ConfigurePrimaryKey(builder);
            ConfigureProperties(builder);
            ConfigureIdentity(builder);
        }

        private void ConfigureTableName(EntityTypeBuilder<Match> builder)
        {
            builder.ToTable("Matches");
        }

        private void ConfigurePrimaryKey(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(k => new { k.Id});
        }

        private void ConfigureProperties(EntityTypeBuilder<Match> builder)
        {
            builder.Property(con => con.Id).HasColumnName("Id");
            builder.Property(con => con.Date).HasColumnName("Date");
            builder.Property(con => con.Score).HasColumnName("Score");
            builder.Property(con => con.IsHighestScore).HasColumnName("IsHighestScore");
        }

        private void ConfigureIdentity(EntityTypeBuilder<Match> builder)
        {
            builder
                .Property(e => e.Id)
                .UseSqlServerIdentityColumn();
        }
    }
}

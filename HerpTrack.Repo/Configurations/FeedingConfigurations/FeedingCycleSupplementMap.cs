using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class FeedingCycleSupplementMap
    {
        public FeedingCycleSupplementMap(EntityTypeBuilder<FeedingCycleSupplement> entityBuilder)
        {
            entityBuilder.HasKey(f => new { f.FeedingCycleId, f.SupplementId });
            entityBuilder.Property(f => f.FeedingCycleId).IsRequired();
            entityBuilder.Property(f => f.SupplementId).IsRequired();

            entityBuilder.HasOne(f => f.Supplement).WithMany(s => s.FeedingCycleSupplements).HasForeignKey(f => f.SupplementId);
            entityBuilder.HasOne(f => f.FeedingCycle).WithMany(s => s.FeedingCycleSupplements).HasForeignKey(f => f.FeedingCycleId);
        }
    }
}

using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class FeedingEntryMap
    {
        public FeedingEntryMap(EntityTypeBuilder<FeedingEntry> entityBuilder)
        {
            entityBuilder.Property(f => f.PetDiaryId).IsRequired();
            entityBuilder.Property(f => f.FeedingId).IsRequired();

            entityBuilder.HasOne(f => f.Diary).WithMany(d => d.FeedingEntries).HasForeignKey(f => f.PetDiaryId);
            //entityBuilder.HasOne(f => f.Feeding).WithMany(d => d.FeedingEntries).HasForeignKey(f => f.PetDiaryId);
        }
    }
}

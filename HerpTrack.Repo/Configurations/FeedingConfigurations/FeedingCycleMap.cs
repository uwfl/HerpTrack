using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class FeedingCycleMap
    {
        public FeedingCycleMap(EntityTypeBuilder<FeedingCycle> entityBuilder)
        {
            entityBuilder.Property(feedingCycle => feedingCycle.StartDate).IsRequired();
            entityBuilder.Property(feedingCycle => feedingCycle.CycleInDays).IsRequired();
        }
    }
}

using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class FeedingMap
    {
        public FeedingMap(EntityTypeBuilder<Feeding> entityBuilder)
        {
            entityBuilder.Property(feeding => feeding.FoodId).IsRequired();
            entityBuilder.Property(feeding => feeding.Quantity).IsRequired();

            entityBuilder.HasOne(feeding => feeding.Food).WithMany();
        }
    }
}

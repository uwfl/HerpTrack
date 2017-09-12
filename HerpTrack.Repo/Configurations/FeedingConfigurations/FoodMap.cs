using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class FoodMap
    {
        public FoodMap(EntityTypeBuilder<Food> entityBuilder)
        {
            entityBuilder.HasKey(food => food.Id);
            entityBuilder.Property(food => food.Name).IsRequired();
        }
    }
}

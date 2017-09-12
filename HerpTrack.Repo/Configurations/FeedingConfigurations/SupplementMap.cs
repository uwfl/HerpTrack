using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class SupplementMap
    {
        public SupplementMap(EntityTypeBuilder<Supplement> entityBuilder)
        {
            entityBuilder.HasKey(supplement => supplement.Id);
            entityBuilder.Property(supplement => supplement.Name).IsRequired();
        }
    }
}

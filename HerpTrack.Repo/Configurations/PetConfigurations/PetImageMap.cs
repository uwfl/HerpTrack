using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class PetImageMap
    {
        public PetImageMap(EntityTypeBuilder<PetImage> entityBuilder)
        {
            entityBuilder.HasKey(pet => pet.Id);
            entityBuilder.Property(pet => pet.PetId).IsRequired();

            entityBuilder.HasOne(petImage => petImage.Pet).WithMany(pet => pet.Images).HasForeignKey(petImage => petImage.PetId);
        }
    }
}

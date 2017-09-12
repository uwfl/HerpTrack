using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class PetMap
    {
        public PetMap(EntityTypeBuilder<Pet> entityBuilder)
        {
            entityBuilder.HasKey(pet => pet.Id);
            entityBuilder.Property(pet => pet.Name).IsRequired();
            entityBuilder.Property(pet => pet.UserId).IsRequired();
            entityBuilder.Property(pet => pet.Birthdate).IsRequired();
            entityBuilder.Property(pet => pet.PetDiaryId).IsRequired();

            entityBuilder.HasOne(pet => pet.Owner).WithMany(user => user.Pets).HasForeignKey(pet => pet.UserId);
            entityBuilder.HasOne(pet => pet.Diary).WithOne(diary => diary.Pet);
        }
    }
}

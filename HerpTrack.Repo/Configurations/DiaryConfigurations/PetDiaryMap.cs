using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class PetDiaryMap
    {
        public PetDiaryMap(EntityTypeBuilder<PetDiary> entityBuilder)
        {
            entityBuilder.Property(w => w.PetId).IsRequired();

            entityBuilder.HasOne(w => w.Pet).WithOne(p => p.Diary);
        }
    }
}

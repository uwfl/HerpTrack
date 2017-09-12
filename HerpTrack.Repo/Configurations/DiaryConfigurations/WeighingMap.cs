using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations.PetConfigurations
{
    public class WeighingMap
    {
        public WeighingMap(EntityTypeBuilder<Weighing> entityBuilder)
        {
            entityBuilder.Property(w => w.Date).IsRequired();
            entityBuilder.Property(w => w.Weight).IsRequired();
            entityBuilder.Property(w => w.PetDiaryId).IsRequired();

            entityBuilder.HasOne(w => w.PetDiary).WithMany(p => p.Weighings).HasForeignKey(w => w.PetDiaryId);
        }
    }
}

using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations
{
    public class BaseEntityMap
    {
        public BaseEntityMap(EntityTypeBuilder<BaseEntity> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.CreatedDate).ValueGeneratedOnAdd();
            entityBuilder.Property(t => t.ModifiedDate).ValueGeneratedOnAddOrUpdate();
            entityBuilder.Property(t => t.CreatedDate).IsRequired();
        }
    }
}

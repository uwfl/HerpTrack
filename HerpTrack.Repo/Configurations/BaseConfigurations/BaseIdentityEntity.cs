using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations
{
    public class BaseIdentityEntityMap
    {
        public BaseIdentityEntityMap(EntityTypeBuilder<BaseIdentityEntity> entityBuilder)
        {
            entityBuilder.HasKey(t => t.IdentityId);
            entityBuilder.Property(t => t.CreatedDate).ValueGeneratedOnAdd();
            entityBuilder.Property(t => t.ModifiedDate).ValueGeneratedOnAddOrUpdate();
            entityBuilder.Property(t => t.Active).IsRequired();
        }
    }
}

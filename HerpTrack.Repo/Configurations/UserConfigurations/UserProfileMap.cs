using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Birthday).IsRequired();

            entityBuilder.HasOne(userProfile => userProfile.User).WithOne(user => user.UserProfile).HasForeignKey<User>(user => user.IdentityId); // 1-to-1 Relationship where the Foreign Key is user.Id.
        }
    }
}

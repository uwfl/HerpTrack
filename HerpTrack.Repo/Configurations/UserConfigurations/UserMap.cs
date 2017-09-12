using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Configurations
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(user =>user.IdentityId);
            entityBuilder.Property(user => user.IdentityId).ValueGeneratedOnAdd();
            entityBuilder.Property(user => user.Email).IsRequired();
            entityBuilder.Property(user => user.UserName).IsRequired();
            entityBuilder.Property(user => user.UserProfileId).IsRequired();

            entityBuilder.HasOne(user => user.Avatar).WithOne(avatar => avatar.User);
            entityBuilder.HasOne(user => user.UserProfile).WithOne(userProfile => userProfile.User);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class User : BaseIdentityEntity 
    {
        public User()
        {
            Pets = new List<Pet>();
        }

        public Int64 UserProfileId { get; set; }
        public Int64? AvatarId { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        public virtual Avatar Avatar { get; set; }
        public virtual List<Pet> Pets { get; set; }
    }
}

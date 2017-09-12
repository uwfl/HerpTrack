using HerpTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Service.Interfaces
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
        IEnumerable<UserProfile> GetUserProfiles();
    }
}

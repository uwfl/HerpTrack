using HerpTrack.Data.Models;
using HerpTrack.Repo.Interfaces;
using HerpTrack.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Service.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
        }
    }
}
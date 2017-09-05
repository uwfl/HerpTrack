using Microsoft.EntityFrameworkCore;
using HerpTrack.Data.Configurations;
using HerpTrack.Data.Models;

namespace HerpTrack.Repo
{
    public class HerpTrackContext : DbContext
    {
        public HerpTrackContext(DbContextOptions<HerpTrackContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}

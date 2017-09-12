using Microsoft.EntityFrameworkCore;
using HerpTrack.Data.Models;
using HerpTrack.Repo.Interfaces;
using HerpTrack.Repo.Configurations;
using HerpTrack.Repo.Configurations.PetConfigurations;

namespace HerpTrack.Repo
{
    public class HerpTrackContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<PetDiary> PetDiary { get; set; }
        public DbSet<Weighing> Weighing { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Supplement> Supplement { get; set; }
        public DbSet<Feeding> Feeding { get; set; }
        public DbSet<FeedingCycle> FeedingCycle { get; set; }
        public DbSet<FeedingEntry> FeedingEntry { get; set; }

        public HerpTrackContext(DbContextOptions<HerpTrackContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Base configurations.
            new BaseEntityMap(modelBuilder.Entity<BaseEntity>());
            new BaseIdentityEntityMap(modelBuilder.Entity<BaseIdentityEntity>());

            // User configurations.
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());

            // Pet configurations.
            new PetMap(modelBuilder.Entity<Pet>());
            new PetImageMap(modelBuilder.Entity<PetImage>());

            // Feeding configurations.

            // Diary configurations.

        }
    }
}

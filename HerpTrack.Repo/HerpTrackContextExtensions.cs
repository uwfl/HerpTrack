using HerpTrack.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerpTrack.Repo
{
    public static class HerpTrackContextExtensions
    {
        public static void EnsureSeedData(this HerpTrackContext context)
        {
            if(!context.Database.GetPendingMigrations().Any())
            {
                // Seed here.
                if (!context.User.Any())
                {
                    // Initialize User + Profile.
                    var user = context.User.Add(new User { UserName = "distlerm", Email = "martin.distler@gmail.com" }).Entity;
                    var userProfile = context.UserProfile.Add(new UserProfile { FirstName = "Martin", LastName = "Distler", UserId = user.IdentityId });
                }

                if (!context.Supplement.Any())
                {
                    // Initialize Supplements.
                    context.Supplement.AddRange
                    (
                        new Supplement { Name = "Calcium" },
                        new Supplement { Name = "Calcium + D3" },
                        new Supplement { Name = "Minerals" },
                        new Supplement { Name = "Minerals + D3" }
                    );
                }

                if (!context.Food.Any())
                {
                    // Initialize Foods.
                    context.Food.AddRange
                    (
                        new Food { Name = "Heimchen" },
                        new Food { Name = "Zophobas" },
                        new Food { Name = "Mehlwurm" }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}

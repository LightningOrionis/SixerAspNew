using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sixerr.Data;

namespace Sixerr.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AppDbContext>>()))
            {
                if (!context.Profiles.Any())
                {
                    context.Profiles.AddRange(
                        new Profile
                        {
                            Id = 1,
                            User = new IdentityUser("user15"),
                            About = "about profile user 15",
                            Avatar = "Avatar user 15"
                        },
                        new Profile
                        {
                            Id = 2,
                            User = new IdentityUser("user16"),
                            About = "about profile user 16",
                            Avatar = "Avatar user 16"
                        },
                        new Profile
                        {
                            Id = 3,
                            User = new IdentityUser("user17"),
                            About = "about profile user 17",
                            Avatar = "Avatar user 17"
                        }
                    );
                }
                if (!context.Gigs.Any())
                {
                    context.Gigs.AddRange(
                        new Gig
                        {
                            Id = 1,
                            Title = "Gig 1",
                            Description = "Gig 1 Desc",
                            Price = 10,
                            Photo = "abc",
                            Status = true,
                            CreateTime = DateTime.Now,
                            User = context.Profiles.Find(1u),
                            Category = CategoriesEnum.IT
                        },
                        new Gig
                        {
                            Id = 2,
                            Title = "Gig 2",
                            Description = "Gig 2 Desc",
                            Price = 20,
                            Photo = "abc2",
                            Status = true,
                            CreateTime = DateTime.Now,
                            User = context.Profiles.Find(2u),
                            Category = CategoriesEnum.IT
                        },
                        new Gig
                        {
                            Id = 3,
                            Title = "Gig 3",
                            Description = "Gig 3 Desc",
                            Price = 30,
                            Photo = "abc3",
                            Status = true,
                            CreateTime = DateTime.Now,
                            User = context.Profiles.Find(3u),
                            Category = CategoriesEnum.IT
                        }
                    );
                }
                if(!context.Reviews.Any())
                {
                    context.Reviews.AddRange(
                        new Review
                        {
                            Author = context.Profiles.Find(1u),
                            Gig = context.Gigs.Find(1u),
                            Text = "11"
                        },   
                        new Review
                        {
                            Author = context.Profiles.Find(1u),
                            Gig = context.Gigs.Find(2u),
                            Text = "12"
                        },
                        new Review
                        {
                            Author = context.Profiles.Find(2u),
                            Gig = context.Gigs.Find(2u),
                            Text = "22"
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}

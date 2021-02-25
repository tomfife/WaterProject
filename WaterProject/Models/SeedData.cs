using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WaterProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            CharityDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CharityDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        Type = "Well Rehab",
                        Program = "Water for Sierra Leone",
                        Impact = 400,
                        Phase = "Community Managed",
                        CompletionDate = new DateTime(2010, 08, 01),
                        Features = "WR, LL, CE, HST"
                    },

                    new Project
                    {
                        Type = "Well Rehab",
                        Program = "Water for Burkina Faso",
                        Impact = 500,
                        Phase = "Community Managed",
                        CompletionDate = new DateTime(2012, 08, 01),
                        Features = "WR, LL, CE, HST"
                    },

                    new Project
                    {
                        Type = "Borehole Well and Hand Pump",
                        Program = "Water for South Sudan - NeverThirst",
                        Impact = 500,
                        Phase = "Community Managed",
                        CompletionDate = new DateTime(2013, 08, 01),
                        Features = "BW/HP, LL, CE, HST"
                    },

                    new Project
                    {
                        Type = "Urban Water Kiosk",
                        Program = "Urban Water Kiosks",
                        Impact = 500,
                        Phase = "Community Managed",
                        CompletionDate = new DateTime(2012, 10, 01),
                        Features = "UWK, LL, CE, "
                    },

                    new Project
                    {
                        Type = "Borehole Well and Hand Pump",
                        Program = "Wells for Rwanda",
                        Impact = 500,
                        Phase = "Community Managed",
                        CompletionDate = new DateTime(2012, 10, 01),
                        Features = "BW/HP, LL, CE, HST"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

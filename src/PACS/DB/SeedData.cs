using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PACS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.DB
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDBContext>();
            if (!context.GymCards.Any())
            {
                context.GymCards.AddRange(
                    new GymCard { Tainer = true, DateOrder = DateTime.Now, Kind = Kind.Month_1, GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now, Kind = Kind.Times_12, GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now, Kind = Kind.Year, GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now, Kind = Kind.Month_3, GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now, Kind = Kind.Times_16, GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now, Kind = Kind.Student, GymMemberId = 4 });
                context.SaveChanges();
            }
            if (!context.GymMembers.Any())
            {
                context.GymMembers.AddRange(
                    new GymMember { FirstName = "Dima", LastName="Reznik",BirthDate= new DateTime(1985,2,7),Email="dvreznik@gmail.com", PhoneNumber="+380951231220",Staff=false }
                    );
                context.SaveChanges();
            }       
        }
    }
}

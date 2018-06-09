using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PACS.Infrastructure;
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

            if (!context.GymMembers.Any())
            {
                context.GymMembers.AddRange(
                    new GymMember { FirstName = "Dima", LastName = "Reznik", BirthDate = new DateTime(1985, 2, 7), Email = "dvreznik@gmail.com", PhoneNumber = "+380951231220", Staff = true,RelImage = "/images/dima.jpg" },
                    new GymMember { FirstName = "Rostyslav", LastName = "Kosmirak", BirthDate = new DateTime(1997, 2, 3), Email = "rkosmirak@gmail.com", PhoneNumber = "+380663090777", Staff = false, RelImage = "/images/kosmirak.jpg" },
                    new GymMember { FirstName = "Mykola", LastName = "Yatsyshyn", BirthDate = new DateTime(1980, 2, 18), Email = "yatsyshyn@gmail.com", PhoneNumber = "+380667439960", Staff = true, RelImage = "/images/yatsyshyn.jpg" }
                    );
                context.SaveChanges();
            }

            if (!context.GymCards.Any())
            {
                //var gymMemgerId = context.GymMembers.Select(x => x.GymMemberId).First();

                context.GymCards.AddRange(
                    new GymCard { Trainer = true, DateOrder = DateTime.Now, Kind = Kind.Month_1.GetDisplayName(), GymMemberId = 1 },
            new GymCard { Trainer = false, DateOrder = DateTime.Now, Kind = Kind.Times_12.GetDisplayName(), GymMemberId = 3 },
            new GymCard { Trainer = false, DateOrder = DateTime.Now, Kind = Kind.Year.GetDisplayName(), GymMemberId = 2 },
            new GymCard { Trainer = false, DateOrder = DateTime.Now, Kind = Kind.Month_3.GetDisplayName(), GymMemberId = 1 },
            new GymCard { Trainer = false, DateOrder = DateTime.Now, Kind = Kind.Times_16.GetDisplayName(), GymMemberId = 3 },
            new GymCard { Trainer = false, DateOrder = DateTime.Now, Kind = Kind.Student.GetDisplayName(), GymMemberId = 2 });
                context.SaveChanges();
            }
            
        }
    }
}

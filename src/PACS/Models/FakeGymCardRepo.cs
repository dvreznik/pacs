using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models
{
    public class FakeGymCardRepo : IGymCardRepo
    {
        public IEnumerable<GymCard> GymCards => new List<GymCard>
        {
            new GymCard { Tainer = true, DateOrder = DateTime.Now,Kind = Kind.Month_1,GymMemberId = 2 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now,Kind = Kind.Times_12,GymMemberId = 19 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now,Kind = Kind.Year,GymMemberId = 4 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now,Kind = Kind.Month_3,GymMemberId =2 },
            new GymCard { Tainer = false, DateOrder = DateTime.Now,Kind = Kind.Times_16,GymMemberId = 1},
            new GymCard { Tainer = false, DateOrder = DateTime.Now,Kind = Kind.Student,GymMemberId = 2}

        };
        
    }
}

using PACS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.DB
{
    public class EFMemberRepository : IGymMemberRepo
    {
        private ApplicationDBContext _context;

        public EFMemberRepository(ApplicationDBContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<GymMember> GymMembers => _context.GymMembers;
                        
    }
}

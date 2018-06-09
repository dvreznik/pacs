using PACS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.DB
{
    public class EFCardsRepository : IGymCardRepo
    {
        private ApplicationDBContext _context;

        public EFCardsRepository(ApplicationDBContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<GymCard> GymCards => _context.GymCards;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models.ViewModels
{
    public class CardListViewModel
    {
        public IEnumerable<GymCard> GymCards { get; set; }
        public IEnumerable<GymMember> GymMembers { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}

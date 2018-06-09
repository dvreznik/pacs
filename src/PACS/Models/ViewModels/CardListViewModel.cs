using System;
using System.Collections.Generic;

namespace PACS.Models.ViewModels
{
    public class CardListViewModel
    {
        //public IEnumerable<GymCard> GymCards { get; set; }
        //public IEnumerable<GymMember> GymMembers { get; set; }
        public IEnumerable<GymCardViewModel> GymCards { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentKind { get; set; }        
    }

    public class GymCardViewModel
    {
        public int OwnerId { get; set; }
        public string Img { get; set; }
        public bool Trainer { get; set; }
        public DateTime DateOrder { get; set; }
        public string Kind { get; set; }        
        public string OwnerName { get; set; }
        
    }
}
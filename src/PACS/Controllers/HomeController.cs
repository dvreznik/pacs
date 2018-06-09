using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PACS.Models;
using PACS.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PACS.Controllers
{
    public class HomeController : Controller
    {
        //private fields
        private IGymCardRepo _cardRepo;
        private IGymMemberRepo _memberRepo;
        // public fileds
        public int PageSize = 4;
        //constructor
        // access to data
        public HomeController(IGymCardRepo cardRepo, IGymMemberRepo memberRepo)
        {
            _cardRepo = cardRepo;
            _memberRepo = memberRepo;
        }        

        public ViewResult Index(string kind, int page = 1)
           => View(new CardListViewModel
           {
               GymCards = _cardRepo.GymCards
               .Where(p => kind == null || p.Kind == kind)
               .Include(x => x.GymMember)
               .Select(x => new GymCardViewModel
               {     
                   OwnerId = x.GymMember.GymMemberId,              
                   Img = x.GymMember.RelImage,
                   Trainer = x.Trainer,
                   DateOrder = x.DateOrder,
                   Kind = x.Kind,
                   OwnerName = x.GymMember.FirstName
               })
               .OrderBy(p => p.OwnerId)
               .Skip((page - 1) * PageSize)
               .Take(PageSize),               
               PagingInfo = new PagingInfo
               {
                   CurrentPage = page,
                   ItemPerPage = PageSize,
                    TotalItems = kind == null ?
                   _cardRepo.GymCards.Count() :
                   _cardRepo.GymCards.Where(e => e.Kind == kind).Count()
               },
               CurrentKind = kind
           }
           );

        public ViewResult MemberList() => View(_memberRepo.GymMembers);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        // GET: /<controller>/
        
        public ViewResult Index(int page = 1)
            => View(new CardListViewModel
            {
                GymCards = _cardRepo.GymCards
                .OrderBy(p => p.GymCardId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                GymMembers = _memberRepo.GymMembers,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = PageSize,
                    TotalItems = _cardRepo.GymCards.Count()
                }
            }
            );        

        public ViewResult MemberList() => View(_memberRepo.GymMembers);
    }
}

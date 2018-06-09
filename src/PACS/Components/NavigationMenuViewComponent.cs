using Microsoft.AspNetCore.Mvc;
using PACS.Models;
using PACS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        // private fields
        private IGymCardRepo _cardRepo;
        // constructor
        public NavigationMenuViewComponent(IGymCardRepo cardRepo)
        {
            _cardRepo = cardRepo;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(new NavigationMenuViewModel
            {
                SelectedKind = (string)RouteData?.Values["kind"],
                Kinds = _cardRepo.GymCards
                .Select(x => x.Kind)
                .Distinct()
                .OrderBy(x => x)
            });
        } 
    }
}

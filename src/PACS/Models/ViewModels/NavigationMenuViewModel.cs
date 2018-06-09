using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models.ViewModels
{
    public class NavigationMenuViewModel
    {
        public string SelectedKind { get; set; }
        public IQueryable<string> Kinds { get; set; }
    }
}

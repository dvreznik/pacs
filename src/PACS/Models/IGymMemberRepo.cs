using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models
{
    public interface IGymMemberRepo
    {
        IEnumerable<GymMember> GymMembers { get; }        
    }
}

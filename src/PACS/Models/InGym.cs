using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models
{
    public class InGym
    {
        // private fields
        private List<MemberInGym> memberCollection = new List<MemberInGym>();

        // adding method
        public virtual void AddMember(GymMember gymMeber)
        {
            MemberInGym member = memberCollection
                .Where(p => p.GymMember.GymMemberId == gymMeber.GymMemberId)
                .FirstOrDefault();
            if(member == null)
            {
                memberCollection.Add(
                    new MemberInGym
                    {
                        GymMember = gymMeber,
                        TimeIn = DateTime.Now.ToString("hh:mm")
                    }
                    );
            }
        }

        //removing method
        public virtual void RemoveMember(GymMember gymMember)
        {
            memberCollection.Remove(
                memberCollection.FirstOrDefault(p => p.GymMember.GymMemberId == gymMember.GymMemberId)
            );
        }

    }

    public class MemberInGym
    {
        public GymMember GymMember { get; set; }
        public string TimeIn { get; set; }
    }


}

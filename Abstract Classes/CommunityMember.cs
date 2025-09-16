using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion
{
    public abstract class CommunityMember : Person
    {
        public string CommunityMemberId { get; set; }
        public string RolCommunityMember { get; set; }

        public CommunityMember(string name, string surname, string sex, string communitymember, string rol) :
            base(name, surname, sex)
        {
            CommunityMemberId = communitymember;
            RolCommunityMember = rol;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion
{
    public abstract class CommunityMember : Person
    {
        public string RolCommunityMember { get; set; }

        public CommunityMember(string name, string surname, string sex, string rol) :
            base(name, surname, sex)
        {
            RolCommunityMember = rol;

        }

    }
}

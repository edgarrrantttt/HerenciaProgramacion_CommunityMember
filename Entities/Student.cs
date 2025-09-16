using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Student : CommunityMember
    {

        public string IdStudent { get; set; }
        public string Career { get; set; }

        public Student(string name, string surname, string sex, string communitymember,string rol , string career)
            : base(name, surname, sex, communitymember, rol)
        {
            IdStudent = communitymember;
            Career = career;
        }

        public string StudentInfo()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nStudent ID: {IdStudent}\nRol: {RolCommunityMember}\nCareer: {Career}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class ExStudent: CommunityMember
    {
        public string EnrollmentDate { get; set; }
        public string SelectedCareer { get; set; }

        public ExStudent(string name, string surname, string sex, string enrollment_date, string rol,string selected_career)
            : base( name, surname,  sex, rol)
        {
            EnrollmentDate = enrollment_date;
            SelectedCareer = selected_career;
        }

        public string ExStudentInfo()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nSelected Career: {SelectedCareer}\nRol: {RolCommunityMember}\nEnrollment Career: {EnrollmentDate}\n";
        }

    }
}

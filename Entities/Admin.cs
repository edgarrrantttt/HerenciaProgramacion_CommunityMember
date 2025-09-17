using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Admin: Lecturer
    {
        public int Bonus;
        public int YearsExperiences;
        //public string 

        public Admin(string name, string surname, string sex, string rol,
            int employee_salary, string subject_assigned, int bonus, int years_experiences)
            :base(name, surname, sex, rol, employee_salary,subject_assigned)
        {
            Bonus = bonus;
            YearsExperiences = years_experiences;
        }

        public string AdminInfo()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nRol: {RolCommunityMember}\nYears of Experiences: {YearsExperiences}\nSalary: {Salary}\nBonus: {Bonus}\n";
        
        }
        
    }
}

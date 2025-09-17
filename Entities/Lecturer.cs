using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Lecturer: Employee
    {
        public string SubjectAssigned { get; set; } 

        public Lecturer(string name, string surname, string sex, string rol, int employee_salary, string subject_assigned)
            :base(name, surname ,sex, rol, employee_salary)
        {
            SubjectAssigned = subject_assigned;
        }

        public string ShowLecturer()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nRol: {RolCommunityMember}\nSubject Assigned: {SubjectAssigned}\nSalary: {Salary}\n";
        }
    }
}

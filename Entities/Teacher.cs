using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Teacher:Lecturer
    {
        //public List<string> AssignedSections = new List<string> {};
        public string AssignedSections;
        public Teacher(string name, string surname, string sex, string rol, int employee_salary, string subject_assigned, string assigned_section)
            :base(name, surname, sex, rol, employee_salary, subject_assigned)
        {
            AssignedSections = assigned_section;
        }

        public string InfoTeacher()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nRol: {RolCommunityMember}\nSubject Assigned: {SubjectAssigned}\nSalary: {Salary}\nSection: {AssignedSections}\n";
        }
    }
}

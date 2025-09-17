using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Executive: Employee
    {
        public string Department { get; set; }
        public string Contact { get; set; }
        
        public Executive (string name, string surname, string sex, string rol, int employee_salary, string department, string contact)
            :base (name, surname, sex, rol, employee_salary)
        {
            Department  = department ;
            Contact = contact;
        }

        public string ExecutiveInfo()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nRol: {RolCommunityMember}\nSalary: {Salary}\n Department: {Department}\nContact: {Contact}\n";
        }
    }
}

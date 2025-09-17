using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion.Entities
{
    public class Employee:CommunityMember
    {
        public int Salary { get; set; }

        public Employee(string name, string surname, string sex, string rol, int employee_salary)
            : base(name, surname, sex, rol)
        {
            Salary = employee_salary;

        }

        public string EmployeeInfo()
        {
            return $"Name: {Name}\nSurname: {SurName}\nSex: {Sex}\nRol: {RolCommunityMember}\nSalary: {Salary}\n";
        }
    }
}

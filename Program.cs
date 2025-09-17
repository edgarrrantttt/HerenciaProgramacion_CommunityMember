using HerenciaProgramacion.Entities;

namespace HerenciaProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student newstudent = new Student("Edgar", "Rosario", "M", "2024-1678", "Student", "Software Development");
            Console.WriteLine(newstudent.StudentInfo());

            ExStudent exstudent = new ExStudent("Eitan", "Guzman", "M", "2023/02/12", "Ex-Student", "Cibersecurity");
            Console.WriteLine(exstudent.ExStudentInfo());

            Employee newemployee = new Employee("Edward", "Feliz", "F", " ", 25400);
            Console.WriteLine(newemployee.EmployeeInfo());

            Executive newexcutive = new Executive("Ramona", "Villanueba", "F", "Technian", 50000, "IT", "ramonait@itla.it.do");
            Console.WriteLine(newexcutive.ExecutiveInfo());

            Lecturer newlecturer = new Lecturer("Antonio", "Rosa", "M", "Lecturer", 75000, "Math");
            Console.WriteLine(newlecturer.ShowLecturer());

            Teacher newteacher = new Teacher("Francisco", "Gomez", "M", "Teacher", 67000, "Math", "Algebra");
            Console.WriteLine(newteacher.InfoTeacher());
            
        }
    }
}

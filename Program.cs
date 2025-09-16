using HerenciaProgramacion.Entities;

namespace HerenciaProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student newstudent = new Student("Edgar", "Rosario", "M", "2024-1678", "Student", "Software Development" );
            Console.WriteLine(newstudent.StudentInfo());
        }
    }
}

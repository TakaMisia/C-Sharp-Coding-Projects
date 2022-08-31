using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Studentinfo())
            {
                //info about school
                Console.Write("Enter Student name: ");
                var name = Console.ReadLine();

                var Student = new Student { StudentName = name };
                db.Students.Add(Student);
                db.SaveChanges();

                // Display all schoil from the system
                var query = from a in db.Students
                            orderby a.StudentName
                            select a;

                Console.WriteLine("Here You can find all students:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press anything if you wish exit");
                Console.ReadKey();
            }

        }
    }


    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }

        public virtual Student Students { get; set; }
    }


    public class Studentinfo : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}

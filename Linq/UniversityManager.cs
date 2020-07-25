using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University{ Id = 1, Name = "SPPU"});
            universities.Add(new University{ Id = 2, Name = "Mumbai University"});

            students.Add(new Student{ Id = 1, Name = "Ayush", Gender = "Male", Age = 22, UniversityId = 1});
            students.Add(new Student{ Id = 2, Name = "Yash", Gender = "Male", Age = 22, UniversityId = 2});
            students.Add(new Student{ Id = 3, Name = "Anushree", Gender = "Female", Age = 21, UniversityId = 1});
            students.Add(new Student{ Id = 4, Name = "Amey", Gender = "Male", Age = 22, UniversityId = 2});
            students.Add(new Student{ Id = 5, Name = "Aniket", Gender = "Male", Age = 21, UniversityId = 1});
        }

        public void MaleStudents()
        {
            Console.WriteLine("============================================================================================");
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male Students");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            Console.WriteLine("============================================================================================");
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Female Students");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            Console.WriteLine("============================================================================================");
            var sortedStudents = from student in students orderby student.Age, student.Name select student;
            // var sortedStudentsNames = from student in students orderby student.Age, student.Name select student.Name;
            // foreach (string name in sortedStudentsNames)
            // {
            //     Console.WriteLine(name);
            // }
            Console.WriteLine("Students sorted by age");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromSPPU()
        {
            Console.WriteLine("============================================================================================");
            IEnumerable<Student> sppuStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "SPPU"
                                                select student;
            Console.WriteLine("Students in SPPU");
            foreach (Student student in sppuStudents)
            {
                student.Print();
            }    
        }

        public void AllStudentsFromUniversity(int id)
        {
            Console.WriteLine("============================================================================================");
            IEnumerable<Student> universityStudents = from student in students
                                                      join university in universities on student.UniversityId equals university.Id
                                                      where university.Id == id
                                                      select student;
            Console.WriteLine("Students in University {0}.", id);
            foreach (Student student in universityStudents)
            {
                student.Print();
            }    
        }

        public void StudentAndUniversityNameCollection()
        {

            Console.WriteLine("============================================================================================");
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new {StudentName = student.Name, UniversityName = university.Name};

            Console.WriteLine("New Collection");
            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}.", col.StudentName, col.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}.", Name, Id);
        }
    }

    class Student
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foregin Key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1} , Gender {2} and Age {3} from University with Id {4}.", Name, Id, Gender, Age, UniversityId);
        }
    }
}

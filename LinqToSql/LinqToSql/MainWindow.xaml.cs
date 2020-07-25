using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;


/// <summary>
/// Very Important:
/// In Linq
/// 1.)We can give Id or directly an object where foreign key is involved when inserting records in tables.
/// 2.)Parent Table object can access all the associated records of the child table
/// 3.)we can also access the parent record object associated to child record
/// </summary>
namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.PracticeDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            // InsertUniversities();
            // InsertStudents();
            // InsertLectures();
            // InsertStudentLectureAssociation();
            // GetStudentUniversity("Ayush");
            // GetStudentLecture("Amey");
            // GetAllStudentsFromUniversity("SPPU");
            // GetAllUniversitiesWithFemale();
            // GetAllLecturesFromUniversity("SPPU");
            // UpdateName("Amey", "Ashwin");
            // DeleteStudent("Anushree");
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University SPPU = new University();
            SPPU.Name = "SPPU";
            dataContext.Universities.InsertOnSubmit(SPPU);

            University MumbaiUniversity = new University();
            MumbaiUniversity.Name = "MumbaiUniversity";
            dataContext.Universities.InsertOnSubmit(MumbaiUniversity);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            dataContext.ExecuteCommand("delete from Student");

            University SPPU = dataContext.Universities.First(un => un.Name.Equals("SPPU"));
            University MumbaiUniversity = dataContext.Universities.First(un => un.Name.Equals("MumbaiUniversity"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Ayush", Gender = "Male", UniversityId = SPPU.Id });
            students.Add(new Student { Name = "Amey", Gender = "Male", UniversityId = MumbaiUniversity.Id });
            students.Add(new Student { Name = "Anushree", Gender = "Female", University = SPPU });
            students.Add(new Student { Name = "Yash", Gender = "Male", University = MumbaiUniversity });
            students.Add(new Student { Name = "Aniket", Gender = "Male", University = SPPU });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "DSA" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "DBMS" });
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }
        public void InsertStudentLectureAssociation()
        {
            Student Ayush = dataContext.Students.First(st => st.Name.Equals("Ayush"));
            Student Amey = dataContext.Students.First(st => st.Name.Equals("Amey"));
            Student Anushree = dataContext.Students.First(st => st.Name.Equals("Anushree"));
            Student Yash = dataContext.Students.First(st => st.Name.Equals("Yash"));
            Student Aniket = dataContext.Students.First(st => st.Name.Equals("Aniket"));

            Lecture DSA = dataContext.Lectures.First(le => le.Name.Equals("DSA"));
            Lecture DBMS = dataContext.Lectures.First(le => le.Name.Equals("DBMS"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Ayush, Lecture = DSA });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Amey, Lecture = DBMS });

            // We can give Id or directly an object where foreign key is involved when inserting records in tables.

            StudentLecture sl3 = new StudentLecture();
            sl3.Student = Anushree;
            sl3.LectureId = DSA.Id;
            dataContext.StudentLectures.InsertOnSubmit(sl3);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Yash, Lecture = DBMS });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Aniket, Lecture = DSA });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetStudentUniversity(string name)
        {
            Student s1 = dataContext.Students.First(st => st.Name.Equals(name));
            University u1 = s1.University;

            List<University> universities = new List<University>();
            universities.Add(u1);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetStudentLecture(string name)
        {

            Student s1 = dataContext.Students.First(st => st.Name.Equals(name));

            // StudentLecture sl1 = dataContext.StudentLectures.First(stl => stl.Student.Equals(s1));
            // Console.WriteLine(sl1.LectureId);


            // Parent Table object can access all the associated records of the child table
            var studentLectures = from sl in s1.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = studentLectures;
        }

        public void GetAllStudentsFromUniversity(string name)
        {
            // University u1 = dataContext.Universities.First(ut => ut.Name.Equals(name));
            // var students = from student in u1.Students select student;

            // or
            // we can also access the parent record object associated to child record
            var students = from student in dataContext.Students
                           where student.University.Name == name
                           select student;
            MainDataGrid.ItemsSource = students;
        }

        public void GetAllUniversitiesWithFemale()
        {
            /*
            var universities = from student in dataContext.Students
                               where student.Gender == "Female"
                               select student.University;
            */
            // or
            var universities = from student in dataContext.Students
                               join university in dataContext.Universities
                               on student.University equals university
                               where student.Gender == "Female"
                               select university;
            MainDataGrid.ItemsSource = universities;

        }

        public void GetAllLecturesFromUniversity(string name)
        {
            //var lectures = from sl in dataContext.StudentLectures
            //               where sl.Student.University.Name == name
            //               select sl.Lecture;
            // or
            ///*
            var lectures = from sl in dataContext.StudentLectures
                           join student in dataContext.Students on sl.StudentId equals student.Id
                           where student.University.Name == name
                           select sl.Lecture;
            //*/
            MainDataGrid.ItemsSource = lectures;
        }

        public void UpdateName(string originalName, string newName)
        {
            Student s1 = dataContext.Students.FirstOrDefault(st => st.Name.Equals(originalName));
            s1.Name = newName;
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteStudent(string name)
        {
            Student s1 = dataContext.Students.FirstOrDefault(st => st.Name.Equals(name));
            dataContext.Students.DeleteOnSubmit(s1);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }
    }
}


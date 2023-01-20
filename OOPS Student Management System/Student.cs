using OOPS_Student_Management_System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPSStudentManagementSystem
{
    //Public class
    public class Student
    {
        public int age;
        public int standard;
        public string name;
        //paramitarized constructor
        public Student(int age, int standard,string name)
        {
            this.age = age;
            this.standard = standard;
            this.name=name;
        }

        public void GetStudentBasicinfo()
        {
            Console.WriteLine("Here is the Details of the student:");
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Standard : " + standard);
        }


        //static class
        public static class School
        {
            public static string schoolName = "Zen School";
            public static void SchoolName()
            {
                Console.WriteLine("School Name :" + schoolName);
            }
        }

        public class StudentDetails : CourseDetails, IStudent
        {
            public string GetStudentCourse(string course)
            {
                Console.WriteLine("Course : " + course);
                return course;
            }
            public int GetStudentDivision(int div)
            {
                Console.WriteLine("Division : " + div);
                return div;
            }
            public int GetStudentRollNo(int no)
            {
                Console.WriteLine("Roll No : " + no);
                return no;
            }

            public override void GetCourseDetail()
            {
                Console.WriteLine("CourseName :" + courseName);
                Console.WriteLine("CourseCode :" + courseCode);

            }

            public static void Main(string[] args)
            {
                Student student = new Student(12, 7,"Sarthak Patel");
                student.GetStudentBasicinfo();
                StudentDetails details = new StudentDetails();
                StudentFeesAsParCourseSelection fees = new StudentFeesAsParCourseSelection();
                School.SchoolName();
                details.GetStudentCourse("Computer Science");
                details.GetStudentRollNo(10);
                details.GetStudentDivision(102);
                details.courseName = "Asp.Net";
                details.courseCode=12;
                details.GetCourseDetail();
                Console.WriteLine("Fees of 2 Courses :" + fees.Fees(10000, 10000));
                Console.WriteLine("Fees of 3 Courses :" + fees.Fees(10000, 10000, 10000));

            }
        }
    }
}
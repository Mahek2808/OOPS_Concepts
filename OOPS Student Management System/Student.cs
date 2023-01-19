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
        //paramitarized constructor
        public Student(int age, int standard)
        {
            this.age = age;
            this.standard = standard;
        }

        public void GetStudentinfo()
        {
            Console.WriteLine("Here is the Details of the student:");
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
            public void Course(string course)
            {
                Console.WriteLine("Course : " + course);
            }
            public void Division(int div)
            {
                Console.WriteLine("Division : " + div);
            }
            public void Name(string name)
            {
                Console.WriteLine("Name : " + name);
            }
            public void RollNo(int no)
            {
                Console.WriteLine("Roll No : " + no);
            }

            public override void CourseDetail()
            {
                Console.WriteLine("CourseName :" + courseName);
                Console.WriteLine("CourseCode :" + courseCode);
                
            }
            //public void CourseCode(int code)
            //{
            //    Console.WriteLine("CourseCode:" + code);
            //}


            public static void Main(string[] args)
            {
                Student student = new Student(12, 7);
                student.GetStudentinfo();
                StudentDetails details = new StudentDetails();
                StudentTotalFees fees = new StudentTotalFees();
                School.SchoolName();
                details.Name("Sarthak");
                details.Course("Computer Science");
                details.RollNo(10);
                details.Division(102);
                details.courseName = "Asp.Net";
                details.courseCode=12;
                details.CourseDetail();
                Console.WriteLine("Fees of 2 Courses :" + fees.Fees(10000, 10000));
                Console.WriteLine("Fees of 3 Courses :" + fees.Fees(10000, 10000, 10000));

            }
        }
    }
}
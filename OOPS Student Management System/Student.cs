using OOPS_Student_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPSStudentManagementSystem
{
    //Public class
    public class Student
    {
        private int age;
        private int standard;
        //paramitarized constructor
        public Student(int age,int standard)
        {
            this.age = age;
            this.standard = standard;   
        }
        //copy constructor
        //public Student(Student S)
        //{
        //    this.age = S.age;   
        //    this.standard = S.standard; 
        //}

        private void GetStudentinfo()
        {
            Console.WriteLine("Here is the Details of the student:");
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Standard : " + standard);
        }


        //staic class
        public static class School
        {
            public static string SchoolName = "Zen School";
            public static void SName()
            {
                Console.WriteLine("School Name :" + SchoolName);
            }
        }
       
        public class StudentDetails : CourseDetails,Interface
        {
            public string Course()
            {
                Console.WriteLine("Course : Computer Science");
                return string.Empty;
               
            }

            public int Division()
            {
                Console.WriteLine("Division : 101");
                return 1;
            }

            public string Name()
            {
                Console.WriteLine("Name : Sarthak Patel");
                return string.Empty;    
                
            }

            public int RollNo()
            {
                Console.WriteLine("Roll No : 10");
                return 1;
            }

            protected internal override void Coursedetails()
            {
                Console.WriteLine("CourseName :" + CourseName);
               // Console.WriteLine("CourseCode:" + CourseCode);
            }

            public int Coursecodeno()
            {
                Console.WriteLine("CourseCode :"+ CourseCode);
                return 1;
            }

        }

        public static void Main(string[] args)
        {
            Student student = new Student(12,7);
            student.GetStudentinfo();
            StudentDetails details = new StudentDetails();
            StudentTotalFees fees = new StudentTotalFees();
            StudentTotalFees CourseFees = new CourseFee();
            School.SName();            
            details.Name();
            details.Course();
            details.RollNo();
            details.Division();            
            details.CourseName = "Asp.Net";
            details.CourseCode = 20;
            details.Coursecodeno();
            details.Coursedetails();
            Console.WriteLine("Default Fees of 1 course :" + fees.CourseFees(10000));
            Console.WriteLine("Fees of 2 Courses :" + fees.Fees(10000 , 10000));
            Console.WriteLine("Fees of 3 Courses :" + fees.Fees(10000, 10000 , 10000));
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Student_Management_System
{
    //Interface
    internal interface IStudent
    {
         void Name(string name);
         void Course(string course);
         void RollNo(int no);
         void Division(int div);
    }
    public abstract class CourseDetails 
    { 
        public string? courseName;
        public int? courseCode;
        public int Coursecode
        {
            get 
            {
                return Coursecode;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Please enter positive number of coursecode");
                }
                else
                {
                    Coursecode = value;
                }
            }
        }

        public abstract void CourseDetail();
           
    }
}

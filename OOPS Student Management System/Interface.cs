using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Student_Management_System
{
    //Interface
    internal interface Interface
    {
        public string Name();
        public string Course();
        public int RollNo();
        public int Division();
    }

    //Abstract class with use of protected internal access modifire
    public abstract class CourseDetails 
    { 
        protected internal string? CourseName;
        protected internal int? CourseCode;
        protected internal int Coursecode
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

        protected internal abstract void Coursedetails();
           
    }
}

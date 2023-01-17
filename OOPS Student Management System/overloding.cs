using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Student_Management_System
{
    public class StudentTotalFees
    {
        public int Fees(int Course1 ,int Course2)
        { 
            return Course1 + Course2; 
        }
        public int Fees(int Course1,int Course2,int Course3)
        {
            return Course1 + Course2 + Course3;
        }

        public virtual int  CourseFees(int Course)
        {
            return Course;
        }
    }

    public class CourseFee : StudentTotalFees
    {
        public override int CourseFees(int Course)
        {
            return Course;
        }
    }
}

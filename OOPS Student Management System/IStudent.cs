using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Student_Management_System
{
    public interface IStudent
    {
         
         string GetStudentCourse(string course);
         int GetStudentRollNo(int no);
         int GetStudentDivision(int div);
    }
    
}

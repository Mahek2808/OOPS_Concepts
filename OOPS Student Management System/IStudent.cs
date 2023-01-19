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
         void Name(string name);
         void Course(string course);
         void RollNo(int no);
         void Division(int div);
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Student_Management_System
{
        public abstract class CourseDetails
        {
            public string? courseName;
            private int coursecode;
            public int courseCode
            {
                get
                {
                    return coursecode;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Please enter positive number of coursecode");
                    }
                    else
                    {
                          coursecode = value;
                    }
                }
            }

            public abstract void CourseDetail();

        }
    }


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
            private int _coursecode;
            public int courseCode
            {
                get
                {
                    return _coursecode;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Please enter positive number of coursecode");
                    }
                    else
                    {
                          _coursecode = value;
                    }
                }
            }

            public abstract void GetCourseDetail();

        }
    }


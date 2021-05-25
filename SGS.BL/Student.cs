using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.BL
{
    public class Student
    {
        private List<string> _studentName = new List<string>();
        private List<string> _studentCourseAndSection = new List<string>();

        public List<string> AddStudentName
        {
            get
            {
               return _studentName;
            }
            set
            {
                _studentName = AddStudentName;
            }
        }
        public List<string> AddStudentCourseAndSection
        {
            get
            {
                return _studentCourseAndSection;
            }
            set
            {
                _studentCourseAndSection = AddStudentCourseAndSection;
            }
        }
    }
}

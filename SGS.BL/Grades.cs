using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.BL
{
    public class Grades
    {
        private List<double> _averageGrades = new List<double>();

        public List<double> AverageGrades
        {
            get
            {
                return _averageGrades;
            }
            set
            {
                _averageGrades = AverageGrades;
            }
        }
    }

}

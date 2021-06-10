using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.BL
{

    //Dito po nakalagay yung mga Grades ng bawat Course. Nag-lagay na po ako ng laman para sa example maliban sa BSIT
    //dahil para pwedeng pong lagyan ito habang nirurun. Pero po pwede naman yung ibang course lagyan ng laman kapag nirun
    //pero papatong lang po ito.
    public class Grades
    {
        static private List<double> _bsitGrades = new List<double>();
        static private List<double> _bsaGrades = new List<double>(){89};
        static private List<double> _bscpeGrades = new List<double>(){91};
        static private List<double> _beedGrades = new List<double>(){87};
        static private List<double> _bsieGrades = new List<double>(){92};

        public List<double> BsitGrades
        {
            get
            {
                return _bsitGrades;
            }
            set
            {
                _bsitGrades = BsitGrades;
            }
        }
        public List<double> BsaGrades
        {
            get
            {
                return _bsaGrades;
            }
            set
            {
                _bsaGrades = BsaGrades;
            }
        }
        public List<double> BscpeGrades
        {
            get
            {
                return _bscpeGrades;
            }
            set
            {
                _bscpeGrades = BscpeGrades;
            }
        }
        public List<double> BeedGrades
        {
            get
            {
                return _beedGrades;
            }
            set
            {
                _beedGrades = BeedGrades;
            }
        }
        public List<double> BsieGrades
        {
            get
            {
                return _bsieGrades;
            }
            set
            {
                _bsieGrades = BsieGrades;
            }
        }
        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.BL
{
    //Same po sa Grade.cs ko po, dito naka-lagay yung mga Student Name ng Bawat Course. Naglagay na din po ako ng value sa loob po nila.
    public class StudentCourse
    {
        static private List<string> _bsit = new List<string>();
        static private List<string> _bsa = new List<string>(){"A"};
        static private List<string> _bscpe = new List<string>(){"B"};
        static private List<string> _beed = new List<string>(){"C"};
        static private List<string> _bsie = new List<string>() {"D"};

        public List<string> AddBSIT
        {
            get
            {
                return _bsit;
            }
            set
            {
                _bsit = AddBSIT;
            }
        }
        public List<string> AddBSA
        {
            get
            {
                return _bsa;
            }
            set
            {
                _bsa = AddBSA;
            }
        }
        public List<string> AddBSCPE
        {
            get
            {
                return _bscpe;
            }
            set
            {
                _bscpe = AddBSCPE;
            }
        }
        public List<string> AddBEED
        {
            get
            {
                return _beed;
            }
            set
            {
                _beed = AddBEED;
            }
        }
        public List<string> AddBSIE
        {
            get
            {
                return _bsie;
            }
            set
            {
                _bsie = AddBSIE;
            }
        }

    }
}

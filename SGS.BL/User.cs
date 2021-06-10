using System;

namespace SGS.BL
{
    //Dito naman po nakalagay ang mga Username at Password ng bawat course at ng Porfessor
    public class User
    {
        //PROFESSOR
        private string _professorUsername = "root";
        public string ProfessorUsername
        {
            get
            {
                return _professorUsername;
            }
        }
        private string _professorPassword = "PROF-0001";
        public string ProfessorPassword
        {
            get
            {
                return _professorPassword;
            }
        }

        //BSIT
        private string _bsitStudentUsername = "root";
        public string BsitStudentUsername
        {
            get
            {
                return _bsitStudentUsername;
            }
        }
        private string _bsitStudentPassword = "BSIT-0001";
        public string BsitStudentPassword
        {
            get
            {
                return _bsitStudentPassword;
            }
        }

        //BSA
        private string _bsaStudentUsername = "root";
        public string BsaStudentUsername
        {
            get
            {
                return _bsaStudentUsername;
            }
        }
        private string _bsaStudentPassword = "BSA-0001";
        public string BsaStudentPassword
        {
            get
            {
                return _bsaStudentPassword;
            }
        }

        //BSCPE
        private string _bscpeStudentUsername = "root";
        public string BscpeStudentUsername
        {
            get
            {
                return _bscpeStudentUsername;
            }
        }
        private string _bscpeStudentPassword = "BSCPE-0001";
        public string BscpeStudentPassword
        {
            get
            {
                return _bscpeStudentPassword;
            }
        }

        //BEED
        private string _beedStudentUsername = "root";
        public string BeedStudentUsername
        {
            get
            {
                return _beedStudentUsername;
            }
        }
        private string _beedStudentPassword = "BEED-0001";
        public string BeedStudentPassword
        {
            get
            {
                return _beedStudentPassword;
            }
        }

        //BSIE
        private string _studentUsername = "root";
        public string StudentUsername
        {
            get
            {
                return _studentUsername;
            }
        }
        private string _bsieStudentPassword = "BSIE-0001";
        public string BsieStudentPassword
        {
            get
            {
                return _bsieStudentPassword;
            }
        }
    }
}

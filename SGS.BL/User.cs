using System;

namespace SGS.BL
{
    public class User
    {
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

        private string _studentUsername = "root";
        public string StudentUsername
        {
            get
            {
                return _studentUsername;
            }
        }

        private string _studentPassword = "STUD-0001";
        public string StudentPassword
        {
            get
            {
                return _studentPassword;
            }
        }
    }
}

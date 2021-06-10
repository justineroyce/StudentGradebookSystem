using System;
using SGS.BL;
using SGS.UI;

namespace SGS.UI
{
    public class LogIn
    {
        public int attempt = 3;
        public string profUsername, profPassword;
        public string studUsername, studPassword;
        public char optionSelected;

        //ito po yung menu kung anong course sila or kung professor sila para maglog-in
        public void LoginSystem()
        {
            try
            {
                Console.WriteLine("----------Welcome to Student Gradebook System-----------");
                Console.WriteLine("Please input your destination: \n1 - BSIT\t2 - BSA\t3 - BSCPE");
                Console.WriteLine("4 - BEED\t 5 - BSIE\t6 - Professor");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case '1':
                        BsitSignIn();
                        break;
                    case '2':
                        BsaSignIn();
                        break;
                    case '3':
                        BscpeSignIn();
                        break;
                    case '4':
                        BeedSignIn();
                        break;
                    case '5':
                        BsaSignIn();
                        break;
                    case '6':
                        ProfSignIn();
                        break;
                    default:
                        LoginSystem();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid");
            }
        }
        //ito po sa Sign in para sa Proffesor
        public void ProfSignIn()
        {
            User profUser = new User();
            ProfMainMenu mainMenu = new ProfMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    profUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    profPassword = Console.ReadLine();

                    if (profUsername.Equals(profUser.ProfessorUsername) && profPassword.Equals(profUser.ProfessorPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        mainMenu.ProfessorMainMenu();

                    }
                    else if (profUsername.Equals("") || profPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!profUsername.Equals(profUser.ProfessorUsername) || (!profPassword.Equals(profUser.ProfessorPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Para sa BSIT Student
        public void BsitSignIn()
        {
            User bsitUser = new User();
            BsitStudentMainMenu bsitStud = new BsitStudentMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(bsitUser.BsitStudentUsername) && studPassword.Equals(bsitUser.BsitStudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        bsitStud.BsitMainMenu();

                    }
                    else if (studUsername.Equals("") || studPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!studUsername.Equals(bsitUser.BsitStudentUsername) || (!studPassword.Equals(bsitUser.BsitStudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Para sa BSA STUDENT
        public void BsaSignIn()
        {
            User studUser = new User();
            BsaStudentMainMenu bsaStud = new BsaStudentMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(studUser.BsaStudentUsername) && studPassword.Equals(studUser.BsaStudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        bsaStud.BsaMainMenu();

                    }
                    else if (studUsername.Equals("") || studPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!studUsername.Equals(studUser.BsaStudentUsername) || (!studPassword.Equals(studUser.BsaStudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Para sa BSCPE STUDENT
        public void BscpeSignIn()
        {
            User studUser = new User();
            BscpeStudentMainMenu bscpeStud = new BscpeStudentMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(studUser.BscpeStudentUsername) && studPassword.Equals(studUser.BscpeStudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        bscpeStud.BscpeMainMenu();

                    }
                    else if (studUsername.Equals("") || studPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!studUsername.Equals(studUser.BscpeStudentUsername) || (!studPassword.Equals(studUser.BscpeStudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Para sa BEED Student
        public void BeedSignIn()
        {
            User studUser = new User();
            BeedStudentMainMenu beedStud = new BeedStudentMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(studUser.BeedStudentUsername) && studPassword.Equals(studUser.BeedStudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        beedStud.BeedMainMenu();

                    }
                    else if (studUsername.Equals("") || studPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!studUsername.Equals(studUser.BeedStudentUsername) || (!studPassword.Equals(studUser.BeedStudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Para sa BSIE Student
        public void BsieSignIn()
        {
            User studUser = new User();
            BsieStudentMainMenu bsieStud = new BsieStudentMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(studUser.BsaStudentUsername) && studPassword.Equals(studUser.BsaStudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        bsieStud.BsieMainMenu();

                    }
                    else if (studUsername.Equals("") || studPassword.Equals(""))
                    {
                        Console.WriteLine("Please Input Your Username or Password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input ");
                        --attempt;
                        if (attempt == 0)
                        {
                            Console.WriteLine("\nTry Again\n");
                        }
                    }
                }
                while (!studUsername.Equals(studUser.BeedStudentUsername) || (!studPassword.Equals(studUser.BeedStudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //End Program Method
        public void EndTheProgram()
        {
            Console.WriteLine("----------End of the Program----------");
        }
        public static void Main(string[] args)
        {
            LogIn firstToRun = new LogIn();
            firstToRun.LoginSystem();
        }

    }
}


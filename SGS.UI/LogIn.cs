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
        public void LoginSystem()
        {
            try
            {
                Console.WriteLine("----------Welcome to Student Gradebook System-----------");
                Console.WriteLine("Please input your destination: \nS/s - Student\nP/p - Professor");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case 'p':
                    case 'P':
                        ProfSignIn();
                        break;
                    case 's':
                    case 'S':
                        StudSignIn();
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
        //Proffesor
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
        //Student
        public void StudSignIn()
        {
            User studUser = new User();
            StudMainMenu stud = new StudMainMenu();
            try
            {
                do
                {
                    Console.WriteLine("Please Input Your Username & Password.");
                    Console.Write("Username: ");
                    studUsername = Console.ReadLine();
                    Console.Write("Password: ");
                    studPassword = Console.ReadLine();

                    if (studUsername.Equals(studUser.StudentUsername) && studPassword.Equals(studUser.StudentPassword))
                    {
                        Console.WriteLine("Successfully Log In.\n");
                        stud.StudentMainMenu();

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
                while (!studUsername.Equals(studUser.StudentUsername) || (!studPassword.Equals(studUser.StudentPassword)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
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


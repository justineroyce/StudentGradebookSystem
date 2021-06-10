using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.BL;

namespace SGS.UI
{
    //Dito po makikita ng BSCPE student yung Grade ng Buong course nila same sa ibang Student Main Menu
    class BscpeStudentMainMenu
    {
        char optionSelected;
        int num, num2;


        LogIn login = new LogIn();
        StudentCourse student = new StudentCourse();
        Grades grade = new Grades();
        public void BscpeMainMenu()
        {
            Console.WriteLine("----------Welcome Student/s----------");
            Console.WriteLine("Press a Following Command you want: \nV/v: View your Grades\nL/l: Log-out");
            optionSelected = Console.ReadLine()[0];
            switch (optionSelected)
            {
                case 'V':
                case 'v':
                    DisplayBscpeStudentGrade();
                    break;
                case 'L':
                case 'l':
                    login.LoginSystem();
                    break;
                default:
                    break;
            }
        }

        //Dito po makikita ng student yung Grade para sa Buong course nila same sa ibang Student Main Menu
        public void DisplayBscpeStudentGrade()
        {
            num = 1;
            num2 = 1;
            if (student.AddBSCPE.Count < 0 || grade.BscpeGrades.Count < 0)
            {
                Console.WriteLine("No Information Yet");
                Console.WriteLine("Command: ");
                Console.WriteLine("1.Log-out\t2.End Porgram");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case '1':
                        login.LoginSystem();
                        break;
                    case '2':
                        login.EndTheProgram();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Same Numberical Order Represent their Grades");
                if (student.AddBSCPE.Count > 0 && grade.BscpeGrades.Count > 0)
                {
                    foreach (var studentBscpeNameItems in student.AddBSA)
                    {
                        Console.Write($" {num}. Student Name: {studentBscpeNameItems}\n");
                        num++;
                    }
                    Console.WriteLine(" ");
                    foreach (var gradeBscpeItem in grade.BsaGrades)
                    {
                        Console.Write($" {num2}  Average: {gradeBscpeItem}\n");
                        num2++;
                    }
                    Console.WriteLine("\nPress the Command: ");
                    Console.WriteLine("B/b = Back Main Menu\nL/l = Log-out");
                    Console.Write("Enter a Command: ");
                    optionSelected = Console.ReadLine()[0];
                    switch (optionSelected)
                    {
                        case 'L':
                        case 'l':
                            login.LoginSystem();
                            break;
                        case 'B':
                        case 'b':
                            BscpeMainMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }
            }
        }

    }
}

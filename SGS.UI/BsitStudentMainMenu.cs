using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.BL;

namespace SGS.UI
{
    //Ito po ay sa BSIT Stdent Main Menu. Dito po makikita ng BSIT student 
    //yung Grade ng Buong course nila same sa ibang Student Main Menu
    public class BsitStudentMainMenu
    {
        char optionSelected;
        int num, num2;

        LogIn login = new LogIn();
        StudentCourse student = new StudentCourse();
        Grades grade = new Grades();

        public void BsitMainMenu()
        {
            Console.WriteLine("----------Welcome Student/s----------");
            Console.WriteLine("Press a Followiing Command you want: \nV/v: View your Grades\nL/l: Log-out");
            optionSelected = Console.ReadLine()[0];
            switch (optionSelected)
            {
                case 'V':
                case 'v':
                    DisplayBsitStudentGrade();
                    break;
                case 'L':
                case 'l':
                    login.LoginSystem();
                    break;
                default:
                    break;
            }

        }

        public void DisplayBsitStudentGrade()
        {
                num = 1;
                num2 = 1;
                if (student.AddBSIT.Count < 0 || grade.BsitGrades.Count < 0)
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
                    if (student.AddBSIT.Count > 0 && grade.BsitGrades.Count > 0)
                    {
                        foreach (var studentBsitNameItems in student.AddBSIT)
                        {
                            Console.Write($" {num}. Student Name: {studentBsitNameItems}\n");
                            num++;
                        }
                        Console.WriteLine(" ");
                        foreach (var gradeBsitItem in grade.BsitGrades)
                        {
                            Console.Write($" {num2}  Average: {gradeBsitItem}\n");
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
                                BsitMainMenu();
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
    


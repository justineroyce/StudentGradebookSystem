using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.BL;
using SGS.UI;

namespace SGS.UI
{
    //Dito po ay sa Professor Main Menu, Dito po nagtutuos ng grade siya at saan na course ilalagay nila.
    //Sa view po dito, BSIT palang nalalagay ko po.
    public class ProfMainMenu
    {
        int num, num2;
        string studentName;
        char optionSelected;
        string additonalOptionSelected;

        double percentageBased, finalPercentage;
        double quiz1Score, project1Score, midtermExam;
        double prefinalsResult1, midtermResult1, addingMidAndFinal1, finalResult, finalPercentageAverage;

        LogIn log = new LogIn();
        Grades grade = new Grades();
        StudentCourse course = new StudentCourse();
        Professor prof = new Professor();

        public void ProfessorMainMenu()
        {
            Console.WriteLine("Welcome " +prof.ProfName);
            Console.WriteLine("Press a Following Command: \nS/s - Start to Encode Grades\nL/l - Log-out");
            optionSelected = Console.ReadLine()[0];

            switch (optionSelected)
            {
                case 'S':
                case 's':
                    StudentProfile();
                    break;

                case 'L':
                case 'l':
                    log.LoginSystem();
                    break;
                default:
                    Console.WriteLine("Invalid, Try Again\n");
                    ProfessorMainMenu();
                    break;
            }
        }
        
        public void StudentProfile()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------Student Profile-----------------------");
                Console.Write("Enter a Student Name: ");
                studentName = Console.ReadLine();
                Console.WriteLine("Course: ");
                Console.WriteLine("1. BSIT\n2. BSA\n3. BSCpE\n4. BEED\n5. BSIE");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case '1':
                        course.AddBSIT.Add(studentName);
                        MidtermAndPreFinalsComputing();
                        break;
                    case '2':
                        course.AddBSA.Add(studentName);
                        MidtermAndPreFinalsComputing();
                        break;
                    case '3':
                        course.AddBSCPE.Add(studentName);
                        MidtermAndPreFinalsComputing();
                        break;
                    case '4':
                        course.AddBEED.Add(studentName);
                        MidtermAndPreFinalsComputing();
                        break;
                    case '5':
                        course.AddBSIE.Add(studentName);
                        MidtermAndPreFinalsComputing();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void MidtermAndPreFinalsComputing()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("Would you like to add percentage? y/n: ");
                Console.Write("Press a Command: ");
                additonalOptionSelected = Console.ReadLine().ToLower();

                //With Percentage Based
                if (optionSelected.Equals("y"))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter a Percentage Based: ");
                    percentageBased = Convert.ToDouble(Console.ReadLine());
                    finalPercentage = percentageBased / 100;

                    //Midterm
                    Console.WriteLine(" ");
                    Console.WriteLine("-----Midterm-----");
                    Console.Write("Quiz 1 (Up to 10 choices)(10%): ");
                    quiz1Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("1st Project (Up to 100)(50%): ");
                    project1Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Midterm Exam (Up to 50 choices)(40%): ");
                    midtermExam = Convert.ToDouble(Console.ReadLine());

                    //Pre-Finals
                    Console.WriteLine(" ");
                    Console.WriteLine("-----Pre-Finals-----");
                    Console.Write("Quiz 2 (Up to 10)(10%): ");
                    double quiz2Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2nd Project (Up to 100)(50%): ");
                    double project2Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Final Eaxam (Up to 50 choices)(40%): ");
                    double finalExam = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Press Which Course You What Save The Grades.");
                    Console.WriteLine("1.BSIT\t 2.BSA\t3.BSCPE\t4.BEED\t5.BSIE");
                    optionSelected = Console.ReadLine()[0];

                    double q1Score = quiz1Score / 10 * 10;
                    double p1Score = project1Score / 100 * 50;
                    double meScore = midtermExam / 50 * 40;
                    midtermResult1 = q1Score + p1Score + meScore;

                    double q2Score = quiz2Score / 10 * 10;
                    double p2score = project2Score / 100 * 50;
                    double feScore = finalExam / 50 * 40;
                    prefinalsResult1 = q2Score + p2score + feScore;
                    addingMidAndFinal1 = midtermResult1 + prefinalsResult1;
                    finalResult = addingMidAndFinal1 / 2;
                    finalPercentageAverage = prefinalsResult1 + finalPercentage;

                    switch (optionSelected)
                    {
                        case '1':
                            grade.BsitGrades.Add(finalPercentageAverage);
                            OtherCommand();
                            break;
                        case '2':
                            grade.BsaGrades.Add(finalPercentageAverage);
                            OtherCommand();
                            break;
                        case '3':
                            grade.BscpeGrades.Add(finalPercentageAverage);
                            OtherCommand();
                            break;
                        case '4':
                            grade.BeedGrades.Add(finalPercentageAverage);
                            OtherCommand();
                            break;
                        case '5':
                            grade.BsieGrades.Add(finalPercentageAverage);
                            OtherCommand();
                            break;
                        default:
                            break;
                    }
                }

                //Without Percentage Based
                else if (additonalOptionSelected.Equals("n"))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");

                    //Midterm
                    Console.WriteLine("-----Midterm-----");
                    Console.Write("Quiz 1 (Up to 10 choices)(10%): ");
                    quiz1Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("1st Project (Up to 100)(50%): ");
                    project1Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Midterm Exam (Up to 50 choices)(40%): ");
                    midtermExam = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");

                    //Pre-Finals
                    Console.WriteLine("-----Pre-Finals-----");
                    Console.Write("Quiz 2 (Up to 10)(10%): ");
                    double quiz2Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2nd Project (Up to 100)(50%): ");
                    double project2Score = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Final Eaxam (Up to 50 choices)(40%): ");
                    double finalExam = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Press Enter to Finish.");

                    //Computing
                    double q1Score = quiz1Score / 10 * 10;
                    double p1Score = project1Score / 100 * 50;
                    double meScore = midtermExam / 50 * 40;
                    midtermResult1 = q1Score + p1Score + meScore;

                    double q2Score = quiz2Score / 10 * 10;
                    double p2score = project2Score / 100 * 50;
                    double feScore = finalExam / 50 * 40;
                    prefinalsResult1 = q2Score + p2score + feScore;
                    addingMidAndFinal1 = midtermResult1 + prefinalsResult1;
                    finalResult = addingMidAndFinal1 / 2;

                    Console.WriteLine("1.BSIT\t 2.BSA\t3.BSCPE\t4.BEED\t5.BSIE");
                    optionSelected = Console.ReadLine()[0];
                    switch (optionSelected)
                    {
                        case '1':
                            grade.BsitGrades.Add(finalResult);
                            OtherCommand();
                            break;
                        case '2':
                            grade.BsaGrades.Add(finalResult);
                            OtherCommand();
                            break;
                        case '3':
                            grade.BscpeGrades.Add(finalResult);
                            OtherCommand();
                            break;
                        case '4':
                            grade.BeedGrades.Add(finalResult);
                            OtherCommand();
                            break;
                        case '5':
                            grade.BsieGrades.Add(finalResult);
                            OtherCommand();
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void OtherCommand()
        {
            //Command to View, End the Program & Back to Main Menu
            Console.WriteLine("Done, Successfully Added");
            Console.WriteLine("Command: \nV/v to View the Result Grades");
            Console.WriteLine("L/l to Log-out");
            Console.WriteLine("E/e to End the Program");
            Console.WriteLine("B/b to Back to Professor Main Menu");
            optionSelected = Console.ReadLine()[0];

            switch (optionSelected)
            {
                case 'v':
                case 'V':
                    DisplayTheStudent();
                    break;
                case 'L':
                case 'l':
                    log.LoginSystem();
                    break;
                case 'e':
                case 'E':
                    log.EndTheProgram();
                    break;
                case 'b':
                case 'B':
                    ProfessorMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        public void DisplayTheStudent()
        {
            Console.WriteLine("Command: ");
            Console.WriteLine("1. BSIT \t2. BSA\t3.BSCPE\n4.BEED\t5.BSIE");
            Console.WriteLine("6.to End the Program \t7.Log-Out");
            Console.Write("Enter a Command: ");
            optionSelected = Console.ReadLine()[0];

            switch (optionSelected)
            {
                case '1':
                    DisplayAllBsitStudentAndGrades();
                    break;
                case '2':
                    log.LoginSystem();
                    break;
                case '3':
                    log.EndTheProgram();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            num = 1;
            num2 = 1;
        }
        public void DisplayAllBsitStudentAndGrades()
        {
            if (course.AddBSIT.Count < 0 && grade.BsitGrades.Count < 0)
            {
                Console.WriteLine("No Information Yet");
                Console.WriteLine("Press the Command: ");
                Console.WriteLine("B/b = Back Main Menu\nL/l = Log-out");
                Console.Write("Enter a Command: ");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case 'L':
                    case 'l':
                        log.LoginSystem();
                        break;
                    case 'B':
                    case 'b':
                        ProfessorMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Same Numberical Order Represent their Grades");
                if (course.AddBSIT.Count > 0 && grade.BsitGrades.Count > 0)
                {
                    foreach (var studentNameItems in course.AddBSIT)
                    {
                        Console.Write($" {num}. Student Name: {studentNameItems}\n");
                        num++;
                    }
                    Console.WriteLine(" ");
                    foreach (var gradeBsitItem in grade.BsitGrades)
                    {
                        Console.Write($" {num2}  Average: {gradeBsitItem}\n");
                        num2++;
                    }
                }
            }
            Console.WriteLine("\nB/b - Professor Main Menu\nL/l - Log-Out");
            optionSelected = Console.ReadLine()[0];
            switch (optionSelected)
            {
                case 'b':
                case 'B':
                    ProfessorMainMenu();
                    break;
                case 'L':
                case 'l':
                    log.LoginSystem();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

    }
}


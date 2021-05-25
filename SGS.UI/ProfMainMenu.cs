using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.BL;
using SGS.UI;

namespace SGS.UI
{
    public class ProfMainMenu
    {
        int num;
        string studentName;
        string studentCourse;
        char optionSelected;
        string additonalOptionSelected;

        double percentageBased, finalPercentage;
        double quiz1Score, project1Score, midtermExam;
        double prefinalsResult1, midtermResult1, addingMidAndFinal1, finalResult, finalPercentageAverage;

        LogIn log = new LogIn();
        Student student = new Student();
        Grades grade = new Grades();

        public void ProfessorMainMenu()
        {
            Console.WriteLine("----------Welcome----------");
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
                student.AddStudentName.Add(studentName);

                Console.Write("Course and Section: ");
                studentCourse = Console.ReadLine();
                student.AddStudentCourseAndSection.Add(studentCourse);
                Console.Write("Press n to Next & e to End the Program: ");
                optionSelected = Console.ReadLine()[0];
                switch (optionSelected)
                {
                    case 'n':
                    case 'N':
                        MidtermAndPreFinalsComputing();
                        break;
                    case 'e':
                    case 'E':
                        log.EndTheProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid Imput, Try Again\n");
                        StudentProfile();
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
                    Console.WriteLine("Press Enter to Finish.");

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
                    grade.AverageGrades.Add(finalPercentageAverage);
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
                    grade.AverageGrades.Add(finalResult);

                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");

                    //Command to View, End the Program & Back to Main Menu
                    Console.WriteLine("Done, Successfully Added");
                    Console.WriteLine("Command: \nV/v to View the Result Grades");
                    Console.WriteLine("L/l to Log-out");
                    Console.WriteLine("E/e to End the Program");
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
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
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
        public void DisplayTheStudent()
        {
            num = 1;
            if (student.AddStudentName.Count < 0 && student.AddStudentCourseAndSection.Count < 0)
            {
                Console.WriteLine("No Information Yet");
                Console.WriteLine("Press the Command: ");
                Console.WriteLine("B/b = Back Main Menu\nL/l = Log-out");
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
                if (student.AddStudentName.Count > 0 && student.AddStudentCourseAndSection.Count > 0) 
                {
                    foreach (var studentNameItems in student.AddStudentName)
                    {
                        Console.Write($"{num}. Student Name: {studentNameItems}");
                        num++;
                    }
                    foreach (var courseAndSection in student.AddStudentCourseAndSection)
                    {
                        Console.Write($"\n  Course & Section: {courseAndSection}");
                    }
                    foreach (var studentGrade in grade.AverageGrades)
                    {
                        Console.WriteLine($"\n  Average Grade: {studentGrade}");
                    }
                }
            }
        }
    }
}

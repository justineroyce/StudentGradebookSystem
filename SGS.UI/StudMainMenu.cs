using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.BL;

namespace SGS.UI
{
    public class StudMainMenu
    {
        char optionSelected;
        int num;

        LogIn login = new LogIn();
        Student student = new Student();
        Grades grade = new Grades();

        public void StudentMainMenu()
        {
            Console.WriteLine("----------Welcome Student/s----------");
            Console.WriteLine("Press a Followiing Command you want: \nV/v: View your Grades\nL/l: Log-out");
            optionSelected = Console.ReadLine()[0];
            switch (optionSelected)
            {
                case 'V':
                case 'v':
                    DisplayStudentGrade();
                    break;
                case 'L':
                case 'l':
                    login.LoginSystem();
                    break;
                default:
                    break;
            }

        }
        public void DisplayStudentGrade()
        {
            num = 1;
            if (student.AddStudentName.Count < 0 && student.AddStudentCourseAndSection.Count < 0)
            {
                Console.WriteLine("No Information Yet");
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
                    foreach (var studentCAndSItems in student.AddStudentCourseAndSection)
                    {
                        Console.Write($"\n  Course & Section: {studentCAndSItems}");
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

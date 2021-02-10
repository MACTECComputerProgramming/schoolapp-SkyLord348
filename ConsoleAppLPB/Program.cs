using System;

namespace ConsoleAppLPB
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create First Student

            Student firstStudent = new Student();

            // Get Student Info

            firstStudent.StudentNum = AskForStudentNumber();
            firstStudent.StudentFirstName = AskForStudentName("First");
            firstStudent.StudentLastName = AskForStudentName("Last");
            firstStudent.Major = AskForMajor(firstStudent.StudentFirstName);
            firstStudent.Score1 = AskForScore(1);
            firstStudent.Score2 = AskForScore(2);
            firstStudent.Score3 = AskForScore(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(firstStudent.ToString());

            Console.WriteLine("Press any to end");
            Console.ReadKey();


        }

        private static int AskForScore(int v)
        {
            throw new NotImplementedException();
        }

        private static string AskForMajor(string studentFirstName)
        {
            string inValue;
            Console.WriteLine("Enter Student Major: ");
            inValue = Console.ReadLine();
            return inValue;
        }

        private static string AskForStudentName(string whichOne)
        {
            string inValue;
            Console.WriteLine("Enter Students {0} Name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;
        }

        private static string AskForStudentNumber()
        {
            string inValue;
            Console.WriteLine("Enter Student ID Number: ");
            inValue = Console.ReadLine();
            return inValue;
        }
    }
}

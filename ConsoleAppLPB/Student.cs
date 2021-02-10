﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLPB
{
    class Student
    {
        // Fields/Variables

        private string studentNum, studentLastName, studentFirstName, major;
        private int score1, score2, score3;



        // Constructer

        // Default

        public Student()
        {

        }

        // Constructor - One Arg
        public Student(string sID)
        {
            studentNum = sID;
        }

        //Constructor - Three Args
        public Student(string sID, string lastName, string firstName)
        {
            studentNum = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
        }

        //Constructor - All Args
        public Student(string sID, string lastName, string firstName, string Major, int Score1, int Score2, int Score3)
        {
            studentNum = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
            major = Major;
            score1 = Score1;
            score2 = Score2;
            score3 = Score3;
        }



        // Properties

        public string StudentNum { get => studentNum; set => studentNum = value; }

        public string StudentLastName { get => studentLastName; set => studentLastName = value; }

        public string StudentFirstName { get => studentFirstName; set => studentFirstName = value; }

        public string Major { get => major; set => major = value; }

        public int Score1 { get => score1; set => score1 = value; }

        public int Score2 { get => score2; set => score2 = value; }

        public int Score3 { get => score3; set => score3 = value; }




        // Methods

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " + studentFirstName + " " + studentLastName +
                "\nMajor: " + major + "\nScore Average: " + CalculateAverage().ToString();
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class User
    {
        //------data fields------
        protected string name;
        protected int correctAnswers;
        protected int incorrectAnswer;
        protected int grade;
        protected string timeExam;

        //------properties-----
        public string Name { get => name; set => name = value; }
        public int CorrectAnswers { get => correctAnswers; set => correctAnswers = value; }
        public int IncorrectAnswer { get => incorrectAnswer; set => incorrectAnswer = value; }
        public int Grade { get => grade; set => grade = value; }
        public string TimeExam { get => timeExam; set => timeExam = value; }

        //------methods------
        //constructor:
        public User()
        {
            //default value
            Name = "Not named yet";
            CorrectAnswers = 0;
            IncorrectAnswer = 0;
            Grade = 0;
            TimeExam = DateTime.Now.ToString();
        }
        public User(string name, int correctAnswers, int incorrectAnswers)
        {
            Name = name;
            CorrectAnswers = correctAnswers;
            IncorrectAnswer = incorrectAnswers;
            Grade = (correctAnswers * 10);
            TimeExam = DateTime.Now.ToString();
        }
            //
        public override string ToString()
        {
            return name + " Correct answers: " + correctAnswers + " Incorrect answers " + incorrectAnswer + " Grade :" + grade + " Date: " + timeExam;
        }
    }
}

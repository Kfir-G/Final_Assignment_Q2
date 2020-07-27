using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class Question
    {
        //-----data fields-----
        protected int qNumber;
        protected int typeQ;
        protected string questionQ;
        protected string correctAnswer;

        //-----properties----
        public int QNumber { get => qNumber; set => qNumber = value; }
        public string QuestionQ { get => questionQ; set => questionQ = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public int TypeQ { get => typeQ; set => typeQ = value; }

        //-----methods-----
        //constructor:
        public Question()
        {
            //default values
            QNumber = -1;
            TypeQ = -1;
            QuestionQ = "Not named yet";
            CorrectAnswer = "Not named yet";
        }
        public Question (int qNumber, int qType, string questionQ,string correctAnswer)
        {
            QNumber = qNumber;
            typeQ = qType;
            QuestionQ = questionQ;
            CorrectAnswer = correctAnswer;
        }
            //
        public override string ToString()
        {
            return "The number of the question" + qNumber + "\n" + "The type is: " + typeQ + "\n" +
                "The question is: " + questionQ + "\n" + "The correct answer is: " + correctAnswer;
        }
    }
}

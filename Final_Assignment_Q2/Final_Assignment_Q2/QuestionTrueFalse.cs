using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class QuestionTrueFalse: Question
    {
        //-------data fields------
        protected string incorrecrAnswer;

        //-------properties------
        public string IncorrecrAnswer { get => incorrecrAnswer; set => incorrecrAnswer = value; }

        //-------methods------
        //constructor:
        public QuestionTrueFalse() :base()
        {
            IncorrecrAnswer = "Not named yet"; //default value
        }
        public QuestionTrueFalse(int qNumber, int typeQ, string questionQ, string correcrAnswer, string incorrectAnswer)
            :base (qNumber, typeQ, questionQ,correcrAnswer)
        {
            IncorrecrAnswer = incorrectAnswer;
        }
            //
        public override string ToString()
        {
            return base.ToString() + " Incorrect answer: " + incorrecrAnswer;
        }
    }
}

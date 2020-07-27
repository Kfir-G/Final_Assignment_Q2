using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class QuestionMulti: Question
    {
        //-------data fields-----
        protected string incorrectAnswer2;
        protected string incorrectAnswer3;
        protected string incorrectAnswer4;

        //------properties------
        public string IncorrectAnswer2 { get => incorrectAnswer2; set => incorrectAnswer2 = value; }
        public string IncorrectAnswer3 { get => incorrectAnswer3; set => incorrectAnswer3 = value; }
        public string IncorrectAnswer4 { get => incorrectAnswer4; set => incorrectAnswer4 = value; }

        //-------methods------
        //constructor:
        public QuestionMulti() : base()
        {
            incorrectAnswer2 = null;
            incorrectAnswer3 = null;
            incorrectAnswer4 = null;
        }
        public QuestionMulti(int qNumber, int typeQ, string questionQ, string correcrAnswer, string incorrectAnswer2, string incorrectAnswer3, string incorrectAnswer4)
            :base (qNumber, typeQ, questionQ, correcrAnswer)
        {
            IncorrectAnswer2 = incorrectAnswer2;
            IncorrectAnswer3 = incorrectAnswer3;
            IncorrectAnswer4 = incorrectAnswer4;
        }


        //
        public override string ToString()
        {

            return base.ToString() + incorrectAnswer2 + incorrectAnswer3 + incorrectAnswer4;
        }
    }
}

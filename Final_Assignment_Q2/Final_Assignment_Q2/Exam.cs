using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment_Q2
{
    public partial class Exam : Form
    {
        
        Service service = new Service();
        public ArrayList chosenQuestions = new ArrayList();
        int idx = 0, correctAnswers= 0, incorrectAnswers = 0;
        Main mainForm1 = new Main();

        public Exam()
        {
            InitializeComponent();

            service.ReadQuestionsFromTxt();

            Random rnd = new Random();
            int rndm= rnd.Next(0, 10) ;
            int i = rndm;
            rndm += 10;
            for ( int j=0  ; j < 10; j++) 
            {
                chosenQuestions.Add(service.questions[j]);
            }
        }

        private void btnGiveQ_Click(object sender, EventArgs e)
        {
            RandomQuestion(idx);
        }
        public void RandomQuestion(int idx)
        {
            lblQuestion.Text = ((Question)chosenQuestions[idx]).QuestionQ;
            rdbtnAnswer3.Visible = true;
            rdbtnAnswer4.Visible = true;
            if (chosenQuestions[idx] is QuestionTrueFalse)
            {
                rdbtnAnswer1.Text = ((QuestionTrueFalse)chosenQuestions[idx]).CorrectAnswer;
                rdbtnAnswer2.Text = ((QuestionTrueFalse)chosenQuestions[idx]).IncorrecrAnswer;
                rdbtnAnswer3.Visible = false;
                rdbtnAnswer4.Visible = false;
            }
            else
            {
                rdbtnAnswer1.Text = ((QuestionMulti)chosenQuestions[idx]).CorrectAnswer;
                rdbtnAnswer2.Text = ((QuestionMulti)chosenQuestions[idx]).IncorrectAnswer2;
                rdbtnAnswer3.Text = ((QuestionMulti)chosenQuestions[idx]).IncorrectAnswer3;
                rdbtnAnswer4.Text = ((QuestionMulti)chosenQuestions[idx]).IncorrectAnswer4;
            }
            
        }
        public void checkFinish()
        {
            if (idx == 9)
            {
                string message = "You answer right: " + correctAnswers + " questions and wrong in " + incorrectAnswers+ " questions ";
                string title = "You Finished (:";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    var dateTime = DateTime.Now.ToString("yyyy-M-ddThh_mm_ss");
                    string name = service.User.Name;
                    using (StreamWriter writer = new StreamWriter(name + "'s statistics - outdata_" + dateTime + ".txt", true))
                    {
                        writer.WriteLine("Player Name: " + name + " Correct Answers: " + correctAnswers.ToString() + " Worng Answers: " + incorrectAnswers.ToString());
                    }
                    this.Close();
                }
                this.Close(); //hide?
                idx = 0;
                mainForm1.ShowDialog();
                
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
                //
        }

        private void rdbtnAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuestion(idx);
            correctAnswers++;
            checkFinish();
            RandomQuestion(idx);
            correctAnswers++;
            idx++;
        }

        private void rdbtnAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuestion(idx);
            correctAnswers++;
            checkFinish();
            RandomQuestion(idx);
            correctAnswers++;
            idx++;
        }

        private void rdbtnAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuestion(idx);
            correctAnswers++;
            checkFinish();
            RandomQuestion(idx);
            correctAnswers++;
            idx++;
        }

        private void rdbtnAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            RandomQuestion(idx);
            correctAnswers++;
            checkFinish();
            RandomQuestion(idx);
            correctAnswers++;
            idx++;
        }

        private void Exam_Load(object sender, EventArgs e)
        {

        }
    }
}

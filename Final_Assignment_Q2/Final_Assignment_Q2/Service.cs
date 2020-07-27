using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class Service
    {
        //-------data fields------
        public List <InfoData> infoDatas = new List<InfoData>();
        public ArrayList questions = new ArrayList();

        public User User = new User();

        //------properties-------
        public ArrayList Questions { get => questions; set => questions = value; }
        public List<InfoData> InfoDatas { get => infoDatas; set => infoDatas = value; }

        //-------methods-------
        //constructor:
        public Service()
        {
                 
        }
        public void ReadQuestionsFromTxt()

        {
            string[] str = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\QUESTIONS\gameData.txt");
            for (int i = 0; i < str.Length; i++)
            {
                QuestionMulti question2 = new QuestionMulti();
                QuestionTrueFalse question1 = new QuestionTrueFalse();
                if (int.Parse(str[i].Split(';')[1]) == 0)
                {
                    question1.TypeQ = 0;
                    question1.QNumber= int.Parse(str[i].Split(';')[0]);
                    question1.QuestionQ = str[i].Split(';')[2];
                    question1.CorrectAnswer = str[i].Split(';')[3];
                    question1.IncorrecrAnswer = str[i].Split(';')[4];
                    questions.Add(question1);
                }
                
                if (int.Parse(str[i].Split(';')[1]) == 1)
                {
                    question2.TypeQ = 1;
                    question2.QNumber = int.Parse(str[i].Split(';')[0]);
                    question2.QuestionQ = str[i].Split(';')[2];
                    question2.CorrectAnswer = str[i].Split(';')[3];
                    question2.IncorrectAnswer2 = str[i].Split(';')[4];
                    question2.IncorrectAnswer3= str[i].Split(';')[5];
                    question2.IncorrectAnswer4 = str[i].Split(';')[6];
                    questions.Add(question2);
                    
                }
                
            }
        }
        public void AddInfoDataNOImage()
        {
            int numberOfInfo, idx1, idx2;
            string str, topicInfo, content;
            try
            {
                using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\DATA\infoData.txt"))
                {
                    while ((str = sr.ReadLine()) != null)
                    {
                        idx1 = str.IndexOf(';');
                        numberOfInfo = int.Parse(str.Substring(0, idx1));
                        idx2 = str.IndexOf(';', idx1 + 1);
                        topicInfo = str.Substring(idx1 + 1, idx2 - idx1 - 1);
                        content = str.Substring(idx2 + 1, str.Length - idx2 -2);

                        InfoData infoData = new InfoData(numberOfInfo, topicInfo, content);
                        infoDatas.Add(infoData);
                    }
                }
            }
            catch(Exception e3)
            {
                Console.WriteLine(e3.Message);
            }
        }
        public void AddInfoDataWithWithImage()
        {
            int numberOfInfo, idx1, idx2, idx3;
            string str, topicInfo, content, addressImage;
            try
            {
                using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\DATA\infoData.txt")) 
                {
                    while ( (str = sr.ReadLine()) != null )
                    {
                        idx1 = str.IndexOf(';');
                        numberOfInfo = int.Parse(str.Substring(0, idx1));
                        idx2 = str.IndexOf(';', idx1 + 1);
                        topicInfo = str.Substring(idx1 + 1, idx2 - idx1 - 1);
                        idx3 = str.IndexOf(';', idx2 + 1);
                        content = str.Substring(idx2 + 1, idx3 - idx2 - 1);
                        addressImage = str.Substring(idx3 + 1, str.Length - 1);

                        InfoData infoData = new InfoData(numberOfInfo, topicInfo, content, addressImage);
                        infoDatas.Add(infoData);
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
            //
        public bool HasImage(string str) //for infoData
        {
            int count = 0;
            foreach(char c in str)
            {
                if (c == ';')
                    count++;
            }

            if (count == 3)
                return false;
            else
                return true;
        }
    }
}

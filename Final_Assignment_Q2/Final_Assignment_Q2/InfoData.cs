using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_Q2
{
    class InfoData
    {
        //------data fields-------
        protected int numberOfInfo;
        protected string topicInfo;
        protected string content;
        protected string addressImage;

        //------properties-----
        public int NumberOfInfo { get => numberOfInfo; set => numberOfInfo = value; }
        public string TopicInfo { get => topicInfo; set => topicInfo = value; }
        public string Content { get => content; set => content = value; }
        public string AddressImage { get => addressImage; set => addressImage = value; }

        //------methods------
        //constructor:
        public InfoData()
        {
            //default values
            NumberOfInfo = -1;
            TopicInfo = "Not named yet";
            Content = "Not named yet";
            AddressImage = "Not named yet";
        } 
        public InfoData(int numberOfInfo, string topicInfo, string content, string addressImage)
        {
            NumberOfInfo = numberOfInfo;
            TopicInfo = topicInfo;
            Content = content;
            AddressImage = addressImage; // if there's no photo it will be writen- Empty
        }
        public InfoData(int numberOfInfo, string topicInfo, string content)
        {
            NumberOfInfo = numberOfInfo;
            TopicInfo = topicInfo;
            Content = content;
            AddressImage = "Empty"; // if there's no photo it will be writen- Empty
        }
            //
        public override string ToString()
        {
            return "Index:" + numberOfInfo + "\n" + " The topic:" + topicInfo + "\n" + "The content: " + content + "\n" + "Where the image is stored:" + addressImage;
        }
        public string GetIdxData()
        {
            return numberOfInfo.ToString();
        }
    }
}

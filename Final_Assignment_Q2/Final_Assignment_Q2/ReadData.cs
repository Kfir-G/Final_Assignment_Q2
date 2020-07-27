using System;
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
    public partial class ReadData : Form
    {
        Main mainForm1 = new Main();
        Service service = new Service();
        int idx = 0;
        public ReadData()
        {
            InitializeComponent();
            service.AddInfoDataNOImage();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNextInfo_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (InfoData infoData in service.infoDatas)
            {
                if (idx == i)
                {
                    lblIdxReadMain.Text = infoData.GetIdxData();
                    lblTopicReadData.Text = infoData.TopicInfo;
                    lblContentReadInfo.Text = infoData.Content;
                }
                i++;
            }
            AddPlusIdx();
        }
        public void AddPlusIdx()
        {
            idx++;
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close(); //hide?
            mainForm1.ShowDialog();
        }
    }
}

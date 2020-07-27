using System;
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
    public partial class UpdateQuestion : Form
    {
        int idx = 20;
        Main mainForm1 = new Main();
        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();
            str = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\QUESTIONS\gameData.txt").ToList();
            str.Add(String.Format(idx.ToString() + " ;" +"0;"+ txtbxQuestion.Text + " ;" + txtbxCorrecrAnswer.Text+";"+txtbxIncorrectAnswer.Text+";"));
            using (StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + @"\QUESTIONS\gameData.txt")) //if there's a problem turn off your antivirus
            {
                foreach (string var in str)
                    sr.WriteLine(var);
            }
            idx++;
            this.Close(); //hide?
            mainForm1.ShowDialog();
        }
    }
}

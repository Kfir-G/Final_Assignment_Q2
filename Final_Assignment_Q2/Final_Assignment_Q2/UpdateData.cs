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
    public partial class UpdateData : Form
    {
        int idx = 15;
        Main mainForm1 = new Main();
        public UpdateData()
        {
            InitializeComponent();
        }

        private void UpdateData_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();
            str = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\DATA\infoData.txt").ToList();
            str.Add( String.Format(idx.ToString()+" ;"+txtbxTopic.Text+" ;"+ txtbxContent.Text+";") );
            using (StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + @"\DATA\infoData.txt")) //if there's a problem turn off your antivirus
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

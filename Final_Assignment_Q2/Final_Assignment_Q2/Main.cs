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
    public partial class Main : Form
    {
        Service service = new Service();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam pract4 = new Exam();
            pract4.ShowDialog();
        }

        private void btnMainPushData_Click(object sender, EventArgs e)
        {
            ReadData pract3 = new ReadData();
            pract3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            UpdateData pract4 = new UpdateData();
            pract4.ShowDialog();
        }

        private void picbxMain_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            UpdateQuestion pract5 = new UpdateQuestion();
            pract5.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

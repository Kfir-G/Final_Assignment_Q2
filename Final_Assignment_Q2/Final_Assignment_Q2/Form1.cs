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
    public partial class Form1 : Form
    {
        Service service = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterSend_Click(object sender, EventArgs e)
        {          
            Main pract2 = new Main();
            pract2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

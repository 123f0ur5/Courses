using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bacon_Click(object sender, EventArgs e)
        {
            label3.Text = "Não consegue né, Moises.";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();

            sendButton.Location = new System.Drawing.Point(randNum.Next(400), randNum.Next(400));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

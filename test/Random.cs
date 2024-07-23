using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace test
{
    public partial class Random : Form
    {
        string filePath = "Properties\rf.txt";
        public Random()
        {
            InitializeComponent();
        }

        private void Random_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            string filePath = "rf.txt";
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            System.Random random = new System.Random();
            int randomNumber = random.Next(0, lines.Length);
            string randomArticle = lines[randomNumber];

            label1.Text = "За что тебя посадят сегодня:";
            label2.Text = randomArticle;
        }
    }
}

//87, 93, 72, 98, 65, 70, 89, 78, 77, 66, 92, 72
//71, 98, 93, 79, 84, 90, 88, 91
//88, 81, 56, 72, 69, 74, 80, 66, 71, 73




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace examScoresJaggedArray
{
    public partial class Form1 : Form
    {
        int[][] scores = new int[3][];

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inFile;

            inFile = File.OpenText("Section1.txt");
            section1ListBox.Items.Add("Section 1");
            section2ListBox.Items.Add("Section 2");
            section3ListBox.Items.Add("Section 3");

            int num = 0;
            int index = 0;
            while (!inFile.EndOfStream)
            {
                int.TryParse(inFile.ReadLine(), out num);
                scores[0][index] = num;
                section1ListBox.Items.Add(scores[0][index]);
                index++;
            }

            inFile = File.OpenText("Section2.txt");
            index = 0;
            while (!inFile.EndOfStream)
            {
                int.TryParse(inFile.ReadLine(), out num);
                scores[1][index] = num;
                section1ListBox.Items.Add(scores[1][index]);
                index++;
            }

            inFile = File.OpenText("Section3.txt");
            index = 0;
            while (!inFile.EndOfStream)
            {
                int.TryParse(inFile.ReadLine(), out num);
                scores[2][index] = num;
                section1ListBox.Items.Add(scores[2][index]);
                index++;
            }

            inFile.Close();
        }
    }
}

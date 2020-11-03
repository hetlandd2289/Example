/*Drake Hetland
 * 9/15/20
 * Exam 1 Practical
 * Creating a GUI that displays the name of the card clicked on in a text box*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_DrakeHetland
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aceOfSpades_Click(object sender, EventArgs e)
        {
            cardDisplay.Text = ("Ace of Spades");
        }

        private void cardDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void jackOfClubs_Click(object sender, EventArgs e)
        {
            cardDisplay.Text = ("Jack of Clubs");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardDisplay.Text = ("Ten of Diamonds");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardDisplay.Text = ("Nine of Clubs");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardDisplay.Text = ("Seven of Hearts");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

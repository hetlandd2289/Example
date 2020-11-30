/* Author: Drake Hetland
 * Date: 11-17-2020
 * Description: Exam covering concepts learned in chapter 5 */


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

namespace exam3Practical
{
    public partial class exam3Practical : Form
    {
        public exam3Practical()
        {
            InitializeComponent();
        }

        private void exam3Practical_Load(object sender, EventArgs e)
        {
            //Sets up the class and integers variables that the randoms are going to occupy.
            Random rand = new Random();
            int number1, number2;

            //Sets the range of the randoms.
            number1 = rand.Next(1, 1000);
            number2 = rand.Next(1, 1000);

            //Puts the results into a readable/solvable format.
            problemLabel1.Text = number1.ToString();
            problemLabel2.Text = "+";
            problemLabel3.Text = number2.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit button (duh lol).
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Set some more variables so the program has a place to put the parsed numbers
            int number1 = 0;
            int number2 = 0;
            int userInput = 0;

            //Parse the text so the program can do the math to see if the user is correct
            int.TryParse(problemLabel1.Text, out number1);
            int.TryParse(problemLabel3.Text, out number2);
            int.TryParse(answerTextBox.Text, out userInput);

            //If statement so we can take different routs depending on if the user is correct or not
            if (userInput == number1 + number2)
            {
                MessageBox.Show("You got the correct answer! \nCongratulations!");
            }
            else
            {
                //Writes to a review.txt file so we can save the questions the user got wrong
                StreamWriter outFile;
                outFile = File.AppendText("review.txt.txt"); //Open

                outFile.WriteLine(problemLabel1.Text + problemLabel2.Text + problemLabel3.Text); //Process

                outFile.Close(); //Close
                
                
            }
            //All the same steps as when we did it for the load event, just makes a new question when submit is clicked
            Random rand = new Random();
            

            number1 = rand.Next(1, 1000);
            number2 = rand.Next(1, 1000);

            problemLabel1.Text = number1.ToString();
            problemLabel2.Text = "+";
            problemLabel3.Text = number2.ToString();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //Clear the list box so submissions don't pile up and take unnecessary space
            missedProblemsListBox.Items.Clear();

            //Opens the specific file we are looking for
            StreamReader inFile;
            inFile = File.OpenText("review.txt.txt");

            //Reads the lines in the review.txt file and adds them as items in the list box
            while (!inFile.EndOfStream)
            {
                missedProblemsListBox.Items.Add(inFile.ReadLine());
            }
            inFile.Close(); //Closes the file

            //Makes a bunch of stuff that didn't need to be visible at the start visible
            missedProblemsListBox.Visible = true;
            missedProblemsLabel.Visible = true;
            kilroyPictureBox.Visible = true;
        }
    }
}

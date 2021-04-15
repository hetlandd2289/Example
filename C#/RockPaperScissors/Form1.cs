using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {

        int aiChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            winsTextBox.Text = "0";
            lossesTextBox.Text = "0";
            drawsTextBox.Text = "0";
            resetImages();
            aiHand();
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            resetImages();
            aiHand();
        }

        private void incrementDraws()
        {
            int draw = 0;
            int.TryParse(drawsTextBox.Text, out draw);
            drawsTextBox.Text = (draw + 1).ToString();
        }

        private void incrementWins()
        {
            int win = 0;
            int.TryParse(winsTextBox.Text, out win);
            drawsTextBox.Text = (win + 1).ToString();
        }

        private void incrementLosses()
        {
            int loss = 0;
            int.TryParse(lossesTextBox.Text, out loss);
            drawsTextBox.Text = (loss + 1).ToString();
        }


        private void resetImages()
        {
            if (oppPaperPictureBox.Visible == false)
                oppPaperPictureBox.Visible = true;
            if (oppRockPictureBox.Visible == false)
                oppRockPictureBox.Visible = true;
            if (oppScissorsPictureBox.Visible == false)
                oppScissorsPictureBox.Visible = true;

            if (paperPictureBox.Visible == false)
                paperPictureBox.Visible = true;
            paperPictureBox.Enabled = true;
            if (rockPictureBox.Visible == false)
                rockPictureBox.Visible = true;
            rockPictureBox.Enabled = true;
            if (scissorsPictureBox.Visible == false)
                scissorsPictureBox.Visible = true;
            scissorsPictureBox.Enabled = true;
        }

        private void aiHand()
        {
            Random rand = new Random(System.DateTime.Now.Millisecond);
            aiChoice = rand.Next(1, 4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aiHand();
            resetImages();
        }
        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            rockPictureBox.Enabled = false;
            paperPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            /*if (aiChoice == 1)
            {
                oppPaperPictureBox.Visible = false;
                oppScissorsPictureBox.Visible = false;
            }
            else if (aiChoice == 2)
            {
                oppRockPictureBox.Visible = false;
                oppScissorsPictureBox.Visible = false;
            }
            else
            {
                oppRockPictureBox.Visible = false;
                oppPaperPictureBox.Visible = false;
            }*/

            switch (aiChoice)
            {
                case 1:
                    oppPaperPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 2:
                    oppRockPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 3:
                    oppRockPictureBox.Visible = false;
                    oppPaperPictureBox.Visible = false;
                    break;
                default:
                    MessageBox.Show("Something weird happened");
                    break;


            }
            switch (aiChoice)
            {
                case 1:
                    incrementDraws();
                    break;
                case 2:
                    incrementLosses();
                    break;
                case 3:
                    incrementWins();
                    break;
            }



        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            paperPictureBox.Enabled = false;
            paperPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            switch (aiChoice)
            {
                case 1:
                    oppPaperPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 2:
                    oppRockPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 3:
                    oppRockPictureBox.Visible = false;
                    oppPaperPictureBox.Visible = false;
                    break;
                default:
                    MessageBox.Show("Something weird happened");
                    break;


            }
            switch (aiChoice)
            {
                case 1:
                    incrementWins();
                    break;
                case 2:
                    incrementDraws();
                    break;
                case 3:
                    incrementLosses();
                    break;
            }

        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            paperPictureBox.Enabled = false;
            paperPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            switch (aiChoice)
            {
                case 1:
                    oppPaperPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 2:
                    oppRockPictureBox.Visible = false;
                    oppScissorsPictureBox.Visible = false;
                    break;
                case 3:
                    oppRockPictureBox.Visible = false;
                    oppPaperPictureBox.Visible = false;
                    break;
                default:
                    MessageBox.Show("Something weird happened");
                    break;


            }
            switch (aiChoice)
            {
                case 1:
                    incrementLosses();
                    break;
                case 2:
                    incrementWins();
                    break;
                case 3:
                    incrementDraws();
                    break;
            }
        }
    }
}

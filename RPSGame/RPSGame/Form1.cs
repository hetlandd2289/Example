using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSGame
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
            aiNewHand();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            resetImages();
            aiNewHand();
        }

        private void resetImages()
        {
            if (aiRockPictureBox.Visible == false)
                aiRockPictureBox.Visible = true;
            if (aiPaperPictureBox.Visible == false)
                aiPaperPictureBox.Visible = true;
            if (aiScissorsPictureBox.Visible == false)
                aiScissorsPictureBox.Visible = true;

            if (rockPictureBox.Visible == false)
                rockPictureBox.Enabled = true;
                rockPictureBox.Visible = true;
            if (paperPictureBox.Visible == false)
                paperPictureBox.Enabled = true;
                paperPictureBox.Visible = true;
            if (scissorsPictureBox.Visible == false)
                scissorsPictureBox.Enabled = true;
                scissorsPictureBox.Visible = true;
        }

        private void aiNewHand()
        {
            Random rand = new Random(System.DateTime.Now.Millisecond);
            aiChoice = rand.Next(1,4);
        }

        private void showAIHand()
        {
            switch (aiChoice)
            {
                case 1:
                    aiPaperPictureBox.Visible = false;
                    aiScissorsPictureBox.Visible = false;
                    break;
                case 2:
                    aiRockPictureBox.Visible = false;
                    aiScissorsPictureBox.Visible = false;
                    break;
                case 3:
                    aiPaperPictureBox.Visible = false;
                    aiRockPictureBox.Visible = false;
                    break;
                default:
                    MessageBox.Show("Some crazy crap happened.\n You wouldn't believe me if I told you...");
                    break;
            }
        }

        private void incrementDraws()
        {
            int draw = 0;
            int.TryParse(drawsTextBox.Text, out draw);
            drawsTextBox.Text = (draw+1).ToString();
        }

        private void incrementWins()
        {
            int win = 0;
            int.TryParse(winsTextBox.Text, out win);
            winsTextBox.Text = (win+1).ToString();
        }

        private void incrementLosses()
        {
            int loss = 0;
            int.TryParse(lossesTextBox.Text, out loss);
            lossesTextBox.Text = (loss+1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aiNewHand();
            resetImages();
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            rockPictureBox.Enabled = false;
            paperPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            showAIHand();

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
                default:
                    MessageBox.Show("Look, we didn't offer Lizard nor Spock here.\n Choose a legitimate option, please.");
                    break;
            }
        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            paperPictureBox.Enabled = false;
            rockPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            showAIHand();

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
                default:
                    MessageBox.Show("Look, we didn't offer Lizard nor Spock here.\n Choose a legitimate option, please.");
                    break;
            }
        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            scissorsPictureBox.Enabled = false;
            paperPictureBox.Visible = false;
            rockPictureBox.Visible = false;

            showAIHand();

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
                default:
                    MessageBox.Show("Look, we didn't offer Lizard nor Spock here.\n Choose a legitimate option, please.");
                    break;
            }
        }
    }
}

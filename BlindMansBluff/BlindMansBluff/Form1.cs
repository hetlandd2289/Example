using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GuessingGame
{
    public partial class BlindMansBluff : Form
    {
        //These variables are accessible everywhere in this class!
        int aiMoneyTotal;
        int aiBid;
        int playerMoneyTotal;
        int playerBid;
        int playerRollTotal;
        int aiRollTotal;

        public BlindMansBluff()
        {
            InitializeComponent();
        }

        //The "Let's get out of here!" button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This handles the bidding process
        private void bidButton_Click(object sender, EventArgs e)
        {
            //Create random generator
            Random rand = new Random();

            //Create and display a recommended bid based on the roll
            if (playerRollTotal == 12)
                bidTextBox.Text = playerMoneyTotal.ToString();
            else if (playerRollTotal >= 10)
                bidTextBox.Text = rand.Next((playerMoneyTotal / 2), playerMoneyTotal + 1).ToString();
            else if (playerRollTotal >= 6)
                bidTextBox.Text = rand.Next((playerMoneyTotal / 3), (playerMoneyTotal / 2) + 1).ToString();
            else if (playerRollTotal >= 3)
                bidTextBox.Text = rand.Next((playerMoneyTotal / 4), (playerMoneyTotal / 3) + 1).ToString();
            else
                bidTextBox.Text = "1";

            //Get the actual bid
            int.TryParse(bidTextBox.Text, out playerBid);

            //Get the ai's bid based on its roll
            if (playerBid <= playerMoneyTotal && playerBid >= 1)
            {
                if (aiRollTotal == 12)
                    aiBid = aiMoneyTotal;
                else if (aiRollTotal > 10)
                    aiBid = rand.Next((aiMoneyTotal / 2), aiMoneyTotal + 1);
                else if (aiRollTotal > 6)
                    aiBid = rand.Next((aiMoneyTotal / 3), (aiMoneyTotal / 2) + 1);
                else if (aiRollTotal > 3)
                    aiBid = rand.Next((aiMoneyTotal / 4), (aiMoneyTotal / 3) + 1);
                else
                    aiBid = 1;

                //Update the textboxes
                aiBidTextBox.Text = aiBid.ToString();
                totalBidsTextBox.Text = (playerBid + aiBid).ToString();

                //handle button availability
                bidButton.Enabled = false;
                callButton.Enabled = true;
            }
            else
            {
                if (playerBid > playerMoneyTotal) //bid too much
                    MessageBox.Show("You cannot bid more than you have.");
                else //bid too low
                    MessageBox.Show("The minimum bid is $1.");
            }

            
        }

        //When the player is ready to get the game rolling!
        private void rollButton_Click(object sender, EventArgs e)
        {
            //make ai rolls invisible
            if (die3PictureBox.Visible == true)
                die3PictureBox.Visible = false;
            if (die4PictureBox.Visible == true)
                die4PictureBox.Visible = false;
            if (aiRollTotalTextBox.Text != "?")
                aiRollTotalTextBox.Text = "?";

            //create variables
            int die1, die2, die3, die4;
            Random rand = new Random();

            //get random die rolls
            die1 = rand.Next(1, 7);
            die2 = rand.Next(1, 7);
            die3 = rand.Next(1, 7);
            die4 = rand.Next(1, 7);

            //Update the pictureboxes to reflect the rolls
            if (die1 <= dieFaces.Images.Count && die2 <= dieFaces.Images.Count &&
                die3 <= dieFaces.Images.Count && die4 <= dieFaces.Images.Count)
            {
                playerRollTotal = die1 + die2;
                aiRollTotal = die3 + die4;

                playerRollTotalTextBox.Text = playerRollTotal.ToString();

                die1PictureBox.Image = dieFaces.Images[die1 - 1];
                die2PictureBox.Image = dieFaces.Images[die2 - 1];
                die3PictureBox.Image = dieFaces.Images[die3 - 1];
                die4PictureBox.Image = dieFaces.Images[die4 - 1];

                //handle button accessibility
                rollButton.Enabled = false;
                bidButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Critical Error!"); //Somehow the die rolls are out of range
            }
            
        }

        //This happens when the app first starts
        private void BlindMansBluff_Load(object sender, EventArgs e)
        {
            //Initialize values
            aiMoneyTotal = 25;
            aiBid = 0;
            playerMoneyTotal = 25;
            playerBid = 0;
            playerRollTotal = 0;
            aiRollTotal = 0;

            //Handle button availability
            bidButton.Enabled = false;
            callButton.Enabled = false;

            //ensure the ai roll info is hidden
            if (die3PictureBox.Visible == true)
                die3PictureBox.Visible = false;
            if (die4PictureBox.Visible == true)
                die4PictureBox.Visible = false;
            if (aiRollTotalTextBox.Text != "?")
                aiRollTotalTextBox.Text = "?";
        }

        //When the user calls the round!
        private void callButton_Click(object sender, EventArgs e)
        {
            //Show the user the ai roll info
            if (die3PictureBox.Visible == false)
                die3PictureBox.Visible = true;
            if (die4PictureBox.Visible == false)
                die4PictureBox.Visible = true;
            if (aiRollTotalTextBox.Text == "?")
                aiRollTotalTextBox.Text = aiRollTotal.ToString();


            //See who won the round
            if (playerRollTotal > aiRollTotal) //player won
            {
                playerMoneyTotal += aiBid;
                aiMoneyTotal -= aiBid;
                MessageBox.Show("You won the round!\nAmount Won: $" + aiBid.ToString());
            }
            else if (aiRollTotal > playerRollTotal) //ai won
            {
                playerMoneyTotal -= playerBid;
                aiMoneyTotal += playerBid;
                MessageBox.Show("You lost the round.\nAmount lost: $" + playerBid.ToString());
            }
            else //Tied round
            {
                MessageBox.Show("Tied round. Bids returned.");
            }

            //Update the textboxes to reflect new information
            moneyAmount.Text = playerMoneyTotal.ToString();
            aiMoneyTextBox.Text = aiMoneyTotal.ToString();

            //Check for game continuation requirements
            if (playerMoneyTotal > 0 && aiMoneyTotal > 0) //continue if neither has won
            {
                rollButton.Enabled = true;
                callButton.Enabled = false;
            }
            else if (aiMoneyTotal == 0) //the ai is broke
            {
                MessageBox.Show("You have won!");
                Application.Restart();
                Environment.Exit(0);
            }
            else //the player is broke
            {
                MessageBox.Show("You have lost.");
                Application.Restart();
                Environment.Exit(0);
            }
                
        }
    }
}
